using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Contact {

    public int contactId { get; set; }
    public int patientId { get; set; }
    public string name { get; set; }
    public int phone { get; set; }
    public string relationship { get; set; }


    public Patient patient { get; set; }
  }
}