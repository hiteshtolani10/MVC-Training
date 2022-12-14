using System;
using System.Collections.Generic;

namespace Exception_Handling_MVC.Models;

public partial class TblContact
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Email { get; set; }
}
