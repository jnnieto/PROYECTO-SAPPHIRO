using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EUsuario
/// </summary>
[Serializable]
[Table("Usuario", Schema = "bdsapphiro")]
public class EUsuario
{
    private int id_usuario;
    private int id_rol;
    private string nombre_usuario;
    private string contraseña;
    private string primer_nombre;
    private string segundo_nombre;
    private string primer_apellido;
    private string segundo_apellido;
    private string nombre_empresa;

    [Key]
    [Column("id_usuario")]
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    [Column("id_rol")]
    public int Id_rol { get => id_rol; set => id_rol = value; }
    [Column("nombre_usuario")]
    public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
    [Column("contraseña")]
    public string Contraseña { get => contraseña; set => contraseña = value; }
    [Column("primer_nombre")]
    public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
    [Column("segundo_nombre")]
    public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
    [Column("primer_apellido")]
    public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
    [Column("segundo_apellido")]
    public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
    [Column("nombre_empresa")]
    public string Nombre_empresa { get => nombre_empresa; set => nombre_empresa = value; }
}