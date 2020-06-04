using DotNetNuke.Web.Mvc.Framework.Controllers;
using Planeta.Modules.DNNModule1.Models;
using System.Web.Mvc;
using TestDnn.ApplicationServices.Interfaces;

namespace Planeta.Modules.DNNModule1.Controllers
{
    public class HomeController : DnnController
    {
        protected IMessageService MessageService { get; }

        public HomeController(IMessageService messageService)
        {
            MessageService = messageService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var homeModel = new Home
            {
                Message = MessageService.GetMessage()
            };
            return View(homeModel);
        }
    }
}