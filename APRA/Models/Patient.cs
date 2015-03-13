using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Patient {
    [Required]
    public int PatientId;
    [Required]
    public string Name;
    [Required]
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