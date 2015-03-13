using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using APRA.Models;

namespace APRA.Context {
  public class ScheduleContext : DbContext{

    public ScheduleContext() : base("ScheduleContext") { }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Caretaker> Caretakers { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Task> Tasks { get; set; }

  }
}