namespace Kalender_Gold_Coorp
{
    partial class Profil_Bearbeitung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil_Bearbeitung));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Avatar_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Daten_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Status_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Name_überschrift_Label = new System.Windows.Forms.Label();
            this.Beenden_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(387, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Beruf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(387, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Abteilung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(240, 401);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 106);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Status hier einfügen";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Name_überschrift_Label);
            this.panel1.Controls.Add(this.LogoPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 93);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.Beenden_button);
            this.panel2.Controls.Add(this.Status_Button);
            this.panel2.Controls.Add(this.Daten_Button);
            this.panel2.Controls.Add(this.Avatar_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 481);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(68, 32);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(134, 25);
            this.label41.TabIndex = 0;
            this.label41.Text = "Gold Coorp";
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.LogoPanel.Controls.Add(this.pictureBox2);
            this.LogoPanel.Controls.Add(this.label41);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(222, 93);
            this.LogoPanel.TabIndex = 34;
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.LogoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // Avatar_Button
            // 
            this.Avatar_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Avatar_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Avatar_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar_Button.BorderRadius = 0;
            this.Avatar_Button.ButtonText = "             Avatar wechseln";
            this.Avatar_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Avatar_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Avatar_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Avatar_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Avatar_Button.Iconimage = null;
            this.Avatar_Button.Iconimage_right = null;
            this.Avatar_Button.Iconimage_right_Selected = null;
            this.Avatar_Button.Iconimage_Selected = null;
            this.Avatar_Button.IconMarginLeft = 0;
            this.Avatar_Button.IconMarginRight = 0;
            this.Avatar_Button.IconRightVisible = true;
            this.Avatar_Button.IconRightZoom = 0D;
            this.Avatar_Button.IconVisible = true;
            this.Avatar_Button.IconZoom = 90D;
            this.Avatar_Button.IsTab = false;
            this.Avatar_Button.Location = new System.Drawing.Point(0, 0);
            this.Avatar_Button.Name = "Avatar_Button";
            this.Avatar_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Avatar_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Avatar_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Avatar_Button.selected = false;
            this.Avatar_Button.Size = new System.Drawing.Size(222, 58);
            this.Avatar_Button.TabIndex = 2;
            this.Avatar_Button.Text = "             Avatar wechseln";
            this.Avatar_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Avatar_Button.Textcolor = System.Drawing.Color.LightGray;
            this.Avatar_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avatar_Button.Click += new System.EventHandler(this.Avatar_Button_Click);
            // 
            // Daten_Button
            // 
            this.Daten_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Daten_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Daten_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Daten_Button.BorderRadius = 0;
            this.Daten_Button.ButtonText = "             Pers. Daten ändern";
            this.Daten_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Daten_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Daten_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Daten_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Daten_Button.Iconimage = null;
            this.Daten_Button.Iconimage_right = null;
            this.Daten_Button.Iconimage_right_Selected = null;
            this.Daten_Button.Iconimage_Selected = null;
            this.Daten_Button.IconMarginLeft = 0;
            this.Daten_Button.IconMarginRight = 0;
            this.Daten_Button.IconRightVisible = true;
            this.Daten_Button.IconRightZoom = 0D;
            this.Daten_Button.IconVisible = true;
            this.Daten_Button.IconZoom = 90D;
            this.Daten_Button.IsTab = false;
            this.Daten_Button.Location = new System.Drawing.Point(0, 58);
            this.Daten_Button.Name = "Daten_Button";
            this.Daten_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Daten_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Daten_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Daten_Button.selected = false;
            this.Daten_Button.Size = new System.Drawing.Size(222, 62);
            this.Daten_Button.TabIndex = 3;
            this.Daten_Button.Text = "             Pers. Daten ändern";
            this.Daten_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Daten_Button.Textcolor = System.Drawing.Color.LightGray;
            this.Daten_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daten_Button.Click += new System.EventHandler(this.Daten_Button_Click);
            // 
            // Status_Button
            // 
            this.Status_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Status_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Status_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Status_Button.BorderRadius = 0;
            this.Status_Button.ButtonText = "             Status speichern";
            this.Status_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Status_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Status_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Status_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Status_Button.Iconimage = null;
            this.Status_Button.Iconimage_right = null;
            this.Status_Button.Iconimage_right_Selected = null;
            this.Status_Button.Iconimage_Selected = null;
            this.Status_Button.IconMarginLeft = 0;
            this.Status_Button.IconMarginRight = 0;
            this.Status_Button.IconRightVisible = true;
            this.Status_Button.IconRightZoom = 0D;
            this.Status_Button.IconVisible = true;
            this.Status_Button.IconZoom = 90D;
            this.Status_Button.IsTab = false;
            this.Status_Button.Location = new System.Drawing.Point(0, 120);
            this.Status_Button.Name = "Status_Button";
            this.Status_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Status_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Status_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Status_Button.selected = false;
            this.Status_Button.Size = new System.Drawing.Size(222, 62);
            this.Status_Button.TabIndex = 4;
            this.Status_Button.Text = "             Status speichern";
            this.Status_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Status_Button.Textcolor = System.Drawing.Color.LightGray;
            this.Status_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Button.Click += new System.EventHandler(this.Status_Button_Click);
            // 
            // Name_überschrift_Label
            // 
            this.Name_überschrift_Label.AutoSize = true;
            this.Name_überschrift_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_überschrift_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Name_überschrift_Label.Location = new System.Drawing.Point(286, 35);
            this.Name_überschrift_Label.Name = "Name_überschrift_Label";
            this.Name_überschrift_Label.Size = new System.Drawing.Size(146, 25);
            this.Name_überschrift_Label.TabIndex = 35;
            this.Name_überschrift_Label.Text = "Name´s Profil";
            // 
            // Beenden_button
            // 
            this.Beenden_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Beenden_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Beenden_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beenden_button.BorderRadius = 0;
            this.Beenden_button.ButtonText = "             Beenden";
            this.Beenden_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beenden_button.DisabledColor = System.Drawing.Color.Gray;
            this.Beenden_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Beenden_button.Iconcolor = System.Drawing.Color.Transparent;
            this.Beenden_button.Iconimage = null;
            this.Beenden_button.Iconimage_right = null;
            this.Beenden_button.Iconimage_right_Selected = null;
            this.Beenden_button.Iconimage_Selected = null;
            this.Beenden_button.IconMarginLeft = 0;
            this.Beenden_button.IconMarginRight = 0;
            this.Beenden_button.IconRightVisible = true;
            this.Beenden_button.IconRightZoom = 0D;
            this.Beenden_button.IconVisible = true;
            this.Beenden_button.IconZoom = 90D;
            this.Beenden_button.IsTab = false;
            this.Beenden_button.Location = new System.Drawing.Point(0, 423);
            this.Beenden_button.Name = "Beenden_button";
            this.Beenden_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Beenden_button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Beenden_button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Beenden_button.selected = false;
            this.Beenden_button.Size = new System.Drawing.Size(222, 58);
            this.Beenden_button.TabIndex = 6;
            this.Beenden_button.Text = "             Beenden";
            this.Beenden_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Beenden_button.Textcolor = System.Drawing.Color.LightGray;
            this.Beenden_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beenden_button.Click += new System.EventHandler(this.Beenden_button_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // Profil_Bearbeitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 574);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profil_Bearbeitung";
            this.ShowInTaskbar = false;
            this.Text = "Profil_Bearbeitung";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label41;
        private Bunifu.Framework.UI.BunifuFlatButton Status_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Daten_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Avatar_Button;
        private System.Windows.Forms.Label Name_überschrift_Label;
        private Bunifu.Framework.UI.BunifuFlatButton Beenden_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}