using Biblioteca.Models;
using Biblioteca.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Biblioteca.Controllers
{
    [EnableCors("*", "*", "*")]
    public class LivroController : ApiController
    {
        // GET: Livro
        public ObservableCollection<Livro> Get()
        {
            LivroViewModel livros = new LivroViewModel();
            return livros.Livros;

        }

        // GET: Livro?parametro=valor&nomeParametro=nome_do_parametro
        public List<Livro> Get(string parametro, string nomeParametro)
        {
            LivroViewModel livro = new LivroViewModel();
            List<Livro> livroSelecionado;
            

            //Pesquisa por isbn
            if (nomeParametro == "ISBN")
            {
                livroSelecionado = livro.Livros.Where(p => p.ISBN == parametro).ToList();
                if (livroSelecionado == null)
                {
                    throw new Exception("Nenhum livro encontrado");
                }
            }
            //Pesquisa pelo autor
            else if(nomeParametro == "Autores")
            {

                livroSelecionado = livro.Livros.Where(p => p.Autores.Contains(parametro)).ToList();
                
                
                if (livroSelecionado == null)
                {
                    throw new Exception("Nenhum livro encontrado");
                }
            }
            else
            {
                throw new Exception("Parâmetro inválido");
            }
            return livroSelecionado;
        }

        // POST: Livro
        public ObservableCollection<Livro> Post(Livro novoLivro)
        {
            InserirLivroViewModel _livro = new InserirLivroViewModel();
            _livro.Inserir(novoLivro);

            _livro.ListarLivros();
            return _livro.Livros;
        }

        // PUT: Livro/5
        public ObservableCollection<Livro> Put(int id, [FromBody]Livro livroAtualizado)
        {
            AtualizarLivroViewModel _atualizarLivro = new AtualizarLivroViewModel();
            _atualizarLivro.Atualizar(id, livroAtualizado);

            _atualizarLivro.ListarLivros();
            return _atualizarLivro.Livros;
        }

        // DELETE: Livro/5
        public void Delete(int id)
        {
            DeletarLivroViewModel _deletarLivro = new DeletarLivroViewModel();
            _deletarLivro.Deletar(id);
            
        }
    }
}
