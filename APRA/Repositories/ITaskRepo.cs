using APRA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APRA.Repositories {
  interface ITaskRepo {

    List<Task> GetAllTasksByTask(int task_id);
    List<Task> GetTasksByTimeOfDayAndDate(string timeOfDay, DateTime date, int taskId);
    Task GetTaskById(int id);
    Task Delete(int id);
    Task Add(Task task);
    Task Edit(Task task);
  }
}
