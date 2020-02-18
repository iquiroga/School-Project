using System;
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
      
      var curso1 = new Curso(){
        Nombre="101"
      };

      var curso2 = new Curso(){
        Nombre="201"
      };

      var curso3 = new Curso(){
        Nombre="301"
      };
      Console.WriteLine(escuela);
      Console.WriteLine("==========================");
      Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
      Console.WriteLine($"{curso2.Nombre} , {curso1.UniqueId}");
      Console.WriteLine(curso3);
    }
  }
}
