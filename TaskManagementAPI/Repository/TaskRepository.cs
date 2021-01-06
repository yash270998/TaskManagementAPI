using System;
using System.Collections.Generic;
using System.Linq;
using TMS_API.Data;
using TMS_API.Models;
using TMS_API.Repository.IRepository;

namespace TMS_API.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _db;

        public TaskRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateTask(Task task)
        {
            _db.Tasks.Add(task);
            return Save();
        }

        public bool DeleteTask(int id)
        {
            Task task = GetTask(id);
            if (task == null)
            {
                return Save();
            }
            else
            {
                _db.Remove(task);
                return Save();
            }
        }

        public ICollection<Task> GetTasks()
        {
            return _db.Tasks.OrderBy(a => a.Id).ToList();
        }
        public ICollection<Task> GetTasksDate(DateTime date)
        {
            return _db.Tasks.Where(a => a.Start_date == date && a.State == "inProgress").ToList();
        }

        public Task GetTask(int taskId)
        {
            return _db.Tasks.FirstOrDefault(a => a.Id == taskId);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateTask(Task task)
        {
            _db.Tasks.Update(task);
            return Save();
        }
    }
}
