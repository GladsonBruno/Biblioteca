using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Biblioteca.ViewModel
{
    public class InserirLivroViewModel: LivroViewModel
    {
        public Livro Inserir(Livro novoLivro)
        {
            ObservableCollection<Livro> listaLivros = Livros;

            var maxId = listaLivros.Max(livro => livro.Id);
            novoLivro.Id = maxId + 1;

            listaLivros.Add(novoLivro);

            ReescreverArquivo(listaLivros);
            return novoLivro;
        }
    }
}