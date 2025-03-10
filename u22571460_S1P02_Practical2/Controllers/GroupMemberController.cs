using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u22571460_S1P02_Practical2.Controllers
{
    public class GroupMemberController : Controller
    {
        // GET: GroupMember
        public ActionResult ListOfMembers()
        {

            List<Models.GroupMember> member = new List<Models.GroupMember>();

            member.Add(new Models.GroupMember { StudentNumber = "u22571460", Name = "Panayioti", Surname = "Constantopoulos", EmailAddress = "u22571460@tuks.co.za", myLink = "~/HTML/Panayioti.html"});
            member.Add(new Models.GroupMember { StudentNumber = "u22666797", Name = "Tiano", Surname = "Menegazzi", EmailAddress = "u22666797@tuks.co.za", myLink = "~/HTML/Tiano.html" });
            member.Add(new Models.GroupMember { StudentNumber = "u24593240", Name = "Sofia", Surname = "Finlayson", EmailAddress = "u24593240@tuks.co.za", myLink = "~/HTML/Sofia.html" });
            member.Add(new Models.GroupMember { StudentNumber = "u24571700", Name = "Theodoros", Surname = "Constantopoulos", EmailAddress = "u24571700@tuks.co.za", myLink = "~/HTML/Theodoros.html" });
            member.Add(new Models.GroupMember { StudentNumber = "u24616185", Name = "Lukas", Surname = "Brink", EmailAddress = "u24616185@tuks.co.za", myLink = "~/HTML/Lukas.html" });

            return View(member);
        }

      
    }
}