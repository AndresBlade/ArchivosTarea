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
            this.labelTransacciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTransacciones
            // 
            this.labelTransacciones.AutoSize = true;
            this.labelTransacciones.Location = new System.Drawing.Point(12, 9);
            this.labelTransacciones.Name = "labelTransacciones";
            this.labelTransacciones.Size = new System.Drawing.Size(119, 25);
            this.labelTransacciones.TabIndex = 0;
            this.labelTransacciones.Text = "Transacciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.labelTransacciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTransacciones;
    }
}