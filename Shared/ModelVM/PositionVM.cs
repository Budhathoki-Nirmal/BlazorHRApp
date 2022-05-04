using System.ComponentModel.DataAnnotations;

namespace BlazorHRApp.Shared.ModelVM
{
    public class PositionVM
    {
        
        public int PId { get; set; }
        public string? PName { get; set; }
        public int Salary { get; set; }
        List<EmployeeVM>? EmployeeVM { get; set; }
    }
}
