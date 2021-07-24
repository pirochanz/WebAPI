using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

namespace MvcApl.Controllers
{
    public class BaseController : Controller
    {
        protected class ButtonAttribute : ActionMethodSelectorAttribute
        {
            public string ButtonName { get; set; }
            public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
            {
                return controllerContext.Controller.ValueProvider.GetValue(ButtonName) != null;
            }
        }

    }
}