using Graphml2XML.Grafo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Graphml2XML.Parsers
{
    /// <summary>
    /// Esta clase crea un fichero XML a partir de un grafo
    /// <author>Antonio Paya Gonzalez</author>
    /// </summary>
    public class EscritorXML
    {
        private XmlWriter xml;
        private List<Nodo> _Nodos;
        private List<Edge> _Edges;

        public EscritorXML(XmlWriter xml, List<Nodo> nodos, List<Edge> edges)
        {
            this.xml = xml;
            Nodos = nodos;
            Edges = edges;
            generarXML();
        }

        private void generarXML()
        {
            WriteHeader();
            Nodos.ForEach(x => WriteNode(x));
            Edges.ForEach(x => WriteEdge(x));
            xml.WriteEndDocument();
            xml.Close();
        }

        public void WriteHeader()
        {
            xml.WriteStartDocument();
            xml.WriteStartElement("grafo");
            xml.WriteAttributeString("version", "1.0");
        }

        public void WriteNode(Nodo n)
        {
            xml.WriteStartElement("nodo");
            xml.WriteAttributeString("id", n.Id);
            xml.WriteAttributeString("label", n.Label);
            WriteAtributes(n.Atributos);
            xml.WriteEndElement();
        }

        private void WriteEdge(Edge n)
        {
            xml.WriteStartElement("edge");
            xml.WriteAttributeString("origen", n.Origen);
            xml.WriteAttributeString("destino", n.Destino);
            xml.WriteAttributeString("label", n.Label);
            WriteAtributes(n.Atributos);
            xml.WriteEndElement();
        }

        public void WriteAtributes(Dictionary<string,string> att)
        {
            foreach (KeyValuePair<string, string> atributo in att)
            {
                    xml.WriteStartElement(atributo.Key);
                    xml.WriteValue(atributo.Value);
                    xml.WriteEndElement();
            }
        }

        public List<Nodo> Nodos { get => _Nodos; set => _Nodos = value; }
        public List<Edge> Edges { get => _Edges; set => _Edges = value; }
    }
}
