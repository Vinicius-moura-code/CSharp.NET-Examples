using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Alura.ListaLeitura.Modelos
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Resumo { get; set; }
        public byte[] ImagemCapa { get; set; }
        public string Autor { get; set; }
        public TipoListaLeitura Lista { get; set; }
    }

    [XmlType("Livro")]
    public class LivroApi
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Autor { get; set; }
        public string Resumo { get; set; }
        public string Capa { get; set; }
        public string Lista { get; set; }
    }

    public class LivroUpload
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Autor { get; set; }
        public string Resumo { get; set; }
        public IFormFile Capa { get; set; }
        public TipoListaLeitura Lista { get; set; }
    }
}
