using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TaskManager.Entities
{
    [Table("Tbl_Task")]
   public  class Task
    {
        [Key]
        public int TaskId { get; set; }
        public int? TaskParentId { get; set; }
        [Required]
        [StringLength(20)]
        public string TaskName { get; set; }
        public int? Priority { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? Startdate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? Enddate { get; set; }
        

        public Task TaskParent { get; set; }
    }
   

}
