using DotNetNuke.Web.Mvc.Framework.Controllers;
using ExpressMapper.Extensions;
using Planeta.Modules.DNNModule1.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using TestDnn.ApplicationServices.Interfaces;
using TestDnn.Domain.MainContext;

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
            //var result = MessageService.GetMessages().Select(m => new MessageViewModel { Content = m.Content });
            var result = MessageService.GetMessages().Map<IEnumerable<Message>, List<MessageViewModel>>();
            return View(result);
        }
    }
}