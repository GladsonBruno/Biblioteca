using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class CriticaIndividual: NotifyBase
    {
        private string _comentario;
        public string Comentario
        {
            get { return _comentario; }

            set
            {
                if (_comentario != value)
                {
                    _comentario = value;
                    RaisePropertyChanged("Comentario");
                }
            }
        }
    }
}