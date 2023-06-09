namespace InnoWeeks_Kurisu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbUserLastName = new System.Windows.Forms.TextBox();
            this.tbUserFirstName = new System.Windows.Forms.TextBox();
            this.tbUserBirthDate = new System.Windows.Forms.TextBox();
            this.tbUserAddress = new System.Windows.Forms.TextBox();
            this.tbUserCity = new System.Windows.Forms.TextBox();
            this.tbDoctorCity = new System.Windows.Forms.TextBox();
            this.tbDoctorAddress = new System.Windows.Forms.TextBox();
            this.tbDoctorBirthDate = new System.Windows.Forms.TextBox();
            this.tbDoctorFirstName = new System.Windows.Forms.TextBox();
            this.tbDoctorLastName = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pbVersion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TestApp";
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbTitle.Location = new System.Drawing.Point(0, 0);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(277, 52);
            this.pbTitle.TabIndex = 1;
            this.pbTitle.TabStop = false;
            // 
            // pbWelcome
            // 
            this.pbWelcome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbWelcome.Location = new System.Drawing.Point(17, 68);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(242, 52);
            this.pbWelcome.TabIndex = 2;
            this.pbWelcome.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Gainsboro;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(40, 86);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(198, 15);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Bienvenue sur *nom de l\'app*";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(14, 139);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 15);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Vous";
            // 
            // tbUserLastName
            // 
            this.tbUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserLastName.Location = new System.Drawing.Point(17, 157);
            this.tbUserLastName.Name = "tbUserLastName";
            this.tbUserLastName.Size = new System.Drawing.Size(242, 22);
            this.tbUserLastName.TabIndex = 5;
            this.tbUserLastName.Text = "Nom";
            this.tbUserLastName.Click += new System.EventHandler(this.tbUserLastName_Click);
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserFirstName.Location = new System.Drawing.Point(17, 185);
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(242, 22);
            this.tbUserFirstName.TabIndex = 6;
            this.tbUserFirstName.Text = "Prénom";
            this.tbUserFirstName.Click += new System.EventHandler(this.tbUserFirstName_Click);
            // 
            // tbUserBirthDate
            // 
            this.tbUserBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserBirthDate.Location = new System.Drawing.Point(17, 213);
            this.tbUserBirthDate.Name = "tbUserBirthDate";
            this.tbUserBirthDate.Size = new System.Drawing.Size(242, 22);
            this.tbUserBirthDate.TabIndex = 7;
            this.tbUserBirthDate.Text = "Date de naissance";
            this.tbUserBirthDate.Click += new System.EventHandler(this.tbUserBirthDate_Click);
            // 
            // tbUserAddress
            // 
            this.tbUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserAddress.Location = new System.Drawing.Point(17, 241);
            this.tbUserAddress.Name = "tbUserAddress";
            this.tbUserAddress.Size = new System.Drawing.Size(242, 22);
            this.tbUserAddress.TabIndex = 8;
            this.tbUserAddress.Text = "Adresse domicile";
            this.tbUserAddress.Click += new System.EventHandler(this.tbUserAddress_Click);
            // 
            // tbUserCity
            // 
            this.tbUserCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserCity.Location = new System.Drawing.Point(17, 269);
            this.tbUserCity.Name = "tbUserCity";
            this.tbUserCity.Size = new System.Drawing.Size(242, 22);
            this.tbUserCity.TabIndex = 9;
            this.tbUserCity.Text = "Ville";
            this.tbUserCity.Click += new System.EventHandler(this.tbUserCity_Click);
            // 
            // tbDoctorCity
            // 
            this.tbDoctorCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorCity.Location = new System.Drawing.Point(17, 443);
            this.tbDoctorCity.Name = "tbDoctorCity";
            this.tbDoctorCity.Size = new System.Drawing.Size(242, 22);
            this.tbDoctorCity.TabIndex = 15;
            this.tbDoctorCity.Text = "Ville";
            this.tbDoctorCity.Click += new System.EventHandler(this.tbDoctorCity_Click);
            // 
            // tbDoctorAddress
            // 
            this.tbDoctorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorAddress.Location = new System.Drawing.Point(17, 415);
            this.tbDoctorAddress.Name = "tbDoctorAddress";
            this.tbDoctorAddress.Size = new System.Drawing.Size(242, 22);
            this.tbDoctorAddress.TabIndex = 14;
            this.tbDoctorAddress.Text = "Adresse domicile";
            this.tbDoctorAddress.Click += new System.EventHandler(this.tbDoctorAddress_Click);
            // 
            // tbDoctorBirthDate
            // 
            this.tbDoctorBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorBirthDate.Location = new System.Drawing.Point(17, 387);
            this.tbDoctorBirthDate.Name = "tbDoctorBirthDate";
            this.tbDoctorBirthDate.Size = new System.Drawing.Size(242, 22);
            this.tbDoctorBirthDate.TabIndex = 13;
            this.tbDoctorBirthDate.Text = "Date de naissance";
            this.tbDoctorBirthDate.Click += new System.EventHandler(this.tbDoctorBirthDate_Click);
            // 
            // tbDoctorFirstName
            // 
            this.tbDoctorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorFirstName.Location = new System.Drawing.Point(17, 359);
            this.tbDoctorFirstName.Name = "tbDoctorFirstName";
            this.tbDoctorFirstName.Size = new System.Drawing.Size(242, 22);
            this.tbDoctorFirstName.TabIndex = 12;
            this.tbDoctorFirstName.Text = "Prénom";
            this.tbDoctorFirstName.Click += new System.EventHandler(this.tbDoctorFirstName_Click);
            // 
            // tbDoctorLastName
            // 
            this.tbDoctorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoctorLastName.Location = new System.Drawing.Point(17, 331);
            this.tbDoctorLastName.Name = "tbDoctorLastName";
            this.tbDoctorLastName.Size = new System.Drawing.Size(242, 22);
            this.tbDoctorLastName.TabIndex = 11;
            this.tbDoctorLastName.Text = "Nom";
            this.tbDoctorLastName.Click += new System.EventHandler(this.tbDoctorLastName_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(14, 313);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(99, 15);
            this.lblDoctor.TabIndex = 10;
            this.lblDoctor.Text = "Votre médecin";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(43, 504);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(185, 45);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Enregistrer";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Gainsboro;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(99, 563);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(79, 15);
            this.lblVersion.TabIndex = 18;
            this.lblVersion.Text = "Version 1.0";
            // 
            // pbVersion
            // 
            this.pbVersion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbVersion.Location = new System.Drawing.Point(17, 559);
            this.pbVersion.Name = "pbVersion";
            this.pbVersion.Size = new System.Drawing.Size(242, 24);
            this.pbVersion.TabIndex = 17;
            this.pbVersion.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 594);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pbVersion);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbDoctorCity);
            this.Controls.Add(this.tbDoctorAddress);
            this.Controls.Add(this.tbDoctorBirthDate);
            this.Controls.Add(this.tbDoctorFirstName);
            this.Controls.Add(this.tbDoctorLastName);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.tbUserCity);
            this.Controls.Add(this.tbUserAddress);
            this.Controls.Add(this.tbUserBirthDate);
            this.Controls.Add(this.tbUserFirstName);
            this.Controls.Add(this.tbUserLastName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbWelcome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbTitle);
            this.Name = "Form1";
            this.Text = "Test-App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.PictureBox pbWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbUserLastName;
        private System.Windows.Forms.TextBox tbUserFirstName;
        private System.Windows.Forms.TextBox tbUserBirthDate;
        private System.Windows.Forms.TextBox tbUserAddress;
        private System.Windows.Forms.TextBox tbUserCity;
        private System.Windows.Forms.TextBox tbDoctorCity;
        private System.Windows.Forms.TextBox tbDoctorAddress;
        private System.Windows.Forms.TextBox tbDoctorBirthDate;
        private System.Windows.Forms.TextBox tbDoctorFirstName;
        private System.Windows.Forms.TextBox tbDoctorLastName;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pbVersion;
    }
}

