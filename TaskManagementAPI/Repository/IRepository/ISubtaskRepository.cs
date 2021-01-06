using System;
using System.Collections.Generic;
using TMS_API.Models;

namespace TMS_API.Repository.IRepository
{
  public interface ISubtaskRepository
  {
    ICollection<Subtask> GetSubtasks();
    Subtask GetSubtask(int subtaskId);
    ICollection<Subtask> GetSubtasksByTaskID(int taskid);
    bool CreateSubtask(Subtask subtask);
    bool UpdateSubtask(Subtask subtask);
    bool DeleteSubtask(Subtask subtask);
    bool Save();
  }
}
