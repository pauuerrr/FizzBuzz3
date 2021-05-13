﻿using System;
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
        public static string result { get; set; }


        public void FizzBuzzWyswietl()
        {
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
                    result = "Podana liczba nie spelnia kryteriow FizzBuzz";
                }
            }
            else
            {
                result = "Podana liczba nie spelnia kryteriow FizzBuzz";
            }
        }
    }
}