using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TrabalhoPO.Models;

namespace TrabalhoPO.Shared
{
    public class Utils
    {
        public string _SHA256(string value)
        {
            return BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", "");
        }

        public JavaScriptResult ComandoJS(string funcao, string parametros)
        {
            return new JavaScriptResult { Script = funcao + "('" + parametros + "');" };
        }

        public JavaScriptResult ModalJS(Modal modal, string tipo = "Erro")
        {
            string parametros = new JavaScriptSerializer().Serialize(modal) + "'";
            parametros += (!String.IsNullOrEmpty(tipo) ? ",'" + tipo : tipo);

            return ComandoJS("modal", parametros);
        }

        public JavaScriptResult ModalJS(string mensagem, string tipo = "Erro")
        {
            string parametros = new JavaScriptSerializer().Serialize(new Modal { Mensagem = mensagem }) + "'";
            parametros += (!String.IsNullOrEmpty(tipo) ? ",'" + tipo : tipo);

            return ComandoJS("modal", parametros);
        }
    }
}