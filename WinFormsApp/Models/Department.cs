using System;
using System.Collections.Generic;

namespace WinFormsApp.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public string DisplayValue => $"{Id} - {Name}";
}
