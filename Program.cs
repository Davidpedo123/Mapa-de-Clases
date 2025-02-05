namespace Classes;

public class Miembro_de_la_comunidad
{
    public string Nombre { get; }
    public string Sexo { get; set; }
    

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre}");
    }
    

    public void DecirSexo()
    {
        Console.WriteLine($"Soy {Sexo}");
    }
}


public class Estudiante : Miembro_de_la_comunidad
{
    public string Carrera { get; set; }
    public int Semestre { get; set; }


    public void DecirCarrera()
    {
        Console.WriteLine($"Estudio {Carrera}");
    }


    public void DecirSemestre()
    {
        Console.WriteLine($"Estoy en el semestre {Semestre}");
    }
}

public class Exalumno : Miembro_de_la_comunidad
{
    public string nombre { get; set; }
    public string Carrera { get; set; }

    public void ExDecirCarrera()
    {
        Console.WriteLine($"Estudié {Carrera}");
    }

}

public class Empleado : Miembro_de_la_comunidad
{
    public string Nombre { get; set; }
    public string Profesion { get; set; }

    public void EmDecirNombre()
    {
        Console.WriteLine($"Me llamo {Nombre}");
    }

    public void EmDecirProfesion()
    {
        Console.WriteLine($"Y soy un {Profesion}");
    }
}


public class Docente : Empleado
{
    public string Nombre { get; set; }
    public string Profesion { get; set; }

    public void DDecirNombre()
    {
        Console.WriteLine($"Me llamo {Nombre}");
    }

    public void DDecirProfesion()
    {
        Console.WriteLine($"Y enseño {Profesion}");
    }
}

public class Maestro : Docente
{
    public string Nombre { get; set; }
    public string Profesion { get; set; }

    public void MDecirNombre()
    {
        Console.WriteLine($"Me llamo {Nombre}");
    }

    public void MMDecirProfesion()
    {
        Console.WriteLine($"Y soy un {Profesion}");
    }
}



