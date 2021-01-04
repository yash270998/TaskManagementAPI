using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TMS_API.Models
{
  public class Task
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    public string State { get; set; }
    public DateTime Start_date { get; set; }
    public DateTime Finish_date { get; set; }

        internal static Task<IEnumerable<Task>> FromResult(IEnumerable<Task> enumerable)
        {
            throw new NotImplementedException();
        }
    }
}
