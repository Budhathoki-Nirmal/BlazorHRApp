using System.ComponentModel.DataAnnotations;

namespace BlazorHRApp.Shared.ModelVM
{
    public class DepartmentVM
    {
        public int DId { get; set; }
        public string? DName { get; set; }
        List<EmployeeVM>? EmployeeVM { get; set; }
    }
}
