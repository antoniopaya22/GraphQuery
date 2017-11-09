using Graphml2XML.Grafo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Graphml2XML
{
    /// <summary>
    /// Clase que lee un archivo graphml y devuelve los nodos y las aristas
    /// </summary>
    public class LectorGraphml
    {
        private List<Nodo> _Nodos;
        private List<Edge> _Edges;
        private XmlReader xml;
        private Nodo nodo;
        private Edge edge;
        private Dictionary<string, string> atributos;
        private string key;

        public LectorGraphml(XmlReader xmlReader)
        {
            xml = xmlReader;
            nodo = null;
            edge = null;
            key = "";
            Nodos = new List<Nodo>();
            Edges = new List<Edge>();
            generarGrafo();
        }

        private void generarGrafo()
        {
            while (xml.Read())
            {
                switch (xml.NodeType)
                {
                    case XmlNodeType.Element:
                        if (xml.Name == "node")
                        {
                            if (xml.HasAttributes)
                            {
                                atributos = new Dictionary<string, string>();
                                string label = "";
                                string id = "";
                                while (xml.MoveToNextAttribute())
                                {
                                    if (xml.Name == "labels") label = xml.Value;
                                    else if (xml.Name == "id") id = xml.Value;
                                }
                                nodo = new Nodo(id, atributos, label);
                            }
                        }
                        else if (xml.Name == "data")
                        {
                            if (xml.HasAttributes)
                            {
                                while (xml.MoveToNextAttribute())
                                {
                                    key = xml.Value;
                                }
                            }
                        }
                        else if (xml.Name == "edge")
                        {
                            if (xml.HasAttributes)
                            {
                                atributos = new Dictionary<string, string>();
                                string label = "";
                                string origen = "";
                                string destino = "";
                                while (xml.MoveToNextAttribute())
                                {
                                    if (xml.Name == "label") label = xml.Value;
                                    else if (xml.Name == "source") origen = xml.Value;
                                    else if (xml.Name == "target") destino = xml.Value;
                                }
                                edge = new Edge(origen,destino, atributos, label);
                            }
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (xml.Name == "node" && nodo != null)
                        {
                            Nodos.Add(nodo);
                            nodo = null;
                        }
                        else if (xml.Name == "edge" && edge != null)
                        {
                            Edges.Add(edge);
                            edge = null;
                        }
                        break;
                    case XmlNodeType.Text:
                        if (nodo != null)
                            nodo.Atributos.Add(key, xml.Value);
                        else if (edge != null)
                            edge.Atributos.Add(key, xml.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.WriteLine("XmlDeclaration.Name: {0}", xml.Name);
                        Console.WriteLine("XmlDeclaration.Value: {0}", xml.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.WriteLine("ProcessingInstruction.Name: {0}", xml.Name);
                        Console.WriteLine("ProcessingInstruction.Value: {0}", xml.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine("Comment.Value: {0}", xml.Value);
                        break;
                }

            }
        }

        public List<Nodo> Nodos { get => _Nodos; set => _Nodos = value; }
        public List<Edge> Edges { get => _Edges; set => _Edges = value; }
    }
}
