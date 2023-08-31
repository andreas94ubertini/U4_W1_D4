using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn_LogOut
{
    public static class Gestione
    {
        private static List<InfoAccesso> cronologia = new List<InfoAccesso>();
        private static List<Utente> utenti = new List<Utente>();
        private static bool IsLogged = false;


        public static void Menu()
        {
            Console.WriteLine("===============OPERAZIONI==============");
            Console.WriteLine("Scegli l’operazione da effettuare:");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica ora e data di login");
            Console.WriteLine("4.: Lista degli accessi");
            Console.WriteLine("5.: Esci");
            Console.WriteLine("========================================");
            if (IsLogged)
            {
                Console.WriteLine($"Bentornato {utenti[utenti.Count - 1].Username}");
                Console.WriteLine("========================================");
            }
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Inserisci Username");
                string username = Console.ReadLine();
                try
                {
                    
                    Console.WriteLine("Inserisci Password");
                    string pass = string.Empty;
                    ConsoleKey key;
                    do
                    {
                        var keyInfo = Console.ReadKey(intercept: true);
                        key = keyInfo.Key;

                        if (key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            Console.Write("\b \b");
                        }
                        else if (!char.IsControl(keyInfo.KeyChar))
                        {
                            Console.Write("*");
                            pass += keyInfo.KeyChar;
                        }
                    } while (key != ConsoleKey.Enter);
                   
                    int psw = int.Parse(pass);
                 
                    Console.WriteLine("Conferma Password");

                    string passC = string.Empty;
                    ConsoleKey key2;
                    do
                    {
                        var keyInfo = Console.ReadKey(intercept: true);
                        key2 = keyInfo.Key;

                        if (key2 == ConsoleKey.Backspace && passC.Length > 0)
                        {
                            Console.Write("\b \b");
                        }
                        else if (!char.IsControl(keyInfo.KeyChar))
                        {
                            Console.Write("*");
                            passC += keyInfo.KeyChar;
                        }
                    } while (key2 != ConsoleKey.Enter);
                    Console.WriteLine(passC);
                    int Confirmedpsw = int.Parse(passC);
                    if (psw != Confirmedpsw)
                    {
                        Console.WriteLine("Le password non corrispondono");
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Utente loggato");
                        Utente user = new Utente(username, psw, Confirmedpsw);
                        DateTime userLogData = DateTime.Now;
                        user.LastLog = userLogData;

                        Console.WriteLine(userLogData);
                        InfoAccesso infouser = new InfoAccesso(user, userLogData);
                        cronologia.Add(infouser);

                        utenti.Add(user);
                        IsLogged = true;


                        Menu();
                    }

                }
                catch
                {
                    Console.WriteLine("La password deve contenero solo numeri");
                    Menu();
                }
            }
            else if (choice == "2")
            {
                IsLogged = false;
                Menu();
            }
            else if (choice == "3")
            {
                if (utenti.Count > 0 && IsLogged)
                {
                    Console.WriteLine($"Ultimo logIn effettuato da {utenti[utenti.Count - 1].Username}:");
                    Console.WriteLine(utenti[utenti.Count - 1].LastLog);
                    Menu();
                }
                else
                {
                    Console.WriteLine("Nessun utente attualmente loggato");
                    Menu();
                }

            }
            else if (choice == "4")
            {
                Console.WriteLine("Ecco la lista di tutti i tuoi accessi:");
                foreach (InfoAccesso log in cronologia)
                {
                    if (log.User.Username == utenti[utenti.Count - 1].Username)
                    {
                        
                        Console.WriteLine($"-{log.Data}");
                    }
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Chiusura programma in corso... premi Invio per confermare");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Comando non trovato");
                Menu();
            }
        }
    }
}
