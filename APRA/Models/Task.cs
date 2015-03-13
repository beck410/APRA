using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace APRA.Models {
  public class Task {

    [Required]
    public int TaskId { get; set; }
    [Required]
    public int PatientID { get; set; }
    //between 1-52
    [Required]
    [Range(1,52)]
    public int Week { get; set; }
    [Required]
    public string TaskName { get; set; }
    //morning,lunch,afternoon,night
    [Required]
    public string TimeOfDay { get; set; }
    public string TaskNotes { get; set; }
    //must be http link
    public string ImageLink { get; set; }
    [Required]
    public DateTime Date { get; set; }
    //1-10 or null
    [Range(1,10)]
    public int? Difficulty { get; set; }
    //1-10 or null
    [Range(1,10)]
    public int? Stress { get; set; }
    public string FeedbackNotes { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }

    public Patient Patient { get; set; }

    public Task(int patientId, int week, string taskName, string taskNotes, string timeOfDay, string imageLink, DateTime date) {

      _isEmpty(taskName, week.ToString());

      this.PatientID = patientId;
      this.Week = week;
      this.TaskName = taskName;
      this.TaskNotes = taskNotes;
      this.ImageLink = imageLink;
      this.Date = date;
    }

    private void _isEmpty(string name, string relationship) {
      if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(relationship))
        throw new ArgumentException("task name and week must have a value");
    }
  }
}