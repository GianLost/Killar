using System.Collections.Generic;

namespace Killar.Models
{
    public class UserService
    {
        public void AddUser(Users newUser)
        {
            using (KillarContext dataBase = new KillarContext())
            {

                dataBase.Usuarios.Add(newUser);
                dataBase.SaveChanges();
            
            }
        }

        public void ListUser()
        {

        }

        public void ListUser(int id)
        {

        }

        public void Profile()
        {

        }

        public void EditUser()
        {

        }

        public void DeleteUser()
        {

        }

        public void SearchForId()
        {

        }

    }
}