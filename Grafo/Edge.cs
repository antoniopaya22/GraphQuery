using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphml2XML.Grafo
{
    /// <summary>
    /// Clase que simula una arista entre dos nodos
    /// <author>Antonio Paya Gonzalez</author>
    /// </summary>
    public class Edge{

        private string _Origen, _Destino;
        private string _Label;
        private Dictionary<string,string> _Atributos;

        public Edge(string origen, string destino, Dictionary<string,string> atributos, string label)
        {
            Origen = origen;
            Destino = destino;
            Label = label;
            Atributos = atributos;
        }

        public override string ToString()
        {
            string cadena = "(" + Origen + ")-" + "[" + Label;
            foreach (KeyValuePair<string, string> atributo in Atributos)
            {
                cadena += atributo.Key + ":" + atributo.Value + ",";
            }
            cadena += "]->(" + Destino + ")"; 
            return cadena;
        }

        public string Origen { get => _Origen; set => _Origen = value; }
        public string Destino { get => _Destino; set => _Destino = value; }
        public string Label { get => _Label; set => _Label = value; }
        public Dictionary<string,string> Atributos { get => _Atributos; set => _Atributos = value; }
    }
}
