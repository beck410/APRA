using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Caretaker {
    public int ID{ get; set; }
    public int PatientID { get; set; } 
    public string ImageLink { get; set; }
    public string Name { get; set; }
    public string Relationship { get; set; }
    public string Details { get; set; }

    public Caretaker() {}

    public Caretaker(int patientId, string imageLink, string name, string relationship, string details ) {

      _isEmpty(name, relationship);
 
      this.PatientID = patientId;
      this.ImageLink = imageLink;
      this.Name = name;
      this.Relationship = relationship;
      this.Details = details;
    }

    private void _isEmpty(string name, string relationship) {

      if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(relationship))
        throw new ArgumentException("name and relationship must have a value");
    }
  }
}