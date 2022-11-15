using System.Collections.Generic;
using System.Linq;


namespace Killar.Models
{
    public class UsersService
    {
        public void AddUser(Users newUser)
        {
            using (KillarContext dataBase = new KillarContext())
            {

                dataBase.Usuarios.Add(newUser);
                dataBase.SaveChanges();

            }
        }

        public List<Users> ListUser()
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Usuarios.ToList();
            }
        }

        public Users ListUser(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Usuarios.Find(id);
            }
        }

        public void EditUser(Users editUser)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                Users u = dataBase.Usuarios.Find(editUser.Id);
                u.Name = editUser.Name;
                u.BirthDate = editUser.BirthDate;
                u.LoginWr = editUser.LoginWr;
                u.LoginName = editUser.LoginName;
                u.Password = editUser.Password;
                u.CheckedPassword = editUser.CheckedPassword;
                u.Lane = editUser.Lane;
                u.Elo = editUser.Elo;
                u.Tipo = editUser.Tipo;

                dataBase.SaveChanges();
            }

        }

        public void DeleteUser(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                Users FoundUser = dataBase.Usuarios.Find(id);

                dataBase.Usuarios.Remove(FoundUser);
                dataBase.SaveChanges();
            }
        }

        public List<Users> ProfileUser(int id)
        {
            using (var dataBase = new KillarContext())
            {

                List<Users> UserList = new List<Users>();

                Users UserFound = dataBase.Usuarios.Where(p => p.Id == id).SingleOrDefault();

                UserList.Add(UserFound);
                return UserList;

            }
        }

        public Users SearchForId(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Usuarios.Find(id);
            }
        }

    }
}