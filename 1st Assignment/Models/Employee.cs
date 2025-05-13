using System;
using System.Collections.Generic;

namespace _1st_Assignment.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public DateOnly? HireDate { get; set; }

    public decimal? Salary { get; set; }
}
