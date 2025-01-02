using BEL;

using ORM;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SRV
{
    public static class Archivador
    {
        public static void Respaldar(string pUsuario, string pDescripcion)
        {
            try
            {
                ArchivoORM archivoORM = new ArchivoORM();
                List<Archivo> archivos = archivoORM.Consultar();
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                string subcarpeta = Path.Combine("Archivador", timestamp);

                if (!Directory.Exists(subcarpeta))
                {
                    Directory.CreateDirectory(subcarpeta);
                }

                foreach (var archivo in archivos)
                {
                    string origen = Path.Combine("Archivos", archivo.Nombre);
                    string destino = Path.Combine(subcarpeta, archivo.Nombre);
                    File.Copy(origen, destino, true);
                }

                Registrar(pUsuario, "Respaldo", pDescripcion);
            }
            catch { throw new Exception("Error al respaldar."); }
        }


        public static void Restaurar
            (
            int pId,
            string pUsuario,
            string pDescripcion
            )
        {
            try
            {
                ArchivoORM archivoORM = new ArchivoORM();
                BitacoraORM bitacoraORM = new BitacoraORM();
                List<Archivo> archivos = archivoORM.Consultar();
                List<Bitacora> bitacoras = bitacoraORM.Consultar();
                Bitacora bitacora = bitacoras.FirstOrDefault(x => x.Id == pId);
                string subcarpeta = Path.Combine("Archivador", bitacora.FechaHora.ToString("yyyy-MM-dd-HH-mm-ss"));

                foreach (var archivo in archivos)
                {
                    string origen = Path.Combine(subcarpeta, archivo.Nombre);
                    string destino = Path.Combine("Archivos", archivo.Nombre);
                    File.Copy(origen, destino, true);
                }

                Registrar(pUsuario, "Restauracion", pDescripcion);
            }
            catch { throw new Exception("Error al restaurar."); }
        }


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| COMPARTIDO

        /// <summary>
        /// Registra en bitácora ya sea respaldo ya sea restauración.
        /// </summary>
        /// <param name="pUsuario">Usuario del sistema</param>
        /// <param name="pTipo">Respaldo || Restauracion</param>
        /// <param name="pDescripcion">Notas adicionales</param>
        public static void Registrar
            (
            string pUsuario,
            string pTipo,
            string pDescripcion
            )
        {
            try
            {
                BitacoraORM bitacoraORM = new BitacoraORM();
                List<Bitacora> bitacoras = bitacoraORM.Consultar();

                Bitacora bitacora = new Bitacora
                {
                    Usuario = pUsuario,
                    FechaHora = DateTime.Now,
                    Tipo = pTipo,
                    Descripcion = pDescripcion
                };

                bitacoraORM.Agregar(bitacora);
            }
            catch { throw new Exception("Error al registrar."); }
        }

        public static List<Bitacora> ConsultarRespaldos()
        {
            BitacoraORM bitacoraORM = new BitacoraORM();
            return bitacoraORM.Consultar()
                .Where(x => x.Tipo == "Respaldo")
                .ToList();
        }

        public static List<Bitacora> ConsultarTodo()
        {
            BitacoraORM bitacoraORM = new BitacoraORM();
            return bitacoraORM.Consultar();
        }
    }
}
