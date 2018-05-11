using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XP.Web.SR48.Controllers
{
    public class ToolController : Controller
    {
        // GET: Tool
        public ActionResult Index()
        {
            return View();
        }



        /// <summary>
        /// 获取头像  来啊，摸鱼啦！
        /// </summary>
        /// <remarks>
        /// https://image.showroom-live.com/showroom-prod/image/room/cover/c75cd71e181d793616653ee41973a63075433d7a167df25e02c471e45efb8830_l.png?v=1521699878
        /// https://image.showroom-live.com/showroom-prod/image/room/cover/0d65a5b611edf64b49ae1883cbe836808a69220acc1c17407ae8e787033ce8f3_l.png?v=1521699878
        /// https://image.showroom-live.com/showroom-prod/image/room/cover/c75cd71e181d793616653ee41973a63075433d7a167df25e02c471e45efb8830_ss.png?v=1521699878
        /// https://image.showroom-live.com/showroom-prod/image/room/cover/0d65a5b611edf64b49ae1883cbe836808a69220acc1c17407ae8e787033ce8f3_m.png?v=1521699878
        /// https://image.showroom-live.com/showroom-prod/image/room/cover/0d65a5b611edf64b49ae1883cbe836808a69220acc1c17407ae8e787033ce8f3_s.png?v=1521699878
        /// </remarks>
        /// <returns></returns>
        public ActionResult GetFaceImg()
        {

            return View();
        }


    }
}