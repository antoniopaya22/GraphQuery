using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphml2XML.Grafo{

    /// <summary>
    /// Clase Nodo que simula el nodo de un grafo
    /// <author>Antonio Payá González</author>
    /// </summary>
    public class Nodo{

        private string _Label;
        private Dictionary<string,string> _Atributos;
        private string id;

        public Nodo(string id,Dictionary<string,string> atributos,string label = "")
        {
            Id = id;
            Atributos = atributos;
            Label = label;
        }

        public string Label { get => _Label; set => _Label = value; }
        public Dictionary<string,string> Atributos { get => _Atributos; set => _Atributos = value; }
        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            string cadena = Label+ "\r\n";
            if (Atributos.ContainsKey("Nombre"))
                cadena += Atributos["Nombre"]+"\r\n";

            foreach (KeyValuePair<string, string> atributo in Atributos)
            {
                cadena += atributo.Key + ":" + atributo.Value + "\r\n";
            }
            return cadena; 
        }
    }
}
