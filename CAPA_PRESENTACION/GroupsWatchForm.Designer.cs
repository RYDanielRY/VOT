namespace WindowsFormsApp35.CAPA_PRESENTACION
{
    partial class GroupsWatchForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createJury = new System.Windows.Forms.Button();
            this.createModers = new System.Windows.Forms.Button();
            this.WatchMyProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(349, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Мероприятия";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(332, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Участники";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // createJury
            // 
            this.createJury.Location = new System.Drawing.Point(322, 263);
            this.createJury.Name = "createJury";
            this.createJury.Size = new System.Drawing.Size(332, 56);
            this.createJury.TabIndex = 4;
            this.createJury.Text = "Жюри";
            this.createJury.UseVisualStyleBackColor = true;
            this.createJury.Click += new System.EventHandler(this.createJury_Click);
            // 
            // createModers
            // 
            this.createModers.Location = new System.Drawing.Point(322, 352);
            this.createModers.Name = "createModers";
            this.createModers.Size = new System.Drawing.Size(332, 55);
            this.createModers.TabIndex = 5;
            this.createModers.Text = "Модераторы";
            this.createModers.UseVisualStyleBackColor = true;
            this.createModers.Click += new System.EventHandler(this.createModers_Click);
            // 
            // WatchMyProfile
            // 
            this.WatchMyProfile.Location = new System.Drawing.Point(29, 263);
            this.WatchMyProfile.Name = "WatchMyProfile";
            this.WatchMyProfile.Size = new System.Drawing.Size(174, 144);
            this.WatchMyProfile.TabIndex = 6;
            this.WatchMyProfile.Text = "Мой Профиль";
            this.WatchMyProfile.UseVisualStyleBackColor = true;
            this.WatchMyProfile.Click += new System.EventHandler(this.WatchMyProfile_Click);
            // 
            // GroupsWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 438);
            this.Controls.Add(this.WatchMyProfile);
            this.Controls.Add(this.createModers);
            this.Controls.Add(this.createJury);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupsWatchForm";
            this.Text = "Форма Организаторов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button createJury;
        private System.Windows.Forms.Button createModers;
        private System.Windows.Forms.Button WatchMyProfile;
    }
}