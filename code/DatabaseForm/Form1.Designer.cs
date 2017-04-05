namespace DatabaseForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.naam = new System.Windows.Forms.TextBox();
            this.aantal_plaatsen = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.TextBox();
            this.plaats = new System.Windows.Forms.TextBox();
            this.opslaan = new System.Windows.Forms.Button();
            this.ophalen = new System.Windows.Forms.Button();
            this.annuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "aantal plaatsen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "postcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "plaats";
            // 
            // naam
            // 
            this.naam.Location = new System.Drawing.Point(154, 50);
            this.naam.Name = "naam";
            this.naam.Size = new System.Drawing.Size(215, 20);
            this.naam.TabIndex = 5;
            // 
            // aantal_plaatsen
            // 
            this.aantal_plaatsen.Location = new System.Drawing.Point(154, 80);
            this.aantal_plaatsen.Name = "aantal_plaatsen";
            this.aantal_plaatsen.Size = new System.Drawing.Size(57, 20);
            this.aantal_plaatsen.TabIndex = 6;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(154, 112);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(215, 20);
            this.adres.TabIndex = 7;
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(154, 143);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(57, 20);
            this.postcode.TabIndex = 8;
            // 
            // plaats
            // 
            this.plaats.Location = new System.Drawing.Point(154, 174);
            this.plaats.Name = "plaats";
            this.plaats.Size = new System.Drawing.Size(135, 20);
            this.plaats.TabIndex = 9;
            // 
            // opslaan
            // 
            this.opslaan.Location = new System.Drawing.Point(154, 200);
            this.opslaan.Name = "opslaan";
            this.opslaan.Size = new System.Drawing.Size(75, 23);
            this.opslaan.TabIndex = 10;
            this.opslaan.Text = "opslaan";
            this.opslaan.UseVisualStyleBackColor = true;
            this.opslaan.Click += new System.EventHandler(this.opslaan_Click);
            // 
            // ophalen
            // 
            this.ophalen.Location = new System.Drawing.Point(294, 200);
            this.ophalen.Name = "ophalen";
            this.ophalen.Size = new System.Drawing.Size(75, 23);
            this.ophalen.TabIndex = 11;
            this.ophalen.Text = "ophalen";
            this.ophalen.UseVisualStyleBackColor = true;
            // 
            // annuleren
            // 
            this.annuleren.Location = new System.Drawing.Point(224, 229);
            this.annuleren.Name = "annuleren";
            this.annuleren.Size = new System.Drawing.Size(75, 23);
            this.annuleren.TabIndex = 12;
            this.annuleren.Text = "annuleren";
            this.annuleren.UseVisualStyleBackColor = true;
            this.annuleren.Click += new System.EventHandler(this.annuleren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.annuleren);
            this.Controls.Add(this.ophalen);
            this.Controls.Add(this.opslaan);
            this.Controls.Add(this.plaats);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.aantal_plaatsen);
            this.Controls.Add(this.naam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox naam;
        private System.Windows.Forms.TextBox aantal_plaatsen;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.TextBox plaats;
        private System.Windows.Forms.Button opslaan;
        private System.Windows.Forms.Button ophalen;
        private System.Windows.Forms.Button annuleren;
    }
}

