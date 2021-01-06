using System;
using System.Collections;
using System.Collections.Generic;
using TMS_API.Models;

namespace TMS_API.Repository.IRepository
{
  public interface ITaskRepository
  {
    ICollection<Task> GetTasks();
    ICollection<Task> GetTasksDate(DateTime date);
    Task GetTask(int taskId);
    bool CreateTask(Task task);
    bool UpdateTask(Task task);
    bool DeleteTask(int id);
    bool Save();
  }
}
