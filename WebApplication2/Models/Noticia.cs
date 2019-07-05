using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Noticia
    {

        public int NoticiaId { get; set; }
        public string Categoria { get; set; }
        public string Titulo { get; set; }
      

        public string Conteudo { get; set; }
        public DateTime Data { get; set; }





        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {



                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Policial",
                    Titulo = "teste titulo policial",
                    Conteudo="o Bandido....",
                    Data= new DateTime(2019,3,1)


                },

                   new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Humor",
                    Titulo = "teste titulo comedia ",
                    Conteudo="os comediantes mais engraçados....",
                    Data= new DateTime(2019,3,31)


                },

                         new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Vendas",
                    Titulo = "venda",
                    Conteudo="vendo esta casa ...",
                    Data= new DateTime(2019,3,31)


                },

        };
            return retorno;
         }

    }
}