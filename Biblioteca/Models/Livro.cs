using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Livro: INotifyPropertyChanged
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









        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}