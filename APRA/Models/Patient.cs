using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Patient {

    public int PatientId;
    public string Name;
    public int UserId;
    public string Location;

    public Contact Contact { get; set; }
    public Caretaker Caretaker { get; set; }
    public ICollection<Task> Tasks { get; set; }

    public Patient(string name, string location,int userId) {
      if (String.IsNullOrWhiteSpace(name))
        throw new ArgumentException("name is invalid");
      else
        this.Name = name;
      
      this.Location = location;
      this.UserId = userId; 
    }
  }
}