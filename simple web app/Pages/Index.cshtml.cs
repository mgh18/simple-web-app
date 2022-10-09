using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simple_web_app.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string message { get; set; }
        public void OnGet()
        {
            message = "hello from model";
            ViewData["message"] = "hello from view data";
            ViewData["number"] = 100;

        }
        [BindProperty]
        public int Length { get; set; }
        [BindProperty]
        public int Width { get; set; }
        public IActionResult OnPost()
        {
            var area = Length * Width;
            TempData["area"] = area;
            return RedirectToPage("./Result");
        }
    }
}