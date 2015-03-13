using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APRA.Models {
  public class Task {

    public int taskId { get; set; }
    public int patientID { get; set; }
    public int week { get; set; }
    public string taskName { get; set; }
    public string timeOfDay { get; set; }
    public string taskNotes { get; set; }
    public int imageLink { get; set; }
    public DateTime date { get; set; }
    public int difficulty { get; set; }
    public int stress { get; set; }
    public string feedbackNotes { get; set; }


    public Patient patient { get; set; }
  }
}