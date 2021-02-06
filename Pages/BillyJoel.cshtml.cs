using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace assignemnt2.Pages
{
    public class BillyJoelModel : PageModel
    {
        private readonly ILogger<BillyJoelModel> _logger;

        public BillyJoelModel(ILogger<BillyJoelModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
