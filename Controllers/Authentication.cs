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
            using (KillarContext dataBase = new KillarContext())
            {
                CheckIfUserAdministratorExists(dataBase);

                string PasswordUser = password;

                IQueryable<Users> UserFound = dataBase.Usuarios.Where(searchForUser => searchForUser.LoginName == login && searchForUser.Password == PasswordUser);

                List<Users> FoundUserList = UserFound.ToList();

                if (FoundUserList.Count == 0)
                {
                    return false;
                }
                else
                {

                    controller.HttpContext.Session.SetString("login", FoundUserList[0].LoginName);
                    controller.HttpContext.Session.SetString("name", FoundUserList[0].Name);
                    controller.HttpContext.Session.SetString("password", FoundUserList[0].Password);
                    controller.HttpContext.Session.SetInt32("type", FoundUserList[0].Tipo);
                    controller.HttpContext.Session.SetInt32("IdUser", FoundUserList[0].Id);

                    return true;
                }
            }
        }

        public static void CheckIfUserAdministratorExists(KillarContext dataBase)
        {
            IQueryable<Users> UserFound = dataBase.Usuarios.Where(searchForUser => searchForUser.LoginName == "admin");

            if (UserFound.ToList().Count == 0)
            {
                //crio usuario admin automático casa não exista um

                Users admin = new Users();
                admin.Name = "Administrador";
                admin.LoginName = "admin";
                admin.Password = "123";
                admin.Tipo = Users.ADMIN;


                dataBase.Usuarios.Add(admin);
                dataBase.SaveChanges();
            }
        }

        public static void CheckIfUserIsAdministrator(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("type") == Users.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

    }
}