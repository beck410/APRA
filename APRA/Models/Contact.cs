using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Contact {

    public Contact() {}

    public int ID { get; set; }
    public int PatientID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Relationship { get; set; }

    public Patient Patient { get; set; }

    public Contact(int patientid, string name,string phone, string relationship) {
    if(String.IsNullOrWhiteSpace(name)||String.IsNullOrWhiteSpace(relationship)||String.IsNullOrWhiteSpace(phone))
      throw new ArgumentException("name is invalid");

      this.Name = name;
      this.Relationship = relationship;
      this.PatientID = patientid;
      this.Name = name;
      this.Phone = phone;
      this.Relationship = relationship;
    }
  }
}