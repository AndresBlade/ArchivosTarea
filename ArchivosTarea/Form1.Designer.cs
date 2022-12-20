namespace ArchivosTarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRespaldarTodo = new System.Windows.Forms.Button();
            this.buttonRecuperarAuxiliar = new System.Windows.Forms.Button();
            this.labelSalida = new System.Windows.Forms.Label();
            this.buttonRespaldoBinario = new System.Windows.Forms.Button();
            this.buttonRespaldoExencion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownCedula = new System.Windows.Forms.NumericUpDown();
            this.buttonBusqueda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCedula)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRespaldarTodo
            // 
            this.buttonRespaldarTodo.Location = new System.Drawing.Point(70, 37);
            this.buttonRespaldarTodo.Name = "buttonRespaldarTodo";
            this.buttonRespaldarTodo.Size = new System.Drawing.Size(273, 34);
            this.buttonRespaldarTodo.TabIndex = 0;
            this.buttonRespaldarTodo.Text = "Botón 1 (Respaldar Todo)";
            this.buttonRespaldarTodo.UseVisualStyleBackColor = true;
            this.buttonRespaldarTodo.Click += new System.EventHandler(this.buttonRespaldarTodo_Click);
            // 
            // buttonRecuperarAuxiliar
            // 
            this.buttonRecuperarAuxiliar.Location = new System.Drawing.Point(70, 87);
            this.buttonRecuperarAuxiliar.Name = "buttonRecuperarAuxiliar";
            this.buttonRecuperarAuxiliar.Size = new System.Drawing.Size(273, 34);
            this.buttonRecuperarAuxiliar.TabIndex = 1;
            this.buttonRecuperarAuxiliar.Text = "Botón 2 (Abrir Auxiliar)";
            this.buttonRecuperarAuxiliar.UseVisualStyleBackColor = true;
            this.buttonRecuperarAuxiliar.Click += new System.EventHandler(this.buttonRecuperarAuxiliar_Click);
            // 
            // labelSalida
            // 
            this.labelSalida.AutoSize = true;
            this.labelSalida.Location = new System.Drawing.Point(420, 68);
            this.labelSalida.Name = "labelSalida";
            this.labelSalida.Size = new System.Drawing.Size(0, 25);
            this.labelSalida.TabIndex = 2;
            // 
            // buttonRespaldoBinario
            // 
            this.buttonRespaldoBinario.Location = new System.Drawing.Point(70, 140);
            this.buttonRespaldoBinario.Name = "buttonRespaldoBinario";
            this.buttonRespaldoBinario.Size = new System.Drawing.Size(273, 34);
            this.buttonRespaldoBinario.TabIndex = 3;
            this.buttonRespaldoBinario.Text = "Botón 3 (Respaldo Binario)";
            this.buttonRespaldoBinario.UseVisualStyleBackColor = true;
            this.buttonRespaldoBinario.Click += new System.EventHandler(this.buttonRespaldoBinario_Click);
            // 
            // buttonRespaldoExencion
            // 
            this.buttonRespaldoExencion.Location = new System.Drawing.Point(70, 197);
            this.buttonRespaldoExencion.Name = "buttonRespaldoExencion";
            this.buttonRespaldoExencion.Size = new System.Drawing.Size(338, 34);
            this.buttonRespaldoExencion.TabIndex = 4;
            this.buttonRespaldoExencion.Text = "Botón 4 (Respaldo por Exención)";
            this.buttonRespaldoExencion.UseVisualStyleBackColor = true;
            this.buttonRespaldoExencion.Click += new System.EventHandler(this.buttonRespaldoExencion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownCedula);
            this.panel1.Controls.Add(this.buttonBusqueda);
            this.panel1.Location = new System.Drawing.Point(70, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 78);
            this.panel1.TabIndex = 5;
            // 
            // numericUpDownCedula
            // 
            this.numericUpDownCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownCedula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericUpDownCedula.Location = new System.Drawing.Point(0, 51);
            this.numericUpDownCedula.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericUpDownCedula.Name = "numericUpDownCedula";
            this.numericUpDownCedula.Size = new System.Drawing.Size(300, 27);
            this.numericUpDownCedula.TabIndex = 1;
            // 
            // buttonBusqueda
            // 
            this.buttonBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBusqueda.Location = new System.Drawing.Point(0, 0);
            this.buttonBusqueda.Name = "buttonBusqueda";
            this.buttonBusqueda.Size = new System.Drawing.Size(300, 34);
            this.buttonBusqueda.TabIndex = 0;
            this.buttonBusqueda.Text = "Botón 5 (Búsqueda)";
            this.buttonBusqueda.UseVisualStyleBackColor = true;
            this.buttonBusqueda.Click += new System.EventHandler(this.buttonBusqueda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRespaldoExencion);
            this.Controls.Add(this.buttonRespaldoBinario);
            this.Controls.Add(this.labelSalida);
            this.Controls.Add(this.buttonRecuperarAuxiliar);
            this.Controls.Add(this.buttonRespaldarTodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCedula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonRespaldarTodo;
        private Button buttonRecuperarAuxiliar;
        private Label labelSalida;
        private Button buttonRespaldoBinario;
        private Button buttonRespaldoExencion;
        private Panel panel1;
        private NumericUpDown numericUpDownCedula;
        private Button buttonBusqueda;
    }
}