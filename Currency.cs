using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Currency
    {
        private string TextCurrency;
        private double CourseCurrency;
        public Currency(string TextCurrency, double CourseCurrency)
        {
            this.TextCurrency = TextCurrency;
            this.CourseCurrency = CourseCurrency;
        }
        public double ConvertToSGD(double Balance)
        {
            return Balance / CourseCurrency;
        }

        public double ConvertToSEK(double Balance)
        {
            return Balance / CourseCurrency;
        }
        public double ConvertToRUB(double Balance)
        {
            return Balance;
        }

    }




    class Account
    {
        private double Balance = 100.01;

        public double Print()
        {
            return Balance;
        }

        public void Credit(double sum)
        {
            Balance += sum;
        }

        public void Withdraw(double sum)
        {
            Balance -= sum;
        }
        
    }
}
