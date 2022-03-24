using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Proxy
{
    /// <summary>
    /// Clasa RealAuthManager ce va contine metode folosite de catre clasa ProxyAuthManager.
    /// </summary>
    internal class RealAuthManager : IAuthManager
    {
        private static List<User> _users;
        private const string Path = "Documents\\";

        /// <summary>
        /// Structura cu datele utilizatorilor.
        /// </summary>
        public struct User
        {
            public readonly string Name;
            public readonly string PassHash;

            public User(string name, string passHash)
            {
                Name = name;
                PassHash = passHash;
            }
        }

        /// <summary>
        /// Metoda ce va deschide documentul, va citi datele si le va adauga in lista.
        /// </summary>
        public RealAuthManager()
        {
            try
            {
                _users = new List<User>();
                StreamReader line = new StreamReader(Path + "users.txt");
                while (line.Peek() != -1)
                {
                    string[] toks = line.ReadLine().Split('\t');
                    User user = new User(toks[0], toks[1]);
                    _users.Add(user);
                }
                line.Close();
            }catch(Exception ex)
            { }
        }

        /// <summary>
        /// Metoda ce va salva utilizatorii.
        /// </summary>
        public void SaveUser()
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path + "users.txt");
                foreach (User u in _users)
                {
                    sw.WriteLine(u.Name + "\t" + u.PassHash);
                }
                sw.Close();
            }catch(Exception ex)
            { }
        }

        /// <summary>
        /// Metoda ce  verifica daca utilizatorii exista.
        /// </summary>
        public bool UserExists(string user)
        {
            foreach (User u in _users)
            {
                if (u.Name.Equals(user))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Metoda ce va salva datele unui utilizaotr.
        /// </summary>
        public void AddUser(string user, string pass)
        {
            User newUser = new User(user, Cryptography.HashString(pass));
            _users.Add(newUser);
            SaveUser();
        }

        /// <summary>
        /// Metoda ce va verifica daca parola introdusa de utilizator este corecta.
        /// </summary>
        public bool PassIsRight(string password)
        {
            foreach (User u in _users)
            {
                if (u.PassHash.Equals(Cryptography.HashString(password)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
