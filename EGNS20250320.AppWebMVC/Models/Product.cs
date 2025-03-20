using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGNS20250320.AppWebMVC.Models;

public partial class Product
{
    [Display(Name = "Id del Producto")]
    public int ProductId { get; set; }

    [Display(Name = "Nombre del Producto")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Descripción del Producto")]
    public string? Description { get; set; }

    [Display(Name = "Precio del Producto")]
    public decimal Price { get; set; }

    [Display(Name = "Id de la Bodega")]
    public int? BodegaId { get; set; }

    [Display(Name = "Id de la Marca")]
    public int? BrandId { get; set; }

    public virtual Warehouse? Bodega { get; set; }

    public virtual Brand? Brand { get; set; }
}
