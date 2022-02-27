using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    [Authorize]
    [RequireHttps]
    public class CreditCardController : Controller
    {
        // GET: CreditCard
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        //[HttpGet]
        [ActionName("GetCreditCardDetails")]
        public ActionResult GetCreditCardDetails_Get()
        {
            return View();
        }

        //[AcceptVerbs(HttpVerbs.Post)]
        [HttpPost]
        [ActionName("GetCreditCardDetails")]
        public ActionResult GetCreditCardDetails_Post(string cardName)
        {
            return View();
        }

        //[AcceptVerbs(HttpVerbs.Post)]
        [HttpPost]
        public ActionResult Save(string cardName)
        {
            return View();
        }

        [NonAction]
        public string NotToBeUsedAsAnActionMethod()
        {
            return null;
        }

        [AllowAnonymous]
        public string PerformNonSecureOperation() 
        {
            return null;
        }

        [Authorize]
        public string PerformSecureOperation()
        {
            return null;
        }

        [ChildActionOnly]
        public string InvokeThisOnlyByAParentControllerMethod()
        {
            return null;
        }

        [HandleError]
        public string SomeError()
        {
            throw new Exception();
        }


    }
}