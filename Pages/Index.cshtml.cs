﻿using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzzForm FizzBuzz { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Name { get; set; }
        public string output { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
            

        }

        public IActionResult OnPost()
        {
           output=FizzBuzz.output();

            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("./Privacy");

           
        }

    }
}