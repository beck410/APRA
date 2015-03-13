using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Permission {

    [Required]
    public int PermissionId { get; set; }
    [Required]
    public int PatientId { get; set; }
    //admin or patient
    [Required]
    public string Role { get; set; }

    public Permission(int patientId, string role) {
      this.PatientId = patientId;
      _checkRoleValidity(role);
    }

    private void _checkRoleValidity(string role) {
      string[] roles = { "admin","patient" };

      if (roles.Contains(role) == true) {
        this.Role = role;
        return;
      }

      throw new ArgumentException("role is not valid");
    }
  }
}