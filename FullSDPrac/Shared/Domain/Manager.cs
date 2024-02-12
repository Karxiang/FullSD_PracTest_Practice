using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSDPrac.Shared.Domain
{
    public class Manager : BaseDomainModel
    {
        public int TaskId { get; set; }
        public virtual TaskItem? Task { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
