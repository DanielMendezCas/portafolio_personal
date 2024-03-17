using Portafolio.Models;
namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto
            {
              Titulo = "UPIICSA",
              Descripcion = "Unidad Profesional Interdisciplinaria de Ingeniería y Ciencias Sociales y Administrativas",
              Link = "https://www.upiicsa.ipn.mx/",
              ImagenURL = "/images/upiicsa.png"
            },

             new Proyecto
            {
              Titulo = "Spotify",
              Descripcion = "Empresa de servicios multimedia sueca fundada en 2006, cuyo producto es la aplicación homónima empleada para la reproducción de música vía streaming.",
              Link = "https://www.spotify.com",
              ImagenURL = "/images/spotify.jpeg"
            }
            };
        }
    }
}