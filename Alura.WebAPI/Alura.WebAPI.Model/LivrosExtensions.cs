using System.IO;
using Microsoft.AspNetCore.Http;

namespace Alura.ListaLeitura.Modelos
{
    public static class LivrosExtensions
    {
        public static byte[] ConvertToBytes(this IFormFile image)
        {
            if (image == null)
            {
                return null;
            }
            using (var inputStream = image.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                inputStream.CopyTo(stream);
                return stream.ToArray();
            }
        }

        public static Livro ToLivro(this LivroUpload model)
        {
            return new Livro
            {
                Id = model.Id,
                Titulo = model.Titulo,
                Subtitulo = model.Subtitulo,
                Resumo = model.Resumo,
                Autor = model.Autor,
                ImagemCapa = model.Capa.ConvertToBytes(),
                Lista = model.Lista
            };
        }

        public static LivroApi ToApi(this Livro livro)
        {
            return new LivroApi
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                Subtitulo = livro.Subtitulo,
                Resumo = livro.Resumo,
                Autor = livro.Autor,
                Capa = $"/api/capas/{livro.Id}",
                Lista = livro.Lista.ParaString()
            };
        }

        public static LivroUpload ToModel(this Livro livro)
        {
            return new LivroUpload
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                Subtitulo = livro.Subtitulo,
                Resumo = livro.Resumo,
                Autor = livro.Autor,
                Lista = livro.Lista
            };
        }
    }
}
