namespace FAZEDAuth
{
	// Token: 0x02000016 RID: 22
	public partial class LoginMenu : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00005142 File Offset: 0x00005142
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005164 File Offset: 0x00005164
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FAZEDAuth.LoginMenu));
			this.RegisterBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.SaveChkbx = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
			this.Fade = new global::System.Windows.Forms.Timer(this.components);
			this.RegisterPanel = new global::System.Windows.Forms.Panel();
			this.RegisterKey = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.RegisterUser = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.RegisterPass = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.LoginPanel = new global::System.Windows.Forms.Panel();
			this.LoginBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.LoginUser = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.LoginPass = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.GlobalBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.HomeBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.CloseBtn = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.RegisterPanel.SuspendLayout();
			this.LoginPanel.SuspendLayout();
			base.SuspendLayout();
			this.RegisterBtn.Animated = false;
			this.RegisterBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.RegisterBtn.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterBtn.BorderThickness = 1;
			this.RegisterBtn.CheckedState.Parent = this.RegisterBtn;
			this.RegisterBtn.CustomImages.Parent = this.RegisterBtn;
			this.RegisterBtn.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.RegisterBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RegisterBtn.ForeColor = global::System.Drawing.Color.White;
			this.RegisterBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterBtn.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterBtn.HoveredState.FillColor = global::System.Drawing.Color.DarkViolet;
			this.RegisterBtn.HoveredState.Parent = this.RegisterBtn;
			this.RegisterBtn.Location = new global::System.Drawing.Point(30, 131);
			this.RegisterBtn.Name = "RegisterBtn";
			this.RegisterBtn.PressedColor = global::System.Drawing.Color.FromArgb(91, 90, 90);
			this.RegisterBtn.PressedDepth = 0;
			this.RegisterBtn.ShadowDecoration.Parent = this.RegisterBtn;
			this.RegisterBtn.Size = new global::System.Drawing.Size(247, 46);
			this.RegisterBtn.TabIndex = 46;
			this.RegisterBtn.Text = "REGISTER";
			this.RegisterBtn.Click += new global::System.EventHandler(this.RegisterLbl_Click);
			this.SaveChkbx.AutoSize = true;
			this.SaveChkbx.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.SaveChkbx.CheckedState.BorderRadius = 0;
			this.SaveChkbx.CheckedState.BorderThickness = 0;
			this.SaveChkbx.CheckedState.FillColor = global::System.Drawing.Color.RoyalBlue;
			this.SaveChkbx.CheckMarkColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.SaveChkbx.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.SaveChkbx.ForeColor = global::System.Drawing.Color.White;
			this.SaveChkbx.Location = new global::System.Drawing.Point(101, 100);
			this.SaveChkbx.Name = "SaveChkbx";
			this.SaveChkbx.Size = new global::System.Drawing.Size(104, 18);
			this.SaveChkbx.TabIndex = 48;
			this.SaveChkbx.Text = "REMEMBER ME";
			this.SaveChkbx.UncheckedState.BorderColor = global::System.Drawing.Color.White;
			this.SaveChkbx.UncheckedState.BorderRadius = 0;
			this.SaveChkbx.UncheckedState.BorderThickness = 2;
			this.SaveChkbx.UncheckedState.FillColor = global::System.Drawing.Color.Black;
			this.SaveChkbx.UseVisualStyleBackColor = false;
			this.Fade.Enabled = true;
			this.Fade.Tick += new global::System.EventHandler(this.Fade_Tick);
			this.RegisterPanel.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.RegisterPanel.Controls.Add(this.RegisterKey);
			this.RegisterPanel.Controls.Add(this.RegisterUser);
			this.RegisterPanel.Controls.Add(this.RegisterPass);
			this.RegisterPanel.Controls.Add(this.RegisterBtn);
			this.RegisterPanel.Location = new global::System.Drawing.Point(12, 47);
			this.RegisterPanel.Name = "RegisterPanel";
			this.RegisterPanel.Size = new global::System.Drawing.Size(306, 189);
			this.RegisterPanel.TabIndex = 49;
			this.RegisterKey.AllowDrop = true;
			this.RegisterKey.Animated = false;
			this.RegisterKey.BackColor = global::System.Drawing.Color.Transparent;
			this.RegisterKey.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.RegisterKey.DefaultText = "";
			this.RegisterKey.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.DisabledState.Parent = this.RegisterKey;
			this.RegisterKey.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.RegisterKey.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.FocusedState.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.RegisterKey.FocusedState.Parent = this.RegisterKey;
			this.RegisterKey.ForeColor = global::System.Drawing.Color.White;
			this.RegisterKey.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.HoveredState.Parent = this.RegisterKey;
			this.RegisterKey.IconLeftOffset = new global::System.Drawing.Point(3, 0);
			this.RegisterKey.Location = new global::System.Drawing.Point(17, 90);
			this.RegisterKey.Margin = new global::System.Windows.Forms.Padding(4);
			this.RegisterKey.Name = "RegisterKey";
			this.RegisterKey.PasswordChar = '\0';
			this.RegisterKey.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterKey.PlaceholderText = "";
			this.RegisterKey.SelectedText = "";
			this.RegisterKey.ShadowDecoration.Color = global::System.Drawing.Color.MediumOrchid;
			this.RegisterKey.ShadowDecoration.Parent = this.RegisterKey;
			this.RegisterKey.Size = new global::System.Drawing.Size(273, 30);
			this.RegisterKey.TabIndex = 48;
			this.RegisterKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.RegisterUser.AllowDrop = true;
			this.RegisterUser.Animated = false;
			this.RegisterUser.BackColor = global::System.Drawing.Color.Transparent;
			this.RegisterUser.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.RegisterUser.DefaultText = "";
			this.RegisterUser.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.DisabledState.Parent = this.RegisterUser;
			this.RegisterUser.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.RegisterUser.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.FocusedState.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.RegisterUser.FocusedState.Parent = this.RegisterUser;
			this.RegisterUser.ForeColor = global::System.Drawing.Color.White;
			this.RegisterUser.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.HoveredState.Parent = this.RegisterUser;
			this.RegisterUser.IconLeftOffset = new global::System.Drawing.Point(3, 0);
			this.RegisterUser.Location = new global::System.Drawing.Point(17, 10);
			this.RegisterUser.Margin = new global::System.Windows.Forms.Padding(4);
			this.RegisterUser.Name = "RegisterUser";
			this.RegisterUser.PasswordChar = '\0';
			this.RegisterUser.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterUser.PlaceholderText = "";
			this.RegisterUser.SelectedText = "";
			this.RegisterUser.ShadowDecoration.BorderRadius = 0;
			this.RegisterUser.ShadowDecoration.Color = global::System.Drawing.Color.MediumOrchid;
			this.RegisterUser.ShadowDecoration.Parent = this.RegisterUser;
			this.RegisterUser.Size = new global::System.Drawing.Size(273, 30);
			this.RegisterUser.TabIndex = 44;
			this.RegisterUser.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.RegisterPass.AllowDrop = true;
			this.RegisterPass.Animated = false;
			this.RegisterPass.BackColor = global::System.Drawing.Color.Transparent;
			this.RegisterPass.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.RegisterPass.DefaultText = "";
			this.RegisterPass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.DisabledState.Parent = this.RegisterPass;
			this.RegisterPass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.RegisterPass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.FocusedState.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.RegisterPass.FocusedState.Parent = this.RegisterPass;
			this.RegisterPass.ForeColor = global::System.Drawing.Color.White;
			this.RegisterPass.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.HoveredState.Parent = this.RegisterPass;
			this.RegisterPass.IconLeftOffset = new global::System.Drawing.Point(3, 0);
			this.RegisterPass.Location = new global::System.Drawing.Point(17, 50);
			this.RegisterPass.Margin = new global::System.Windows.Forms.Padding(4);
			this.RegisterPass.Name = "RegisterPass";
			this.RegisterPass.PasswordChar = '•';
			this.RegisterPass.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.RegisterPass.PlaceholderText = "";
			this.RegisterPass.SelectedText = "";
			this.RegisterPass.ShadowDecoration.Color = global::System.Drawing.Color.MediumOrchid;
			this.RegisterPass.ShadowDecoration.Parent = this.RegisterPass;
			this.RegisterPass.Size = new global::System.Drawing.Size(273, 30);
			this.RegisterPass.TabIndex = 45;
			this.RegisterPass.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.LoginPanel.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.LoginPanel.Controls.Add(this.LoginBtn);
			this.LoginPanel.Controls.Add(this.LoginUser);
			this.LoginPanel.Controls.Add(this.LoginPass);
			this.LoginPanel.Controls.Add(this.SaveChkbx);
			this.LoginPanel.Location = new global::System.Drawing.Point(12, 47);
			this.LoginPanel.Name = "LoginPanel";
			this.LoginPanel.Size = new global::System.Drawing.Size(306, 189);
			this.LoginPanel.TabIndex = 50;
			this.LoginPanel.Paint += new global::System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
			this.LoginBtn.Animated = false;
			this.LoginBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginBtn.BorderThickness = 1;
			this.LoginBtn.CheckedState.Parent = this.LoginBtn;
			this.LoginBtn.CustomImages.Parent = this.LoginBtn;
			this.LoginBtn.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.LoginBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.White;
			this.LoginBtn.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginBtn.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginBtn.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.LoginBtn.HoveredState.Parent = this.LoginBtn;
			this.LoginBtn.Location = new global::System.Drawing.Point(30, 131);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.PressedColor = global::System.Drawing.Color.FromArgb(91, 90, 90);
			this.LoginBtn.PressedDepth = 0;
			this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
			this.LoginBtn.Size = new global::System.Drawing.Size(247, 46);
			this.LoginBtn.TabIndex = 49;
			this.LoginBtn.Text = "LOGIN";
			this.LoginBtn.Click += new global::System.EventHandler(this.button1_Click);
			this.LoginUser.AllowDrop = true;
			this.LoginUser.Animated = false;
			this.LoginUser.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginUser.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.LoginUser.DefaultText = "";
			this.LoginUser.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.DisabledState.Parent = this.LoginUser;
			this.LoginUser.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.LoginUser.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.FocusedState.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.LoginUser.FocusedState.Parent = this.LoginUser;
			this.LoginUser.ForeColor = global::System.Drawing.Color.White;
			this.LoginUser.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.HoveredState.Parent = this.LoginUser;
			this.LoginUser.IconLeftOffset = new global::System.Drawing.Point(3, 0);
			this.LoginUser.Location = new global::System.Drawing.Point(17, 13);
			this.LoginUser.Margin = new global::System.Windows.Forms.Padding(4);
			this.LoginUser.Name = "LoginUser";
			this.LoginUser.PasswordChar = '\0';
			this.LoginUser.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginUser.PlaceholderText = "";
			this.LoginUser.SelectedText = "";
			this.LoginUser.ShadowDecoration.BorderRadius = 0;
			this.LoginUser.ShadowDecoration.Color = global::System.Drawing.Color.MediumOrchid;
			this.LoginUser.ShadowDecoration.Parent = this.LoginUser;
			this.LoginUser.Size = new global::System.Drawing.Size(273, 30);
			this.LoginUser.TabIndex = 44;
			this.LoginUser.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.LoginPass.AllowDrop = true;
			this.LoginPass.Animated = false;
			this.LoginPass.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginPass.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.LoginPass.DefaultText = "";
			this.LoginPass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.DisabledState.Parent = this.LoginPass;
			this.LoginPass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.LoginPass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.FocusedState.FillColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.LoginPass.FocusedState.Parent = this.LoginPass;
			this.LoginPass.ForeColor = global::System.Drawing.Color.White;
			this.LoginPass.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.HoveredState.Parent = this.LoginPass;
			this.LoginPass.IconLeftOffset = new global::System.Drawing.Point(3, 0);
			this.LoginPass.Location = new global::System.Drawing.Point(17, 57);
			this.LoginPass.Margin = new global::System.Windows.Forms.Padding(4);
			this.LoginPass.Name = "LoginPass";
			this.LoginPass.PasswordChar = '•';
			this.LoginPass.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.LoginPass.PlaceholderText = "";
			this.LoginPass.SelectedText = "";
			this.LoginPass.ShadowDecoration.Color = global::System.Drawing.Color.MediumOrchid;
			this.LoginPass.ShadowDecoration.Parent = this.LoginPass;
			this.LoginPass.Size = new global::System.Drawing.Size(273, 30);
			this.LoginPass.TabIndex = 45;
			this.LoginPass.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.GlobalBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.BorderColor = global::System.Drawing.Color.Empty;
			this.GlobalBtn.ButtonMode = 1;
			this.GlobalBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.GlobalBtn.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.GlobalBtn.CheckedState.Parent = this.GlobalBtn;
			this.GlobalBtn.CustomBorderColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.GlobalBtn.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 3, 0, 0);
			this.GlobalBtn.CustomImages.Parent = this.GlobalBtn;
			this.GlobalBtn.DisabledState.Parent = this.GlobalBtn;
			this.GlobalBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold);
			this.GlobalBtn.ForeColor = global::System.Drawing.Color.White;
			this.GlobalBtn.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.GlobalBtn.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.GlobalBtn.HoverState.Parent = this.GlobalBtn;
			this.GlobalBtn.Location = new global::System.Drawing.Point(165, 235);
			this.GlobalBtn.Name = "GlobalBtn";
			this.GlobalBtn.PressedColor = global::System.Drawing.Color.Empty;
			this.GlobalBtn.ShadowDecoration.Parent = this.GlobalBtn;
			this.GlobalBtn.Size = new global::System.Drawing.Size(153, 45);
			this.GlobalBtn.TabIndex = 52;
			this.GlobalBtn.Text = "REGISTER";
			this.GlobalBtn.UseTransparentBackground = true;
			this.GlobalBtn.Click += new global::System.EventHandler(this.GlobalBtn_Click);
			this.HomeBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.BorderColor = global::System.Drawing.Color.Empty;
			this.HomeBtn.ButtonMode = 1;
			this.HomeBtn.Checked = true;
			this.HomeBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.HomeBtn.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.CheckedState.Parent = this.HomeBtn;
			this.HomeBtn.CustomBorderColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.HomeBtn.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 3, 0, 0);
			this.HomeBtn.CustomImages.Parent = this.HomeBtn;
			this.HomeBtn.DisabledState.Parent = this.HomeBtn;
			this.HomeBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold);
			this.HomeBtn.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.HomeBtn.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.HoverState.Parent = this.HomeBtn;
			this.HomeBtn.Location = new global::System.Drawing.Point(12, 235);
			this.HomeBtn.Name = "HomeBtn";
			this.HomeBtn.PressedColor = global::System.Drawing.Color.Empty;
			this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
			this.HomeBtn.Size = new global::System.Drawing.Size(153, 45);
			this.HomeBtn.TabIndex = 51;
			this.HomeBtn.Text = "LOGIN";
			this.HomeBtn.UseTransparentBackground = true;
			this.HomeBtn.Click += new global::System.EventHandler(this.HomeBtn_Click);
			this.siticoneDragControl1.TargetControl = this;
			this.CloseBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.CloseBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.CloseBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.BorderRadius = 10;
			this.CloseBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.BorderColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.FillColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.IconColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.Parent = this.CloseBtn;
			this.CloseBtn.IconColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.Location = new global::System.Drawing.Point(300, 9);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.PressedColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
			this.CloseBtn.Size = new global::System.Drawing.Size(20, 20);
			this.CloseBtn.TabIndex = 42;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Arial Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(27, 9);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(267, 30);
			this.label4.TabIndex = 79;
			this.label4.Text = "PINEAPPLE SERVICES";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(329, 295);
			base.ControlBox = false;
			base.Controls.Add(this.label4);
			base.Controls.Add(this.CloseBtn);
			base.Controls.Add(this.GlobalBtn);
			base.Controls.Add(this.HomeBtn);
			base.Controls.Add(this.LoginPanel);
			base.Controls.Add(this.RegisterPanel);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoginMenu";
			base.Opacity = 0.0;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PINEAPPLE SERVICES";
			base.Load += new global::System.EventHandler(this.LoginMenu_Load);
			this.RegisterPanel.ResumeLayout(false);
			this.LoginPanel.ResumeLayout(false);
			this.LoginPanel.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000074 RID: 116
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000075 RID: 117
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox SaveChkbx;

		// Token: 0x04000076 RID: 118
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox RegisterUser;

		// Token: 0x04000077 RID: 119
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox RegisterPass;

		// Token: 0x04000078 RID: 120
		private global::Siticone.UI.WinForms.SiticoneRoundedButton RegisterBtn;

		// Token: 0x04000079 RID: 121
		private global::Siticone.UI.WinForms.SiticoneControlBox CloseBtn;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Timer Fade;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Panel RegisterPanel;

		// Token: 0x0400007C RID: 124
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox RegisterKey;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Panel LoginPanel;

		// Token: 0x0400007E RID: 126
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox LoginUser;

		// Token: 0x0400007F RID: 127
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox LoginPass;

		// Token: 0x04000080 RID: 128
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton GlobalBtn;

		// Token: 0x04000081 RID: 129
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton HomeBtn;

		// Token: 0x04000082 RID: 130
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000083 RID: 131
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label label4;
	}
}
