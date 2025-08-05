using Encuesta.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Encuesta.Pages;

public class EncuestaModel : PageModel
{
    [BindProperty]
    public Encuesta.Models.Encuesta encuesta { get; set; } = new Encuesta.Models.Encuesta();

    private readonly ServicioEncuestas _servicioEncuestas;

    public EncuestaModel(ServicioEncuestas servicioEncuestas)
    {
        _servicioEncuestas = servicioEncuestas;
    }

    public IActionResult OnPost()
    {
        _servicioEncuestas.Agregar(encuesta);
        return RedirectToPage("Gracias");
    }
}