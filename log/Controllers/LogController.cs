using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log.Service;

namespace log.Controllers
{
    public class LogController : Controller
    {
        LogDbService logdb = new LogDbService();
        // GET: Log
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string strUsername,string strPassword,string strConfirmPassword)
        {
            if (strUsername != "")
            {
                if (strPassword != strConfirmPassword||strPassword=="")
                {
                    Response.Write("<script>alert('密码未输入或输入不一致')</script>");
                    return View("Create");
                }
                logdb.AddUser(strUsername, strPassword);
                Response.Write("<script>alert('注册成功，请登录。')</script>");
                return View("index");
            }
            else
            {
                Response.Write("");
                return View("Create");
            }
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {

            return View();
        }
    }
}