﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Sistema
    {

        private List<Usuario> _listaUsuarios = new List<Usuario>();
        private List<Invitacion> _listaInvitaciones = new List<Invitacion>();
        private List<Publicacion> _listaPubicaciones = new List<Publicacion>();
        private List<Reaccion> _listaReacciones = new List<Reaccion>();

        public  List<Usuario> ListaUsuarios { get { return _listaUsuarios; } }
        public  List<Invitacion> ListaInvitaciones { get { return _listaInvitaciones; } }
        public  List<Publicacion> ListaPublicaciones { get { return _listaPubicaciones; } }
        public  List<Reaccion> ListaReacciones { get { return _listaReacciones; } }



        //LOGIN USUARIO
        public string Login(string email, string pass)
        {
            string mensaje="Error de sistema";
            if (ExisteEmail(email))
            {
                if (VerificarPass(email,pass))
                {
                    mensaje = "Login Correcto!";
                }
                else
                {
                    mensaje = "La password ingresada no coincide! Intente nuevamente";
                }
            }
            else
            {
                 mensaje = "El mail ingresado no existe! Intente nuevamente";
            }
            return mensaje;
        }

        private bool ExisteEmail(string email)
        {
            bool existe = false;
            foreach (Usuario usu in _listaUsuarios)
            {
                if (usu.Email == email)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        private bool VerificarPass(string email, string pass)
        {
            bool existe = false;
            foreach (Usuario usu in _listaUsuarios)
            {
                if (usu.Email == email)
                {
                    if (usu.Password == pass)
                    {
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }
        //END LOGIN USUARIO


        //CREAR NUEVO MIEMBRO
        public string CrearNuevoMiembro(string email, string password, string nombre, string apellido, DateTime fechNac)
        {

            Usuario.ValidarEmail(email);
            if (ExisteEmail(email))
            {
                throw new Exception("El email que ingreso ya existe! Intente nuevamente");
            }
            Usuario.ValidarPassword(password);
            Miembro nuevo = new Miembro(email,password,false,nombre,apellido,fechNac,false);
            _listaUsuarios.Add(nuevo);
            return "Se creo el mimebro correctamente!";

        }
        //END CREAR NUEVO MIEMBRO


        //CREAR NUEVO MIEMBRO

        //END CREAR NUEVO MIEMBRO
    }
}
