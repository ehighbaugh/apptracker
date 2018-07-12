using AppTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

//namespace AppTracker.Data
//{
//    public class AppTrackerInitializer 
//    {
//        //protected override void Seed(AppTrackerContext context)
//        //{
//        //    var companies = new List<Company>
//        //    {
//        //        new Company { ID = 1, Name = "ABC Company", ContactName = "Sue Smith", ContactTitle = "HR Manager", Email = "sue@abcco.com", Phone = "5025551212", Website = "www.abccompany.com" },
//        //        new Company { ID = 2, Name = "Microsoft", ContactName = "Joe Johnson", ContactTitle = "Manager", Email = "joe@ms.com", Phone = "5025461234", Website = "www.microsoft.com" },
//        //        new Company { ID = 3, Name = "IT Inc.", ContactName = "Bob Brown", ContactTitle = "IT Manager", Email = "bob@it.com", Phone = "5022221555", Website = "www.itinc.com" }
//        //    };

//        //    companies.ForEach(s => context.Companies.Add(s));
//        //    context.SaveChanges();

//        //    var apps = new List<Application>
//        //    {
//        //        new Application {ID = 1, AppliedVia = "LinkedIn", DateApplied=DateTime.Parse("12/12/2005"), Position = "software engineer", AppSubmitted = true, CLSubmitted = true, ResSubmitted = true, CompanyID = 2},
//        //        new Application {ID = 2, AppliedVia = "Indeed", DateApplied=DateTime.Parse("12/05/2005"), Position = "DBA", AppSubmitted = true, CLSubmitted = true, ResSubmitted = false, CompanyID = 3},
//        //        new Application {ID = 3, AppliedVia = "LinkedIn", DateApplied=DateTime.Parse("11/25/2005"), Position = "web developer", AppSubmitted = true, CLSubmitted = false, ResSubmitted = true, CompanyID = 1}
//        //    };

//        //    apps.ForEach(a => context.Applications.Add(a));
//        //    context.SaveChanges();

//        //    var updates = new List<Update>
//        //    {
//        //        new Update { Subject = UpdateSubject.Email, Note = "Received email confirming application", ApplicationID = 3},
//        //        new Update { Date=DateTime.Parse("08/08/2015"), Subject = UpdateSubject.Interview, Note = "Telephone interview scheduled.", ApplicationID = 1},
//        //        new Update { Subject=UpdateSubject.Other, Note = "Submitted cover letter via email", Date=DateTime.Parse("09/09/2015"), ApplicationID = 2 }
//        //    };

//        //    updates.ForEach(u => context.Updates.Add(u));
//        //    context.SaveChanges();
//        //}
//    } 
//}