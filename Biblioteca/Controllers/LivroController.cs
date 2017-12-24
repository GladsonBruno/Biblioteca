using Biblioteca.Models;
using Biblioteca.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Biblioteca.Controllers
{
    public class LivroController : ApiController
    {
        // GET: api/Livro
        public ObservableCollection<Livro> Get()
        {
            LivroViewModel livros = new LivroViewModel();
            return livros.Livros;

        }

        // GET: api/Livro/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Livro
        public ObservableCollection<Livro> Post(Livro novoLivro)
        {
            InserirLivroViewModel _livro = new InserirLivroViewModel();
            _livro.Inserir(novoLivro);

            return _livro.Livros;
        }

        // PUT: api/Livro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Livro/5
        public void Delete(int id)
        {
        }
    }
}
