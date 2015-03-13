using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Permission {

    public int PermissionId { get; set; }
    public int PatientId { get; set; }
    public string Role { get; set; }

  }
}