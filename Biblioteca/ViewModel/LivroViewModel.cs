﻿using Biblioteca.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Biblioteca.ViewModel
{
    public class LivroViewModel
    {   
        //public MyICommand DeleteCommand { get; set; }

        public LivroViewModel()
        {
            ListarLivros();
            //DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }

        public ObservableCollection<Livro> Livros { get; set; }
        

        public void ListarLivros()
        {
            //ObservableCollection<Livro> livros = new ObservableCollection<Livro>();

            /*
            livros.Add(new Livro {ISBN = "978-8535907728", Titulo = "Coração de Tinta", Autores = "Conelia Funke", Editora = "Cia das Letras", Data_Publicacao = "01/01/2006", Preco = 29.90, Critica_de_Leitores="Ótimo"});
            livros.Add(new Livro { ISBN = "978-006-19-6955-3", Titulo = "Eu sou o número 4", Autores = "Pittacus Lore", Editora = "HarperCollins", Data_Publicacao = "03/08/2010", Preco = 29.90, Critica_de_Leitores = "Ótimo" });
            livros.Add(new Livro { ISBN = "978-85-7302-842-3", Titulo = "A Bússola de Ouro", Autores = "Philip Pullman", Editora = "Suma de Letras", Data_Publicacao = "01/01/2007", Preco = 39.90, Critica_de_Leitores = "Ótimo" });
            */

            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data/Base.json");
            var Json = File.ReadAllText(caminhoArquivo);

            var listaLivros = JsonConvert.DeserializeObject<ObservableCollection<Livro>>(Json);

            for (int i = 0; i < listaLivros.Count(); i++)
            {
                listaLivros[i].Preco_Extenso = ConversorViewModel.EscreverExtenso(listaLivros[i].Preco);
            }

            Livros = listaLivros;
            
        }

        public void ReescreverArquivo(ObservableCollection<Livro> ListaLivros)
        {

            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data/Base.json");
            var Json = JsonConvert.SerializeObject(ListaLivros, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, Json);
            
        }
        /*
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
        */
    }
}