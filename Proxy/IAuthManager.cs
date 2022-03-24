using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy

///<summary>
///O clasa interfata care contine urmatoarele metode.
///
///</summary>
{
    internal interface IAuthManager
    {
        /// <summary>
        /// Metoda aceasta verifica daca exista utilizatori.
        /// </summary>
        bool UserExists(string user);
        /// <summary>
        /// Metoda aceasta adauga utilizatori.
        /// /// </summary>
        void AddUser(string user, string pass);
    }
}
