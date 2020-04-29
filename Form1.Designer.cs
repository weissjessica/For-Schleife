namespace Weiss_Jessica_For
{
    partial class Form1
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
            this.textBoxEintrag = new System.Windows.Forms.TextBox();
            this.btnVorwärts = new System.Windows.Forms.Button();
            this.btnRückwärts = new System.Windows.Forms.Button();
            this.btnLücken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEintrag
            // 
            this.textBoxEintrag.Location = new System.Drawing.Point(42, 50);
            this.textBoxEintrag.Multiline = true;
            this.textBoxEintrag.Name = "textBoxEintrag";
            this.textBoxEintrag.Size = new System.Drawing.Size(278, 293);
            this.textBoxEintrag.TabIndex = 0;
            // 
            // btnVorwärts
            // 
            this.btnVorwärts.Location = new System.Drawing.Point(370, 50);
            this.btnVorwärts.Name = "btnVorwärts";
            this.btnVorwärts.Size = new System.Drawing.Size(101, 35);
            this.btnVorwärts.TabIndex = 1;
            this.btnVorwärts.Text = "Vorwärts";
            this.btnVorwärts.UseVisualStyleBackColor = true;
            this.btnVorwärts.Click += new System.EventHandler(this.btnVorwärts_Click);
            // 
            // btnRückwärts
            // 
            this.btnRückwärts.Location = new System.Drawing.Point(370, 123);
            this.btnRückwärts.Name = "btnRückwärts";
            this.btnRückwärts.Size = new System.Drawing.Size(101, 35);
            this.btnRückwärts.TabIndex = 2;
            this.btnRückwärts.Text = "Rückwärts";
            this.btnRückwärts.UseVisualStyleBackColor = true;
            this.btnRückwärts.Click += new System.EventHandler(this.btnRückwärts_Click);
            // 
            // btnLücken
            // 
            this.btnLücken.Location = new System.Drawing.Point(370, 199);
            this.btnLücken.Name = "btnLücken";
            this.btnLücken.Size = new System.Drawing.Size(101, 34);
            this.btnLücken.TabIndex = 3;
            this.btnLücken.Text = "Lücken";
            this.btnLücken.UseVisualStyleBackColor = true;
            this.btnLücken.Click += new System.EventHandler(this.btnLücken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLücken);
            this.Controls.Add(this.btnRückwärts);
            this.Controls.Add(this.btnVorwärts);
            this.Controls.Add(this.textBoxEintrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEintrag;
        private System.Windows.Forms.Button btnVorwärts;
        private System.Windows.Forms.Button btnRückwärts;
        private System.Windows.Forms.Button btnLücken;
    }
}

