using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace assignemnt2.Pages
{
    public class WcmtModel : PageModel
    {
        private readonly ILogger<WcmtModel> _logger;

        public WcmtModel(ILogger<WcmtModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
