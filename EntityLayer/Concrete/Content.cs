using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ID { get; set; }
        [StringLength(250)]
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public int Heading_ID { get; set; }
        public virtual Heading Heading { get; set; }

        public int Writer_ID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
