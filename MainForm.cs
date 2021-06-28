
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Xml;



namespace TrabajoPracticoG4Catalogador
{
	
	

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		}
		
	
		
		
	
		String rutaArchivo;
				
		void Button1Click(object sender, EventArgs e)
		{
			
	
				FolderBrowserDialog carpeta = new FolderBrowserDialog();
				
				
				

				
				if(carpeta.ShowDialog() == DialogResult.OK)
				{
					rutaArchivo = carpeta.SelectedPath;
			
				}
				
				DirectoryInfo dir = new DirectoryInfo(@rutaArchivo);

				
				
			        
		
				foreach(var cada in dir.GetFiles())
				{

					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = cada.Name;
					dataGridView1.Rows[n].Cells[1].Value = cada.Length;
					dataGridView1.Rows[n].Cells[2].Value = cada.Extension;
					dataGridView1.Rows[n].Cells[3].Value = cada.LastAccessTime;
					
					
					
				}
				
				
		}
		void MostrarClick(object sender, EventArgs e)
		{
			string archivo;
			archivo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
			string rutaynombre = rutaArchivo;
			rutaynombre+= "/";
			rutaynombre+=archivo;
   			
			
			Process.Start(rutaynombre);
		}
		void BtnexportarClick(object sender, EventArgs e)
		{	
			exportarXML();
	
		}
		
		private void exportarXML()
		{
			var ds = new DataSet();
			var dt = new DataTable();
			try{
				foreach(DataGridViewColumn column in dataGridView1.Columns)
				{
					dt.Columns.Add();
				}
				
				var cellvalues = new object[dataGridView1.Columns.Count];
				
				foreach(DataGridViewRow row in dataGridView1.Rows)
				{
					for(int i=0; i< row.Cells.Count;i++)
					{
						cellvalues[i] = row.Cells[i].Value;
						
					}
					dt.Rows.Add(cellvalues);
					
				}
				ds.Tables.Add(dt);
				
				string FileName = "Archivo.xml";
				FileStream Stream = new FileStream(FileName, FileMode.OpenOrCreate);
				XmlTextWriter rscribexml = new XmlTextWriter(Stream,System.Text.Encoding.Unicode);
				ds.WriteXml(rscribexml);
				rscribexml.Close();
				MessageBox.Show("Exportado");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				throw;
			}
		}
		
	}
}

