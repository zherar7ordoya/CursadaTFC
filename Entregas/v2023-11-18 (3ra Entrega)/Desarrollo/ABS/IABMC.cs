using System.Collections.Generic;

namespace ABS
{
    public interface IABMC<T>
    {
        void Agregar(T pObject);
        void Eliminar(int pId);
        void Modificar(T pObject);
        List<T> Consultar();
    }
}
