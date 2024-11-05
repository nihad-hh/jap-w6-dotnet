using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using dotnetcoresample.Models;

namespace dotnetcoresample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CustomSettings _customSettings;

        public IndexModel(IOptions<CustomSettings> customSettings)
        {
            _customSettings = customSettings.Value;
        }

        public string Var1 { get; private set; }
        public string Var2 { get; private set; }

        public void OnGet()
        {
            Var1 = _customSettings.Var1;
            Var2 = _customSettings.Var2;
        }
    }
}