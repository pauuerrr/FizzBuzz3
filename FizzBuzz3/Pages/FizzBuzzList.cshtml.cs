using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzz3.Pages
{
    public class FizzBuzzListModel : PageModel
    {
        public FizzBuzz FizzBz { get; set; }
        public void OnGet()
        {
            var SessionFizzBuzz = HttpContext.Session.GetString("SessionFizzBuzz");
            if (SessionFizzBuzz != null)
            {
                FizzBz = JsonConvert.DeserializeObject<FizzBuzz>(SessionFizzBuzz);
            }
        }
    }
}
