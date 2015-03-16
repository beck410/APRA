using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Patient {
    public int ID {get; set;}
    public string Name {get; set;}
    public string Location {get; set;}

    public ICollection<Task> Tasks { get; set; }

    public Patient(string name, string location) {
      //if (String.IsNullOrWhiteSpace(name))
      //  throw new ArgumentException("name is invalid");

      this.Name = name;
      this.Location = location; 
    }

    public Patient() { }
  }
}