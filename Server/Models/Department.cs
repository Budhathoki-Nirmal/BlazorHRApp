using System.ComponentModel.DataAnnotations;

namespace BlazorHRApp.Server.Models
{
    public class Department
    {
        [Key]
        public int DId { get; set; }
        public string? DName { get; set; }
    }
}
