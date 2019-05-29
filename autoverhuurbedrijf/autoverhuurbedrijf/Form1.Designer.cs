namespace autoverhuurbedrijf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerhuur = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.btnReserveringen = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autoverhuurbedrijf";
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(614, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 82);
            this.label2.TabIndex = 1;
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerhuur.Location = new System.Drawing.Point(96, 147);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(298, 154);
            this.btnVerhuur.TabIndex = 2;
            this.btnVerhuur.Text = "Verhuur";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            this.btnVerhuur.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // btnKlanten
            // 
            this.btnKlanten.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlanten.Location = new System.Drawing.Point(494, 147);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(298, 154);
            this.btnKlanten.TabIndex = 3;
            this.btnKlanten.Text = "Klanten";
            this.btnKlanten.UseVisualStyleBackColor = true;
            this.btnKlanten.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReserveringen
            // 
            this.btnReserveringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveringen.Location = new System.Drawing.Point(96, 334);
            this.btnReserveringen.Name = "btnReserveringen";
            this.btnReserveringen.Size = new System.Drawing.Size(298, 154);
            this.btnReserveringen.TabIndex = 4;
            this.btnReserveringen.Text = "Reserveringen";
            this.btnReserveringen.UseVisualStyleBackColor = true;
            this.btnReserveringen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(494, 334);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(298, 154);
            this.btnAuto.TabIndex = 5;
            this.btnAuto.Text = "Auto\'s";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 538);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnReserveringen);
            this.Controls.Add(this.btnKlanten);
            this.Controls.Add(this.btnVerhuur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerhuur;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Button btnReserveringen;
        private System.Windows.Forms.Button btnAuto;
    }
}

