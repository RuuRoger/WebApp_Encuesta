using System;

namespace Encuesta.Services;

public class ServicioEncuestas
{
    //** This page control all the logical of the application

    public List<Encuesta.Models.Encuesta> Encuestas { get; set; } = new List<Encuesta.Models.Encuesta>();

    public void Agregar(Encuesta.Models.Encuesta encuesta)
    {
        Encuestas.Add(encuesta);
    }
}