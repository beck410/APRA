using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Caretaker {

    public int caretakerId { get; set; }
    public int PatientId { get; set; } 
    public string ImageLink { get; set; }
    public string Name { get; set; }
    public string Relationship { get; set; }
    public string Details { get; set; }

    public Patient patient { get; set; }

    public Caretaker(int patientId, string imageLink, string name, string relationship, string details ) {

      _isEmpty(name, relationship);

      this.PatientId = patientId;
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