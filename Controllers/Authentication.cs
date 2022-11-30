using System;
using System.Collections.Generic;
using System.Linq;
using Killar.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Killar.Controllers
{
    public class Authentication
    {
        public static void CheckLogin(Controller controller)
        {
            if (string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool CheckLoginAndPassword(string login, string password, Controller controller)
        {
            using (KillarContext dataBase = new KillarContext()) // inicia-se uma conexão;
            {
                CheckIfUserAdministratorExists(dataBase); // Chama-se o método que verifica se existe um usuário administrador e que se caso não existir cria um novo;

                string PasswordUser = Cryptography.EncryptedText(password); // Transforma em Hash MD5 a string digitada no campo de senha no momento do login;

                IQueryable<Users> UserFound = dataBase.Usuarios.Where(searchForUser => searchForUser.LoginName == login && searchForUser.CheckedPassword == PasswordUser); // Armazena no objeto userFound uma busca de verificação que avalia se os dados de login e senha digitados são correspondentes aos que estão presentes no banco de dados;

                List<Users> FoundUserList = UserFound.ToList();

                if (FoundUserList.Count == 0)
                {
                    return false;
                }
                else
                {

                    controller.HttpContext.Session.SetString("login", FoundUserList[0].LoginName);
                    controller.HttpContext.Session.SetInt32("type", FoundUserList[0].Tipo);
                    controller.HttpContext.Session.SetInt32("IdUser", FoundUserList[0].Id);

                    return true;
                }
            }
        }

        public static void CheckIfUserAdministratorExists(KillarContext dataBase)
        {
            IQueryable<Users> UserFound = dataBase.Usuarios.Where(searchForUser => searchForUser.Tipo == 0); // busco pelo identificador (Tipo) para verificar a existência de um usuário administrador;

            if (UserFound.ToList().Count == 0)
            {
                //crio usuário admin automático casa não exista um;

                Users admin = new Users();
                admin.Name = "Administrador";
                admin.LoginName = "admin";
                admin.Password = Cryptography.EncryptedText("123456");
                admin.CheckedPassword = Cryptography.EncryptedText("123456");
                admin.Tipo = Users.ADMIN;

                dataBase.Usuarios.Add(admin);
                dataBase.SaveChanges();
            }
        }

        public static void CheckIfUserIsAdministrator(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("type") == Users.ADMIN)) // se o tipo de usuário da sessão não corresponder à um usuário administrador redireciona para a página de login. 
            {
                controller.HttpContext.Session.Clear();
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

    }
}