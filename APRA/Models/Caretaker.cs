using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Caretaker {

    public int caretakerId { get; set; }
    public int patientId { get; set; } 
    public string imageLink { get; set; }
    public string name { get; set; }
    public string relationship { get; set; }
    public string details { get; set; }


    public Patient patient { get; set; }
  }
}