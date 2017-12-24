using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Biblioteca.ViewModel
{
    public class DeletarLivroViewModel: LivroViewModel
    {
        public bool Deletar(int id)
        {
            List<Livro> listaLivros = new List<Livro>(Livros);

            var itemIndex = listaLivros.FindIndex(p => p.Id == id);
            if (itemIndex >= 0)
            {
                listaLivros.RemoveAt(itemIndex);
            }
            else
            {
                return false;
            }

            ObservableCollection<Livro> listaAtualizada = new ObservableCollection<Livro>(listaLivros);

            ReescreverArquivo(listaAtualizada);
            ListarLivros();
            return true;
        }
    }
}