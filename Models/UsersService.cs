using System.Collections.Generic;
using System.Linq;

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