using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz3.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Podana liczba")]
        [Required(ErrorMessage = "Pole jest obowiazkowe")]
        public int Number { get; set; }
        public static int Number_2 { get; set; }
        public static string result { get; set; }


        public void FizzBuzzWyswietl()
        {
            Number_2 = Number;
            if(Number >= 1 && Number <= 1000)
            {
                result = "";
                if(Number%3==0)
                {
                    result += "Fizz";
                }
                if(Number%5==0)
                {
                    result += "Buzz";
                }
                if(Number%3 != 0 && Number%5 != 0)
                {
                    result = "Liczba : " + Number_2 + " nie spelnia kryteriow Fizz/Buzz";
                }
            }
            else
            {
                result = "Blad.Podana liczba nie znajduje sie w zakresie";
            }
        }
    }
}
