
namespace Client2_Host_Rest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVdemande = new System.Windows.Forms.DataGridView();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAttente = new System.Windows.Forms.Label();
            this.ChBTempsReel = new System.Windows.Forms.CheckBox();
            this.RBtnCeJour = new System.Windows.Forms.RadioButton();
            this.RBtnTJour = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdemande)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DGVdemande);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 209);
            this.panel1.TabIndex = 0;
            // 
            // DGVdemande
            // 
            this.DGVdemande.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdemande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVdemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdemande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.host,
            this.user,
            this.date,
            this.time,
            this.annee,
            this.Message});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdemande.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVdemande.Location = new System.Drawing.Point(3, 3);
            this.DGVdemande.Name = "DGVdemande";
            this.DGVdemande.Size = new System.Drawing.Size(803, 195);
            this.DGVdemande.TabIndex = 1;
            // 
            // host
            // 
            this.host.HeaderText = "Host";
            this.host.Name = "host";
            this.host.ReadOnly = true;
            this.host.Width = 125;
            // 
            // user
            // 
            this.user.HeaderText = "User";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 95;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 95;
            // 
            // time
            // 
            this.time.HeaderText = "Heure";
            this.time.Name = "time";
            this.time.Width = 75;
            // 
            // annee
            // 
            this.annee.HeaderText = "Année";
            this.annee.Name = "annee";
            this.annee.Width = 75;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.Width = 285;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Location = new System.Drawing.Point(688, 13);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(104, 27);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "Actualiser";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblAttente);
            this.panel2.Controls.Add(this.ChBTempsReel);
            this.panel2.Controls.Add(this.RBtnCeJour);
            this.panel2.Controls.Add(this.RBtnTJour);
            this.panel2.Controls.Add(this.BtnOK);
            this.panel2.Location = new System.Drawing.Point(12, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 57);
            this.panel2.TabIndex = 2;
            // 
            // lblAttente
            // 
            this.lblAttente.AutoSize = true;
            this.lblAttente.Image = ((System.Drawing.Image)(resources.GetObject("lblAttente.Image")));
            this.lblAttente.Location = new System.Drawing.Point(184, -2);
            this.lblAttente.MaximumSize = new System.Drawing.Size(45, 45);
            this.lblAttente.MinimumSize = new System.Drawing.Size(55, 55);
            this.lblAttente.Name = "lblAttente";
            this.lblAttente.Size = new System.Drawing.Size(55, 55);
            this.lblAttente.TabIndex = 5;
            this.lblAttente.Visible = false;
            // 
            // ChBTempsReel
            // 
            this.ChBTempsReel.AutoSize = true;
            this.ChBTempsReel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBTempsReel.Location = new System.Drawing.Point(18, 15);
            this.ChBTempsReel.Name = "ChBTempsReel";
            this.ChBTempsReel.Size = new System.Drawing.Size(160, 22);
            this.ChBTempsReel.TabIndex = 4;
            this.ChBTempsReel.Text = "Lectute à temps réel";
            this.ChBTempsReel.UseVisualStyleBackColor = true;
            this.ChBTempsReel.CheckedChanged += new System.EventHandler(this.ChBTempsReel_CheckedChanged);
            // 
            // RBtnCeJour
            // 
            this.RBtnCeJour.AutoSize = true;
            this.RBtnCeJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCeJour.Location = new System.Drawing.Point(347, 15);
            this.RBtnCeJour.Name = "RBtnCeJour";
            this.RBtnCeJour.Size = new System.Drawing.Size(74, 22);
            this.RBtnCeJour.TabIndex = 3;
            this.RBtnCeJour.Text = "Ce jour";
            this.RBtnCeJour.UseVisualStyleBackColor = true;
            this.RBtnCeJour.CheckedChanged += new System.EventHandler(this.BtnOK_Click);
            // 
            // RBtnTJour
            // 
            this.RBtnTJour.AutoSize = true;
            this.RBtnTJour.Checked = true;
            this.RBtnTJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnTJour.Location = new System.Drawing.Point(468, 15);
            this.RBtnTJour.Name = "RBtnTJour";
            this.RBtnTJour.Size = new System.Drawing.Size(168, 22);
            this.RBtnTJour.TabIndex = 2;
            this.RBtnTJour.TabStop = true;
            this.RBtnTJour.Text = "Toutes les demandes";
            this.RBtnTJour.UseVisualStyleBackColor = true;
            this.RBtnTJour.CheckedChanged += new System.EventHandler(this.BtnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 296);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tp1_Client2_Host";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.BtnOK_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdemande)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVdemande;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RBtnCeJour;
        private System.Windows.Forms.RadioButton RBtnTJour;
        private System.Windows.Forms.CheckBox ChBTempsReel;
        private System.Windows.Forms.Label lblAttente;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}

