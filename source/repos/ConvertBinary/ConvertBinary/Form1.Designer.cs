
namespace ConvertBinary
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
            this.components = new System.ComponentModel.Container();
            this.radHexadecimal = new System.Windows.Forms.RadioButton();
            this.radDecimal = new System.Windows.Forms.RadioButton();
            this.radBinaire = new System.Windows.Forms.RadioButton();
            this.nudBinaire3 = new System.Windows.Forms.NumericUpDown();
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.nudBinaire1 = new System.Windows.Forms.NumericUpDown();
            this.nudBinaire2 = new System.Windows.Forms.NumericUpDown();
            this.nudHexadecimal = new System.Windows.Forms.NumericUpDown();
            this.nudBinaire0 = new System.Windows.Forms.NumericUpDown();
            this.lblSeg_A = new System.Windows.Forms.Label();
            this.lblSeg_G = new System.Windows.Forms.Label();
            this.lblSeg_D = new System.Windows.Forms.Label();
            this.lblSeg_B = new System.Windows.Forms.Label();
            this.lblSeg_F = new System.Windows.Forms.Label();
            this.lblSeg_C = new System.Windows.Forms.Label();
            this.lblSeg_E = new System.Windows.Forms.Label();
            this.chkActiveCompteur = new System.Windows.Forms.CheckBox();
            this.clkSeconde = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHexadecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire0)).BeginInit();
            this.SuspendLayout();
            // 
            // radHexadecimal
            // 
            this.radHexadecimal.AutoSize = true;
            this.radHexadecimal.Location = new System.Drawing.Point(535, 47);
            this.radHexadecimal.Name = "radHexadecimal";
            this.radHexadecimal.Size = new System.Drawing.Size(86, 17);
            this.radHexadecimal.TabIndex = 0;
            this.radHexadecimal.Text = "Hexadecimal";
            this.radHexadecimal.UseVisualStyleBackColor = true;
            this.radHexadecimal.CheckedChanged += new System.EventHandler(this.radHexadecimal_CheckedChanged);
            // 
            // radDecimal
            // 
            this.radDecimal.AutoSize = true;
            this.radDecimal.Checked = true;
            this.radDecimal.Location = new System.Drawing.Point(110, 47);
            this.radDecimal.Name = "radDecimal";
            this.radDecimal.Size = new System.Drawing.Size(63, 17);
            this.radDecimal.TabIndex = 0;
            this.radDecimal.TabStop = true;
            this.radDecimal.Text = "Decimal";
            this.radDecimal.UseVisualStyleBackColor = true;
            this.radDecimal.CheckedChanged += new System.EventHandler(this.radDecimal_CheckedChanged);
            // 
            // radBinaire
            // 
            this.radBinaire.AutoSize = true;
            this.radBinaire.Location = new System.Drawing.Point(330, 47);
            this.radBinaire.Name = "radBinaire";
            this.radBinaire.Size = new System.Drawing.Size(57, 17);
            this.radBinaire.TabIndex = 0;
            this.radBinaire.Text = "Binaire";
            this.radBinaire.UseVisualStyleBackColor = true;
            this.radBinaire.CheckedChanged += new System.EventHandler(this.radBinaire_CheckedChanged);
            // 
            // nudBinaire3
            // 
            this.nudBinaire3.Enabled = false;
            this.nudBinaire3.Location = new System.Drawing.Point(268, 106);
            this.nudBinaire3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBinaire3.Name = "nudBinaire3";
            this.nudBinaire3.Size = new System.Drawing.Size(43, 20);
            this.nudBinaire3.TabIndex = 1;
            this.nudBinaire3.ValueChanged += new System.EventHandler(this.nudBinaire_ValueChanged);
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(93, 106);
            this.nudDecimal.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(62, 20);
            this.nudDecimal.TabIndex = 1;
            this.nudDecimal.ValueChanged += new System.EventHandler(this.nudDecimal_ValueChanged);
            // 
            // nudBinaire1
            // 
            this.nudBinaire1.Enabled = false;
            this.nudBinaire1.Location = new System.Drawing.Point(368, 106);
            this.nudBinaire1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBinaire1.Name = "nudBinaire1";
            this.nudBinaire1.Size = new System.Drawing.Size(60, 20);
            this.nudBinaire1.TabIndex = 1;
            this.nudBinaire1.ValueChanged += new System.EventHandler(this.nudBinaire_ValueChanged);
            // 
            // nudBinaire2
            // 
            this.nudBinaire2.Enabled = false;
            this.nudBinaire2.Location = new System.Drawing.Point(317, 106);
            this.nudBinaire2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBinaire2.Name = "nudBinaire2";
            this.nudBinaire2.Size = new System.Drawing.Size(45, 20);
            this.nudBinaire2.TabIndex = 1;
            this.nudBinaire2.ValueChanged += new System.EventHandler(this.nudBinaire_ValueChanged);
            // 
            // nudHexadecimal
            // 
            this.nudHexadecimal.Enabled = false;
            this.nudHexadecimal.Hexadecimal = true;
            this.nudHexadecimal.Location = new System.Drawing.Point(556, 106);
            this.nudHexadecimal.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudHexadecimal.Name = "nudHexadecimal";
            this.nudHexadecimal.Size = new System.Drawing.Size(65, 20);
            this.nudHexadecimal.TabIndex = 1;
            this.nudHexadecimal.ValueChanged += new System.EventHandler(this.nudHexadecimal_ValueChanged);
            // 
            // nudBinaire0
            // 
            this.nudBinaire0.Enabled = false;
            this.nudBinaire0.Location = new System.Drawing.Point(434, 106);
            this.nudBinaire0.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBinaire0.Name = "nudBinaire0";
            this.nudBinaire0.Size = new System.Drawing.Size(45, 20);
            this.nudBinaire0.TabIndex = 1;
            this.nudBinaire0.ValueChanged += new System.EventHandler(this.nudBinaire_ValueChanged);
            // 
            // lblSeg_A
            // 
            this.lblSeg_A.AccessibleName = "";
            this.lblSeg_A.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_A.Location = new System.Drawing.Point(330, 150);
            this.lblSeg_A.Name = "lblSeg_A";
            this.lblSeg_A.Size = new System.Drawing.Size(98, 21);
            this.lblSeg_A.TabIndex = 2;
            // 
            // lblSeg_G
            // 
            this.lblSeg_G.AccessibleName = "";
            this.lblSeg_G.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_G.Location = new System.Drawing.Point(330, 245);
            this.lblSeg_G.Name = "lblSeg_G";
            this.lblSeg_G.Size = new System.Drawing.Size(98, 20);
            this.lblSeg_G.TabIndex = 3;
            this.lblSeg_G.Text = " ";
            // 
            // lblSeg_D
            // 
            this.lblSeg_D.AccessibleName = "";
            this.lblSeg_D.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg_D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeg_D.Location = new System.Drawing.Point(330, 360);
            this.lblSeg_D.Name = "lblSeg_D";
            this.lblSeg_D.Size = new System.Drawing.Size(98, 18);
            this.lblSeg_D.TabIndex = 4;
            this.lblSeg_D.Text = " ";
            // 
            // lblSeg_B
            // 
            this.lblSeg_B.AccessibleName = "";
            this.lblSeg_B.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg_B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeg_B.Location = new System.Drawing.Point(434, 165);
            this.lblSeg_B.Name = "lblSeg_B";
            this.lblSeg_B.Size = new System.Drawing.Size(24, 86);
            this.lblSeg_B.TabIndex = 9;
            // 
            // lblSeg_F
            // 
            this.lblSeg_F.AccessibleName = "";
            this.lblSeg_F.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg_F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeg_F.Location = new System.Drawing.Point(300, 165);
            this.lblSeg_F.Name = "lblSeg_F";
            this.lblSeg_F.Size = new System.Drawing.Size(24, 86);
            this.lblSeg_F.TabIndex = 10;
            // 
            // lblSeg_C
            // 
            this.lblSeg_C.AccessibleName = "";
            this.lblSeg_C.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg_C.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeg_C.Location = new System.Drawing.Point(434, 269);
            this.lblSeg_C.Name = "lblSeg_C";
            this.lblSeg_C.Size = new System.Drawing.Size(24, 89);
            this.lblSeg_C.TabIndex = 11;
            // 
            // lblSeg_E
            // 
            this.lblSeg_E.AccessibleName = "";
            this.lblSeg_E.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSeg_E.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeg_E.Location = new System.Drawing.Point(300, 269);
            this.lblSeg_E.Name = "lblSeg_E";
            this.lblSeg_E.Size = new System.Drawing.Size(24, 89);
            this.lblSeg_E.TabIndex = 12;
            // 
            // chkActiveCompteur
            // 
            this.chkActiveCompteur.AutoSize = true;
            this.chkActiveCompteur.Location = new System.Drawing.Point(330, 390);
            this.chkActiveCompteur.Name = "chkActiveCompteur";
            this.chkActiveCompteur.Size = new System.Drawing.Size(104, 17);
            this.chkActiveCompteur.TabIndex = 13;
            this.chkActiveCompteur.Text = "Active Compteur";
            this.chkActiveCompteur.UseVisualStyleBackColor = true;
            this.chkActiveCompteur.CheckedChanged += new System.EventHandler(this.chkActiveCompteur_CheckedChanged);
            // 
            // clkSeconde
            // 
            this.clkSeconde.Interval = 1000;
            this.clkSeconde.Tick += new System.EventHandler(this.clkSeconde_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkActiveCompteur);
            this.Controls.Add(this.lblSeg_E);
            this.Controls.Add(this.lblSeg_C);
            this.Controls.Add(this.lblSeg_F);
            this.Controls.Add(this.lblSeg_B);
            this.Controls.Add(this.lblSeg_D);
            this.Controls.Add(this.lblSeg_G);
            this.Controls.Add(this.lblSeg_A);
            this.Controls.Add(this.nudBinaire0);
            this.Controls.Add(this.nudBinaire2);
            this.Controls.Add(this.nudHexadecimal);
            this.Controls.Add(this.nudBinaire1);
            this.Controls.Add(this.nudDecimal);
            this.Controls.Add(this.nudBinaire3);
            this.Controls.Add(this.radBinaire);
            this.Controls.Add(this.radDecimal);
            this.Controls.Add(this.radHexadecimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHexadecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBinaire0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radHexadecimal;
        private System.Windows.Forms.RadioButton radDecimal;
        private System.Windows.Forms.RadioButton radBinaire;
        private System.Windows.Forms.NumericUpDown nudBinaire3;
        private System.Windows.Forms.NumericUpDown nudDecimal;
        private System.Windows.Forms.NumericUpDown nudBinaire1;
        private System.Windows.Forms.NumericUpDown nudBinaire2;
        private System.Windows.Forms.NumericUpDown nudHexadecimal;
        private System.Windows.Forms.NumericUpDown nudBinaire0;
        private System.Windows.Forms.Label lblSeg_A;
        private System.Windows.Forms.Label lblSeg_G;
        private System.Windows.Forms.Label lblSeg_D;
        private System.Windows.Forms.Label lblSeg_B;
        private System.Windows.Forms.Label lblSeg_F;
        private System.Windows.Forms.Label lblSeg_C;
        private System.Windows.Forms.Label lblSeg_E;
        private System.Windows.Forms.CheckBox chkActiveCompteur;
        private System.Windows.Forms.Timer clkSeconde;
    }
}

