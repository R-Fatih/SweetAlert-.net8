using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static SweetAlert_.net8.Enums.Enums;

namespace SweetAlert_.net8.Controllers
{
    public class TestController : BaseController
    {
        public IActionResult Index()
        {
            //Alert("This is a success message", NotificationType.success);
            //Alert("This is a success message", NotificationType.info);
            Alert("This is a success message", NotificationType.error);
           // Alert("This is a success message", NotificationType.success);
            return View();
        }
    }
}
