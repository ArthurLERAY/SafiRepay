﻿namespace SAFI_Dekstop
{
    partial class frm_connexion
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
            this.lbl_identifiantConnexion = new System.Windows.Forms.Label();
            this.lbl_mdpConnexion = new System.Windows.Forms.Label();
            this.lbl_mdpOublie = new System.Windows.Forms.Label();
            this.tbx_identifiantConnexion = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.rbn_rememberMe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_identifiantConnexion
            // 
            this.lbl_identifiantConnexion.AutoSize = true;
            this.lbl_identifiantConnexion.Location = new System.Drawing.Point(205, 43);
            this.lbl_identifiantConnexion.Name = "lbl_identifiantConnexion";
            this.lbl_identifiantConnexion.Size = new System.Drawing.Size(59, 13);
            this.lbl_identifiantConnexion.TabIndex = 0;
            this.lbl_identifiantConnexion.Text = "Identifiant :";
            // 
            // lbl_mdpConnexion
            // 
            this.lbl_mdpConnexion.AutoSize = true;
            this.lbl_mdpConnexion.Location = new System.Drawing.Point(205, 159);
            this.lbl_mdpConnexion.Name = "lbl_mdpConnexion";
            this.lbl_mdpConnexion.Size = new System.Drawing.Size(77, 13);
            this.lbl_mdpConnexion.TabIndex = 1;
            this.lbl_mdpConnexion.Text = "Mot de passe :";
            // 
            // lbl_mdpOublie
            // 
            this.lbl_mdpOublie.AutoSize = true;
            this.lbl_mdpOublie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdpOublie.Location = new System.Drawing.Point(365, 259);
            this.lbl_mdpOublie.Name = "lbl_mdpOublie";
            this.lbl_mdpOublie.Size = new System.Drawing.Size(102, 13);
            this.lbl_mdpOublie.TabIndex = 2;
            this.lbl_mdpOublie.Text = "Mot de passe oublié";
            this.lbl_mdpOublie.Click += new System.EventHandler(this.Lbl_mdpOublie_Click);
            // 
            // tbx_identifiantConnexion
            // 
            this.tbx_identifiantConnexion.Location = new System.Drawing.Point(208, 83);
            this.tbx_identifiantConnexion.Name = "tbx_identifiantConnexion";
            this.tbx_identifiantConnexion.Size = new System.Drawing.Size(100, 20);
            this.tbx_identifiantConnexion.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(220, 285);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(88, 40);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Se connecter";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // rbn_rememberMe
            // 
            this.rbn_rememberMe.AutoSize = true;
            this.rbn_rememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_rememberMe.Location = new System.Drawing.Point(89, 259);
            this.rbn_rememberMe.Name = "rbn_rememberMe";
            this.rbn_rememberMe.Size = new System.Drawing.Size(113, 17);
            this.rbn_rememberMe.TabIndex = 8;
            this.rbn_rememberMe.TabStop = true;
            this.rbn_rememberMe.Text = "Se rappeler de moi";
            this.rbn_rememberMe.UseVisualStyleBackColor = true;
            // 
            // frm_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 360);
            this.Controls.Add(this.rbn_rememberMe);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbx_identifiantConnexion);
            this.Controls.Add(this.lbl_mdpOublie);
            this.Controls.Add(this.lbl_mdpConnexion);
            this.Controls.Add(this.lbl_identifiantConnexion);
            this.Name = "frm_connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_identifiantConnexion;
        private System.Windows.Forms.Label lbl_mdpConnexion;
        private System.Windows.Forms.Label lbl_mdpOublie;
        private System.Windows.Forms.TextBox tbx_identifiantConnexion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RadioButton rbn_rememberMe;
    }
}