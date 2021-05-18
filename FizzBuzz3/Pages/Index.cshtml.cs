using FizzBuzz3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzz3.Data;

namespace FizzBuzz3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FizzBuzzContext _context;
        
        [BindProperty]
        public FizzBuzz FizzBz { get; set; }

        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                FizzBz.FizzBuzzWyswietl();
                FizzBz.Datapobierz(DateTime.Now);
                HttpContext.Session.SetString("SessionFizzBuzz", JsonConvert.SerializeObject(FizzBz));
                //return RedirectToPage("./FizzBuzzList");
            }
            return Page();
        }
    }
}
