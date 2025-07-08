using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDoGera.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }  
        public string Autor { get; set; }
        public bool Disponivel { get; set; } = true;
        
    }
}