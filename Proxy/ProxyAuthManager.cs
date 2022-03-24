using System;

namespace Proxy
{
    ///<summary>
    /// Clasa ProxyAuthManager ce va gestiona interactiunea cu fisierul cu utilizatori.
    ///</summary>
    public class ProxyAuthManager : IAuthManager
    {

        private readonly RealAuthManager _realAuthManager;
        ///<summary>
        /// Constructorul clasei ProxyAuthManager.
        ///</summary>
        public ProxyAuthManager()
        {
            if (_realAuthManager == null)
            {
                _realAuthManager = new RealAuthManager();
            }
        }

        ///<summary>
        /// Metoda ce va apela alte doua metode ce verifica daca utilizatorul exista. 
        /// In caz afirmativ, metoda va loga utilizatorul.
        ///</summary>
        public bool Login(string username, string password)
        {
            if (_realAuthManager.UserExists(username) && _realAuthManager.PassIsRight(password))
            {
                return true;
            }
            return false;
        }
        ///<summary>
        /// Metoda ce va adauga utilizatorul in fisier.
        ///</summary>
        public void AddUser(string user, string pass)
        {
            _realAuthManager.AddUser(user, pass);
        }

        ///<summary>
        /// Metoda ce va verifica daca utilizatorul exista.
        ///</summary>
        public bool UserExists(string user)
        {
            return _realAuthManager.UserExists(user);
        }
    }
}
