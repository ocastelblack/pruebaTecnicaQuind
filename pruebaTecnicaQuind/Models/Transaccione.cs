using System;
using System.Collections.Generic;

namespace pruebaTecnicaQuind.Models;

public partial class Transaccione
{
    public int IdTransacciones { get; set; }

    public string? TipoTransaccion { get; set; }

    public string? DescripcionTransaccion { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
