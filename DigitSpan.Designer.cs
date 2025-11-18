
namespace CAB__Cognitive_Amplitude_Battery
{
    partial class DigitSpan
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.Pruefe_Button = new System.Windows.Forms.Button();
            this.DigitSpan_Eingabe = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Rohpunkte_Forwards = new System.Windows.Forms.Label();
            this.Rohpunkte_Backwards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(358, 62);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label1";
            // 
            // Pruefe_Button
            // 
            this.Pruefe_Button.Location = new System.Drawing.Point(361, 303);
            this.Pruefe_Button.Name = "Pruefe_Button";
            this.Pruefe_Button.Size = new System.Drawing.Size(75, 23);
            this.Pruefe_Button.TabIndex = 1;
            this.Pruefe_Button.Text = "Bestätigen";
            this.Pruefe_Button.UseVisualStyleBackColor = true;
          
            // 
            // DigitSpan_Eingabe
            // 
            this.DigitSpan_Eingabe.Location = new System.Drawing.Point(361, 251);
            this.DigitSpan_Eingabe.Name = "DigitSpan_Eingabe";
            this.DigitSpan_Eingabe.Size = new System.Drawing.Size(100, 20);
            this.DigitSpan_Eingabe.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(361, 398);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Weiter";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Rohpunkte_Forwards
            // 
            this.Rohpunkte_Forwards.AutoSize = true;
            this.Rohpunkte_Forwards.Location = new System.Drawing.Point(50, 110);
            this.Rohpunkte_Forwards.Name = "Rohpunkte_Forwards";
            this.Rohpunkte_Forwards.Size = new System.Drawing.Size(35, 13);
            this.Rohpunkte_Forwards.TabIndex = 4;
            this.Rohpunkte_Forwards.Text = "label1";
            // 
            // Rohpunkte_Backwards
            // 
            this.Rohpunkte_Backwards.AutoSize = true;
            this.Rohpunkte_Backwards.Location = new System.Drawing.Point(50, 162);
            this.Rohpunkte_Backwards.Name = "Rohpunkte_Backwards";
            this.Rohpunkte_Backwards.Size = new System.Drawing.Size(35, 13);
            this.Rohpunkte_Backwards.TabIndex = 5;
            this.Rohpunkte_Backwards.Text = "label1";
            // 
            // DigitSpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rohpunkte_Backwards);
            this.Controls.Add(this.Rohpunkte_Forwards);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.DigitSpan_Eingabe);
            this.Controls.Add(this.Pruefe_Button);
            this.Controls.Add(this.lblInfo);
            this.Name = "DigitSpan";
            this.Text = "DigitSpan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button Pruefe_Button;
        private System.Windows.Forms.TextBox DigitSpan_Eingabe;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label Rohpunkte_Forwards;
        private System.Windows.Forms.Label Rohpunkte_Backwards;
    }
}