using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
  public class EscuelaEngine
  {
    public Escuela Escuela { get; set; }

    public EscuelaEngine()
    {

    }

    public void Inicializar()
    {
      Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                            pais: "Colombia", ciudad: "Bogotá");
      CargarCursos();
      CargarAsignaturas();
      CargarEvaluaciones();
    }

    private void CargarEvaluaciones()
    {
      throw new NotImplementedException();
    }

    private void CargarAsignaturas()
    {
      foreach (var curso in Escuela.Cursos)
      {
        List<Asignatura> listaAsignaturas = new List<Asignatura>(){
          new Asignatura{Nombre="Matemáticas"},
          new Asignatura{Nombre="Educación Física"},
          new Asignatura{Nombre="Castellano"},
          new Asignatura{Nombre="Ciencias Naturales"},
        };
        curso.Asignaturas = listaAsignaturas;
      }
    }

    private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
    {
      string[] nombre1 = { "Julieta", "Lucas", "Donald", "Ignacio", "Omar", "Cristina", "Ragnar", "Bjorn", "Harald" };
      string[] nombre2 = { "Freddy", "Rick", "Morty", "Diomedes", "Olaf", "Floki", "Lagertha", "Ubbe", "Ivar" };
      string[] apellido = { "Montgaillard", "Quiroga", "Robles", "Villarruel", "Benedetti", "Blasco" };

      var listaAlumnos = from n1 in nombre1
                         from n2 in nombre2
                         from a1 in apellido
                         select new Alumno { Nombre = $"{n1} {n2} {a1}" };
      return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();

    }

    private void CargarCursos()
    {
      Escuela.Cursos = new List<Curso>(){
                       new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
                       new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
                       new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},
                       new Curso{Nombre = "401", Jornada = TiposJornada.Mañana},
                       new Curso{Nombre = "501", Jornada = TiposJornada.Mañana}
      };

      Random rnd = new Random();
      foreach (var c in Escuela.Cursos)
      {
        int cantRandom = rnd.Next(5, 20);
        c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
      }
    }
  }
}