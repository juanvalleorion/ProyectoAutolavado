﻿namespace ProyectoAutolavado.Pantallas
{
    partial class Pantalla_Administrador
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar nuevo usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "Caja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 110);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inventario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 110);
            this.button4.TabIndex = 3;
            this.button4.Text = "Provedores";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(373, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 110);
            this.button5.TabIndex = 4;
            this.button5.Text = "Agregar nuevo cliente";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(373, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 110);
            this.button6.TabIndex = 5;
            this.button6.Text = "Venta";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Pantalla_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Pantalla_Administrador";
            this.Text = "Pantalla_Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}