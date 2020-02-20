using System;
using System.Linq;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
  class Program
  {
    static void Main(string[] args)
    {
      var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
      pais: "Colombia", ciudad: "Bogotá"
      );

      escuela.Cursos = new Curso[]{
                          new Curso{Nombre = "101"},
                          new Curso{Nombre = "201"},
                          new Curso{Nombre = "301"}
      };

      ImprimirCursosEscuela(escuela);
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
        WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}, Jornada {curso.Jornada}");
      }
    }
  }
}
