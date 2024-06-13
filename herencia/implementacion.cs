

namespace herencia
{
   
        public class MiembroDeLaComunidad
        {
            public string Nombre { get; set; }

            public MiembroDeLaComunidad(string nombre)
            {
                Nombre = nombre;
            }

            public virtual void MostrarInfo()
            {
                Console.WriteLine($"Nombre: {Nombre}");
            }
        }

    // Herencia
    public class Empleado : MiembroDeLaComunidad
    {
        public Empleado(string nombre) : base(nombre) { }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public Estudiante(string nombre) : base(nombre) { }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public ExAlumno(string nombre) : base(nombre) { }
    }

    public class Docente : Empleado
    {
        public Docente(string nombre) : base(nombre) { }
    }

    public class Administrativo : Empleado
    {
        public Administrativo(string nombre) : base(nombre) { }
    }

    public class Administrador : Docente
    {
        public Administrador(string nombre) : base(nombre) { }

        // Polimorfismo
        public override void MostrarInfo()
        {
            Console.WriteLine($"Administrador: {Nombre}");
        }
    }

    public class Maestro : Docente
    {
        public Maestro(string nombre) : base(nombre) { }

        // encapsulamiento
        public override void MostrarInfo()
        {
            Console.WriteLine($"Maestro: {Nombre}");
        }
    }

    public void MiembroDeLaComunidad(string[] args)
    {
        MiembroDeLaComunidad[] miembros = new MiembroDeLaComunidad[]
        {
                new Administrador("Juan Pérez"),
                new Maestro("María López"),
                new Estudiante("Carlos Sánchez"),
                new ExAlumno("Ana Gómez"),
                new Administrativo("Luis Fernández")
        };

        foreach (var miembro in miembros)
        {
            miembro.MostrarInfo();
        }
    }


}

