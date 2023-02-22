using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework_22._02._2023
{
    internal class Bankomat: Bill
    {
        private int sum;

        public Bankomat() { }
        public Bankomat(int pin, int sum) { 
            this.sum = sum;
        }

        public void EnterSum(int sum) { 
            Console.WriteLine($"Amount processed...\nIssuance amount: {sum} euro");
        }
    }
}
