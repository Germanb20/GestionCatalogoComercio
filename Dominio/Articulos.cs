﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descipcion { get; set; }

        public Marcas Marca {  get; set; }  
        
        public Categorias Categoria { get; set; }

        public string ImagenUrl { get; set; }

        public float Precio {  get; set; }



    }
}
