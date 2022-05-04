using System.ComponentModel.DataAnnotations;

namespace BlazorHRApp.Server.Models
{
    public class Position
    {
        [Key]
        public int PId { get; set; }
        public string? PName { get; set; }
        public int Salary { get; set; }
    }
}
