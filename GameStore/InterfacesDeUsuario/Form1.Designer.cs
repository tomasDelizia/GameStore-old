﻿
namespace GameStore.InterfacesDeUsuario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClasificaciones = new System.Windows.Forms.RichTextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClasificaciones
            // 
            this.txtClasificaciones.Location = new System.Drawing.Point(115, 27);
            this.txtClasificaciones.Name = "txtClasificaciones";
            this.txtClasificaciones.Size = new System.Drawing.Size(239, 171);
            this.txtClasificaciones.TabIndex = 0;
            this.txtClasificaciones.Text = "";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(417, 112);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtClasificaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtClasificaciones;
        private System.Windows.Forms.Button btn;
    }
}

