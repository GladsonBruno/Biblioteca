using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Livro : NotifyBase
    {

        /*
        - ISBN (chave primária)
        - Título
        - Autores (um ou mais)
        - Editora
        - Data de publicação
        - Preço (em reais)
        - Críticas de leitores (uma ou mais)
        */
        public int Id { get; set; }

        private string _isbn;
        public string ISBN
        {
            get { return _isbn; }

            set
            {
                if(_isbn != value)
                {
                    _isbn = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }

            set
            {
                if(_titulo != value)
                {
                    _titulo = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string _autores;
        public string Autores
        {
            get { return _autores; }

            set
            {
                if(_autores != value)
                {
                    _autores = value;
                    RaisePropertyChanged();
                }
            }
        }


        private string _editora;
        public string Editora
        {
            get { return _editora; }

            set
            {
                if(_editora != value)
                {
                    _editora = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string _data_publicacao;
        public string Data_Publicacao
        {
            get { return _data_publicacao; }

            set
            {
                if(_data_publicacao != value)
                {
                    _data_publicacao = value;
                    RaisePropertyChanged();
                }
            }
        }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }

            set
            {
                if(_preco != value)
                {
                    _preco = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string _preco_extenso;
        public string Preco_Extenso
        {
            get { return _preco_extenso; }

            set
            {
                if(_preco_extenso != value)
                {
                    _preco_extenso = value;
                    RaisePropertyChanged();
                }
            }
        }


        private List<CriticaIndividual> _critica_de_leitores;
        public List<CriticaIndividual> Critica_de_Leitores
        {
            get { return _critica_de_leitores; }

            set
            {
                if(_critica_de_leitores != value)
                {
                    _critica_de_leitores = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string _image;
        public string Image
        {
            get { return _image; }

            set
            {
                if(_image != value)
                {
                    _image = value;
                    RaisePropertyChanged();
                }
            }
        }

        public Livro(string isbn, string titulo, string autores, string editora, string data_publicacao, decimal preco)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autores = autores;
            Editora = editora;
            Data_Publicacao = data_publicacao;
            Preco = preco;
        }

        /*
- ISBN (chave primária)
- Título
- Autores (um ou mais)
- Editora
- Data de publicação
- Preço (em reais)
- Críticas de leitores (uma ou mais)
*/

    }
}