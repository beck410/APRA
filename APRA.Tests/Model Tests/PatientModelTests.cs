using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APRA.Models;

namespace APRA.Tests.Model_Tests {
  [TestClass]
  public class PatientModelTests {

    [TestMethod]
    public void AddPatientSuccess() {
      Patient john = new Patient("John Smith","Nashville, TN");
      Assert.AreEqual("John Smith", john.Name);
      Assert.AreEqual("Nashville, TN", john.Location);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidPatientWithEmptyName() {
      Patient john = new Patient("", "Nashville, TN");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidPatientWithWhiteSpace() {
      Patient john = new Patient("  ", "Nashville, TN");
    }
  }
}
