using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Form.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Form.Pages
{
    public class Index1Model : PageModel
    {
        public Address Addr { get; set; }
        public void OnGet()
        {
            var SessionAddress = HttpContext.Session.GetString("SessionAddress");

            if (SessionAddress != null) Addr = JsonConvert.DeserializeObject<Address>(SessionAddress);
        }
    }
}
