using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopApp.Backend.Services;

namespace DesktopApp.Backend.Controllers
{
    public class FormsController
    {
        private static FormService formService;

        public static FormService getFormService()
        {
            if (formService == null)
            {
                formService = new FormServiceImpl();
            }

            return formService;
        }


    }
}
