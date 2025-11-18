
namespace CAB__Cognitive_Amplitude_Battery
{
    partial class SymbolenSuche
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
            this.Symbol_Links = new System.Windows.Forms.PictureBox();
            this.Symbol_Rechts = new System.Windows.Forms.PictureBox();
            this.Suche_Links = new System.Windows.Forms.Button();
            this.Suche_Rechts = new System.Windows.Forms.Button();
            this.Suche_Richtung = new System.Windows.Forms.PictureBox();
            this.Suche_Nach = new System.Windows.Forms.PictureBox();
            this.Skip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Symbol_Links)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Symbol_Rechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suche_Richtung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suche_Nach)).BeginInit();
            this.SuspendLayout();
            // 
            // Symbol_Links
            // 
            this.Symbol_Links.Location = new System.Drawing.Point(221, 206);
            this.Symbol_Links.Name = "Symbol_Links";
            this.Symbol_Links.Size = new System.Drawing.Size(75, 54);
            this.Symbol_Links.TabIndex = 0;
            this.Symbol_Links.TabStop = false;
            // 
            // Symbol_Rechts
            // 
            this.Symbol_Rechts.Location = new System.Drawing.Point(479, 206);
            this.Symbol_Rechts.Name = "Symbol_Rechts";
            this.Symbol_Rechts.Size = new System.Drawing.Size(75, 54);
            this.Symbol_Rechts.TabIndex = 2;
            this.Symbol_Rechts.TabStop = false;
            // 
            // Suche_Links
            // 
            this.Suche_Links.Location = new System.Drawing.Point(221, 295);
            this.Suche_Links.Name = "Suche_Links";
            this.Suche_Links.Size = new System.Drawing.Size(75, 23);
            this.Suche_Links.TabIndex = 3;
            this.Suche_Links.Text = "Links";
            this.Suche_Links.UseVisualStyleBackColor = true;
            this.Suche_Links.Click += new System.EventHandler(this.Suche_Links_Click);
            // 
            // Suche_Rechts
            // 
            this.Suche_Rechts.Location = new System.Drawing.Point(479, 295);
            this.Suche_Rechts.Name = "Suche_Rechts";
            this.Suche_Rechts.Size = new System.Drawing.Size(75, 23);
            this.Suche_Rechts.TabIndex = 4;
            this.Suche_Rechts.Text = "Rechts";
            this.Suche_Rechts.UseVisualStyleBackColor = true;
            this.Suche_Rechts.Click += new System.EventHandler(this.Suche_Rechts_Click);
            // 
            // Suche_Richtung
            // 
            this.Suche_Richtung.Location = new System.Drawing.Point(350, 206);
            this.Suche_Richtung.Name = "Suche_Richtung";
            this.Suche_Richtung.Size = new System.Drawing.Size(75, 54);
            this.Suche_Richtung.TabIndex = 5;
            this.Suche_Richtung.TabStop = false;
            // 
            // Suche_Nach
            // 
            this.Suche_Nach.Location = new System.Drawing.Point(350, 97);
            this.Suche_Nach.Name = "Suche_Nach";
            this.Suche_Nach.Size = new System.Drawing.Size(75, 54);
            this.Suche_Nach.TabIndex = 6;
            this.Suche_Nach.TabStop = false;
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(350, 295);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(75, 23);
            this.Skip.TabIndex = 7;
            this.Skip.Text = "Nicht da";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // SymbolenSuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.Suche_Nach);
            this.Controls.Add(this.Suche_Richtung);
            this.Controls.Add(this.Suche_Rechts);
            this.Controls.Add(this.Suche_Links);
            this.Controls.Add(this.Symbol_Rechts);
            this.Controls.Add(this.Symbol_Links);
            this.Name = "SymbolenSuche";
            this.Text = "SymbolenSuche";
            this.Load += new System.EventHandler(this.SymbolenSuche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Symbol_Links)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Symbol_Rechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suche_Richtung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suche_Nach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Symbol_Links;
        private System.Windows.Forms.PictureBox Symbol_Rechts;
        private System.Windows.Forms.Button Suche_Links;
        private System.Windows.Forms.Button Suche_Rechts;
        private System.Windows.Forms.PictureBox Suche_Richtung;
        private System.Windows.Forms.PictureBox Suche_Nach;
        private System.Windows.Forms.Button Skip;
    }
}