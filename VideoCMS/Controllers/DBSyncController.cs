using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoCMS.Controllers
{
    public class DBSyncController : Controller
    {
        //
        // GET: /DBSync/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDb(string name)
        {
            if (name == "cbv")
            {
                return new RedirectResult("http://dl.dropbox.com/u/17484775/movies-db/cbv-db.json");
            }
            else
            {
                return null;
            }
        }

    }
}
