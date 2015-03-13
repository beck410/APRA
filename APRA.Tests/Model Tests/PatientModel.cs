using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APRA.Models;

namespace APRA.Tests.Model_Tests {
  [TestClass]
  public class PatientModel {

    [TestMethod]
    public void AddPatientSuccess() {
      Patient john = new Patient("John Smith","Nashville, TN", 12);
      Assert.AreEqual("John Smith", john.Name);
      Assert.AreEqual("Nashville, TN", john.Location);
      Assert.AreEqual(12, john.UserId);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidPatientWithEmptyName() {
      Patient john = new Patient("", "Nashville, TN", 12);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidPatientWithWhiteSpace() {
      Patient john = new Patient("  ", "Nashville, TN", 12);
    }
  }
}
