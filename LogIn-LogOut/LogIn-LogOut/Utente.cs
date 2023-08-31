using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn_LogOut
{
    internal class Utente
    {
        public string Username { get; set; }
        public int Psw { get; set; }
        public int ConfirmedPsw { get; set; }

        public DateTime LastLog {  get; set; }
        

        public Utente() { }
        public Utente(string username, int psw, int confirmed) {
            Username = username;
            Psw = psw;
            ConfirmedPsw = confirmed;
            
        }
    }
}
