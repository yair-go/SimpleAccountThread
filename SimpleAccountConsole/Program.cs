using SimpleAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleAccountConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(1000, 2);
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main is alive");
            }
        }
    }
}
