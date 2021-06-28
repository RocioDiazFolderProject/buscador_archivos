/*
 * Created by SharpDevelop.
 * User: Luis
 * Date: 14/06/2021
 * Time: 08:35 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoPracticoG4Catalogador
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Mostrar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Modificado;
		private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
		private System.Windows.Forms.Button btnexportar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Mostrar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnexportar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(180, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(28, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Archivos";
			// 
			// Mostrar
			// 
			this.Mostrar.Location = new System.Drawing.Point(561, 579);
			this.Mostrar.Name = "Mostrar";
			this.Mostrar.Size = new System.Drawing.Size(75, 23);
			this.Mostrar.TabIndex = 6;
			this.Mostrar.Text = "Mostrar";
			this.Mostrar.UseVisualStyleBackColor = true;
			this.Mostrar.Click += new System.EventHandler(this.MostrarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Nombre,
			this.Tamaño,
			this.Tipo,
			this.Modificado,
			this.comentario});
			this.dataGridView1.Location = new System.Drawing.Point(12, 33);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(624, 521);
			this.dataGridView1.TabIndex = 7;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre ";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Tamaño
			// 
			this.Tamaño.HeaderText = "Tamaño";
			this.Tamaño.Name = "Tamaño";
			this.Tamaño.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// Modificado
			// 
			this.Modificado.HeaderText = "Modificado";
			this.Modificado.Name = "Modificado";
			this.Modificado.ReadOnly = true;
			// 
			// comentario
			// 
			this.comentario.HeaderText = "Comentario";
			this.comentario.Name = "comentario";
			this.comentario.ReadOnly = true;
			// 
			// btnexportar
			// 
			this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnexportar.Location = new System.Drawing.Point(286, 579);
			this.btnexportar.Name = "btnexportar";
			this.btnexportar.Size = new System.Drawing.Size(75, 23);
			this.btnexportar.TabIndex = 10;
			this.btnexportar.Text = "Exportar";
			this.btnexportar.UseVisualStyleBackColor = true;
			this.btnexportar.Click += new System.EventHandler(this.BtnexportarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(811, 623);
			this.Controls.Add(this.btnexportar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Mostrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Text = "TrabajoPracticoG4Catalogador";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
