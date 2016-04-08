using System.Web.Mvc;
using Nop.Web.Framework.Security;
using Nop.Web.Models.Common;

namespace Nop.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        [NopHttpsRequirement(SslRequirement.No)]
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult HomeMenu()
        {
            MenuModel model = new MenuModel();
            return PartialView(model);
        }
    }
}
