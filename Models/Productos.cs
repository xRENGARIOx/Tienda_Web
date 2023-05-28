using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaWeb.Models;
public class Productos
{
    [Key]
    public int id { get; set; }
    [Display(Name ="Nombre del Producto")]
    [Required(ErrorMessage ="Ingresa el Nombre del Producto")]
    public string nombre { get; set; }
    [Display(Name ="Precio del Producto")]
    [Required(ErrorMessage ="Ingresa el Precio del Producto")]
    public double precio { get; set; }
    [Display(Name ="Categoria")]
    public int id_categoria { get; set; }
    [ForeignKey("id_categoria")]
    public Categorias? categoria { get; set; }
    [Display(Name ="Imagen del Producto")]
    public string? UrlImagen { get; set; }
}