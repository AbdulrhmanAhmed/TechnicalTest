using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TasskTracking.Models
{
    public class Task_Tracking
    {
        public int id  { get; set; }
        [Required]
        [Display(Name="Task Title")]
        public string task_Title { get; set; }
        [Required]
        [Display(Name = "Task Describtion")]
        public string Task_Description { get; set; }
        [Required]
        [Display(Name = "Assingee")]
        public string Assingee { get; set; }
        [Required]
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime due_date { get; set; }
        [Required]
        [Display(Name = "Priority")]
        public string priority { get; set; }
        [Required]
        [Display(Name = "Statue")]
        public string statue { get; set; }
    }
}