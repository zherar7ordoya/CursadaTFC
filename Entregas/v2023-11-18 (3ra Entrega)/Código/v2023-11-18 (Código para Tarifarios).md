# Perfeccionamiento del mecanismo de tarifarios

Entendido, aquí tienes un ejemplo más completo que incluye la definición de la clase `Tarifa`, un archivo XML de ejemplo llamado `Tarifas.xml` con cuatro tarifas, y un ejemplo de cómo cargar y consultar las tarifas en función de la fecha y el tipo de cliente en tu aplicación.

Primero, la definición de la clase `Tarifa`:

```csharp
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public enum TipoCliente
{
    ClienteCorporativo,
    ClienteEmpresarial,
    ClienteGubernamental,
    ClienteParticular
}

public class Tarifa : IId
{
    [XmlAttribute("Id")]
    public int Id { get; set; }
    public DateTime VigenciaFechaDesde { get; set; }
    public DateTime VigenciaFechaHasta { get; set; }
    public decimal TarifaPorKilometro { get; set; }
    public Dictionary<TipoCliente, decimal> RecargosPorTipoCliente { get; set; }
}
```

A continuación, el contenido del archivo XML de ejemplo `Tarifas.xml`:

```xml
<Tarifas>
  <Tarifa Id="1">
    <VigenciaFechaDesde>2023-01-01</VigenciaFechaDesde>
    <VigenciaFechaHasta>2023-04-30</VigenciaFechaHasta>
    <TarifaPorKilometro>100</TarifaPorKilometro>
    <RecargosPorTipoCliente>
      <Cliente Tipo="ClienteCorporativo">0.05</Cliente>
      <Cliente Tipo="ClienteEmpresarial">0.10</Cliente>
      <Cliente Tipo="ClienteGubernamental">0.15</Cliente>
      <Cliente Tipo="ClienteParticular">0.20</Cliente>
    </RecargosPorTipoCliente>
  </Tarifa>
  <Tarifa Id="2">
    <!-- Otras tarifas -->
  </Tarifa>
  <!-- Agregar más tarifas según sea necesario -->
</Tarifas>
```

Finalmente, el ejemplo de cómo cargar y consultar las tarifas en tu aplicación:

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        // Cargar las tarifas desde el archivo XML
        List<Tarifa> listaTarifas;

        using (FileStream fs = new FileStream("Tarifas.xml", FileMode.Open))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tarifa>));
            listaTarifas = (List<Tarifa>)serializer.Deserialize(fs);
        }

        // Consultar tarifas para una fecha y tipo de cliente específicos
        DateTime fechaDeseada = DateTime.Now;
        TipoCliente tipoClienteDeseado = TipoCliente.ClienteEmpresarial; // Cambia al tipo de cliente deseado

        Tarifa tarifaEncontrada = listaTarifas.FirstOrDefault(tarifa =>
            fechaDeseada >= tarifa.VigenciaFechaDesde &&
            fechaDeseada <= tarifa.VigenciaFechaHasta);

        if (tarifaEncontrada != null)
        {
            decimal tarifaPorKilometro = tarifaEncontrada.TarifaPorKilometro;
            decimal recargoPorTipoCliente = tarifaEncontrada.RecargosPorTipoCliente[tipoClienteDeseado];

            Console.WriteLine($"Tarifa por kilómetro: {tarifaPorKilometro}");
            Console.WriteLine($"Recargo para {tipoClienteDeseado}: {recargoPorTipoCliente}");
        }
        else
        {
            Console.WriteLine("No se encontró una tarifa válida para la fecha y tipo de cliente especificados.");
        }
    }
}
```

Este ejemplo carga las tarifas desde el archivo XML, consulta las tarifas vigentes para una fecha y un tipo de cliente específicos y muestra los valores de tarifa por kilómetro y recargo en la consola. Puedes ajustar la fecha y el tipo de cliente según tus necesidades.

Espero que este ejemplo te ayude a implementar la funcionalidad en tu aplicación.
