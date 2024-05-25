using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Institucion.Interfaces
{
    public interface IRepositorio<T>where T:class
    {
        bool Create(T entidad);
        bool Updater(T entidadOriginal, T entidadModificada);
        bool Delete(T entidad);
        List<T> Read{ get; }


    }
}
