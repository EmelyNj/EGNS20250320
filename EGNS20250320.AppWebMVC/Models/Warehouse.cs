using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGNS20250320.AppWebMVC.Models;

public partial class Warehouse
{
   
    [Display(Name = "ID de la Bodega")]
    public int WarehouseId { get; set; }


    [Display(Name = "Nombre de la Bodega")]
    public string WarehouseName { get; set; } = null!;

    [Display(Name = "Desripción de la Bodega")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
