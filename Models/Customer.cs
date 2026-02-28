using System;
using System.Collections.Generic;

namespace CoreRazorPagesDemo1.Models;

public partial class Customer
{
    public int Custid { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public decimal? Balance { get; set; }

    public string? Status { get; set; }
}
