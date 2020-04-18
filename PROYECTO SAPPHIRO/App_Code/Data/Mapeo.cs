using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Mapeo
/// </summary>
public class Mapeo : DbContext
{
    public Mapeo() : base("name=Conexion")
    {

    }
    public DbSet<EUsuario> usuario { get; set; }
}