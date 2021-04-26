using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz3.Models
{
    public class FizzBuzz
    {
        public int Number { get; set; }
        public string result { get; set; }

        public void FizzBuzzWyswietl()
        {
            if(Number >= 1 && Number <= 1000)
            {
                if(Number%3==0)
                {
                    result += "Fizz";
                }
                if(Number%5==0)
                {
                    result += "Buzz";
                }
                else
                {
                    result = "Podana liczba nie spelnia kryteriow FizzBuzz";
                }
            }
        }
    }
}
