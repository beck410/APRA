using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APRA.Models;

namespace APRA.Tests.Model_Tests {
  [TestClass]
  public class CaretakerModelTests {
    [TestMethod]
    public void AddCaretakerSuccess() {
      Caretaker ct = new Caretaker(3,"https://s3-us-west-2.amazonaws.com/apra/84/2015-03-04","Nancy Smith","wife","wearing black pants and white shirt");

      Assert.AreEqual(3,ct.PatientId);
      Assert.AreEqual("https://s3-us-west-2.amazonaws.com/apra/84/2015-03-04",ct.ImageLink);
      Assert.AreEqual("Nancy Smith",ct.Name);
      Assert.AreEqual("wife",ct.Relationship);
      Assert.AreEqual("wearing black pants and white shirt",ct.Details);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidCaretakerEmptyName() {
      Caretaker ct = new Caretaker(3,"https://s3-us-west-2.amazonaws.com/apra/84/2015-03-04","","wife","wearing black pants and white shirt");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidCaretakerEmptyRelationship() {
      Caretaker ct = new Caretaker(3,"https://s3-us-west-2.amazonaws.com/apra/84/2015-03-04","Nancy Smith","","wearing black pants and white shirt");
    }
  }
}
