using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingEg
{
   public class Calculator:ICalculator
    {
        public int add(int first,int second)
        {
            return first + second;
        }

        public float CalculateAmt(int qty,float price)
        {
            return qty * price;
        }

        public bool checkamt(int a, int b)
        {
            float f = CalculateAmt(a,b);
            if (f > 10)
                return true;
            else
                return false;
        }

        public int CheckTemp(bool f)
        {
            if(f)
            {
                return 42;   
            }
            else
            {
                throw new InvalidOperationException("Temperature not Initialized");
            }
        }

        public bool checkAge(int age)
        {
           
            if (age > 18)
                return true;
            else
                return false;
        }

        public string message(string name)
        {
            return "Hello " + name;
        }

        public string Login(string username,string password)
        {
            string msg;
            if ((username == "user_11" && password == "secret@user11")||(username == "user_22" && password == "secret@user22"))
            {
                msg = "Welcome " + username;
            }
            else
            {
                msg = "Invalid User Id/Password";
            }
            return msg;
        }
    }
}
