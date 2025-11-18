
namespace CAB__Cognitive_Amplitude_Battery
{
    partial class Menü
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
            this.Titel = new System.Windows.Forms.Label();
            this.Untertitel = new System.Windows.Forms.Label();
            this.menu_Start = new System.Windows.Forms.Button();
            this.menu_Laden = new System.Windows.Forms.Button();
            this.menu_Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.Location = new System.Drawing.Point(317, 9);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(164, 73);
            this.Titel.TabIndex = 0;
            this.Titel.Text = "CAB";
            this.Titel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Untertitel
            // 
            this.Untertitel.AutoSize = true;
            this.Untertitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Untertitel.Location = new System.Drawing.Point(224, 82);
            this.Untertitel.Name = "Untertitel";
            this.Untertitel.Size = new System.Drawing.Size(378, 37);
            this.Untertitel.TabIndex = 1;
            this.Untertitel.Text = "Cognitve Aptitude Battery";
            this.Untertitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu_Start
            // 
            this.menu_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Start.Location = new System.Drawing.Point(366, 155);
            this.menu_Start.Name = "menu_Start";
            this.menu_Start.Size = new System.Drawing.Size(75, 23);
            this.menu_Start.TabIndex = 2;
            this.menu_Start.Text = "Test starten";
            this.menu_Start.UseVisualStyleBackColor = true;
            this.menu_Start.Click += new System.EventHandler(this.menu_Start_Click);
            // 
            // menu_Laden
            // 
            this.menu_Laden.Location = new System.Drawing.Point(366, 184);
            this.menu_Laden.Name = "menu_Laden";
            this.menu_Laden.Size = new System.Drawing.Size(75, 23);
            this.menu_Laden.TabIndex = 3;
            this.menu_Laden.Text = "Profil Laden";
            this.menu_Laden.UseVisualStyleBackColor = true;
            // 
            // menu_Beenden
            // 
            this.menu_Beenden.Location = new System.Drawing.Point(366, 213);
            this.menu_Beenden.Name = "menu_Beenden";
            this.menu_Beenden.Size = new System.Drawing.Size(75, 23);
            this.menu_Beenden.TabIndex = 4;
            this.menu_Beenden.Text = "Beenden";
            this.menu_Beenden.UseVisualStyleBackColor = true;
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.menu_Beenden);
            this.Controls.Add(this.menu_Laden);
            this.Controls.Add(this.menu_Start);
            this.Controls.Add(this.Untertitel);
            this.Controls.Add(this.Titel);
            this.Name = "Menü";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label Untertitel;
        private System.Windows.Forms.Button menu_Start;
        private System.Windows.Forms.Button menu_Laden;
        private System.Windows.Forms.Button menu_Beenden;
    }
}

