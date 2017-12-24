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

            _livro.ListarLivros();
            return _livro.Livros;
        }

        // PUT: api/Livro/5
        public ObservableCollection<Livro> Put(int id, [FromBody]Livro livroAtualizado)
        {
            AtualizarLivroViewModel _atualizarLivro = new AtualizarLivroViewModel();
            _atualizarLivro.Atualizar(id, livroAtualizado);

            _atualizarLivro.ListarLivros();
            return _atualizarLivro.Livros;
        }

        // DELETE: api/Livro/5
        public void Delete(int id)
        {
        }
    }
}
