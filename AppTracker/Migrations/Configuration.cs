namespace AppTracker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AppTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AppTracker.Data.AppTrackerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AppTracker.Data.AppTrackerContext";
        }

        protected override void Seed(AppTracker.Data.AppTrackerContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Companies.AddOrUpdate(x => x.CompanyID,

                new Company { CompanyID = 1, Name = "ABC Company", ContactName = "Sue Smith", ContactTitle = "HR Manager", Email = "sue@abcco.com", Phone = "5025551212", Website = "www.abccompany.com" },
                new Company { CompanyID = 2, Name = "Microsoft", ContactName = "Joe Johnson", ContactTitle = "Manager", Email = "joe@ms.com", Phone = "5025461234", Website = "www.microsoft.com" },
                new Company { CompanyID = 3, Name = "IT Inc.", ContactName = "Bob Brown", ContactTitle = "HR", Email = "bob@it.com", Phone = "5022221555", Website = "www.itinc.com" },
                new Company { CompanyID = 4, Name = "QRSoft", ContactName = "Janet Mitchell", ContactTitle = "Architect", Email = "j.mitchell@qr.com", Phone = "5027771555", Website = "www.qrsoft.com" },
                new Company { CompanyID = 5, Name = "Apple", ContactName = "Sarah Murray", ContactTitle = "Recruiter", Email = "sarah@apple.com", Phone = "5028881555", Website = "www.apple.com" }
                );

            context.Applications.AddOrUpdate(x => x.ApplicationID,
                new Application { ApplicationID = 1, AppliedVia = "LinkedIn", DateApplied = DateTime.Parse("12/12/2017"), Position = "Software Engineer", AppSubmitted = true, CLSubmitted = true, ResSubmitted = true, CompanyID = 2 },
                new Application { ApplicationID = 2, AppliedVia = "Indeed", DateApplied = DateTime.Parse("12/05/2017"), Position = "DBA", AppSubmitted = true, CLSubmitted = true, ResSubmitted = false, CompanyID = 3 },
                new Application { ApplicationID = 3, AppliedVia = "LinkedIn", DateApplied = DateTime.Parse("11/25/2017"), Position = "Web Developer", AppSubmitted = true, CLSubmitted = false, ResSubmitted = true, CompanyID = 1 },
                new Application { ApplicationID = 4, AppliedVia = "Company website", DateApplied = DateTime.Parse("10/25/2017"), Position = "IT Intern", AppSubmitted = true, CLSubmitted = true, ResSubmitted = true, CompanyID = 5 },
                new Application { ApplicationID = 5, AppliedVia = "Direct", DateApplied = DateTime.Parse("11/11/2017"), Position = "Software Developer", AppSubmitted = false, CLSubmitted = true, ResSubmitted = true, CompanyID = 4 }
                );

            context.Updates.AddOrUpdate(x => x.UpdateID,
                new Update { Date = DateTime.Parse("08/10/2015"), Subject = UpdateSubject.Email, Note = "Received email confirming application", ApplicationID = 3 },
                new Update { Date = DateTime.Parse("10/10/2015"), Subject = UpdateSubject.Interview, Note = "Telephone interview scheduled.", ApplicationID = 1 },
                new Update { Date = DateTime.Parse("09/09/2015"), Subject = UpdateSubject.Other, Note = "Submitted cover letter via email", ApplicationID = 2 },
                new Update { Date = DateTime.Parse("11/11/2015"), Subject = UpdateSubject.Other, Note = "Interview scheduled for Friday", ApplicationID = 5 },
                new Update { Date = DateTime.Parse("12/12/2015"), Subject = UpdateSubject.Other, Note = "Received job offer", ApplicationID = 4 }

                );
        }
    }
}
