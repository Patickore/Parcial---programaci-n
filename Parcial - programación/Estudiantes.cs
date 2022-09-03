using System;

namespace Parcial___programación
{
    internal class Estudiantes
    {
        internal int NotaFinal;

        public Estudiantes(int id, string codigo, string nombre, int edad, int nota1, int nota2, int notaFinal)
        {
            Codigo = codigo;
            NotaFinal = notaFinal;
        }

        public Estudiantes(int id, string codigo, string nombre, int edad, string facultad, string asignatura, int nota1, int nota2, int notaFinal)
        {
            Codigo = codigo;
            NotaFinal = notaFinal;
        }

        public string Codigo { get; internal set; }

        internal bool mostrar()
        {
            throw new NotImplementedException();
        }
    }
}