using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Biblioteca.ViewModel
{
    public class AtualizarLivroViewModel: LivroViewModel
    {
        public Livro Atualizar(int id, Livro livroAtualizado)
        {
            List<Livro> listaLivros = new List<Livro>(Livros);

            var itemIndex = listaLivros.FindIndex(p => p.Id == id);
            if(itemIndex >= 0)
            {
                livroAtualizado.Id = id;
                listaLivros[itemIndex] = livroAtualizado;
            }
            else
            {
                return null;
            }

            ObservableCollection<Livro> listaAtualizada = new ObservableCollection<Livro>(listaLivros);

            ReescreverArquivo(listaAtualizada);

            return livroAtualizado;
            
        }
    }
}