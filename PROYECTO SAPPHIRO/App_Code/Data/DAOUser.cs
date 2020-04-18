using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOUser
/// </summary>
public class DAOUser
{
    public EUsuario Login(EUsuario user)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Nombre_usuario.Equals(user.Nombre_usuario) && x.Contraseña.Equals(user.Contraseña)).FirstOrDefault();
        }
    }
}