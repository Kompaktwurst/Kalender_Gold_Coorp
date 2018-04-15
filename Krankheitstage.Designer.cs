namespace Kalender_Gold_Coorp
{
    partial class Krankheitstage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Krankheitstage));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Löschen = new System.Windows.Forms.Button();
            this.SelectedDatum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 232);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Löschen);
            this.groupBox1.Controls.Add(this.SelectedDatum);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(142, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag bearbeiten";
            // 
            // Löschen
            // 
            this.Löschen.Location = new System.Drawing.Point(6, 203);
            this.Löschen.Name = "Löschen";
            this.Löschen.Size = new System.Drawing.Size(188, 23);
            this.Löschen.TabIndex = 1;
            this.Löschen.Text = "Löschen";
            this.Löschen.UseVisualStyleBackColor = true;
            this.Löschen.Click += new System.EventHandler(this.Löschen_Click);
            // 
            // SelectedDatum
            // 
            this.SelectedDatum.AutoSize = true;
            this.SelectedDatum.Location = new System.Drawing.Point(6, 33);
            this.SelectedDatum.Name = "SelectedDatum";
            this.SelectedDatum.Size = new System.Drawing.Size(49, 19);
            this.SelectedDatum.TabIndex = 0;
            this.SelectedDatum.Text = "Datum";
            // 
            // Krankheitstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 298);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 298);
            this.Name = "Krankheitstage";
            this.ShowInTaskbar = false;
            this.Text = "Krankheitstage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Krankheitstage_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Löschen;
        private System.Windows.Forms.Label SelectedDatum;
    }
}