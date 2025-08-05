using System;

namespace Encuesta.Models;

public class Encuesta
{
    public string Nombre { get; set; } = string.Empty;
    public string Comentarios { get; set; } = string.Empty;
    public bool HorasExtra { get; set; }
}