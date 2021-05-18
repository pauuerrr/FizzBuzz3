using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz3.Data;
using FizzBuzz3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzz3.Pages
{
    public class FizzBuzzBazaDModel : PageModel
    {
        private readonly FizzBuzzContext _context;
        public IList<FizzBuzz> Fizzbuzzes { get; set; }
        public void OnGet()
        {
            Fizzbuzzes = _context.FizzBuzz.ToList();
        }
    }
}
