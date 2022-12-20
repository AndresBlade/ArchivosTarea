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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.buttonRespaldarTodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonRespaldarTodo;
    }
}