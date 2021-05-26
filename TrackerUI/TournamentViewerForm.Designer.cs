
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cobRound = new System.Windows.Forms.ComboBox();
            this.chbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lbMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.lblScoreOne = new System.Windows.Forms.Label();
            this.tbScoreOne = new System.Windows.Forms.TextBox();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.tbScoreTwo = new System.Windows.Forms.TextBox();
            this.lblScoreTwo = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(214, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(233, 13);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(150, 50);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(17, 106);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(94, 37);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round";
            // 
            // cobRound
            // 
            this.cobRound.FormattingEnabled = true;
            this.cobRound.Location = new System.Drawing.Point(117, 105);
            this.cobRound.Name = "cobRound";
            this.cobRound.Size = new System.Drawing.Size(208, 38);
            this.cobRound.TabIndex = 3;
            // 
            // chbUnplayedOnly
            // 
            this.chbUnplayedOnly.AutoSize = true;
            this.chbUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.chbUnplayedOnly.Location = new System.Drawing.Point(117, 149);
            this.chbUnplayedOnly.Name = "chbUnplayedOnly";
            this.chbUnplayedOnly.Size = new System.Drawing.Size(208, 41);
            this.chbUnplayedOnly.TabIndex = 4;
            this.chbUnplayedOnly.Text = "Unplayed only";
            this.chbUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lbMatchup
            // 
            this.lbMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMatchup.FormattingEnabled = true;
            this.lbMatchup.ItemHeight = 30;
            this.lbMatchup.Location = new System.Drawing.Point(24, 196);
            this.lbMatchup.Name = "lbMatchup";
            this.lbMatchup.Size = new System.Drawing.Size(301, 212);
            this.lbMatchup.TabIndex = 5;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOne.Location = new System.Drawing.Point(393, 196);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(165, 37);
            this.lblTeamOne.TabIndex = 6;
            this.lblTeamOne.Text = "<team one>";
            // 
            // lblScoreOne
            // 
            this.lblScoreOne.AutoSize = true;
            this.lblScoreOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblScoreOne.Location = new System.Drawing.Point(393, 233);
            this.lblScoreOne.Name = "lblScoreOne";
            this.lblScoreOne.Size = new System.Drawing.Size(88, 37);
            this.lblScoreOne.TabIndex = 7;
            this.lblScoreOne.Text = "Score:";
            // 
            // tbScoreOne
            // 
            this.tbScoreOne.Location = new System.Drawing.Point(487, 233);
            this.tbScoreOne.Name = "tbScoreOne";
            this.tbScoreOne.Size = new System.Drawing.Size(100, 35);
            this.tbScoreOne.TabIndex = 8;
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwo.Location = new System.Drawing.Point(393, 312);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(165, 37);
            this.lblTeamTwo.TabIndex = 9;
            this.lblTeamTwo.Text = "<team two>";
            // 
            // tbScoreTwo
            // 
            this.tbScoreTwo.Location = new System.Drawing.Point(487, 352);
            this.tbScoreTwo.Name = "tbScoreTwo";
            this.tbScoreTwo.Size = new System.Drawing.Size(100, 35);
            this.tbScoreTwo.TabIndex = 11;
            // 
            // lblScoreTwo
            // 
            this.lblScoreTwo.AutoSize = true;
            this.lblScoreTwo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblScoreTwo.Location = new System.Drawing.Point(393, 352);
            this.lblScoreTwo.Name = "lblScoreTwo";
            this.lblScoreTwo.Size = new System.Drawing.Size(88, 37);
            this.lblScoreTwo.TabIndex = 10;
            this.lblScoreTwo.Text = "Score:";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblVS.Location = new System.Drawing.Point(455, 275);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(70, 37);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "-VS-";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(606, 268);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(109, 57);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 452);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.tbScoreTwo);
            this.Controls.Add(this.lblScoreTwo);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.tbScoreOne);
            this.Controls.Add(this.lblScoreOne);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.lbMatchup);
            this.Controls.Add(this.chbUnplayedOnly);
            this.Controls.Add(this.cobRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cobRound;
        private System.Windows.Forms.CheckBox chbUnplayedOnly;
        private System.Windows.Forms.ListBox lbMatchup;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.Label lblScoreOne;
        private System.Windows.Forms.TextBox tbScoreOne;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.TextBox tbScoreTwo;
        private System.Windows.Forms.Label lblScoreTwo;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnScore;
    }
}

