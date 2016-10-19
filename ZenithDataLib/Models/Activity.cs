using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [MaxLength(75)]
        public String Description { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        public List<Event> Events { get; set; }

    }
}
