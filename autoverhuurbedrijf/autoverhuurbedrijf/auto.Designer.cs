namespace autoverhuurbedrijf
{
    partial class auto
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtKenteken = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMerk = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblKenteken = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.rbtnNee = new System.Windows.Forms.RadioButton();
            this.rbtnJa = new System.Windows.Forms.RadioButton();
            this.lblBeschikbaar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(696, 215);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 36);
            this.btnExit.TabIndex = 77;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.White;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Black;
            this.btnClean.Location = new System.Drawing.Point(696, 167);
            this.btnClean.Margin = new System.Windows.Forms.Padding(2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(105, 36);
            this.btnClean.TabIndex = 76;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.White;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOverview.Location = new System.Drawing.Point(535, 284);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(2);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(105, 36);
            this.btnOverview.TabIndex = 75;
            this.btnOverview.Text = "Show Data";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.BtnOverview_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(387, 284);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 36);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(696, 284);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 36);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(218, 284);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 36);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Wijzigen";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(52, 284);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 36);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(52, 337);
            this.dgView.Margin = new System.Windows.Forms.Padding(2);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(748, 239);
            this.dgView.TabIndex = 70;
            // 
            // txtMerk
            // 
            this.txtMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerk.Location = new System.Drawing.Point(345, 141);
            this.txtMerk.Margin = new System.Windows.Forms.Padding(2);
            this.txtMerk.Multiline = true;
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(164, 24);
            this.txtMerk.TabIndex = 65;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(345, 180);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(205, 24);
            this.txtType.TabIndex = 64;
            // 
            // txtKenteken
            // 
            this.txtKenteken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKenteken.Location = new System.Drawing.Point(345, 109);
            this.txtKenteken.Margin = new System.Windows.Forms.Padding(2);
            this.txtKenteken.Multiline = true;
            this.txtKenteken.Name = "txtKenteken";
            this.txtKenteken.Size = new System.Drawing.Size(134, 24);
            this.txtKenteken.TabIndex = 62;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(345, 75);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 24);
            this.txtId.TabIndex = 61;
            this.txtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // lblMerk
            // 
            this.lblMerk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerk.Location = new System.Drawing.Point(135, 144);
            this.lblMerk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(160, 23);
            this.lblMerk.TabIndex = 59;
            this.lblMerk.Text = "Merk";
            this.lblMerk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(135, 182);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(160, 23);
            this.lblType.TabIndex = 57;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKenteken
            // 
            this.lblKenteken.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKenteken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKenteken.Location = new System.Drawing.Point(135, 109);
            this.lblKenteken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKenteken.Name = "lblKenteken";
            this.lblKenteken.Size = new System.Drawing.Size(160, 23);
            this.lblKenteken.TabIndex = 55;
            this.lblKenteken.Text = "Kenteken";
            this.lblKenteken.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(135, 77);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(160, 23);
            this.lblId.TabIndex = 53;
            this.lblId.Text = "Auto Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAuto
            // 
            this.lblAuto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.ForeColor = System.Drawing.Color.Blue;
            this.lblAuto.Location = new System.Drawing.Point(256, 7);
            this.lblAuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(316, 50);
            this.lblAuto.TabIndex = 52;
            this.lblAuto.Text = "Auto";
            this.lblAuto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbtnNee
            // 
            this.rbtnNee.AutoSize = true;
            this.rbtnNee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNee.Location = new System.Drawing.Point(412, 230);
            this.rbtnNee.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnNee.Name = "rbtnNee";
            this.rbtnNee.Size = new System.Drawing.Size(52, 21);
            this.rbtnNee.TabIndex = 68;
            this.rbtnNee.TabStop = true;
            this.rbtnNee.Text = "Nee";
            this.rbtnNee.UseVisualStyleBackColor = true;
            // 
            // rbtnJa
            // 
            this.rbtnJa.AutoSize = true;
            this.rbtnJa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJa.Location = new System.Drawing.Point(345, 230);
            this.rbtnJa.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnJa.Name = "rbtnJa";
            this.rbtnJa.Size = new System.Drawing.Size(41, 21);
            this.rbtnJa.TabIndex = 67;
            this.rbtnJa.TabStop = true;
            this.rbtnJa.Text = "Ja";
            this.rbtnJa.UseVisualStyleBackColor = true;
            // 
            // lblBeschikbaar
            // 
            this.lblBeschikbaar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBeschikbaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschikbaar.Location = new System.Drawing.Point(135, 227);
            this.lblBeschikbaar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeschikbaar.Name = "lblBeschikbaar";
            this.lblBeschikbaar.Size = new System.Drawing.Size(160, 23);
            this.lblBeschikbaar.TabIndex = 58;
            this.lblBeschikbaar.Text = "Beschikbaar";
            this.lblBeschikbaar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 586);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.rbtnNee);
            this.Controls.Add(this.rbtnJa);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtKenteken);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMerk);
            this.Controls.Add(this.lblBeschikbaar);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblKenteken);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAuto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "auto";
            this.Text = "auto";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtKenteken;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMerk;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblKenteken;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.RadioButton rbtnNee;
        private System.Windows.Forms.RadioButton rbtnJa;
        private System.Windows.Forms.Label lblBeschikbaar;
    }
}