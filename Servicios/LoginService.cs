﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Net.Mail;

namespace Servicios
{
    public class LoginService
    {

        Entities asd = new Entities();
        public void RegistrarUsuario(Usuarios u)
        {

            u.Activo = true;
            u.Token = "19E41C31E74A4526";
            u.FechaCracion = DateTime.Today;
            u.TipoUsuario = 1;

            asd.Usuarios.Add(u);
            asd.SaveChanges();
        }

        public Usuarios BuscarUsuario(Usuarios u)
        {
            var usua = (from p in asd.Usuarios
                             where p.Password == u.Password && p.Email == u.Email
                             select p).ToList();

            Usuarios usu2 = new Usuarios();
            foreach (var a in usua) {

                usu2 = a;
            }


            return usu2;
        }

        public Usuarios BuscarUsuarioActivo(Usuarios u)
        {
            Usuarios usua = (from p in asd.Usuarios
                             where p.Password == u.Password && p.Email == u.Email && p.Activo == true
                             select p).First();

            return usua;
        }

        public List<Usuarios> ExisteCorreo(Usuarios u)
        {
            var usua = from p in asd.Usuarios
                       where p.Email == u.Email
                       select p;
            return usua.ToList();
        }

        public Usuarios GuardarNombreDeUsuario(Usuarios u, String Nombre)
        {

            Usuarios usua = (from p in asd.Usuarios
                             where p.IdUsuario == u.IdUsuario
                             select p).First();

            usua.UserName = Nombre;
            asd.SaveChanges();
            return usua;
        }


        public List<Usuarios> buscarUsernames(String Nombre)
        {

            List<Usuarios> usua = (from p in asd.Usuarios
                                   where p.UserName.Contains(Nombre)
                                   select p).ToList();

       
            return usua;
        }

        public Usuarios GuardarNombreDeUsuario2(Usuarios u, String Nombre)
        {
           List <Usuarios> usua = (from p in asd.Usuarios
                             where p.UserName.Contains(Nombre)
                             orderby p.FechaCracion descending
                             select p).ToList();

            int cont = usua.Count;

            Usuarios usuaAGuardar = (from p in asd.Usuarios
                             where p.IdUsuario == u.IdUsuario
                             select p).First();


            usuaAGuardar.UserName = Nombre + cont.ToString() ;
            asd.SaveChanges();
            return usuaAGuardar;
        }

        public void enviarCorreo(Usuarios u)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("ecommerce.mmda@gmail.com");
                correo.To.Add(u.Email);
                correo.Subject = "Activacion de Cuenta";
                correo.Body = "Active su cuenta mediante el siguiente link: WWW.asdasdasd.com";
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;


                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                string scuentaCorreo = "ecommerce.mmda@gmail.com";
                string spasswordCorreo = "admin-123";

                smtp.Credentials = new System.Net.NetworkCredential(scuentaCorreo, spasswordCorreo);

                smtp.Send(correo);

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

        }
    }
}
