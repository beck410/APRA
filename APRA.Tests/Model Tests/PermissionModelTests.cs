﻿﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APRA.Models;

namespace APRA.Tests.Model_Tests {
  [TestClass]
  public class PermissionModelTests {
    [TestMethod]
    public void AddPermissionAdminSuccess() {
      Permission user1 = new Permission("1", "admin");
      Assert.Equals(3, user1.Role);
      Assert.Equals("admin", user1.Role);
    }

    [TestMethod]
    public void AddPermissionPatientSuccess() {
      Permission user1 = new Permission("1", "admin");
      Assert.Equals(3, user1.Role);
      Assert.Equals("patient", user1.Role);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddPermissonInvalidRole() {
      Permission user2 = new Permission("1", "admin");
    }
  }
}
