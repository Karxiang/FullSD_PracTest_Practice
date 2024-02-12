using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSDPrac.Shared.Domain
{
    public class Task : BaseDomainModel
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public virtual User? Users { get; set; }
        public virtual List<Manager>? Managers { get; set; }


    }
}
