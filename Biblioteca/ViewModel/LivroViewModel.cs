using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Biblioteca.ViewModel
{
    public class LivroViewModel
    {   
        public MyICommand DeleteCommand { get; set; }

        public LivroViewModel()
        {
            LoadLivros();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }

        public ObservableCollection<Livro> Livros { get; set; }

        public void LoadLivros()
        {
            ObservableCollection<Livro> livros = new ObservableCollection<Livro>();
            
            livros.Add(new Livro {ISBN = "978-8535907728", Titulo = "Coração de Tinta", Autores = "Conelia Funke", Editora = "Cia das Letras", Data_Publicacao = "01/01/2006", Preco = 29.90, Critica_de_Leitores="Ótimo"});
            livros.Add(new Livro { ISBN = "978-006-19-6955-3", Titulo = "Eu sou o número 4", Autores = "Pittacus Lore", Editora = "HarperCollins", Data_Publicacao = "03/08/2010", Preco = 29.90, Critica_de_Leitores = "Ótimo" });
            livros.Add(new Livro { ISBN = "978-85-7302-842-3", Titulo = "A Bússola de Ouro", Autores = "Philip Pullman", Editora = "Suma de Letras", Data_Publicacao = "01/01/2007", Preco = 39.90, Critica_de_Leitores = "Ótimo" });

            Livros = livros;
            
        }

        private Livro _selectedLivro;

        public Livro SelectedLivro
        {
            get { return _selectedLivro; }

            set
            {
                _selectedLivro = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        private void OnDelete()
        {
            Livros.Remove(SelectedLivro);
        }

        private bool CanDelete()
        {
            return SelectedLivro != null;
        }

    }
}