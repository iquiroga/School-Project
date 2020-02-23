using CoreEscuela.Util;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
  class Program
  {
    static void Main(string[] args)
    {
      var engine = new EscuelaEngine();
      engine.Inicializar();
      Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
      Printer.Beep();
      ImprimirCursosEscuela(engine.Escuela);
    }
    private static void ImprimirCursosEscuela(Escuela escuela)
    {
      Printer.WriteTitle("Cursos de la Escuela");

      foreach (var curso in escuela.Cursos)
      {
        WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}, Jornada: {curso.Jornada}");
      }
    }
  }
}
