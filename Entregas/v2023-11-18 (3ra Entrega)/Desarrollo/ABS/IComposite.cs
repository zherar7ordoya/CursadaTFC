using System.Collections.Generic;

namespace ABS
{
    public interface IComposite
    {
        string ObtenerNombre();
        void AgregarNodo(IComposite nodo);
        void QuitarNodo(IComposite nodo);
        IEnumerable<IComposite> ObtenerNodos();
        void LimpiarNodos();
    }
}
