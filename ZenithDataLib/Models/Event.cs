using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public String UserName { get; set; }

        

        public DateTime CreationDate { get; set; }

        public bool IsActive { get; set; }

        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
