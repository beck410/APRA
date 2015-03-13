using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APRA.Models;

namespace APRA.Tests.Model_Tests {
  [TestClass]
  public class TaskModelTests {
    [TestMethod]
    public void AddTaskSuccess() {
      Task breakfast = new Task(3,5,"breakfast","cereal and a banana - take pills with food","morning","http://www.aws.com/photolink",new DateTime(2015,5,4));
      Assert.AreEqual(3, breakfast.PatientID);
      Assert.AreEqual(5, breakfast.Week);
      Assert.AreEqual("breakfast", breakfast.TaskName);
      Assert.AreEqual("cereal and a banana - take pills with food" ,breakfast.TaskNotes);
      Assert.AreEqual("http://www.aws.com/photolink", breakfast.ImageLink);
      Assert.AreEqual(new DateTime(2015, 5, 4), breakfast.Date);
      Assert.AreEqual(null, breakfast.Difficulty);
      Assert.AreEqual(null, breakfast.Stress);
      Assert.AreEqual(null, breakfast.StartTime);
      Assert.AreEqual(null, breakfast.EndTime);

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidTaskEmptyTaskName() {
      Task breakfast = new Task(3,5," ","cereal and a banana - take pills with food","morning","http://www.aws.com/photolink",new DateTime(2015,5,4));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddInvalidTaskInvalidWeek() {
      Task breakfast = new Task(3,57," ","cereal and a banana - take pills with food","morning","http://www.aws.com/photolink",new DateTime(2015,5,4));
    }
  }
}
