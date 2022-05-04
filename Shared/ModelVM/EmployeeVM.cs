
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorHRApp.Shared.ModelVM
{
    public class EmployeeVM
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string EAddress { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Gender GenderVM { get; set; }
        public DateTime? JoinDate { get; set; }
        public int DId { get; set; }
        [ForeignKey("DId")]
        public string? DName { get; set; }
        public DepartmentVM? DepartmentVM { get; set; }
        public int PId { get; set; }
        [ForeignKey("PId")]
        public string? PName { get; set; }
        public PositionVM? PositionVM { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}
