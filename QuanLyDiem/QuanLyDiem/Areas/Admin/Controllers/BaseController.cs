using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            TaiKhoan loginAccount = (TaiKhoan)Session["LoginAccount"];
            if (loginAccount == null)
            {
                filterContext.Result = new RedirectResult("~/Login/Index");
            }
            base.OnActionExecuted(filterContext);
        }
    }
}