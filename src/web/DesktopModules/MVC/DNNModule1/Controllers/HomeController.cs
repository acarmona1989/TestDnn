using DotNetNuke.Web.Mvc.Framework.Controllers;
using Planeta.Modules.DNNModule1.Models;
using System.Linq;
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
            var result = MessageService.GetMessages().Select(m => new MessageViewModel { Content = m.Content });
            return View(result);
        }
    }
}