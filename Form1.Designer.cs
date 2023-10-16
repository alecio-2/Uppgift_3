namespace Uppgift_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxPersonnummer = new System.Windows.Forms.TextBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.RichTextBox();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personnummer:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(182, 47);
            this.tbxFörnamn.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(246, 20);
            this.tbxFörnamn.TabIndex = 3;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(182, 95);
            this.tbxEfternamn.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(246, 20);
            this.tbxEfternamn.TabIndex = 4;
            // 
            // tbxPersonnummer
            // 
            this.tbxPersonnummer.Location = new System.Drawing.Point(182, 139);
            this.tbxPersonnummer.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPersonnummer.Name = "tbxPersonnummer";
            this.tbxPersonnummer.Size = new System.Drawing.Size(246, 20);
            this.tbxPersonnummer.TabIndex = 5;
            this.tbxPersonnummer.TextChanged += new System.EventHandler(this.tbxPersonnummer_TextChanged);
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRegistrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrera.Location = new System.Drawing.Point(333, 188);
            this.btnRegistrera.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(104, 57);
            this.btnRegistrera.TabIndex = 6;
            this.btnRegistrera.Text = "Kontrollera";
            this.btnRegistrera.UseVisualStyleBackColor = false;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(60, 188);
            this.tbxResultat.Margin = new System.Windows.Forms.Padding(2);
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.Size = new System.Drawing.Size(247, 134);
            this.tbxResultat.TabIndex = 7;
            this.tbxResultat.Text = "";
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.BackColor = System.Drawing.Color.IndianRed;
            this.btnAvsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvsluta.Location = new System.Drawing.Point(333, 255);
            this.btnAvsluta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(104, 67);
            this.btnAvsluta.TabIndex = 8;
            this.btnAvsluta.Text = "Avsluta program";
            this.btnAvsluta.UseVisualStyleBackColor = false;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(134, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Personnummer Kontroll";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(57, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "10 numbers without any other character";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.tbxPersonnummer);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Personnummer kontroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxPersonnummer;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.RichTextBox tbxResultat;
        private System.Windows.Forms.Button btnAvsluta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

