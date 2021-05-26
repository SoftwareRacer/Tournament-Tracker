
namespace CreateTournamentForm
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.tbEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cobSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.lnkCreateTeam = new System.Windows.Forms.LinkLabel();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lbTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lblTournamentParticipants = new System.Windows.Forms.Label();
            this.btnDeleteSelectedParticipants = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrizes = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.lbPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(325, 50);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create Tournament:";
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.Location = new System.Drawing.Point(21, 99);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(316, 35);
            this.tbTournamentName.TabIndex = 10;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(14, 59);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(249, 37);
            this.lblTournamentName.TabIndex = 9;
            this.lblTournamentName.Text = "Tournament Name: ";
            // 
            // tbEntryFee
            // 
            this.tbEntryFee.Location = new System.Drawing.Point(152, 162);
            this.tbEntryFee.Name = "tbEntryFee";
            this.tbEntryFee.Size = new System.Drawing.Size(100, 35);
            this.tbEntryFee.TabIndex = 12;
            this.tbEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEntryFee.Location = new System.Drawing.Point(15, 159);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(131, 37);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "Entry Fee:";
            // 
            // cobSelectTeam
            // 
            this.cobSelectTeam.FormattingEnabled = true;
            this.cobSelectTeam.Location = new System.Drawing.Point(22, 261);
            this.cobSelectTeam.Name = "cobSelectTeam";
            this.cobSelectTeam.Size = new System.Drawing.Size(316, 38);
            this.cobSelectTeam.TabIndex = 14;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeam.Location = new System.Drawing.Point(13, 221);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(162, 37);
            this.lblSelectTeam.TabIndex = 13;
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // lnkCreateTeam
            // 
            this.lnkCreateTeam.AutoSize = true;
            this.lnkCreateTeam.Location = new System.Drawing.Point(228, 227);
            this.lnkCreateTeam.Name = "lnkCreateTeam";
            this.lnkCreateTeam.Size = new System.Drawing.Size(109, 30);
            this.lnkCreateTeam.TabIndex = 15;
            this.lnkCreateTeam.TabStop = true;
            this.lnkCreateTeam.Text = "create new";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreatePrize.Location = new System.Drawing.Point(112, 357);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(140, 46);
            this.btnCreatePrize.TabIndex = 16;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // lbTournamentPlayers
            // 
            this.lbTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTournamentPlayers.FormattingEnabled = true;
            this.lbTournamentPlayers.ItemHeight = 30;
            this.lbTournamentPlayers.Location = new System.Drawing.Point(399, 99);
            this.lbTournamentPlayers.Name = "lbTournamentPlayers";
            this.lbTournamentPlayers.Size = new System.Drawing.Size(301, 152);
            this.lbTournamentPlayers.TabIndex = 17;
            // 
            // lblTournamentParticipants
            // 
            this.lblTournamentParticipants.AutoSize = true;
            this.lblTournamentParticipants.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentParticipants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentParticipants.Location = new System.Drawing.Point(392, 59);
            this.lblTournamentParticipants.Name = "lblTournamentParticipants";
            this.lblTournamentParticipants.Size = new System.Drawing.Size(204, 37);
            this.lblTournamentParticipants.TabIndex = 18;
            this.lblTournamentParticipants.Text = "Teams / Players:";
            // 
            // btnDeleteSelectedParticipants
            // 
            this.btnDeleteSelectedParticipants.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedParticipants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedParticipants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedParticipants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedParticipants.Location = new System.Drawing.Point(706, 128);
            this.btnDeleteSelectedParticipants.Name = "btnDeleteSelectedParticipants";
            this.btnDeleteSelectedParticipants.Size = new System.Drawing.Size(140, 92);
            this.btnDeleteSelectedParticipants.TabIndex = 19;
            this.btnDeleteSelectedParticipants.Text = "Delete Selected";
            this.btnDeleteSelectedParticipants.UseVisualStyleBackColor = true;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeam.Location = new System.Drawing.Point(112, 305);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(140, 46);
            this.btnAddTeam.TabIndex = 20;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPrizes
            // 
            this.btnDeleteSelectedPrizes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedPrizes.Location = new System.Drawing.Point(706, 332);
            this.btnDeleteSelectedPrizes.Name = "btnDeleteSelectedPrizes";
            this.btnDeleteSelectedPrizes.Size = new System.Drawing.Size(140, 97);
            this.btnDeleteSelectedPrizes.TabIndex = 23;
            this.btnDeleteSelectedPrizes.Text = "Delete Selected";
            this.btnDeleteSelectedPrizes.UseVisualStyleBackColor = true;
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPrizes.Location = new System.Drawing.Point(392, 262);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(91, 37);
            this.lblPrizes.TabIndex = 22;
            this.lblPrizes.Text = "Prizes:";
            // 
            // lbPrizes
            // 
            this.lbPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrizes.FormattingEnabled = true;
            this.lbPrizes.ItemHeight = 30;
            this.lbPrizes.Location = new System.Drawing.Point(399, 302);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(301, 152);
            this.lbPrizes.TabIndex = 21;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTournament.Location = new System.Drawing.Point(294, 460);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(247, 76);
            this.btnCreateTournament.TabIndex = 24;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 614);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnDeleteSelectedPrizes);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnDeleteSelectedParticipants);
            this.Controls.Add(this.lblTournamentParticipants);
            this.Controls.Add(this.lbTournamentPlayers);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.lnkCreateTeam);
            this.Controls.Add(this.cobSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.tbEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.tbTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox tbEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox cobSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel lnkCreateTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox lbTournamentPlayers;
        private System.Windows.Forms.Label lblTournamentParticipants;
        private System.Windows.Forms.Button btnDeleteSelectedParticipants;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnDeleteSelectedPrizes;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox lbPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}

