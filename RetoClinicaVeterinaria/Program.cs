using System;

class Program
{
    static void Main()
    {
        string especieMascota = "perro";
        int edadMascota = 7;
        double peso = 28.5;
        bool tieneVacunasAlDia = false;
        bool esSocio = true;
        string motivoConsulta = "cirugia";

        string etapaVida = edadMascota switch
        {
            < 1 => "Cachorro",
            >= 1 and <= 3 => "Joven",
            >= 4 and <= 8 => "Adulto",
            _ => "Senior"
        };
        Console.WriteLine("=== Reporte de Atencion Veterinaria ===");
        Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} anos | Etapa: {etapaVida}");

        string alertaVacuna;
        if ((especieMascota == "perro" || especieMascota == "gato") && !tieneVacunasAlDia)
            alertaVacuna = "ALERTA: vacunacion urgente requerida";
        else if ((especieMascota == "perro" || especieMascota == "gato") && tieneVacunasAlDia)
            alertaVacuna = "Vacunacion al dia";
        else
            alertaVacuna = "Esquema de vacunacion no aplica";
        Console.WriteLine($"Estado de vacunacion: {alertaVacuna}");

        decimal costoBase = 0;
        switch (motivoConsulta)
        {
            case "vacuna": costoBase = 35000; break;
            case "revision": costoBase = 50000; break;
            case "cirugia": costoBase = 280000; break;
            case "urgencia": costoBase = 150000; break;
            default: costoBase = 0; break;
        }
        Console.WriteLine($"Motivo: {motivoConsulta} | Costo base: ${costoBase:N0}");

        double porcentajeDescuento = esSocio ? (peso > 25 ? 15.0 : 10.0) : 0.0;
        decimal descuento = costoBase * (decimal)(porcentajeDescuento / 100);
        decimal costoFinal = costoBase - descuento;
        Console.WriteLine($"Descuento: {porcentajeDescuento}% | Costo final: ${costoFinal:N0}");

        string recomendacion;
        if (motivoConsulta == "cirugia")
        {
            if (etapaVida == "Senior")
                recomendacion = "Reposo absoluto por 10 dias, control post-operatorio obligatorio";
            else
                recomendacion = "Reposo por 5 dias, evitar ejercicio intenso";
        }
        else if (motivoConsulta == "urgencia")
        {
            if (!tieneVacunasAlDia)
                recomendacion = "Atender urgencia y programar vacunacion inmediata";
            else
                recomendacion = "Seguimiento en 48 horas";
        }
        else
        {
            recomendacion = "Seguimiento en proxima consulta de rutina";
        }
        Console.WriteLine($"Recomendacion: {recomendacion}");
    }
}
