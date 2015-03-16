namespace APRA.Migrations
{
  using APRA.Models;
  using Microsoft.AspNet.Identity;
  using Microsoft.AspNet.Identity.EntityFramework;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

    internal sealed class Configuration: DbMigrationsConfiguration<APRA.Context.ScheduleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        public void AddUsers(ApplicationDbContext context) {
          List<ApplicationUser> users = new List<ApplicationUser>{
            new ApplicationUser { 
              UserName = "admin1", 
              PasswordHash = "password"
            },
            new ApplicationUser { 
              UserName = "johnsmith", 
              PasswordHash = "password"
            }    
          };

          users.ForEach(user => context.Users.AddOrUpdate(user));
          context.SaveChanges();
        }

        protected override void Seed(APRA.Context.ScheduleContext context)
        {
          ApplicationDbContext userContext = new ApplicationDbContext();

          AddUsers(userContext);

          ApplicationUser admin = userContext.Users.Where(x => x.UserName == "admin1").First();
          
          ApplicationUser patient = userContext.Users.Where(x => x.UserName == "johnsmith").First();

          context.Patients.AddOrUpdate(i => i.Name,
            new Patient {
              Name = "John Smith",
              Location = "Nashville, TN"
            },
             new Patient {
              Name = "Peter Thompson",
              Location = "Franklin, TN"
            }
          );

          //context.Contacts.AddOrUpdate(i => i.Name,
          //  new Contact {
          //    PatientID = 1,
          //    Name = "Joe Smith",
          //    Phone = "6158769870",
          //    Relationship = "son",
          //  },
          //  new Contact {
          //    PatientID = 1,
          //    Name = "Mary Smith",
          //    Phone = "6158769874",
          //    Relationship = "wife",
          //  }
          //);

          //context.Caretakers.AddOrUpdate(i => i.Name,
          //  new Caretaker {
          //    PatientID = 1,
          //    ImageLink = "http=//aws.com/apra/image1.png",
          //    Name = "Mary Smith",
          //    Relationship = "wife",
          //    Details = "clothes= white blouse and black pants"
          //  }
          // );

          //context.Permissions.AddOrUpdate(i => i.Role,
          //  new Permission {
          //    Role = "admin",
          //    UserID = admin.Id
          //  },

          //  new Permission {
          //    Role = "patient",
          //    UserID = patient.Id
          //  }
          //);

          //context.Tasks.AddOrUpdate(i => i.TaskName,
          //  new Task {
          //    PatientID = 1,
          //    Week = 1,
          //    TaskName = "Make Breakfast",
          //    TimeOfDay = "morning",
          //    TaskNotes = "make bacon and eggs",
          //    ImageLink = "http://www.fredsullivan.com/wp-content/uploads/2013/12/animal-fats-bacon-and-eggs.jpg",
          //    Date = new DateTime(2015, 01, 01),
          //  },
          //  new Task {
          //    PatientID = 1,
          //    Week = 1,
          //    TaskName = "John Thompson coming over at one",
          //    TimeOfDay = "Noon",
          //    TaskNotes = "serve carrot cake",
          //    Date = new DateTime(2015, 01, 01),
          //  },
          //  new Task {
          //    PatientID = 1,
          //    Week = 1,
          //    TaskName = "Pay Bills - electricity, gas, insurance",
          //    TimeOfDay = "Afternoon",
          //    TaskNotes = "",
          //    Date = new DateTime(2015, 01, 01)
          //  },
          //  new Task {
          //    PatientID = 1,
          //    Week = 1,
          //    TaskName = "Cook Dinner",
          //    TimeOfDay = "Evening",
          //    TaskNotes = "Steak and veges - steak defrosting in fridge",
          //    ImageLink = "http://images.wisegeek.com/crisscrossed-steak.jpg",
          //    Date = new DateTime(2015, 01, 01)
          //  }
          //);
        }
    }
}
