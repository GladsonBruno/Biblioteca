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

        private double _preco;
        public double Preco
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


        private string _critica_de_leitores;
        public string Critica_de_Leitores
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