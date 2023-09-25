﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Miembro:Usuario
    {

        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        public DateTime FechaNac { get; set; }

        public bool Bloqueado { get; set; }
        
        private List<Miembro> _listaAmigos = new List<Miembro>();

        public Miembro(string email, string password, bool isAdmin,string nombre, string apellido, DateTime fechaNac, bool bloqueado)
        :base(email,password,isAdmin)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Bloqueado = bloqueado;
        }




    }
}