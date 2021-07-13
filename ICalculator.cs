using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingEg
{
   public interface ICalculator
    {
        public bool checkAge(int age);
        public string message(string name);
        public int add(int first, int second);
        public float CalculateAmt(int qty, float price);
    }
}
