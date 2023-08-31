using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn_LogOut
{
    internal class InfoAccesso
    {
        public Utente User { get; set; }
        public DateTime Data { get; set; }

        public InfoAccesso() { }
        public InfoAccesso(Utente user, DateTime data)
        {
            User = user;
            Data = data;
        }
    }
}
