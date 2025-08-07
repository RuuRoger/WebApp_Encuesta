using Encuesta.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Encuesta.Pages;

public class ResultadosModel : PageModel
{
    private readonly ServicioEncuestas _servicioEncuestas;

    public ResultadosModel(ServicioEncuestas servicioEncuestas)
    {
        _servicioEncuestas = servicioEncuestas;
    }


    public List<Encuesta.Models.Encuesta> Encuestas { get; set; } = new List<Encuesta.Models.Encuesta>();

    public void OnGet()
    {
        Encuestas = _servicioEncuestas.Encuestas;
    }

}
