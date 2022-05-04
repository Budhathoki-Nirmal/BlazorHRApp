using BlazorHRApp.Server.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorHRApp.Server.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string EAddress { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Gender Gender { get; set; }
        public DateTime? JoinDate { get; set; }
        public int DId { get; set; }
        [ForeignKey("DId")]
        public Department? Department { get; set; }
        public int PId { get; set; }
        [ForeignKey("PId")]
        public Position? Position { get; set; }
    }
}
