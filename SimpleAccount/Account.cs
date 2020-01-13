using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleAccount
{
    public class Account
    {
        #region Fields
        private int balance;
        private readonly int interestRate; // integer % number
        #endregion

        public Account(int initBalance, int interestRate)
        {
            this.balance = initBalance;
            this.interestRate = interestRate;
            Thread th = new Thread(interestLoop);
            th.Start();
        }

        #region Interest
        private void applyInterest()
        {
            timeOutput();
            oldBalanceOutput("applyInterest");
            balance = (balance * (100 + interestRate)) / 100;
            newBalanceOutput();
        }

        public void interestLoop()
        {
            while (true)
            {
                applyInterest();
                Thread.Sleep(3000); // 3000 milliseconds
                
            }
        }
        #endregion

        #region Output
        private void timeOutput()
        {
            Console.Write("{0}: ", DateTime.Now.ToString("HH:mm:ss"));
        }
        private void oldBalanceOutput(string loc)
        {
            Console.Write("{0}: old balance = {1}, ", loc, balance);
        }
        private void newBalanceOutput()
        {
            Console.WriteLine("new balance = {0}, ", balance);
        } 
        #endregion
    }
}
