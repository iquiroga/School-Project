using System;
using System.Linq;
using CoreEscuela.Entidades;


namespace Etapa1
{
  class Program
  {
    static void Main(string[] args)
    {
      var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
      pais: "Colombia", ciudad: "Bogotá"
      );

      var arregloCursos = new Curso[3];

      arregloCursos[0] = new Curso()
      {
        Nombre = "101"
      };

      var curso2 = new Curso()
      {
        Nombre = "201"
      };
      arregloCursos[1] = curso2;

      arregloCursos[2] = new Curso
      {
        Nombre = "301"
      };

      string separador = String.Concat(Enumerable.Repeat("=", 20));
      string separador2 = new string('*', 20);
      Console.WriteLine(separador2);
      Console.WriteLine(escuela);
      Console.WriteLine(separador2);
      Console.WriteLine(separador);
      Console.WriteLine("Cursos con While");
      Console.WriteLine(separador);
      //Console.WriteLine(arregloCursos[0].Nombre);
      ImprimirCursosWhile(arregloCursos);
      Console.WriteLine(separador);
      Console.WriteLine("Cursos con Do While");
      Console.WriteLine(separador);
      ImprimirCursosDoWhile(arregloCursos);
      Console.WriteLine(separador);
      Console.WriteLine("Cursos con For");
      Console.WriteLine(separador);
      ImprimirCursosFor(arregloCursos);
      Console.WriteLine(separador);
      Console.WriteLine("Cursos con ForEach");
      Console.WriteLine(separador);
      ImprimirCursosForEach(arregloCursos);


    }

    private static void ImprimirCursosWhile(Curso[] arregloCursos)
    {
      int contador = 0;
      while (contador < arregloCursos.Length)
      {
        Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
        contador++;
      }
    }

    private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
    {
      int contador = 0;
      do
      {
        Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
        //contador ++;
      } while (++contador < arregloCursos.Length); /*se puede poner el contador dentro del while, pero
       si se pone la suma antes (+++contador) se va a sumar un 1 antes del <. En cambio, si ponemos contador++,
       la suma se va a hacer despues del signo <...*/
    }

    private static void ImprimirCursosFor(Curso[] arregloCursos)
    {
      for (int i = 0; i < arregloCursos.Length; i++)
      {
        Console.WriteLine($"Nombre {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}");
      }
    }

    private static void ImprimirCursosForEach(Curso[] arregloCursos)
    {
      foreach (var curso in arregloCursos)
      {
        Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
      }
    }
  }
}
