﻿using ABS;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BEL
{
    public class Rol : IComposite
    {
        private readonly string nombre;
        private readonly List<IComposite> nodos;

        public Rol(string nombre)
        {
            this.nombre = nombre;
            this.nodos = new List<IComposite>();
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public void AgregarNodo(IComposite nodo)
        {
            nodos.Add(nodo);
        }

        public void QuitarNodo(IComposite nodo)
        {
            nodos.Remove(nodo);
        }

        public IEnumerable<IComposite> ObtenerNodos()
        {
            return nodos;
        }

        public void LimpiarNodos()
        {
            nodos.Clear();
        }
    }


    public class Permiso : IComposite
    {
        private string nombre;

        public Permiso(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public void AgregarNodo(IComposite nodo)
        {
            throw new InvalidOperationException("No se pueden agregar nodos a un permiso.");
        }

        public void QuitarNodo(IComposite nodo)
        {
            throw new InvalidOperationException("No se pueden quitar nodos de un permiso.");
        }

        public IEnumerable<IComposite> ObtenerNodos()
        {
            return Enumerable.Empty<IComposite>();
        }

        public void LimpiarNodos()
        {
            throw new InvalidOperationException("No se pueden limpiar nodos de un permiso.");
        }
    }
}
