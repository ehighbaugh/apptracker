using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppTracker.Data
{
    public class AppTrackerInitializer : DropCreateDatabaseIfModelChanges<AppTrackerContext>
    {
        protected override void Seed(AppTrackerContext context)
        {
            base.Seed(context);
        }
    }
}