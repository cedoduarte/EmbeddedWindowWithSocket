
namespace EmbeddedWindow
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendToQt_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sendToQt_textBox1 = new System.Windows.Forms.TextBox();
            this.fromQt_textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendToQt_button1
            // 
            this.sendToQt_button1.Location = new System.Drawing.Point(12, 14);
            this.sendToQt_button1.Name = "sendToQt_button1";
            this.sendToQt_button1.Size = new System.Drawing.Size(75, 23);
            this.sendToQt_button1.TabIndex = 0;
            this.sendToQt_button1.Text = "Send to Qt";
            this.sendToQt_button1.UseVisualStyleBackColor = true;
            this.sendToQt_button1.Click += new System.EventHandler(this.sendToQt_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Qt";
            // 
            // sendToQt_textBox1
            // 
            this.sendToQt_textBox1.Location = new System.Drawing.Point(93, 15);
            this.sendToQt_textBox1.Name = "sendToQt_textBox1";
            this.sendToQt_textBox1.Size = new System.Drawing.Size(100, 20);
            this.sendToQt_textBox1.TabIndex = 2;
            // 
            // fromQt_textBox2
            // 
            this.fromQt_textBox2.Location = new System.Drawing.Point(93, 41);
            this.fromQt_textBox2.Name = "fromQt_textBox2";
            this.fromQt_textBox2.Size = new System.Drawing.Size(100, 20);
            this.fromQt_textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 73);
            this.Controls.Add(this.fromQt_textBox2);
            this.Controls.Add(this.sendToQt_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendToQt_button1);
            this.Name = "Form1";
            this.Text = "EmbeddedWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendToQt_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sendToQt_textBox1;
        private System.Windows.Forms.TextBox fromQt_textBox2;
    }
}

