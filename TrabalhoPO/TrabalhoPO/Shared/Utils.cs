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
        public string Hash(string value, HashAlgorithm algorithm)
        {
            return BitConverter.ToString(algorithm.ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", "");
        }

        public string Modal(Modal modal)
        {
            return new JavaScriptSerializer().Serialize(modal);
        }

        public string Modal(string mensagem)
        {
            return new JavaScriptSerializer().Serialize(new Modal { Mensagem = mensagem });
        }

        public JavaScriptResult ModalJS(Modal modal)
        {
            return ComandoJS("modal", Modal(modal));
        }

        public JavaScriptResult ModalJS(string mensagem)
        {
            return ComandoJS("modal", Modal(mensagem));
        }

        public JavaScriptResult ComandoJS(string funcao, string parametros)
        {
            return new JavaScriptResult { Script = funcao + "('" + parametros + "');" };
        }
    }
}