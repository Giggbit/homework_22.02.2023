using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework_22._02._2023
{
    internal class Bill
    {
        public Bill() { }
        public void Print(int sum) { 
            Console.WriteLine($"Issuance amount: {sum} euro");
        }
        public void NoPrint() {
            Console.WriteLine("Bill will not printe");
        }
    }
}
