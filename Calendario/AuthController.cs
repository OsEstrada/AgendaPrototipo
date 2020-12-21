using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario
{
    public static class AuthController
    {
        public static Usuarios usuario;

        public static async Task<bool> RegisterUser(string username, string name, string password)
        {
            try
            {


                using (var db = new syspolizaEntities())
                {
                    Usuarios newUser = new Usuarios();

                    return await Task.Run(() =>
                    {
                        return db.Usuarios.Where(u => u.usuarioUsername == username).FirstOrDefault();
                    }).ContinueWith((taskResult) =>
                    {
                        var user = taskResult.Result;
                        if (user != null)
                        {
                            return false;
                        }
                        else
                        {
                            newUser.usuarioUsername = username;
                            newUser.usuarioPassword = password;
                            newUser.usuarioNombre = name;

                            db.Usuarios.Add(newUser);
                            db.SaveChanges();
                            return true;
                        }
                    });

                }

            }
            catch (Exception)
            {
                throw new Exception("Hubo un error al registrar");
            }
        }


        public static Usuarios getUser()
        {
            using (var db = new syspolizaEntities())
            {
                var searchUser = db.Usuarios.Where(u => u.usuarioUsername == "Adriana").FirstOrDefault();
                return searchUser;
            }

        }

        public static List<Usuarios> getUsers()
        {
            using (var db = new syspolizaEntities())
            {
                var searchUser = db.Usuarios.Select(u => u).ToList();
                return searchUser;

            }

        }
    }
}
