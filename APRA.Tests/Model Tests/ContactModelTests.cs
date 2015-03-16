using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APRA.Models;

namespace APRA.Tests.Model_Tests {
  [TestClass]
  public class ContactModelTests {

    [TestMethod]
    public void AddContactSuccess() {
      Contact contact = new Contact(3, "Mary Smith", "6157728790", "wife");
      Assert.AreEqual(3,contact.PatientID);
      Assert.AreEqual("Mary Smith",contact.Name);
      Assert.AreEqual("6157728790",contact.Phone);
      Assert.AreEqual("wife",contact.Relationship);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidContactEmptyName() {
      Contact contact = new Contact(3, " ", "6157728790", "wife");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidContactEmptyRelationship() {
      Contact contact = new Contact(3, "Mary Smith", "6157728790", "");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidContactEmptyPhone() {
      Contact contact = new Contact(3, "Mary Smith", "", "wife");
    }
  }
}
