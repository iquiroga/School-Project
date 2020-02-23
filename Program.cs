using System;
using System.Linq;
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
      
      ImprimirCursosEscuela(engine.Escuela);
    }
    private static void ImprimirCursosEscuela(Escuela escuela)
    {
      string separador = String.Concat(Enumerable.Repeat("=", 20));
      string separador2 = new string('*', 20);
      WriteLine(separador);
      WriteLine("Cursos de la Escuela");
      WriteLine(separador);

      foreach (var curso in escuela.Cursos)
      {
        WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}, Jornada: {curso.Jornada}");
      }
    }
  }
}
