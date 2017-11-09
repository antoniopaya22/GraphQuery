using Graphml2XML;
using Graphml2XML.Grafo;
using Graphml2XML.Parsers;
using GraphQuery.parsers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;

/// <summary>
///  <author>Antonio Paya Gonzalez</author>
/// </summary>
namespace GraphQuery
{
    public partial class Form1 : Form
    {
        private LectorGraphml lxml;
        public Form1()
        {
            InitializeComponent();
        }

        private void SubirFichero(object sender, EventArgs e)
        {
            tablaGrafo.DataSource = new DataTable();
            cbTipo.Items.Clear();
            Stream myStream = null;
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "GRAPHML Files (*.graphml)|*.graphml",
                FilterIndex = 0,
                DefaultExt = "graphml"
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            XmlReader xml = XmlReader.Create(myStream);
                            LectorGraphml lector = new LectorGraphml(xml);
                            lxml = lector;
                            AddDataTable();               
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se puede leer el archivo seleccionado. Original error: " + ex.Message);
                }
            }
        }

        private void AddDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Nodo id", typeof(string));
            table.Columns.Add("Label", typeof(string));

            lxml.Nodos.ForEach(x => table.Rows.Add(x.Id,x.Label));
            tablaGrafo.DataSource = table;
            List<string> atributos = new List<string>();
            lxml.Nodos.ForEach(x =>
            {
                foreach (var atributo in x.Atributos)
                {
                    if (!atributos.Contains(atributo.Key)) atributos.Add(atributo.Key);
                }
            });
            atributos.ForEach(x => cbTipo.Items.Add(x));
            cbTipo.SelectedItem = cbTipo.Items[0];
        }

        private void ImprimirNodo(object sender, EventArgs e)
        {
            if (tablaGrafo.CurrentRow.Cells[0].Value is string id)
                lxml.Nodos.ForEach(x => { if (x.Id.Equals(id)) txtDescNodo.Text = x.ToString(); });
        }

        private void BuscarNodo(object sender, EventArgs e)
        {
            if(txtQuery.Equals("")) AddDataTable();
            else
            {
                string atributo = cbTipo.SelectedItem as string;
                List<Nodo> nodos = new List<Nodo>();
                lxml.Nodos.ForEach(x =>
                {
                    if(x.Atributos.ContainsKey(atributo))
                    {
                        if (x.Atributos[atributo].Contains(txtQuery.Text)) nodos.Add(x);
                    }
                });
                DataTable table = new DataTable();
                table.Columns.Add("Nodo id", typeof(string));
                table.Columns.Add("Label", typeof(string));

                nodos.ForEach(x => table.Rows.Add(x.Id, x.Label));
                tablaGrafo.DataSource = table;
            }
        }

        private void Guardar(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml",
                Title = "Guarda el archivo xml generado"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveDialog.FileName;

                XmlWriter xmlWriter = XmlWriter.Create(ruta);
                EscritorXML escritor = new EscritorXML(xmlWriter, lxml.Nodos, lxml.Edges);
                MessageBox.Show("Gracias por usar GraphQuery\nSe creó el archivo en la ruta: " 
                    + saveDialog.FileName+"\nAutor: Antonio Payá González");
            }
            else
            {
                MessageBox.Show("Has cancelado.");
            }
            saveDialog.Dispose();
            saveDialog = null;

        }
    }
}
