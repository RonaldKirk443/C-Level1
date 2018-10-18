using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    struct Account {

        String[] loginArray;
        String[] passwordArray;
        String log;
        String pass;

        public Account(String login, String password) {
            loginArray = new string[getinfo.getlogin().Length];
            passwordArray = new string[getinfo.getpass().Length];
            loginArray = getinfo.getlogin();
            passwordArray = getinfo.getpass();
            log = login;
            pass = password;
        }

        public Boolean check(){

            loginArray = new string[getinfo.getlogin().Length];
            passwordArray = new string[getinfo.getpass().Length];
            
            loginArray = getinfo.getlogin();
            passwordArray = getinfo.getpass();

            for (int i = 0; i < passwordArray.Length; i++) {
                if (log == loginArray[i]) {
                    for (int f = 0; f < loginArray.Length; f++)
                    {
                        if (pass == passwordArray[f])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
            
        }

    }
 

    partial class Program
    {

        static void task4()
        {
            int attempts = 0;

            String login;
            String password;


            while (attempts != 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Login: ");
                login = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Password: ");
                password = Console.ReadLine();

                Account acc = new Account(login, password);
                if (acc.check())
                {
                    menu();
                }
                else
                {
                    attempts++;
                    Console.WriteLine("");
                    Console.WriteLine("Wrong Password");
                    if (attempts == 3) {
                        Console.WriteLine("You have reached you maximum amount of attempts.");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Press any key to retry.");
                    Console.ReadKey();
                }
            }
            

        }

    }

    public class getinfo{
        public static String[] getlogin() {


            StreamReader sr = null;
            String login = "log.txt";
            


            try
            {
                sr = new StreamReader(login);
                int size = File.ReadLines(login).Count();
                String[] log = new string[size];
                //Console.WriteLine(size);
                int i = 0;
                
                do
                {
                    log[i] = sr.ReadLine();
                    i++;
                }
                while (!sr.EndOfStream);
                return log;

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found. Oops.");
                Console.WriteLine(e.Message);
                return null;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            finally
            {
                if (sr != null) sr.Close();
            }

        }

        public static String[] getpass()
        {


            StreamReader sr = null;
            String pass = "pass.txt";



            try
            {
                sr = new StreamReader(pass);
                int size = File.ReadLines(pass).Count();
                String[] password = new string[size];
                //Console.WriteLine(size);
                int i = 0;

                do
                {
                    password[i] = sr.ReadLine();
                    i++;
                }
                while (!sr.EndOfStream);

                return password;

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found. Oops.");
                return null;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            finally
            {
                if (sr != null) sr.Close();
            }

        }
    }

}
