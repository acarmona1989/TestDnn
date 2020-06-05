using DotNetNuke.Web.Mvc.Framework.Controllers;
using ExpressMapper.Extensions;
using Planeta.Modules.DNNModuleMvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using TestDnn.ApplicationServices.Interfaces;
using TestDnn.Domain.MainContext;

namespace Planeta.Modules.DNNModuleMvc.Controllers
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
            var result = MessageService.GetMessages().Map<IEnumerable<TestMessage>, List<MessageViewModel>>();
            return View(result);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
    }
}