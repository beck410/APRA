using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Monitor {

    public int carerId { get; set; }
    public int patientId { get; set; }

    public Patient patient { get; set; }

  }
}