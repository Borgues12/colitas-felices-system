using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace colitasFelices.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWebHostEnvironment _env;

        public IndexModel(IWebHostEnvironment env) => _env = env;

        public List<Categoria> Categorias { get; private set; } = new();

        public void OnGet()
        {
            var ruta = Path.Combine(_env.WebRootPath, "img/data", "galeria.json");
            var json = System.IO.File.ReadAllText(ruta);
            Categorias = JsonSerializer.Deserialize<List<Categoria>>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();
        }

    }

    public record Categoria(string Id, string Titulo, string Frase, string Alt, List<string> Fotos);
}
