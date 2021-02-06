using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace assignemnt2.Pages
{
    public class BeatlesModel : PageModel
    {
        private readonly ILogger<BeatlesModel> _logger;

        public BeatlesModel(ILogger<BeatlesModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
