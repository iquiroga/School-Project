using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
  public class Escuela
  {
    string nombre; // variable que encapsula la propiedad
    public string Nombre //propiedad que accede a la variable nombre...
    {
      get { return "Copia: " + nombre; } //cuando alguien pregunta por el nombre retorna el campo nombre...
      set { nombre = value.ToUpper(); } /*cuando alguien desde afuera de la clase quiera asignarle un valor
                                por medio de esta propiedad. el valor que nos entregue se lo asignamos a
                                la variable nombre...*/
      //con .ToUpper lo que hacemos es convertir el nombre en mayúsculas
    }

    public int AñoDeCreacion { get; set; } //el compilador crea una variable "AñoDeCreacion" y crea una logica como arriba

    public string Pais { get; set; }

    public string Ciudad { get; set; }

    public TiposEscuela TipoEscuela { get; set; }

    public List<Curso> Cursos  { get; set; }

    public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año) ;

    public Escuela(string nombre, int año, TiposEscuela tipo,
                   string pais="", string ciudad="")
    {
      (Nombre, AñoDeCreacion) = (nombre, año);
      Pais = pais;
      Ciudad = ciudad;
    }

    public override string ToString()
    {
      return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
    }
  }
}