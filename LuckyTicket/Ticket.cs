using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    public class Ticket
    {

        string number;
        public string Number
        {
            get { return number; }
            set
            {
                this.Com(value);
            }
        }

        private void Com (string n)
        {

            if (n.Length > 4 && n.Length < 8)
            {

                if (n.ToString().Length % 2 == 0)
                {
                    number = n;
                }
                else
                {
                    number = "0" + n;
                }
            }
            else
            {
                Console.WriteLine("Invalid num, please try again");
                this.Com(Console.ReadLine());
            }
        }
        public void IsHappyTicket()
        {
            int sum1 = 0;
            int sum2 = 0;

            char[] numbers = Number.ToCharArray();

            for (int i = 0; i < Number.ToString().Length; i++)
            {
                if (i < number.Length / 2)
                {
                    sum1 += Int32.Parse(numbers[i].ToString());
                }
                else
                {
                    sum2 += Int32.Parse(numbers[i].ToString());
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("You are lucky, you win");
            }
            else
            {
                Console.WriteLine("Maybe in the next time");
            }
        }
    }
}
