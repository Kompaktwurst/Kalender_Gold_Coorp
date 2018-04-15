namespace Kalender_Gold_Coorp
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.Mitarbeitername_Label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Urlaub_Anzeige_Btn = new System.Windows.Forms.Button();
            this.Passwort_ändern_Btn = new System.Windows.Forms.Button();
            this.Krankheit_anzeigen_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Beenden_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Postfach_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Verwalten_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Event_Erstellen_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mitarbeitername_Label
            // 
            this.Mitarbeitername_Label.AutoSize = true;
            this.Mitarbeitername_Label.Location = new System.Drawing.Point(607, 137);
            this.Mitarbeitername_Label.Name = "Mitarbeitername_Label";
            this.Mitarbeitername_Label.Size = new System.Drawing.Size(128, 13);
            this.Mitarbeitername_Label.TabIndex = 0;
            this.Mitarbeitername_Label.Text = "Name des Mitarbeiters";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(610, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 108);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Urlaub_Anzeige_Btn
            // 
            this.Urlaub_Anzeige_Btn.Location = new System.Drawing.Point(820, 398);
            this.Urlaub_Anzeige_Btn.Name = "Urlaub_Anzeige_Btn";
            this.Urlaub_Anzeige_Btn.Size = new System.Drawing.Size(148, 21);
            this.Urlaub_Anzeige_Btn.TabIndex = 2;
            this.Urlaub_Anzeige_Btn.Text = "Urlaub anzeigen";
            this.Urlaub_Anzeige_Btn.UseVisualStyleBackColor = true;
            this.Urlaub_Anzeige_Btn.Click += new System.EventHandler(this.Urlaub_Anzeige_Btn_Click);
            // 
            // Passwort_ändern_Btn
            // 
            this.Passwort_ändern_Btn.Location = new System.Drawing.Point(807, 374);
            this.Passwort_ändern_Btn.Name = "Passwort_ändern_Btn";
            this.Passwort_ändern_Btn.Size = new System.Drawing.Size(161, 21);
            this.Passwort_ändern_Btn.TabIndex = 4;
            this.Passwort_ändern_Btn.Text = "Passwort ändern";
            this.Passwort_ändern_Btn.UseVisualStyleBackColor = true;
            this.Passwort_ändern_Btn.Click += new System.EventHandler(this.Passwort_ändern_Btn_Click);
            // 
            // Krankheit_anzeigen_Btn
            // 
            this.Krankheit_anzeigen_Btn.Location = new System.Drawing.Point(807, 347);
            this.Krankheit_anzeigen_Btn.Name = "Krankheit_anzeigen_Btn";
            this.Krankheit_anzeigen_Btn.Size = new System.Drawing.Size(161, 21);
            this.Krankheit_anzeigen_Btn.TabIndex = 3;
            this.Krankheit_anzeigen_Btn.Text = "Kranke Tage anzeigen";
            this.Krankheit_anzeigen_Btn.UseVisualStyleBackColor = true;
            this.Krankheit_anzeigen_Btn.Click += new System.EventHandler(this.Krankheit_anzeigen_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 93);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseUp);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label42.Location = new System.Drawing.Point(215, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(153, 25);
            this.label42.TabIndex = 35;
            this.label42.Text = "Administration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label41);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 93);
            this.panel3.TabIndex = 7;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(58, 35);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(134, 25);
            this.label41.TabIndex = 1;
            this.label41.Text = "Gold Coorp";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.Beenden_Button);
            this.panel2.Controls.Add(this.Postfach_Button);
            this.panel2.Controls.Add(this.Verwalten_Button);
            this.panel2.Controls.Add(this.Event_Erstellen_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 356);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel32_MouseUp);
            // 
            // Beenden_Button
            // 
            this.Beenden_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Beenden_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Beenden_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beenden_Button.BorderRadius = 0;
            this.Beenden_Button.ButtonText = "             Beenden";
            this.Beenden_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beenden_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Beenden_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Beenden_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Beenden_Button.Iconimage = null;
            this.Beenden_Button.Iconimage_right = null;
            this.Beenden_Button.Iconimage_right_Selected = null;
            this.Beenden_Button.Iconimage_Selected = null;
            this.Beenden_Button.IconMarginLeft = 0;
            this.Beenden_Button.IconMarginRight = 0;
            this.Beenden_Button.IconRightVisible = true;
            this.Beenden_Button.IconRightZoom = 0D;
            this.Beenden_Button.IconVisible = true;
            this.Beenden_Button.IconZoom = 90D;
            this.Beenden_Button.IsTab = false;
            this.Beenden_Button.Location = new System.Drawing.Point(0, 298);
            this.Beenden_Button.Name = "Beenden_Button";
            this.Beenden_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Beenden_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Beenden_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Beenden_Button.selected = false;
            this.Beenden_Button.Size = new System.Drawing.Size(199, 58);
            this.Beenden_Button.TabIndex = 8;
            this.Beenden_Button.Text = "             Beenden";
            this.Beenden_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Beenden_Button.Textcolor = System.Drawing.Color.LightGray;
            this.Beenden_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beenden_Button.Click += new System.EventHandler(this.Beenden_Button_Click);
            // 
            // Postfach_Button
            // 
            this.Postfach_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Postfach_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Postfach_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Postfach_Button.BorderRadius = 0;
            this.Postfach_Button.ButtonText = "             Postfach";
            this.Postfach_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Postfach_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Postfach_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Postfach_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Postfach_Button.Iconimage = null;
            this.Postfach_Button.Iconimage_right = null;
            this.Postfach_Button.Iconimage_right_Selected = null;
            this.Postfach_Button.Iconimage_Selected = null;
            this.Postfach_Button.IconMarginLeft = 0;
            this.Postfach_Button.IconMarginRight = 0;
            this.Postfach_Button.IconRightVisible = true;
            this.Postfach_Button.IconRightZoom = 0D;
            this.Postfach_Button.IconVisible = true;
            this.Postfach_Button.IconZoom = 90D;
            this.Postfach_Button.IsTab = false;
            this.Postfach_Button.Location = new System.Drawing.Point(0, 116);
            this.Postfach_Button.Name = "Postfach_Button";
            this.Postfach_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Postfach_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Postfach_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Postfach_Button.selected = false;
            this.Postfach_Button.Size = new System.Drawing.Size(199, 58);
            this.Postfach_Button.TabIndex = 7;
            this.Postfach_Button.Text = "             Postfach";
            this.Postfach_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Postfach_Button.Textcolor = System.Drawing.Color.LightGray;
            this.Postfach_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postfach_Button.Click += new System.EventHandler(this.Postfach_Button_Click);
            // 
            // Verwalten_Button
            // 
            this.Verwalten_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Verwalten_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Verwalten_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Verwalten_Button.BorderRadius = 0;
            this.Verwalten_Button.ButtonText = "             Alle Events Löschen";
            this.Verwalten_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Verwalten_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Verwalten_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Verwalten_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Verwalten_Button.Iconimage = null;
            this.Verwalten_Button.Iconimage_right = null;
            this.Verwalten_Button.Iconimage_right_Selected = null;
            this.Verwalten_Button.Iconimage_Selected = null;
            this.Verwalten_Button.IconMarginLeft = 0;
            this.Verwalten_Button.IconMarginRight = 0;
            this.Verwalten_Button.IconRightVisible = true;
            this.Verwalten_Button.IconRightZoom = 0D;
            this.Verwalten_Button.IconVisible = true;
            this.Verwalten_Button.IconZoom = 90D;
            this.Verwalten_Button.IsTab = false;
            this.Verwalten_Button.Location = new System.Drawing.Point(0, 58);
            this.Verwalten_Button.Name = "Verwalten_Button";
            this.Verwalten_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Verwalten_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Verwalten_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Verwalten_Button.selected = false;
            this.Verwalten_Button.Size = new System.Drawing.Size(199, 58);
            this.Verwalten_Button.TabIndex = 6;
            this.Verwalten_Button.Text = "             Alle Events Löschen";
            this.Verwalten_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Verwalten_Button.Textcolor = System.Drawing.Color.LightGray;
            this.Verwalten_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verwalten_Button.Click += new System.EventHandler(this.Verwalten_Button_Click);
            // 
            // Event_Erstellen_Button
            // 
            this.Event_Erstellen_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Event_Erstellen_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Event_Erstellen_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Event_Erstellen_Button.BorderRadius = 0;
            this.Event_Erstellen_Button.ButtonText = "             Event Erstellen";
            this.Event_Erstellen_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Event_Erstellen_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Event_Erstellen_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Event_Erstellen_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Event_Erstellen_Button.Iconimage = null;
            this.Event_Erstellen_Button.Iconimage_right = null;
            this.Event_Erstellen_Button.Iconimage_right_Selected = null;
            this.Event_Erstellen_Button.Iconimage_Selected = null;
            this.Event_Erstellen_Button.IconMarginLeft = 0;
            this.Event_Erstellen_Button.IconMarginRight = 0;
            this.Event_Erstellen_Button.IconRightVisible = true;
            this.Event_Erstellen_Button.IconRightZoom = 0D;
            this.Event_Erstellen_Button.IconVisible = true;
            this.Event_Erstellen_Button.IconZoom = 90D;
            this.Event_Erstellen_Button.IsTab = false;
            this.Event_Erstellen_Button.Location = new System.Drawing.Point(0, 0);
            this.Event_Erstellen_Button.Name = "Event_Erstellen_Button";
            this.Event_Erstellen_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Event_Erstellen_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Event_Erstellen_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Event_Erstellen_Button.selected = false;
            this.Event_Erstellen_Button.Size = new System.Drawing.Size(199, 58);
            this.Event_Erstellen_Button.TabIndex = 5;
            this.Event_Erstellen_Button.Text = "             Event Erstellen";
            this.Event_Erstellen_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Event_Erstellen_Button.Textcolor = System.Drawing.Color.LightGray;
            this.Event_Erstellen_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Erstellen_Button.Click += new System.EventHandler(this.Event_Erstellen_Button_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.FormatCustom = "            yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 33);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 14, 17, 39, 47, 172);
            // 
            // textBox1
            // 
            this.textBox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.textBox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textBox1.BorderThickness = 3;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.isPassword = false;
            this.textBox1.Location = new System.Drawing.Point(205, 351);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 41);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Eventname";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(546, 93);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(5, 359);
            this.bunifuGradientPanel1.TabIndex = 38;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 449);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Urlaub_Anzeige_Btn);
            this.Controls.Add(this.Krankheit_anzeigen_Btn);
            this.Controls.Add(this.Passwort_ändern_Btn);
            this.Controls.Add(this.Mitarbeitername_Label);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administration";
            this.ShowInTaskbar = false;
            this.Text = "Administration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mitarbeitername_Label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Urlaub_Anzeige_Btn;
        private System.Windows.Forms.Button Krankheit_anzeigen_Btn;
        private System.Windows.Forms.Button Passwort_ändern_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton Beenden_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Postfach_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Verwalten_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Event_Erstellen_Button;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMetroTextbox textBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}