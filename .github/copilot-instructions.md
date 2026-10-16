# Proyecto: Colitas Felices (sitio web de fundación sin fines de lucro)

## Stack
- ASP.NET Core Razor Pages, .NET 10, C#.
- CSS: Bulma 1.0.4 vía CDN. NO usar Bootstrap ni agregar plantillas CSS.
- JS: solo puntual y vanilla, dentro de la página que lo necesite.
- Sin backend ni base de datos en la fase actual (landing estática con Razor).
- Donativos: botón/link de PayPal + transferencia/QR local.
- Despliegue futuro: Docker -> Cloud Run. Cloudflare al frente.

## Reglas
- Priorizar simplicidad y velocidad; no agregar dependencias sin necesidad.
- Código y comentarios mínimos; textos de UI en español.
- Imágenes en WebP con tamaños fijos, en wwwroot/img.
- No guardar archivos en disco del contenedor.
- Configuración y llaves vía variables de entorno, nunca en el código.
- Arquitectura futura: monolito modular (Areas: Public, Admin, Api).
- Aún NO implementar: EF Core, Identity, formularios, panel admin.

## Estilo de respuesta
- Dar solo el código o los cambios, sin explicaciones largas.