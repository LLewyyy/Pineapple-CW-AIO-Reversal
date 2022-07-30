namespace CWTesting
{
	// Token: 0x0200002D RID: 45
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00009AD0 File Offset: 0x00009AD0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00009AF8 File Offset: 0x00009AF8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CWTesting.Form1));
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.logInButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.logInButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.comboBox2 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.outputBox = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.key = new global::System.Windows.Forms.Label();
			this.expiry = new global::System.Windows.Forms.Label();
			this.version = new global::System.Windows.Forms.Label();
			this.SpooferCleaner = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Candara", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Blue;
			this.label2.Location = new global::System.Drawing.Point(380, 124);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(56, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Output:";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Candara", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(364, 178);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(88, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Select Camo:";
			this.logInButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.logInButton2.BorderColor = global::System.Drawing.Color.Transparent;
			this.logInButton2.BorderRadius = 22;
			this.logInButton2.BorderThickness = 2;
			this.logInButton2.CheckedState.FillColor = global::System.Drawing.Color.BlueViolet;
			this.logInButton2.CheckedState.FillColor2 = global::System.Drawing.Color.DarkViolet;
			this.logInButton2.FillColor = global::System.Drawing.Color.Blue;
			this.logInButton2.FillColor2 = global::System.Drawing.Color.Blue;
			this.logInButton2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.logInButton2.ForeColor = global::System.Drawing.Color.FromArgb(24, 22, 21);
			this.logInButton2.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.logInButton2.HoverState.FillColor = global::System.Drawing.Color.DarkViolet;
			this.logInButton2.HoverState.FillColor2 = global::System.Drawing.Color.BlueViolet;
			this.logInButton2.Location = new global::System.Drawing.Point(302, 252);
			this.logInButton2.Name = "logInButton2";
			this.logInButton2.Size = new global::System.Drawing.Size(212, 38);
			this.logInButton2.TabIndex = 7;
			this.logInButton2.Text = "Set Camo";
			this.logInButton2.Click += new global::System.EventHandler(this.logInButton2_Click);
			this.logInButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.logInButton1.BorderColor = global::System.Drawing.Color.Transparent;
			this.logInButton1.CheckedState.FillColor = global::System.Drawing.Color.DarkViolet;
			this.logInButton1.CheckedState.FillColor2 = global::System.Drawing.Color.BlueViolet;
			this.logInButton1.FillColor = global::System.Drawing.Color.Blue;
			this.logInButton1.FillColor2 = global::System.Drawing.Color.Blue;
			this.logInButton1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.logInButton1.ForeColor = global::System.Drawing.Color.FromArgb(24, 22, 21);
			this.logInButton1.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.logInButton1.HoverState.FillColor = global::System.Drawing.Color.BlueViolet;
			this.logInButton1.HoverState.FillColor2 = global::System.Drawing.Color.DarkViolet;
			this.logInButton1.Location = new global::System.Drawing.Point(7, 325);
			this.logInButton1.Name = "logInButton1";
			this.logInButton1.Size = new global::System.Drawing.Size(549, 25);
			this.logInButton1.TabIndex = 7;
			this.logInButton1.Text = "!! How To Use !!";
			this.logInButton1.Click += new global::System.EventHandler(this.logInButton1_Click);
			this.comboBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.comboBox2.BorderColor = global::System.Drawing.Color.Blue;
			this.comboBox2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FillColor = global::System.Drawing.Color.Black;
			this.comboBox2.FocusedColor = global::System.Drawing.Color.BlueViolet;
			this.comboBox2.FocusedState.BorderColor = global::System.Drawing.Color.BlueViolet;
			this.comboBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.comboBox2.ForeColor = global::System.Drawing.Color.Blue;
			this.comboBox2.HoverState.BorderColor = global::System.Drawing.Color.BlueViolet;
			this.comboBox2.ItemHeight = 30;
			this.comboBox2.Items.AddRange(new object[]
			{
				"PAP 1",
				"PAP 2",
				"PAP 3",
				"PAP 5",
				"PAP 6",
				"PAP 7",
				"PAP 8",
				"PAP 9",
				"PAP 10",
				"GOLD",
				"DIAMOND",
				"DM ULTRA",
				"GOLDEN ADDER",
				"DARK AETHER"
			});
			this.comboBox2.Location = new global::System.Drawing.Point(308, 199);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(200, 36);
			this.comboBox2.StartIndex = 0;
			this.comboBox2.TabIndex = 8;
			this.comboBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.outputBox.BackColor = global::System.Drawing.Color.Black;
			this.outputBox.BorderColor = global::System.Drawing.Color.Blue;
			this.outputBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.outputBox.DefaultText = "";
			this.outputBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.outputBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.outputBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.outputBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.outputBox.FillColor = global::System.Drawing.Color.Black;
			this.outputBox.FocusedState.BorderColor = global::System.Drawing.Color.Yellow;
			this.outputBox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.outputBox.ForeColor = global::System.Drawing.Color.BlueViolet;
			this.outputBox.HoverState.BorderColor = global::System.Drawing.Color.Yellow;
			this.outputBox.Location = new global::System.Drawing.Point(308, 147);
			this.outputBox.Name = "outputBox";
			this.outputBox.PasswordChar = '\0';
			this.outputBox.PlaceholderText = "";
			this.outputBox.SelectedText = "";
			this.outputBox.Size = new global::System.Drawing.Size(200, 20);
			this.outputBox.TabIndex = 9;
			this.outputBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.key.AutoSize = true;
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.key.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.key.ForeColor = global::System.Drawing.Color.Blue;
			this.key.Location = new global::System.Drawing.Point(43, 114);
			this.key.Name = "key";
			this.key.Size = new global::System.Drawing.Size(101, 16);
			this.key.TabIndex = 10;
			this.key.Text = "usernameLabel";
			this.expiry.AutoSize = true;
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.expiry.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.expiry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.Color.Blue;
			this.expiry.Location = new global::System.Drawing.Point(43, 143);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(77, 16);
			this.expiry.TabIndex = 10;
			this.expiry.Text = "expiryLabel";
			this.version.AutoSize = true;
			this.version.BackColor = global::System.Drawing.Color.Transparent;
			this.version.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.version.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.version.ForeColor = global::System.Drawing.Color.Blue;
			this.version.Location = new global::System.Drawing.Point(43, 172);
			this.version.Name = "version";
			this.version.Size = new global::System.Drawing.Size(85, 16);
			this.version.TabIndex = 10;
			this.version.Text = "versionLabel";
			this.SpooferCleaner.BackColor = global::System.Drawing.Color.Transparent;
			this.SpooferCleaner.BorderColor = global::System.Drawing.Color.Transparent;
			this.SpooferCleaner.BorderRadius = 15;
			this.SpooferCleaner.BorderThickness = 2;
			this.SpooferCleaner.CheckedState.FillColor = global::System.Drawing.Color.BlueViolet;
			this.SpooferCleaner.CheckedState.FillColor2 = global::System.Drawing.Color.DarkViolet;
			this.SpooferCleaner.FillColor = global::System.Drawing.Color.Blue;
			this.SpooferCleaner.FillColor2 = global::System.Drawing.Color.Blue;
			this.SpooferCleaner.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SpooferCleaner.ForeColor = global::System.Drawing.Color.FromArgb(24, 22, 21);
			this.SpooferCleaner.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.SpooferCleaner.HoverState.FillColor = global::System.Drawing.Color.DarkViolet;
			this.SpooferCleaner.HoverState.FillColor2 = global::System.Drawing.Color.BlueViolet;
			this.SpooferCleaner.Location = new global::System.Drawing.Point(49, 238);
			this.SpooferCleaner.Name = "SpooferCleaner";
			this.SpooferCleaner.Size = new global::System.Drawing.Size(212, 42);
			this.SpooferCleaner.TabIndex = 7;
			this.SpooferCleaner.Text = "Spoofer | Cleaner";
			this.SpooferCleaner.Click += new global::System.EventHandler(this.SpooferCleaner_Click);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Blue;
			this.label3.Location = new global::System.Drawing.Point(184, 7);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(195, 29);
			this.label3.TabIndex = 11;
			this.label3.Text = "P-A-P CAMO TOOL";
			this.label3.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseDown);
			this.label3.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseMove);
			this.label3.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseUp);
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new global::System.Drawing.Point(524, 7);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(32, 28);
			this.button1.TabIndex = 12;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(556, 50);
			this.panel1.TabIndex = 13;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Label_Title_MouseUp);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(562, 357);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.version);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.key);
			base.Controls.Add(this.outputBox);
			base.Controls.Add(this.comboBox2);
			base.Controls.Add(this.logInButton1);
			base.Controls.Add(this.logInButton2);
			base.Controls.Add(this.SpooferCleaner);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PINEAPPLE'S PAP TOOL";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000115 RID: 277
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000119 RID: 281
		private global::Guna.UI2.WinForms.Guna2GradientButton scanBtn;

		// Token: 0x0400011A RID: 282
		private global::Guna.UI2.WinForms.Guna2GradientButton logInButton2;

		// Token: 0x0400011B RID: 283
		private global::Guna.UI2.WinForms.Guna2GradientButton logInButton1;

		// Token: 0x0400011C RID: 284
		private global::Guna.UI2.WinForms.Guna2ComboBox comboBox2;

		// Token: 0x0400011D RID: 285
		private global::Guna.UI2.WinForms.Guna2TextBox outputBox;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.Label key;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.Label expiry;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.Label version;

		// Token: 0x04000121 RID: 289
		private global::Guna.UI2.WinForms.Guna2GradientButton SpooferCleaner;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.Panel panel1;
	}
}
