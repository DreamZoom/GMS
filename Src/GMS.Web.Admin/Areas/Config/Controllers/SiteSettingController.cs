using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GMS.Web.Admin.Common;
using GMS.Framework.Utility;
using GMS.Framework.Web;
using GMS.Account.Contract;
using GMS.Framework.Contract;
using GMS.Core.Config;

namespace GMS.Web.Admin.Areas.Config.Controllers
{
    public class SiteSettingController : AdminControllerBase
    {
        //
        // GET: /Config/SiteSetting/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            var adminMenuConfig = CachedConfigContext.Current.SettingConfig;
            return View(adminMenuConfig);
        }

        [HttpPost]
        public ActionResult Edit(GMS.Core.Config.SettingConfig site)
        {
            try
            {
                var adminMenuConfig = CachedConfigContext.Current.SettingConfig;
                adminMenuConfig.WebSiteDescription = site.WebSiteDescription ?? "";
                adminMenuConfig.WebSiteKeywords = site.WebSiteKeywords ?? "";
                adminMenuConfig.WebSiteTitle = site.WebSiteTitle ?? "";

                CachedConfigContext.Current.Save(adminMenuConfig);

                return RedirectToAction("index");
            }
            catch (Exception err)
            {
                return View("Error");
            }
            
        }

    }
}
