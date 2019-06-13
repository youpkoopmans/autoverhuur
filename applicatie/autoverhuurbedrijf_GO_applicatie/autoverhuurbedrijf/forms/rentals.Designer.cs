namespace autoverhuurbedrijf
{
    partial class rentals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rentals));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.dtRentDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmountCars = new System.Windows.Forms.TextBox();
            this.txtRentId = new System.Windows.Forms.TextBox();
            this.lblAmountCars = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.lblRentId = new System.Windows.Forms.Label();
            this.lblRentals = new System.Windows.Forms.Label();
            this.txtRentPeriod = new System.Windows.Forms.TextBox();
            this.lblRentPeriod = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(835, 556);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 36);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "Afsluiten";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.Control;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClean.FlatAppearance.BorderSize = 2;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClean.Location = new System.Drawing.Point(720, 267);
            this.btnClean.Margin = new System.Windows.Forms.Padding(2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(220, 36);
            this.btnClean.TabIndex = 50;
            this.btnClean.Text = "Invoervelden legen";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(720, 176);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 36);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(720, 221);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 36);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(719, 131);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(221, 36);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Wijzigen";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(719, 86);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 36);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(40, 315);
            this.dgView.Margin = new System.Windows.Forms.Padding(2);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(900, 227);
            this.dgView.TabIndex = 44;
            // 
            // dtRentDate
            // 
            this.dtRentDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRentDate.Location = new System.Drawing.Point(246, 131);
            this.dtRentDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtRentDate.Name = "dtRentDate";
            this.dtRentDate.Size = new System.Drawing.Size(268, 25);
            this.dtRentDate.TabIndex = 40;
            // 
            // txtAmountCars
            // 
            this.txtAmountCars.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountCars.Location = new System.Drawing.Point(246, 176);
            this.txtAmountCars.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountCars.Multiline = true;
            this.txtAmountCars.Name = "txtAmountCars";
            this.txtAmountCars.Size = new System.Drawing.Size(268, 24);
            this.txtAmountCars.TabIndex = 38;
            // 
            // txtRentId
            // 
            this.txtRentId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentId.Location = new System.Drawing.Point(246, 87);
            this.txtRentId.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentId.Multiline = true;
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.Size = new System.Drawing.Size(268, 24);
            this.txtRentId.TabIndex = 35;
            // 
            // lblAmountCars
            // 
            this.lblAmountCars.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmountCars.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountCars.Location = new System.Drawing.Point(40, 176);
            this.lblAmountCars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountCars.Name = "lblAmountCars";
            this.lblAmountCars.Size = new System.Drawing.Size(202, 24);
            this.lblAmountCars.TabIndex = 31;
            this.lblAmountCars.Text = "Aantal auto\'s:";
            this.lblAmountCars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRentDate
            // 
            this.lblRentDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblRentDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentDate.Location = new System.Drawing.Point(40, 131);
            this.lblRentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(202, 23);
            this.lblRentDate.TabIndex = 30;
            this.lblRentDate.Text = "Verhuurdatum:";
            this.lblRentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRentId
            // 
            this.lblRentId.BackColor = System.Drawing.SystemColors.Control;
            this.lblRentId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentId.Location = new System.Drawing.Point(40, 87);
            this.lblRentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentId.Name = "lblRentId";
            this.lblRentId.Size = new System.Drawing.Size(202, 24);
            this.lblRentId.TabIndex = 27;
            this.lblRentId.Text = "Verhuurnummer:";
            this.lblRentId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRentals
            // 
            this.lblRentals.BackColor = System.Drawing.SystemColors.Control;
            this.lblRentals.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentals.ForeColor = System.Drawing.Color.Black;
            this.lblRentals.Location = new System.Drawing.Point(237, 9);
            this.lblRentals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentals.Name = "lblRentals";
            this.lblRentals.Size = new System.Drawing.Size(566, 61);
            this.lblRentals.TabIndex = 26;
            this.lblRentals.Text = "VERHURINGEN";
            this.lblRentals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRentPeriod
            // 
            this.txtRentPeriod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentPeriod.Location = new System.Drawing.Point(246, 221);
            this.txtRentPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentPeriod.Multiline = true;
            this.txtRentPeriod.Name = "txtRentPeriod";
            this.txtRentPeriod.Size = new System.Drawing.Size(268, 24);
            this.txtRentPeriod.TabIndex = 37;
            // 
            // lblRentPeriod
            // 
            this.lblRentPeriod.BackColor = System.Drawing.SystemColors.Control;
            this.lblRentPeriod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPeriod.Location = new System.Drawing.Point(40, 221);
            this.lblRentPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentPeriod.Name = "lblRentPeriod";
            this.lblRentPeriod.Size = new System.Drawing.Size(202, 24);
            this.lblRentPeriod.TabIndex = 28;
            this.lblRentPeriod.Text = "Verhuurperiode (in dagen):";
            this.lblRentPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(719, 556);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 36);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.dtRentDate);
            this.Controls.Add(this.txtAmountCars);
            this.Controls.Add(this.txtRentPeriod);
            this.Controls.Add(this.txtRentId);
            this.Controls.Add(this.lblAmountCars);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.lblRentPeriod);
            this.Controls.Add(this.lblRentId);
            this.Controls.Add(this.lblRentals);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "rentals";
            this.Text = "Verhuringen";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DateTimePicker dtRentDate;
        private System.Windows.Forms.TextBox txtAmountCars;
        private System.Windows.Forms.TextBox txtRentId;
        private System.Windows.Forms.Label lblAmountCars;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblRentId;
        private System.Windows.Forms.Label lblRentals;
        private System.Windows.Forms.TextBox txtRentPeriod;
        private System.Windows.Forms.Label lblRentPeriod;
        private System.Windows.Forms.Button btnBack;
    }
}