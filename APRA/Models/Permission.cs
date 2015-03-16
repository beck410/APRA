﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Permission {

    public int ID { get; set; }
    public string UserID { get; set; }
    //admin or patient
    public string Role { get; set; }

    public Permission() { }

    public Permission(string userId, string role) {
      this.UserID = userId;
      _checkRoleValidity(role);
    }

    private void _checkRoleValidity(string role) {
      string[] roles = { "admin", "patient" };

      if (roles.Contains(role) == true) {
        this.Role = role;
        return;
      }

      throw new ArgumentException("role is not valid");
    }
  }
}