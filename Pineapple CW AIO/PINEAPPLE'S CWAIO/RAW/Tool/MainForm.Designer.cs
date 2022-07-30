namespace RAW.Tool
{
	// Token: 0x020000AF RID: 175
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00029E4F File Offset: 0x00029E4F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00029E70 File Offset: 0x00029E70
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RAW.Tool.MainForm));
			this.BGWorker = new global::System.ComponentModel.BackgroundWorker();
			this.DiscoWorker = new global::System.ComponentModel.BackgroundWorker();
			this.RapidFireWorker = new global::System.ComponentModel.BackgroundWorker();
			this.P1Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.P2Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.P3Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.P4Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.AntiDebugWorker = new global::System.ComponentModel.BackgroundWorker();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.ZombieWorker = new global::System.ComponentModel.BackgroundWorker();
			this.LocationWorker = new global::System.ComponentModel.BackgroundWorker();
			this.AutoFireWorker = new global::System.ComponentModel.BackgroundWorker();
			this.MainBackPnl = new global::System.Windows.Forms.Panel();
			this.homePanel = new global::System.Windows.Forms.Panel();
			this.label28 = new global::System.Windows.Forms.Label();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.InjectLbl = new global::System.Windows.Forms.TextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.DiscordBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.AttachedStateLbl = new global::System.Windows.Forms.TextBox();
			this.UsernameLbl = new global::System.Windows.Forms.TextBox();
			this.daPanel = new global::System.Windows.Forms.Panel();
			this.label22 = new global::System.Windows.Forms.Label();
			this.siticoneCheckBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.papPanel = new global::System.Windows.Forms.Panel();
			this.label26 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.outputBox = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.comboBox2 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label25 = new global::System.Windows.Forms.Label();
			this.CloseBtn = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label24 = new global::System.Windows.Forms.Label();
			this.siticoneButton10 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton9 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton8 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton7 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton6 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton5 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton4 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton3 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton2 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.siticoneButton1 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.HomeBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.a1 = new global::System.Windows.Forms.Panel();
			this.label27 = new global::System.Windows.Forms.Label();
			this.a2 = new global::System.Windows.Forms.Panel();
			this.button6 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.siticoneTrackBar1 = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label21 = new global::System.Windows.Forms.Label();
			this.siticoneToggleSwitch2 = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.siticoneToggleSwitch1 = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.SpeedTrackBar = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.PlayerSpeedValue = new global::System.Windows.Forms.Label();
			this.label29 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.ToggleDCamo = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.ZombieTPDistTrackBar = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.label3 = new global::System.Windows.Forms.Label();
			this.OneShotZombiesChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.WeaponCycleIntervalTrackBar = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.TPZombie = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.TPZC = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.TPCLbl = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.ToggleSPEED = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.TPValue = new global::System.Windows.Forms.Label();
			this.CycleValue = new global::System.Windows.Forms.Label();
			this.a3 = new global::System.Windows.Forms.Panel();
			this.PlayerAllOptionsPnl = new global::System.Windows.Forms.Panel();
			this.ALLAFKDA = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.label10 = new global::System.Windows.Forms.Label();
			this.KillAll = new global::System.Windows.Forms.Button();
			this.ZMCountLbl = new global::System.Windows.Forms.TextBox();
			this.ALLGod = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.TPAllMe = new global::System.Windows.Forms.Button();
			this.label14 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.ALLRapidFire = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.ALLAmmo = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.ALLFreeze = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.label15 = new global::System.Windows.Forms.Label();
			this.ALLCritical = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.label11 = new global::System.Windows.Forms.Label();
			this.ALLPoints = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.label12 = new global::System.Windows.Forms.Label();
			this.ALLCycle = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.label16 = new global::System.Windows.Forms.Label();
			this.WeaponSelectorCombo = new global::Siticone.UI.WinForms.SiticoneRoundedComboBox();
			this.TeleportSelectorCombo = new global::Siticone.UI.WinForms.SiticoneRoundedComboBox();
			this.Player1OptionsPnl = new global::System.Windows.Forms.Panel();
			this.label17 = new global::System.Windows.Forms.Label();
			this.Player1AFNRChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P1Name = new global::System.Windows.Forms.TextBox();
			this.P1CycleLbl = new global::System.Windows.Forms.Label();
			this.Player1WeaponCycleChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P1CritLbl = new global::System.Windows.Forms.Label();
			this.Player1OnlyCritChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P1RapidLbl = new global::System.Windows.Forms.Label();
			this.Player1RapidFireChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P1AmmoLbl = new global::System.Windows.Forms.Label();
			this.Player1UnlimitedAmmoChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P1PointsLbl = new global::System.Windows.Forms.Label();
			this.Player1UnlimitedPointsChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P1GodmodeLbl = new global::System.Windows.Forms.Label();
			this.Player1GodChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.Player2OptionsPnl = new global::System.Windows.Forms.Panel();
			this.label18 = new global::System.Windows.Forms.Label();
			this.Player2AFNRChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P2Name = new global::System.Windows.Forms.TextBox();
			this.P2CycleLbl = new global::System.Windows.Forms.Label();
			this.Player2WeaponCycleChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P2CritLbl = new global::System.Windows.Forms.Label();
			this.Player2OnlyCritChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P2RapidLbl = new global::System.Windows.Forms.Label();
			this.Player2RapidFireChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P2AmmoLbl = new global::System.Windows.Forms.Label();
			this.Player2UnlimitedAmmoChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P2PointsLbl = new global::System.Windows.Forms.Label();
			this.Player2UnlimitedPointsChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P2GodmodeLbl = new global::System.Windows.Forms.Label();
			this.Player2GodChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.Player3OptionsPnl = new global::System.Windows.Forms.Panel();
			this.label19 = new global::System.Windows.Forms.Label();
			this.Player3AFNRChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P3Name = new global::System.Windows.Forms.TextBox();
			this.P3CycleLbl = new global::System.Windows.Forms.Label();
			this.Player3WeaponCycleChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P3CritLbl = new global::System.Windows.Forms.Label();
			this.Player3OnlyCritChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P3RapidLbl = new global::System.Windows.Forms.Label();
			this.Player3RapidFireChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P3AmmoLbl = new global::System.Windows.Forms.Label();
			this.Player3UnlimitedAmmoChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P3PointsLbl = new global::System.Windows.Forms.Label();
			this.Player3UnlimitedPointsChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P3GodmodeLbl = new global::System.Windows.Forms.Label();
			this.Player3GodChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.Player4OptionsPnl = new global::System.Windows.Forms.Panel();
			this.label20 = new global::System.Windows.Forms.Label();
			this.Player4AFNRChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P4Name = new global::System.Windows.Forms.TextBox();
			this.P4CycleLbl = new global::System.Windows.Forms.Label();
			this.Player4WeaponCycleChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P4CritLbl = new global::System.Windows.Forms.Label();
			this.Player4OnlyCritChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P4RapidLbl = new global::System.Windows.Forms.Label();
			this.Player4RapidFireChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P4AmmoLbl = new global::System.Windows.Forms.Label();
			this.Player4UnlimitedAmmoChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P4PointsLbl = new global::System.Windows.Forms.Label();
			this.Player4UnlimitedPointsChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.P4GodmodeLbl = new global::System.Windows.Forms.Label();
			this.Player4GodChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.MainBackgroundImage = new global::System.Windows.Forms.PictureBox();
			this.bindingSource1 = new global::System.Windows.Forms.BindingSource(this.components);
			this.bindingSource2 = new global::System.Windows.Forms.BindingSource(this.components);
			this.bindingSource3 = new global::System.Windows.Forms.BindingSource(this.components);
			this.MainBackPnl.SuspendLayout();
			this.homePanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			this.daPanel.SuspendLayout();
			this.papPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.a1.SuspendLayout();
			this.a2.SuspendLayout();
			this.a3.SuspendLayout();
			this.PlayerAllOptionsPnl.SuspendLayout();
			this.Player1OptionsPnl.SuspendLayout();
			this.Player2OptionsPnl.SuspendLayout();
			this.Player3OptionsPnl.SuspendLayout();
			this.Player4OptionsPnl.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.MainBackgroundImage).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource3).BeginInit();
			base.SuspendLayout();
			this.BGWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
			this.DiscoWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.DiscoWorker_DoWork);
			this.RapidFireWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.RapidFireWorker_DoWork);
			this.P1Cycle.Tick += new global::System.EventHandler(this.P1Cycle_Tick);
			this.P2Cycle.Tick += new global::System.EventHandler(this.P2Cycle_Tick);
			this.P3Cycle.Tick += new global::System.EventHandler(this.P3Cycle_Tick);
			this.P4Cycle.Tick += new global::System.EventHandler(this.P4Cycle_Tick);
			this.AntiDebugWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.AntiDebugWorker_DoWork);
			this.siticoneDragControl1.TargetControl = null;
			this.ZombieWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.ZombieWorker_DoWork);
			this.ZombieWorker.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.ZombieWorker_RunWorkerCompleted);
			this.LocationWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.LocationWorker_DoWork);
			this.AutoFireWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.AutoFireWorker_DoWork);
			this.MainBackPnl.Controls.Add(this.homePanel);
			this.MainBackPnl.Controls.Add(this.daPanel);
			this.MainBackPnl.Controls.Add(this.papPanel);
			this.MainBackPnl.Controls.Add(this.CloseBtn);
			this.MainBackPnl.Controls.Add(this.panel2);
			this.MainBackPnl.Controls.Add(this.siticoneButton10);
			this.MainBackPnl.Controls.Add(this.siticoneButton9);
			this.MainBackPnl.Controls.Add(this.siticoneButton8);
			this.MainBackPnl.Controls.Add(this.siticoneButton7);
			this.MainBackPnl.Controls.Add(this.siticoneButton6);
			this.MainBackPnl.Controls.Add(this.siticoneButton5);
			this.MainBackPnl.Controls.Add(this.siticoneButton4);
			this.MainBackPnl.Controls.Add(this.siticoneButton3);
			this.MainBackPnl.Controls.Add(this.siticoneButton2);
			this.MainBackPnl.Controls.Add(this.siticoneButton1);
			this.MainBackPnl.Controls.Add(this.HomeBtn);
			this.MainBackPnl.Controls.Add(this.a1);
			this.MainBackPnl.Controls.Add(this.a2);
			this.MainBackPnl.Controls.Add(this.a3);
			this.MainBackPnl.Controls.Add(this.MainBackgroundImage);
			this.MainBackPnl.Location = new global::System.Drawing.Point(0, 0);
			this.MainBackPnl.Name = "MainBackPnl";
			this.MainBackPnl.Size = new global::System.Drawing.Size(644, 401);
			this.MainBackPnl.TabIndex = 69;
			this.homePanel.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.homePanel.Controls.Add(this.label28);
			this.homePanel.Controls.Add(this.pictureBox3);
			this.homePanel.Controls.Add(this.InjectLbl);
			this.homePanel.Controls.Add(this.textBox1);
			this.homePanel.Controls.Add(this.DiscordBtn);
			this.homePanel.Controls.Add(this.AttachedStateLbl);
			this.homePanel.Controls.Add(this.UsernameLbl);
			this.homePanel.Location = new global::System.Drawing.Point(0, 86);
			this.homePanel.Name = "homePanel";
			this.homePanel.Size = new global::System.Drawing.Size(632, 315);
			this.homePanel.TabIndex = 84;
			this.label28.AutoSize = true;
			this.label28.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label28.ForeColor = global::System.Drawing.Color.White;
			this.label28.Location = new global::System.Drawing.Point(157, 9);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(343, 16);
			this.label28.TabIndex = 82;
			this.label28.Text = "WELCOME TO PINEAPPLE SERVICES COLD WAR AIO";
			this.label28.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.pictureBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(264, 94);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(105, 105);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 81;
			this.pictureBox3.TabStop = false;
			this.InjectLbl.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.InjectLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.InjectLbl.Font = new global::System.Drawing.Font("Arial", 11f, global::System.Drawing.FontStyle.Bold);
			this.InjectLbl.ForeColor = global::System.Drawing.Color.White;
			this.InjectLbl.Location = new global::System.Drawing.Point(246, 266);
			this.InjectLbl.Multiline = true;
			this.InjectLbl.Name = "InjectLbl";
			this.InjectLbl.Size = new global::System.Drawing.Size(141, 21);
			this.InjectLbl.TabIndex = 68;
			this.InjectLbl.Text = "INJECT STATUS";
			this.InjectLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new global::System.Drawing.Font("Arial Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(151, 33);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(330, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "USERNAME";
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.DiscordBtn.Animated = false;
			this.DiscordBtn.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.DiscordBtn.BorderColor = global::System.Drawing.Color.White;
			this.DiscordBtn.BorderThickness = 1;
			this.DiscordBtn.CheckedState.Parent = this.DiscordBtn;
			this.DiscordBtn.CustomImages.Parent = this.DiscordBtn;
			this.DiscordBtn.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.DiscordBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold);
			this.DiscordBtn.ForeColor = global::System.Drawing.Color.White;
			this.DiscordBtn.HoveredState.BorderColor = global::System.Drawing.Color.White;
			this.DiscordBtn.HoveredState.Parent = this.DiscordBtn;
			this.DiscordBtn.Location = new global::System.Drawing.Point(242, 207);
			this.DiscordBtn.Name = "DiscordBtn";
			this.DiscordBtn.ShadowDecoration.Parent = this.DiscordBtn;
			this.DiscordBtn.Size = new global::System.Drawing.Size(149, 30);
			this.DiscordBtn.TabIndex = 62;
			this.DiscordBtn.Text = "Discord";
			this.DiscordBtn.Click += new global::System.EventHandler(this.DiscordBtn_Click);
			this.AttachedStateLbl.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.AttachedStateLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.AttachedStateLbl.Font = new global::System.Drawing.Font("Arial", 11f, global::System.Drawing.FontStyle.Bold);
			this.AttachedStateLbl.ForeColor = global::System.Drawing.Color.Red;
			this.AttachedStateLbl.Location = new global::System.Drawing.Point(246, 287);
			this.AttachedStateLbl.Multiline = true;
			this.AttachedStateLbl.Name = "AttachedStateLbl";
			this.AttachedStateLbl.Size = new global::System.Drawing.Size(141, 21);
			this.AttachedStateLbl.TabIndex = 67;
			this.AttachedStateLbl.Text = "DISCONNECTED";
			this.AttachedStateLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.UsernameLbl.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.UsernameLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.UsernameLbl.Font = new global::System.Drawing.Font("Arial Black", 8f, global::System.Drawing.FontStyle.Bold);
			this.UsernameLbl.ForeColor = global::System.Drawing.Color.White;
			this.UsernameLbl.Location = new global::System.Drawing.Point(151, 54);
			this.UsernameLbl.Multiline = true;
			this.UsernameLbl.Name = "UsernameLbl";
			this.UsernameLbl.Size = new global::System.Drawing.Size(330, 26);
			this.UsernameLbl.TabIndex = 1;
			this.UsernameLbl.Text = "Pineapple\ud83c\udf4d#9375";
			this.UsernameLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.daPanel.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.daPanel.Controls.Add(this.label22);
			this.daPanel.Controls.Add(this.siticoneCheckBox1);
			this.daPanel.Controls.Add(this.button1);
			this.daPanel.Location = new global::System.Drawing.Point(0, 86);
			this.daPanel.Name = "daPanel";
			this.daPanel.Size = new global::System.Drawing.Size(632, 315);
			this.daPanel.TabIndex = 81;
			this.label22.AutoSize = true;
			this.label22.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label22.ForeColor = global::System.Drawing.Color.White;
			this.label22.Location = new global::System.Drawing.Point(86, 18);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(460, 112);
			this.label22.TabIndex = 189;
			this.label22.Text = componentResourceManager.GetString("label22.Text");
			this.siticoneCheckBox1.AutoSize = true;
			this.siticoneCheckBox1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneCheckBox1.CheckedState.BorderRadius = 0;
			this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
			this.siticoneCheckBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneCheckBox1.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneCheckBox1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneCheckBox1.Location = new global::System.Drawing.Point(271, 253);
			this.siticoneCheckBox1.Name = "siticoneCheckBox1";
			this.siticoneCheckBox1.Size = new global::System.Drawing.Size(90, 20);
			this.siticoneCheckBox1.TabIndex = 188;
			this.siticoneCheckBox1.Text = "RESET DA";
			this.siticoneCheckBox1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.siticoneCheckBox1.UncheckedState.BorderRadius = 0;
			this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
			this.siticoneCheckBox1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.siticoneCheckBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button1.Location = new global::System.Drawing.Point(208, 212);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(217, 29);
			this.button1.TabIndex = 187;
			this.button1.Text = "INSTANT DA";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.papPanel.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.papPanel.Controls.Add(this.label26);
			this.papPanel.Controls.Add(this.button3);
			this.papPanel.Controls.Add(this.button2);
			this.papPanel.Controls.Add(this.outputBox);
			this.papPanel.Controls.Add(this.comboBox2);
			this.papPanel.Controls.Add(this.label4);
			this.papPanel.Controls.Add(this.label25);
			this.papPanel.Location = new global::System.Drawing.Point(0, 86);
			this.papPanel.Name = "papPanel";
			this.papPanel.Size = new global::System.Drawing.Size(632, 315);
			this.papPanel.TabIndex = 82;
			this.label26.AutoSize = true;
			this.label26.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label26.ForeColor = global::System.Drawing.Color.White;
			this.label26.Location = new global::System.Drawing.Point(128, 14);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(377, 96);
			this.label26.TabIndex = 188;
			this.label26.Text = "                                       How to use:\r\n\r\n1. Set Shards Camo On The Gun You Want To Set A Pap Camo\r\n2. Scan Address\r\n3. Select PAP Camo In Combo Box\r\n4. Set The Camo";
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button3.Location = new global::System.Drawing.Point(323, 247);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(200, 29);
			this.button3.TabIndex = 187;
			this.button3.Text = "SET CAMO";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click_1);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button2.Location = new global::System.Drawing.Point(109, 247);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(200, 29);
			this.button2.TabIndex = 187;
			this.button2.Text = "SCAN ADDRESS";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click_2);
			this.outputBox.BackColor = global::System.Drawing.Color.Transparent;
			this.outputBox.BorderColor = global::System.Drawing.Color.White;
			this.outputBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.outputBox.DefaultText = "";
			this.outputBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.outputBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.outputBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.outputBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.outputBox.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.outputBox.FocusedState.BorderColor = global::System.Drawing.Color.White;
			this.outputBox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.outputBox.ForeColor = global::System.Drawing.Color.White;
			this.outputBox.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.outputBox.Location = new global::System.Drawing.Point(109, 188);
			this.outputBox.Name = "outputBox";
			this.outputBox.PasswordChar = '\0';
			this.outputBox.PlaceholderText = "";
			this.outputBox.SelectedText = "";
			this.outputBox.Size = new global::System.Drawing.Size(200, 36);
			this.outputBox.TabIndex = 13;
			this.outputBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.comboBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.comboBox2.BorderColor = global::System.Drawing.Color.White;
			this.comboBox2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.comboBox2.FocusedColor = global::System.Drawing.Color.White;
			this.comboBox2.FocusedState.BorderColor = global::System.Drawing.Color.White;
			this.comboBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.comboBox2.ForeColor = global::System.Drawing.Color.White;
			this.comboBox2.HoverState.BorderColor = global::System.Drawing.Color.White;
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
			this.comboBox2.Location = new global::System.Drawing.Point(323, 188);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(200, 36);
			this.comboBox2.StartIndex = 0;
			this.comboBox2.TabIndex = 12;
			this.comboBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(179, 167);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(62, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Output:";
			this.label25.AutoSize = true;
			this.label25.BackColor = global::System.Drawing.Color.Transparent;
			this.label25.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label25.ForeColor = global::System.Drawing.Color.White;
			this.label25.Location = new global::System.Drawing.Point(375, 167);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(102, 17);
			this.label25.TabIndex = 10;
			this.label25.Text = "Select Camo:";
			this.CloseBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.CloseBtn.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.CloseBtn.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("CloseBtn.BackgroundImage");
			this.CloseBtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.CloseBtn.BorderColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.BorderRadius = 10;
			this.CloseBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.BorderColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.FillColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.IconColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.HoveredState.Parent = this.CloseBtn;
			this.CloseBtn.IconColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.Location = new global::System.Drawing.Point(609, 5);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.PressedColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
			this.CloseBtn.Size = new global::System.Drawing.Size(30, 30);
			this.CloseBtn.TabIndex = 50;
			this.CloseBtn.Click += new global::System.EventHandler(this.CloseBtn_Click);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel2.Controls.Add(this.label24);
			this.panel2.Location = new global::System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(601, 41);
			this.panel2.TabIndex = 80;
			this.panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			this.panel2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
			this.label24.AutoSize = true;
			this.label24.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.label24.Font = new global::System.Drawing.Font("Arial Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label24.ForeColor = global::System.Drawing.Color.White;
			this.label24.Location = new global::System.Drawing.Point(84, 5);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(460, 30);
			this.label24.TabIndex = 79;
			this.label24.Text = "PINEAPPLE SERVICES | COLD WAR AIO";
			this.label24.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.label24.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			this.label24.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
			this.siticoneButton10.ButtonMode = 1;
			this.siticoneButton10.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton10.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton10.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton10.CheckedState.Parent = this.siticoneButton10;
			this.siticoneButton10.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.siticoneButton10.CustomImages.Parent = this.siticoneButton10;
			this.siticoneButton10.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton10.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton10.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton10.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton10.DisabledState.Parent = this.siticoneButton10;
			this.siticoneButton10.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton10.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton10.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton10.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton10.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton10.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton10.HoverState.Parent = this.siticoneButton10;
			this.siticoneButton10.Location = new global::System.Drawing.Point(472, 41);
			this.siticoneButton10.Name = "siticoneButton10";
			this.siticoneButton10.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton10.ShadowDecoration.Parent = this.siticoneButton10;
			this.siticoneButton10.Size = new global::System.Drawing.Size(158, 45);
			this.siticoneButton10.TabIndex = 83;
			this.siticoneButton10.Text = "PACK-A-PUNCH";
			this.siticoneButton10.Click += new global::System.EventHandler(this.siticoneButton10_Click);
			this.siticoneButton9.ButtonMode = 1;
			this.siticoneButton9.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton9.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton9.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton9.CheckedState.Parent = this.siticoneButton9;
			this.siticoneButton9.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.siticoneButton9.CustomImages.Parent = this.siticoneButton9;
			this.siticoneButton9.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton9.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton9.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton9.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton9.DisabledState.Parent = this.siticoneButton9;
			this.siticoneButton9.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton9.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton9.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton9.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton9.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton9.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton9.HoverState.Parent = this.siticoneButton9;
			this.siticoneButton9.Location = new global::System.Drawing.Point(316, 41);
			this.siticoneButton9.Name = "siticoneButton9";
			this.siticoneButton9.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton9.ShadowDecoration.Parent = this.siticoneButton9;
			this.siticoneButton9.Size = new global::System.Drawing.Size(158, 45);
			this.siticoneButton9.TabIndex = 83;
			this.siticoneButton9.Text = "INSTANT DA";
			this.siticoneButton9.Click += new global::System.EventHandler(this.siticoneButton9_Click);
			this.siticoneButton8.ButtonMode = 1;
			this.siticoneButton8.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton8.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton8.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton8.CheckedState.Parent = this.siticoneButton8;
			this.siticoneButton8.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.siticoneButton8.CustomImages.Parent = this.siticoneButton8;
			this.siticoneButton8.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton8.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton8.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton8.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton8.DisabledState.Parent = this.siticoneButton8;
			this.siticoneButton8.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton8.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton8.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton8.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton8.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton8.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton8.HoverState.Parent = this.siticoneButton8;
			this.siticoneButton8.Location = new global::System.Drawing.Point(158, 41);
			this.siticoneButton8.Name = "siticoneButton8";
			this.siticoneButton8.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton8.ShadowDecoration.Parent = this.siticoneButton8;
			this.siticoneButton8.Size = new global::System.Drawing.Size(158, 45);
			this.siticoneButton8.TabIndex = 83;
			this.siticoneButton8.Text = "CW ZOMBIES";
			this.siticoneButton8.Click += new global::System.EventHandler(this.siticoneButton8_Click);
			this.siticoneButton7.ButtonMode = 1;
			this.siticoneButton7.Checked = true;
			this.siticoneButton7.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton7.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton7.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton7.CheckedState.Parent = this.siticoneButton7;
			this.siticoneButton7.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.siticoneButton7.CustomImages.Parent = this.siticoneButton7;
			this.siticoneButton7.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton7.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton7.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton7.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton7.DisabledState.Parent = this.siticoneButton7;
			this.siticoneButton7.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton7.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton7.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton7.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton7.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton7.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton7.HoverState.Parent = this.siticoneButton7;
			this.siticoneButton7.Location = new global::System.Drawing.Point(0, 41);
			this.siticoneButton7.Name = "siticoneButton7";
			this.siticoneButton7.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton7.ShadowDecoration.Parent = this.siticoneButton7;
			this.siticoneButton7.Size = new global::System.Drawing.Size(158, 45);
			this.siticoneButton7.TabIndex = 83;
			this.siticoneButton7.Text = "HOME";
			this.siticoneButton7.Click += new global::System.EventHandler(this.siticoneButton7_Click_1);
			this.siticoneButton6.ButtonMode = 1;
			this.siticoneButton6.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton6.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton6.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton6.CheckedState.Parent = this.siticoneButton6;
			this.siticoneButton6.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 3, 0);
			this.siticoneButton6.CustomImages.Parent = this.siticoneButton6;
			this.siticoneButton6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton6.DisabledState.Parent = this.siticoneButton6;
			this.siticoneButton6.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton6.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton6.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton6.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton6.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton6.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton6.HoverState.Parent = this.siticoneButton6;
			this.siticoneButton6.Location = new global::System.Drawing.Point(0, 356);
			this.siticoneButton6.Name = "siticoneButton6";
			this.siticoneButton6.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton6.ShadowDecoration.Parent = this.siticoneButton6;
			this.siticoneButton6.Size = new global::System.Drawing.Size(82, 45);
			this.siticoneButton6.TabIndex = 63;
			this.siticoneButton6.Text = "PLAYER 4";
			this.siticoneButton6.Click += new global::System.EventHandler(this.siticoneButton6_Click_1);
			this.siticoneButton5.ButtonMode = 1;
			this.siticoneButton5.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton5.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton5.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
			this.siticoneButton5.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 3, 0);
			this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
			this.siticoneButton5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton5.DisabledState.Parent = this.siticoneButton5;
			this.siticoneButton5.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton5.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton5.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton5.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton5.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton5.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton5.HoverState.Parent = this.siticoneButton5;
			this.siticoneButton5.Location = new global::System.Drawing.Point(0, 311);
			this.siticoneButton5.Name = "siticoneButton5";
			this.siticoneButton5.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
			this.siticoneButton5.Size = new global::System.Drawing.Size(82, 45);
			this.siticoneButton5.TabIndex = 63;
			this.siticoneButton5.Text = "PLAYER 3";
			this.siticoneButton5.Click += new global::System.EventHandler(this.siticoneButton5_Click_1);
			this.siticoneButton4.ButtonMode = 1;
			this.siticoneButton4.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton4.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton4.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
			this.siticoneButton4.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 3, 0);
			this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
			this.siticoneButton4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton4.DisabledState.Parent = this.siticoneButton4;
			this.siticoneButton4.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton4.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton4.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton4.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton4.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton4.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton4.HoverState.Parent = this.siticoneButton4;
			this.siticoneButton4.Location = new global::System.Drawing.Point(0, 266);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new global::System.Drawing.Size(82, 45);
			this.siticoneButton4.TabIndex = 63;
			this.siticoneButton4.Text = "PLAYER 2";
			this.siticoneButton4.Click += new global::System.EventHandler(this.siticoneButton4_Click_1);
			this.siticoneButton3.ButtonMode = 1;
			this.siticoneButton3.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton3.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton3.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
			this.siticoneButton3.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 3, 0);
			this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
			this.siticoneButton3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton3.DisabledState.Parent = this.siticoneButton3;
			this.siticoneButton3.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton3.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton3.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton3.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton3.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton3.HoverState.Parent = this.siticoneButton3;
			this.siticoneButton3.Location = new global::System.Drawing.Point(0, 221);
			this.siticoneButton3.Name = "siticoneButton3";
			this.siticoneButton3.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
			this.siticoneButton3.Size = new global::System.Drawing.Size(82, 45);
			this.siticoneButton3.TabIndex = 63;
			this.siticoneButton3.Text = "PLAYER 1";
			this.siticoneButton3.Click += new global::System.EventHandler(this.siticoneButton3_Click_1);
			this.siticoneButton2.ButtonMode = 1;
			this.siticoneButton2.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton2.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton2.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 3, 0);
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
			this.siticoneButton2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton2.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton2.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton2.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton2.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
			this.siticoneButton2.Location = new global::System.Drawing.Point(0, 176);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new global::System.Drawing.Size(82, 45);
			this.siticoneButton2.TabIndex = 63;
			this.siticoneButton2.Text = "ALL PLAYERS";
			this.siticoneButton2.Click += new global::System.EventHandler(this.siticoneButton2_Click_1);
			this.siticoneButton1.ButtonMode = 1;
			this.siticoneButton1.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.siticoneButton1.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton1.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 3, 0);
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.siticoneButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.siticoneButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton1.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton1.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton1.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneButton1.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new global::System.Drawing.Point(0, 131);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.PressedColor = global::System.Drawing.Color.Empty;
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new global::System.Drawing.Size(82, 45);
			this.siticoneButton1.TabIndex = 63;
			this.siticoneButton1.Text = "GLOBAL";
			this.siticoneButton1.Click += new global::System.EventHandler(this.siticoneButton1_Click_1);
			this.HomeBtn.ButtonMode = 1;
			this.HomeBtn.Checked = true;
			this.HomeBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.White;
			this.HomeBtn.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.CheckedState.Parent = this.HomeBtn;
			this.HomeBtn.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 3, 0);
			this.HomeBtn.CustomImages.Parent = this.HomeBtn;
			this.HomeBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.HomeBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.HomeBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.HomeBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.HomeBtn.DisabledState.Parent = this.HomeBtn;
			this.HomeBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HomeBtn.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.HoverState.Parent = this.HomeBtn;
			this.HomeBtn.Location = new global::System.Drawing.Point(0, 86);
			this.HomeBtn.Name = "HomeBtn";
			this.HomeBtn.PressedColor = global::System.Drawing.Color.Empty;
			this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
			this.HomeBtn.Size = new global::System.Drawing.Size(82, 45);
			this.HomeBtn.TabIndex = 63;
			this.HomeBtn.Text = "HOME";
			this.HomeBtn.Click += new global::System.EventHandler(this.HomeBtn_Click_1);
			this.a1.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.a1.Controls.Add(this.label27);
			this.a1.Location = new global::System.Drawing.Point(84, 86);
			this.a1.Name = "a1";
			this.a1.Size = new global::System.Drawing.Size(548, 315);
			this.a1.TabIndex = 15;
			this.label27.AutoSize = true;
			this.label27.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label27.ForeColor = global::System.Drawing.Color.White;
			this.label27.Location = new global::System.Drawing.Point(82, 149);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(384, 16);
			this.label27.TabIndex = 0;
			this.label27.Text = "Welcome To FRENZY SERVICES COLD WAR ZOMBIES TOOL";
			this.label27.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.a2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.a2.Controls.Add(this.button6);
			this.a2.Controls.Add(this.button7);
			this.a2.Controls.Add(this.button4);
			this.a2.Controls.Add(this.button5);
			this.a2.Controls.Add(this.button8);
			this.a2.Controls.Add(this.siticoneTrackBar1);
			this.a2.Controls.Add(this.label5);
			this.a2.Controls.Add(this.label21);
			this.a2.Controls.Add(this.siticoneToggleSwitch2);
			this.a2.Controls.Add(this.siticoneToggleSwitch1);
			this.a2.Controls.Add(this.SpeedTrackBar);
			this.a2.Controls.Add(this.label9);
			this.a2.Controls.Add(this.label2);
			this.a2.Controls.Add(this.PlayerSpeedValue);
			this.a2.Controls.Add(this.label29);
			this.a2.Controls.Add(this.label1);
			this.a2.Controls.Add(this.ToggleDCamo);
			this.a2.Controls.Add(this.ZombieTPDistTrackBar);
			this.a2.Controls.Add(this.label3);
			this.a2.Controls.Add(this.OneShotZombiesChk);
			this.a2.Controls.Add(this.WeaponCycleIntervalTrackBar);
			this.a2.Controls.Add(this.TPZombie);
			this.a2.Controls.Add(this.label8);
			this.a2.Controls.Add(this.TPZC);
			this.a2.Controls.Add(this.TPCLbl);
			this.a2.Controls.Add(this.label7);
			this.a2.Controls.Add(this.ToggleSPEED);
			this.a2.Controls.Add(this.TPValue);
			this.a2.Controls.Add(this.CycleValue);
			this.a2.Location = new global::System.Drawing.Point(84, 86);
			this.a2.Name = "a2";
			this.a2.Size = new global::System.Drawing.Size(548, 315);
			this.a2.TabIndex = 16;
			this.a2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.a2_Paint);
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.button6.ForeColor = global::System.Drawing.Color.White;
			this.button6.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button6.Location = new global::System.Drawing.Point(15, 32);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(145, 29);
			this.button6.TabIndex = 206;
			this.button6.Text = "NO GRAVITY";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click_1);
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.button7.ForeColor = global::System.Drawing.Color.White;
			this.button7.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button7.Location = new global::System.Drawing.Point(15, 63);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(145, 29);
			this.button7.TabIndex = 205;
			this.button7.Text = "SAFE END MATCH";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click_1);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.button4.ForeColor = global::System.Drawing.Color.White;
			this.button4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button4.Location = new global::System.Drawing.Point(166, 63);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(217, 29);
			this.button4.TabIndex = 204;
			this.button4.Text = "ENABLE KILL MULTIPLIER";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_1);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.button5.ForeColor = global::System.Drawing.Color.White;
			this.button5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button5.Location = new global::System.Drawing.Point(389, 32);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(145, 29);
			this.button5.TabIndex = 203;
			this.button5.Text = "FREEZE MYSTERY BOX";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click_1);
			this.button8.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.button8.ForeColor = global::System.Drawing.Color.White;
			this.button8.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button8.Location = new global::System.Drawing.Point(389, 63);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(145, 29);
			this.button8.TabIndex = 202;
			this.button8.Text = "INSTANT 1000";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click_1);
			this.siticoneTrackBar1.Enabled = false;
			this.siticoneTrackBar1.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.siticoneTrackBar1.HoverState.Parent = this.siticoneTrackBar1;
			this.siticoneTrackBar1.LargeChange = 2;
			this.siticoneTrackBar1.Location = new global::System.Drawing.Point(163, 179);
			this.siticoneTrackBar1.Maximum = 15;
			this.siticoneTrackBar1.Minimum = 1;
			this.siticoneTrackBar1.Name = "siticoneTrackBar1";
			this.siticoneTrackBar1.Size = new global::System.Drawing.Size(301, 23);
			this.siticoneTrackBar1.Style = 1;
			this.siticoneTrackBar1.TabIndex = 200;
			this.siticoneTrackBar1.ThumbColor = global::System.Drawing.Color.White;
			this.siticoneTrackBar1.Value = 1;
			this.siticoneTrackBar1.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
			this.label5.AutoSize = true;
			this.label5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new global::System.Drawing.Point(97, 180);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(47, 16);
			this.label5.TabIndex = 199;
			this.label5.Text = "JUMP";
			this.label21.AutoSize = true;
			this.label21.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label21.ForeColor = global::System.Drawing.Color.White;
			this.label21.Location = new global::System.Drawing.Point(483, 180);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(15, 16);
			this.label21.TabIndex = 201;
			this.label21.Text = "1";
			this.siticoneToggleSwitch2.CheckedState.BorderRadius = 10;
			this.siticoneToggleSwitch2.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.siticoneToggleSwitch2.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneToggleSwitch2.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneToggleSwitch2.CheckedState.Parent = this.siticoneToggleSwitch2;
			this.siticoneToggleSwitch2.Location = new global::System.Drawing.Point(57, 179);
			this.siticoneToggleSwitch2.Name = "siticoneToggleSwitch2";
			this.siticoneToggleSwitch2.ShadowDecoration.BorderRadius = 0;
			this.siticoneToggleSwitch2.ShadowDecoration.Parent = this.siticoneToggleSwitch2;
			this.siticoneToggleSwitch2.Size = new global::System.Drawing.Size(35, 20);
			this.siticoneToggleSwitch2.TabIndex = 198;
			this.siticoneToggleSwitch2.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.siticoneToggleSwitch2.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.siticoneToggleSwitch2.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneToggleSwitch2.UncheckedState.Parent = this.siticoneToggleSwitch2;
			this.siticoneToggleSwitch2.CheckedChanged += new global::System.EventHandler(this.siticoneToggleSwitch2_CheckedChanged);
			this.siticoneToggleSwitch1.CheckedState.BorderRadius = 10;
			this.siticoneToggleSwitch1.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.siticoneToggleSwitch1.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneToggleSwitch1.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneToggleSwitch1.CheckedState.Parent = this.siticoneToggleSwitch1;
			this.siticoneToggleSwitch1.Location = new global::System.Drawing.Point(268, 138);
			this.siticoneToggleSwitch1.Name = "siticoneToggleSwitch1";
			this.siticoneToggleSwitch1.ShadowDecoration.BorderRadius = 0;
			this.siticoneToggleSwitch1.ShadowDecoration.Parent = this.siticoneToggleSwitch1;
			this.siticoneToggleSwitch1.Size = new global::System.Drawing.Size(35, 20);
			this.siticoneToggleSwitch1.TabIndex = 197;
			this.siticoneToggleSwitch1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.siticoneToggleSwitch1.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.siticoneToggleSwitch1.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.siticoneToggleSwitch1.UncheckedState.Parent = this.siticoneToggleSwitch1;
			this.siticoneToggleSwitch1.CheckedChanged += new global::System.EventHandler(this.siticoneToggleSwitch1_CheckedChanged);
			this.SpeedTrackBar.Enabled = false;
			this.SpeedTrackBar.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.SpeedTrackBar.HoverState.Parent = this.SpeedTrackBar;
			this.SpeedTrackBar.LargeChange = 2;
			this.SpeedTrackBar.Location = new global::System.Drawing.Point(163, 209);
			this.SpeedTrackBar.Maximum = 15;
			this.SpeedTrackBar.Minimum = 1;
			this.SpeedTrackBar.Name = "SpeedTrackBar";
			this.SpeedTrackBar.Size = new global::System.Drawing.Size(301, 23);
			this.SpeedTrackBar.Style = 1;
			this.SpeedTrackBar.TabIndex = 179;
			this.SpeedTrackBar.ThumbColor = global::System.Drawing.Color.White;
			this.SpeedTrackBar.Value = 1;
			this.SpeedTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.SpeedTrackBar_Scroll);
			this.label9.AutoSize = true;
			this.label9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new global::System.Drawing.Point(97, 210);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(53, 16);
			this.label9.TabIndex = 178;
			this.label9.Text = "SPEED";
			this.label2.AutoSize = true;
			this.label2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(197, 5);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(155, 18);
			this.label2.TabIndex = 185;
			this.label2.Text = "LOBBY COMMANDS";
			this.PlayerSpeedValue.AutoSize = true;
			this.PlayerSpeedValue.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.PlayerSpeedValue.ForeColor = global::System.Drawing.Color.White;
			this.PlayerSpeedValue.Location = new global::System.Drawing.Point(483, 210);
			this.PlayerSpeedValue.Name = "PlayerSpeedValue";
			this.PlayerSpeedValue.Size = new global::System.Drawing.Size(15, 16);
			this.PlayerSpeedValue.TabIndex = 182;
			this.PlayerSpeedValue.Text = "1";
			this.label29.AutoSize = true;
			this.label29.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label29.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label29.ForeColor = global::System.Drawing.Color.White;
			this.label29.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label29.Location = new global::System.Drawing.Point(307, 140);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(227, 16);
			this.label29.TabIndex = 176;
			this.label29.Text = "PANIC AT THE DISCO (RETICLES)";
			this.label1.AutoSize = true;
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(307, 111);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(212, 16);
			this.label1.TabIndex = 176;
			this.label1.Text = "PANIC AT THE DISCO (CAMOS)";
			this.ToggleDCamo.CheckedState.BorderRadius = 10;
			this.ToggleDCamo.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ToggleDCamo.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleDCamo.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleDCamo.CheckedState.Parent = this.ToggleDCamo;
			this.ToggleDCamo.Location = new global::System.Drawing.Point(268, 108);
			this.ToggleDCamo.Name = "ToggleDCamo";
			this.ToggleDCamo.ShadowDecoration.BorderRadius = 0;
			this.ToggleDCamo.ShadowDecoration.Parent = this.ToggleDCamo;
			this.ToggleDCamo.Size = new global::System.Drawing.Size(35, 20);
			this.ToggleDCamo.TabIndex = 175;
			this.ToggleDCamo.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ToggleDCamo.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ToggleDCamo.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleDCamo.UncheckedState.Parent = this.ToggleDCamo;
			this.ToggleDCamo.CheckedChanged += new global::System.EventHandler(this.DiscoCamosChk_CheckedChanged);
			this.ZombieTPDistTrackBar.Enabled = false;
			this.ZombieTPDistTrackBar.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.ZombieTPDistTrackBar.HoverState.Parent = this.ZombieTPDistTrackBar;
			this.ZombieTPDistTrackBar.Location = new global::System.Drawing.Point(156, 239);
			this.ZombieTPDistTrackBar.Maximum = 500;
			this.ZombieTPDistTrackBar.Minimum = 25;
			this.ZombieTPDistTrackBar.Name = "ZombieTPDistTrackBar";
			this.ZombieTPDistTrackBar.Size = new global::System.Drawing.Size(301, 23);
			this.ZombieTPDistTrackBar.Style = 1;
			this.ZombieTPDistTrackBar.TabIndex = 110;
			this.ZombieTPDistTrackBar.ThumbColor = global::System.Drawing.Color.White;
			this.ZombieTPDistTrackBar.Value = 150;
			this.ZombieTPDistTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.TPZCDistance_Scroll);
			this.label3.AutoSize = true;
			this.label3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new global::System.Drawing.Point(62, 138);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(147, 16);
			this.label3.TabIndex = 98;
			this.label3.Text = "ONE SHOT ONE KILL";
			this.OneShotZombiesChk.CheckedState.BorderRadius = 10;
			this.OneShotZombiesChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.OneShotZombiesChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.OneShotZombiesChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.OneShotZombiesChk.CheckedState.Parent = this.OneShotZombiesChk;
			this.OneShotZombiesChk.Location = new global::System.Drawing.Point(23, 136);
			this.OneShotZombiesChk.Name = "OneShotZombiesChk";
			this.OneShotZombiesChk.ShadowDecoration.BorderRadius = 0;
			this.OneShotZombiesChk.ShadowDecoration.Parent = this.OneShotZombiesChk;
			this.OneShotZombiesChk.Size = new global::System.Drawing.Size(35, 20);
			this.OneShotZombiesChk.TabIndex = 97;
			this.OneShotZombiesChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.OneShotZombiesChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.OneShotZombiesChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.OneShotZombiesChk.UncheckedState.Parent = this.OneShotZombiesChk;
			this.WeaponCycleIntervalTrackBar.Enabled = false;
			this.WeaponCycleIntervalTrackBar.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.WeaponCycleIntervalTrackBar.HoverState.Parent = this.WeaponCycleIntervalTrackBar;
			this.WeaponCycleIntervalTrackBar.Location = new global::System.Drawing.Point(176, 268);
			this.WeaponCycleIntervalTrackBar.Maximum = 10;
			this.WeaponCycleIntervalTrackBar.Minimum = 2;
			this.WeaponCycleIntervalTrackBar.Name = "WeaponCycleIntervalTrackBar";
			this.WeaponCycleIntervalTrackBar.Size = new global::System.Drawing.Size(301, 23);
			this.WeaponCycleIntervalTrackBar.Style = 1;
			this.WeaponCycleIntervalTrackBar.TabIndex = 112;
			this.WeaponCycleIntervalTrackBar.ThumbColor = global::System.Drawing.Color.White;
			this.WeaponCycleIntervalTrackBar.Value = 2;
			this.WeaponCycleIntervalTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.WeaponCycleIntervalTrackBar_Scroll);
			this.TPZombie.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.TPZombie.FlatAppearance.BorderSize = 0;
			this.TPZombie.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TPZombie.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.TPZombie.ForeColor = global::System.Drawing.Color.White;
			this.TPZombie.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TPZombie.Location = new global::System.Drawing.Point(166, 32);
			this.TPZombie.Name = "TPZombie";
			this.TPZombie.Size = new global::System.Drawing.Size(217, 29);
			this.TPZombie.TabIndex = 93;
			this.TPZombie.Text = "SET ZOMBIE SPAWN";
			this.TPZombie.UseVisualStyleBackColor = false;
			this.TPZombie.Click += new global::System.EventHandler(this.TPZL_Click);
			this.label8.AutoSize = true;
			this.label8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new global::System.Drawing.Point(45, 273);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(119, 16);
			this.label8.TabIndex = 111;
			this.label8.Text = "WEAPON CYCLE";
			this.TPZC.CheckedState.BorderRadius = 10;
			this.TPZC.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.TPZC.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TPZC.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TPZC.CheckedState.Parent = this.TPZC;
			this.TPZC.Location = new global::System.Drawing.Point(23, 108);
			this.TPZC.Name = "TPZC";
			this.TPZC.ShadowDecoration.BorderRadius = 0;
			this.TPZC.ShadowDecoration.Parent = this.TPZC;
			this.TPZC.Size = new global::System.Drawing.Size(35, 20);
			this.TPZC.TabIndex = 101;
			this.TPZC.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.TPZC.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.TPZC.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TPZC.UncheckedState.Parent = this.TPZC;
			this.TPZC.CheckedChanged += new global::System.EventHandler(this.TPZC_CheckedChanged);
			this.TPCLbl.AutoSize = true;
			this.TPCLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TPCLbl.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.TPCLbl.ForeColor = global::System.Drawing.Color.White;
			this.TPCLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TPCLbl.Location = new global::System.Drawing.Point(60, 109);
			this.TPCLbl.Name = "TPCLbl";
			this.TPCLbl.Size = new global::System.Drawing.Size(165, 16);
			this.TPCLbl.TabIndex = 102;
			this.TPCLbl.Text = "TELEPORT CROSSHAIR";
			this.label7.AutoSize = true;
			this.label7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new global::System.Drawing.Point(49, 240);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(96, 16);
			this.label7.TabIndex = 109;
			this.label7.Text = "TP DISTANCE";
			this.ToggleSPEED.CheckedState.BorderRadius = 10;
			this.ToggleSPEED.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ToggleSPEED.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleSPEED.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleSPEED.CheckedState.Parent = this.ToggleSPEED;
			this.ToggleSPEED.Location = new global::System.Drawing.Point(57, 209);
			this.ToggleSPEED.Name = "ToggleSPEED";
			this.ToggleSPEED.ShadowDecoration.BorderRadius = 0;
			this.ToggleSPEED.ShadowDecoration.Parent = this.ToggleSPEED;
			this.ToggleSPEED.Size = new global::System.Drawing.Size(35, 20);
			this.ToggleSPEED.TabIndex = 177;
			this.ToggleSPEED.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ToggleSPEED.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ToggleSPEED.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleSPEED.UncheckedState.Parent = this.ToggleSPEED;
			this.ToggleSPEED.CheckedChanged += new global::System.EventHandler(this.SpeedToggle_CheckedChanged);
			this.TPValue.AutoSize = true;
			this.TPValue.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.TPValue.ForeColor = global::System.Drawing.Color.White;
			this.TPValue.Location = new global::System.Drawing.Point(467, 241);
			this.TPValue.Name = "TPValue";
			this.TPValue.Size = new global::System.Drawing.Size(31, 16);
			this.TPValue.TabIndex = 183;
			this.TPValue.Text = "150";
			this.CycleValue.AutoSize = true;
			this.CycleValue.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.CycleValue.ForeColor = global::System.Drawing.Color.White;
			this.CycleValue.Location = new global::System.Drawing.Point(487, 273);
			this.CycleValue.Name = "CycleValue";
			this.CycleValue.Size = new global::System.Drawing.Size(15, 16);
			this.CycleValue.TabIndex = 184;
			this.CycleValue.Text = "2";
			this.a3.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.a3.Controls.Add(this.PlayerAllOptionsPnl);
			this.a3.Controls.Add(this.WeaponSelectorCombo);
			this.a3.Controls.Add(this.TeleportSelectorCombo);
			this.a3.Controls.Add(this.Player1OptionsPnl);
			this.a3.Controls.Add(this.Player2OptionsPnl);
			this.a3.Controls.Add(this.Player3OptionsPnl);
			this.a3.Controls.Add(this.Player4OptionsPnl);
			this.a3.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.a3.Location = new global::System.Drawing.Point(84, 86);
			this.a3.Name = "a3";
			this.a3.Size = new global::System.Drawing.Size(548, 315);
			this.a3.TabIndex = 16;
			this.PlayerAllOptionsPnl.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLAFKDA);
			this.PlayerAllOptionsPnl.Controls.Add(this.label10);
			this.PlayerAllOptionsPnl.Controls.Add(this.KillAll);
			this.PlayerAllOptionsPnl.Controls.Add(this.ZMCountLbl);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLGod);
			this.PlayerAllOptionsPnl.Controls.Add(this.TPAllMe);
			this.PlayerAllOptionsPnl.Controls.Add(this.label14);
			this.PlayerAllOptionsPnl.Controls.Add(this.textBox2);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLRapidFire);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLAmmo);
			this.PlayerAllOptionsPnl.Controls.Add(this.label6);
			this.PlayerAllOptionsPnl.Controls.Add(this.label13);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLFreeze);
			this.PlayerAllOptionsPnl.Controls.Add(this.label15);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLCritical);
			this.PlayerAllOptionsPnl.Controls.Add(this.label11);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLPoints);
			this.PlayerAllOptionsPnl.Controls.Add(this.label12);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLCycle);
			this.PlayerAllOptionsPnl.Controls.Add(this.label16);
			this.PlayerAllOptionsPnl.Location = new global::System.Drawing.Point(0, 0);
			this.PlayerAllOptionsPnl.Name = "PlayerAllOptionsPnl";
			this.PlayerAllOptionsPnl.Size = new global::System.Drawing.Size(548, 315);
			this.PlayerAllOptionsPnl.TabIndex = 141;
			this.ALLAFKDA.CheckedState.BorderRadius = 10;
			this.ALLAFKDA.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLAFKDA.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLAFKDA.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLAFKDA.CheckedState.Parent = this.ALLAFKDA;
			this.ALLAFKDA.Location = new global::System.Drawing.Point(307, 239);
			this.ALLAFKDA.Name = "ALLAFKDA";
			this.ALLAFKDA.ShadowDecoration.BorderRadius = 0;
			this.ALLAFKDA.ShadowDecoration.Parent = this.ALLAFKDA;
			this.ALLAFKDA.Size = new global::System.Drawing.Size(35, 20);
			this.ALLAFKDA.TabIndex = 191;
			this.ALLAFKDA.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLAFKDA.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLAFKDA.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLAFKDA.UncheckedState.Parent = this.ALLAFKDA;
			this.ALLAFKDA.CheckedChanged += new global::System.EventHandler(this.ALLAFKDA_CheckedChanged);
			this.label10.AutoSize = true;
			this.label10.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label10.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new global::System.Drawing.Point(348, 241);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(128, 19);
			this.label10.TabIndex = 192;
			this.label10.Text = "AFK XP LOBBY";
			this.KillAll.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.KillAll.FlatAppearance.BorderSize = 0;
			this.KillAll.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.KillAll.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.KillAll.ForeColor = global::System.Drawing.Color.White;
			this.KillAll.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.KillAll.Location = new global::System.Drawing.Point(237, 39);
			this.KillAll.Name = "KillAll";
			this.KillAll.Size = new global::System.Drawing.Size(188, 29);
			this.KillAll.TabIndex = 190;
			this.KillAll.Text = "TP ALL TO JAIL";
			this.KillAll.UseVisualStyleBackColor = false;
			this.KillAll.Click += new global::System.EventHandler(this.TPAllToJailBtn);
			this.ZMCountLbl.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ZMCountLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ZMCountLbl.Font = new global::System.Drawing.Font("Arial Black", 7f, global::System.Drawing.FontStyle.Bold);
			this.ZMCountLbl.ForeColor = global::System.Drawing.Color.Red;
			this.ZMCountLbl.Location = new global::System.Drawing.Point(432, 33);
			this.ZMCountLbl.Multiline = true;
			this.ZMCountLbl.Name = "ZMCountLbl";
			this.ZMCountLbl.Size = new global::System.Drawing.Size(114, 18);
			this.ZMCountLbl.TabIndex = 142;
			this.ZMCountLbl.Text = "COUNT";
			this.ZMCountLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ALLGod.CheckedState.BorderRadius = 10;
			this.ALLGod.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLGod.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLGod.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLGod.CheckedState.Parent = this.ALLGod;
			this.ALLGod.Location = new global::System.Drawing.Point(60, 110);
			this.ALLGod.Name = "ALLGod";
			this.ALLGod.ShadowDecoration.BorderRadius = 0;
			this.ALLGod.ShadowDecoration.Parent = this.ALLGod;
			this.ALLGod.Size = new global::System.Drawing.Size(35, 20);
			this.ALLGod.TabIndex = 122;
			this.ALLGod.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLGod.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLGod.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLGod.UncheckedState.Parent = this.ALLGod;
			this.ALLGod.CheckedChanged += new global::System.EventHandler(this.ALLGod_CheckedChanged);
			this.TPAllMe.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.TPAllMe.FlatAppearance.BorderSize = 0;
			this.TPAllMe.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TPAllMe.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.TPAllMe.ForeColor = global::System.Drawing.Color.White;
			this.TPAllMe.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TPAllMe.Location = new global::System.Drawing.Point(28, 39);
			this.TPAllMe.Name = "TPAllMe";
			this.TPAllMe.Size = new global::System.Drawing.Size(188, 29);
			this.TPAllMe.TabIndex = 189;
			this.TPAllMe.Text = "TP ALL TO ME";
			this.TPAllMe.UseVisualStyleBackColor = false;
			this.TPAllMe.Click += new global::System.EventHandler(this.TPAllToMeBtn);
			this.label14.AutoSize = true;
			this.label14.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label14.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.ForeColor = global::System.Drawing.Color.White;
			this.label14.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label14.Location = new global::System.Drawing.Point(101, 198);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(149, 19);
			this.label14.TabIndex = 127;
			this.label14.Text = "UNLIMITED AMMO";
			this.textBox2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new global::System.Drawing.Font("Arial Black", 7f, global::System.Drawing.FontStyle.Bold);
			this.textBox2.ForeColor = global::System.Drawing.Color.White;
			this.textBox2.Location = new global::System.Drawing.Point(432, 18);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(114, 22);
			this.textBox2.TabIndex = 137;
			this.textBox2.Text = "ZOMBIES LEFT";
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ALLRapidFire.CheckedState.BorderRadius = 10;
			this.ALLRapidFire.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLRapidFire.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLRapidFire.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLRapidFire.CheckedState.Parent = this.ALLRapidFire;
			this.ALLRapidFire.Location = new global::System.Drawing.Point(60, 239);
			this.ALLRapidFire.Name = "ALLRapidFire";
			this.ALLRapidFire.ShadowDecoration.BorderRadius = 0;
			this.ALLRapidFire.ShadowDecoration.Parent = this.ALLRapidFire;
			this.ALLRapidFire.Size = new global::System.Drawing.Size(35, 20);
			this.ALLRapidFire.TabIndex = 128;
			this.ALLRapidFire.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLRapidFire.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLRapidFire.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLRapidFire.UncheckedState.Parent = this.ALLRapidFire;
			this.ALLRapidFire.CheckedChanged += new global::System.EventHandler(this.ALLRapidFire_CheckedChanged);
			this.ALLAmmo.CheckedState.BorderRadius = 10;
			this.ALLAmmo.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLAmmo.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLAmmo.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLAmmo.CheckedState.Parent = this.ALLAmmo;
			this.ALLAmmo.Location = new global::System.Drawing.Point(60, 196);
			this.ALLAmmo.Name = "ALLAmmo";
			this.ALLAmmo.ShadowDecoration.BorderRadius = 0;
			this.ALLAmmo.ShadowDecoration.Parent = this.ALLAmmo;
			this.ALLAmmo.Size = new global::System.Drawing.Size(35, 20);
			this.ALLAmmo.TabIndex = 126;
			this.ALLAmmo.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLAmmo.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLAmmo.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLAmmo.UncheckedState.Parent = this.ALLAmmo;
			this.ALLAmmo.CheckedChanged += new global::System.EventHandler(this.ALLAmmo_CheckedChanged);
			this.label6.AutoSize = true;
			this.label6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new global::System.Drawing.Point(348, 155);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(107, 19);
			this.label6.TabIndex = 136;
			this.label6.Text = "FREEZE ALL";
			this.label13.AutoSize = true;
			this.label13.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label13.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.White;
			this.label13.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label13.Location = new global::System.Drawing.Point(101, 241);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(100, 19);
			this.label13.TabIndex = 129;
			this.label13.Text = "RAPID FIRE";
			this.ALLFreeze.CheckedState.BorderRadius = 10;
			this.ALLFreeze.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLFreeze.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLFreeze.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLFreeze.CheckedState.Parent = this.ALLFreeze;
			this.ALLFreeze.Location = new global::System.Drawing.Point(307, 153);
			this.ALLFreeze.Name = "ALLFreeze";
			this.ALLFreeze.ShadowDecoration.BorderRadius = 0;
			this.ALLFreeze.ShadowDecoration.Parent = this.ALLFreeze;
			this.ALLFreeze.Size = new global::System.Drawing.Size(35, 20);
			this.ALLFreeze.TabIndex = 135;
			this.ALLFreeze.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLFreeze.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLFreeze.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLFreeze.UncheckedState.Parent = this.ALLFreeze;
			this.ALLFreeze.CheckedChanged += new global::System.EventHandler(this.FreezeOthersChk_CheckedChanged);
			this.label15.AutoSize = true;
			this.label15.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label15.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.ForeColor = global::System.Drawing.Color.White;
			this.label15.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label15.Location = new global::System.Drawing.Point(101, 155);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(161, 19);
			this.label15.TabIndex = 125;
			this.label15.Text = "UNLIMITED POINTS";
			this.ALLCritical.CheckedState.BorderRadius = 10;
			this.ALLCritical.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLCritical.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLCritical.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLCritical.CheckedState.Parent = this.ALLCritical;
			this.ALLCritical.Location = new global::System.Drawing.Point(307, 110);
			this.ALLCritical.Name = "ALLCritical";
			this.ALLCritical.ShadowDecoration.BorderRadius = 0;
			this.ALLCritical.ShadowDecoration.Parent = this.ALLCritical;
			this.ALLCritical.Size = new global::System.Drawing.Size(35, 20);
			this.ALLCritical.TabIndex = 130;
			this.ALLCritical.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLCritical.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLCritical.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLCritical.UncheckedState.Parent = this.ALLCritical;
			this.ALLCritical.CheckedChanged += new global::System.EventHandler(this.ALLCritical_CheckedChanged);
			this.label11.AutoSize = true;
			this.label11.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label11.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label11.Location = new global::System.Drawing.Point(348, 198);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(140, 19);
			this.label11.TabIndex = 133;
			this.label11.Text = "WEAPON CYCLE";
			this.ALLPoints.CheckedState.BorderRadius = 10;
			this.ALLPoints.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLPoints.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLPoints.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLPoints.CheckedState.Parent = this.ALLPoints;
			this.ALLPoints.Location = new global::System.Drawing.Point(60, 153);
			this.ALLPoints.Name = "ALLPoints";
			this.ALLPoints.ShadowDecoration.BorderRadius = 0;
			this.ALLPoints.ShadowDecoration.Parent = this.ALLPoints;
			this.ALLPoints.Size = new global::System.Drawing.Size(35, 20);
			this.ALLPoints.TabIndex = 124;
			this.ALLPoints.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLPoints.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLPoints.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLPoints.UncheckedState.Parent = this.ALLPoints;
			this.ALLPoints.CheckedChanged += new global::System.EventHandler(this.ALLPoints_CheckedChanged);
			this.label12.AutoSize = true;
			this.label12.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label12.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.White;
			this.label12.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label12.Location = new global::System.Drawing.Point(348, 112);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(124, 19);
			this.label12.TabIndex = 131;
			this.label12.Text = "CRITICAL KILL";
			this.ALLCycle.CheckedState.BorderRadius = 10;
			this.ALLCycle.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.ALLCycle.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLCycle.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLCycle.CheckedState.Parent = this.ALLCycle;
			this.ALLCycle.Location = new global::System.Drawing.Point(307, 196);
			this.ALLCycle.Name = "ALLCycle";
			this.ALLCycle.ShadowDecoration.BorderRadius = 0;
			this.ALLCycle.ShadowDecoration.Parent = this.ALLCycle;
			this.ALLCycle.Size = new global::System.Drawing.Size(35, 20);
			this.ALLCycle.TabIndex = 132;
			this.ALLCycle.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.ALLCycle.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.ALLCycle.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ALLCycle.UncheckedState.Parent = this.ALLCycle;
			this.ALLCycle.CheckedChanged += new global::System.EventHandler(this.ALLCycle_CheckedChanged);
			this.label16.AutoSize = true;
			this.label16.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label16.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label16.Location = new global::System.Drawing.Point(101, 112);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(93, 19);
			this.label16.TabIndex = 123;
			this.label16.Text = "GODMODE";
			this.WeaponSelectorCombo.BackColor = global::System.Drawing.Color.Transparent;
			this.WeaponSelectorCombo.BorderColor = global::System.Drawing.Color.White;
			this.WeaponSelectorCombo.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.WeaponSelectorCombo.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WeaponSelectorCombo.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.WeaponSelectorCombo.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.WeaponSelectorCombo.FocusedColor = global::System.Drawing.Color.White;
			this.WeaponSelectorCombo.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.WeaponSelectorCombo.ForeColor = global::System.Drawing.Color.White;
			this.WeaponSelectorCombo.HoveredState.Parent = this.WeaponSelectorCombo;
			this.WeaponSelectorCombo.ItemHeight = 30;
			this.WeaponSelectorCombo.Items.AddRange(new object[]
			{
				"",
				"WEAPONS",
				"XM4",
				"AK47",
				"KRIG",
				"QBZ",
				"FFAR",
				"MP5",
				"MILANO",
				"AK74U",
				"KSP",
				"BULLFROG",
				"TYPE",
				"M16",
				"AUG",
				"STONER",
				"RPD",
				"M60",
				"PELLINGTON",
				"LW3",
				"M82",
				"1911",
				"MAGNUM",
				"DIAMATTI",
				"HAUER",
				"GALLO",
				"CIGMA",
				"RPG",
				"M79",
				"KNIFE",
				"GROZA",
				"FARA",
				"C58",
				"MAC10",
				"LC10",
				"PPSH",
				"OTS",
				"DMR",
				"CARV",
				"MG82",
				"ZRG",
				"SWISS",
				"AMP",
				"STREETSWEEPER",
				"WAKIZASHI",
				"SLEDGEHAMMER",
				"E-TOOL",
				"MACHETTE",
				"BALLISTIC KNIFE",
				"BASEBALL BAT",
				"MACE",
				"CANE",
				"SAI",
				"CROSSBOW",
				"NAILGUN",
				"MARSHAL",
				"EM2",
				"TEC-9",
				"410 IRONHIDE",
				"GRAV",
				"BATTLE AXE",
				"LAPA",
				"HAMMER & SICKLE",
				"Vargo",
				"RAYGUN",
				"RAI K",
				"CRBR-S BLAZER",
				"CRBR-S PISTOL",
				"CRBR-S DIFFUSER",
				"CHRYSALAX SAVAGER",
				"Unlimited Healing Aura",
				"Unlimited Energy Blast",
				"Zombies Advanced UAV",
				"RCXD",
				"Chopper Gunner",
				"Attack Helicopter",
				"Gunship v1",
				"Gunship v2",
				"Gunship v3",
				"Sentry Gun",
				"Strafe Run",
				"Attack Helicopter",
				"Drone Squad",
				"Napalm Strike",
				"BO4 Wraith Fire",
				"Snowball"
			});
			this.WeaponSelectorCombo.ItemsAppearance.Parent = this.WeaponSelectorCombo;
			this.WeaponSelectorCombo.Location = new global::System.Drawing.Point(285, 274);
			this.WeaponSelectorCombo.MaxDropDownItems = 10;
			this.WeaponSelectorCombo.Name = "WeaponSelectorCombo";
			this.WeaponSelectorCombo.ShadowDecoration.Parent = this.WeaponSelectorCombo;
			this.WeaponSelectorCombo.Size = new global::System.Drawing.Size(259, 36);
			this.WeaponSelectorCombo.StartIndex = 1;
			this.WeaponSelectorCombo.TabIndex = 67;
			this.WeaponSelectorCombo.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.WeaponSelectorCombo.SelectedIndexChanged += new global::System.EventHandler(this.WeaponSelectorCombo_SelectedIndexChanged);
			this.TeleportSelectorCombo.BackColor = global::System.Drawing.Color.Transparent;
			this.TeleportSelectorCombo.BorderColor = global::System.Drawing.Color.White;
			this.TeleportSelectorCombo.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.TeleportSelectorCombo.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TeleportSelectorCombo.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TeleportSelectorCombo.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TeleportSelectorCombo.FocusedColor = global::System.Drawing.Color.White;
			this.TeleportSelectorCombo.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.TeleportSelectorCombo.ForeColor = global::System.Drawing.Color.White;
			this.TeleportSelectorCombo.HoveredState.Parent = this.TeleportSelectorCombo;
			this.TeleportSelectorCombo.ItemHeight = 30;
			this.TeleportSelectorCombo.Items.AddRange(new object[]
			{
				"TELEPORT",
				"SPAWN",
				"LIVING ROOM",
				"POND",
				"TRUCK",
				"TUNNEL",
				"CONTROL ROOM",
				"TRIAL COMPUTER",
				"MEDICAL BAY",
				"MAIN POWER",
				"PACK A PUNCH",
				"PARTICLE ACCELERATOR",
				"WEAPONS LAB",
				"PERK MACHINE",
				"CRASH SITE",
				"TOP OF PLANE WING",
				"MYSTERY BOX POND",
				"MYSTERY BOX CRASH SITE",
				"MYSTERY BOX SPAWN",
				"MYSTERY BOX PARTICLE ACCELERATOR",
				"MYSTERY BOX MEDICAL BAY"
			});
			this.TeleportSelectorCombo.ItemsAppearance.Parent = this.TeleportSelectorCombo;
			this.TeleportSelectorCombo.Location = new global::System.Drawing.Point(4, 274);
			this.TeleportSelectorCombo.MaxDropDownItems = 10;
			this.TeleportSelectorCombo.Name = "TeleportSelectorCombo";
			this.TeleportSelectorCombo.ShadowDecoration.Parent = this.TeleportSelectorCombo;
			this.TeleportSelectorCombo.Size = new global::System.Drawing.Size(259, 36);
			this.TeleportSelectorCombo.StartIndex = 0;
			this.TeleportSelectorCombo.TabIndex = 143;
			this.TeleportSelectorCombo.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.TeleportSelectorCombo.SelectedIndexChanged += new global::System.EventHandler(this.TeleportSelectorCombo_SelectedIndexChanged);
			this.Player1OptionsPnl.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1OptionsPnl.Controls.Add(this.label17);
			this.Player1OptionsPnl.Controls.Add(this.Player1AFNRChk);
			this.Player1OptionsPnl.Controls.Add(this.P1Name);
			this.Player1OptionsPnl.Controls.Add(this.P1CycleLbl);
			this.Player1OptionsPnl.Controls.Add(this.Player1WeaponCycleChk);
			this.Player1OptionsPnl.Controls.Add(this.P1CritLbl);
			this.Player1OptionsPnl.Controls.Add(this.Player1OnlyCritChk);
			this.Player1OptionsPnl.Controls.Add(this.P1RapidLbl);
			this.Player1OptionsPnl.Controls.Add(this.Player1RapidFireChk);
			this.Player1OptionsPnl.Controls.Add(this.P1AmmoLbl);
			this.Player1OptionsPnl.Controls.Add(this.Player1UnlimitedAmmoChk);
			this.Player1OptionsPnl.Controls.Add(this.P1PointsLbl);
			this.Player1OptionsPnl.Controls.Add(this.Player1UnlimitedPointsChk);
			this.Player1OptionsPnl.Controls.Add(this.P1GodmodeLbl);
			this.Player1OptionsPnl.Controls.Add(this.Player1GodChk);
			this.Player1OptionsPnl.Location = new global::System.Drawing.Point(0, 0);
			this.Player1OptionsPnl.Name = "Player1OptionsPnl";
			this.Player1OptionsPnl.Size = new global::System.Drawing.Size(548, 270);
			this.Player1OptionsPnl.TabIndex = 140;
			this.label17.AutoSize = true;
			this.label17.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label17.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label17.Location = new global::System.Drawing.Point(72, 180);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(196, 19);
			this.label17.TabIndex = 137;
			this.label17.Text = "AUTO FIRE | NO RECOIL";
			this.Player1AFNRChk.CheckedState.BorderRadius = 10;
			this.Player1AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player1AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1AFNRChk.CheckedState.Parent = this.Player1AFNRChk;
			this.Player1AFNRChk.Location = new global::System.Drawing.Point(34, 179);
			this.Player1AFNRChk.Name = "Player1AFNRChk";
			this.Player1AFNRChk.ShadowDecoration.BorderRadius = 0;
			this.Player1AFNRChk.ShadowDecoration.Parent = this.Player1AFNRChk;
			this.Player1AFNRChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player1AFNRChk.TabIndex = 136;
			this.Player1AFNRChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player1AFNRChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player1AFNRChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1AFNRChk.UncheckedState.Parent = this.Player1AFNRChk;
			this.P1Name.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.P1Name.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.P1Name.Font = new global::System.Drawing.Font("Arial Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.P1Name.ForeColor = global::System.Drawing.Color.White;
			this.P1Name.Location = new global::System.Drawing.Point(17, 54);
			this.P1Name.Multiline = true;
			this.P1Name.Name = "P1Name";
			this.P1Name.Size = new global::System.Drawing.Size(294, 26);
			this.P1Name.TabIndex = 135;
			this.P1Name.Text = "PLAYER 1 NAME";
			this.P1Name.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.P1CycleLbl.AutoSize = true;
			this.P1CycleLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P1CycleLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P1CycleLbl.ForeColor = global::System.Drawing.Color.White;
			this.P1CycleLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P1CycleLbl.Location = new global::System.Drawing.Point(368, 138);
			this.P1CycleLbl.Name = "P1CycleLbl";
			this.P1CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P1CycleLbl.TabIndex = 133;
			this.P1CycleLbl.Text = "WEAPON CYCLE";
			this.Player1WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player1WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player1WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1WeaponCycleChk.CheckedState.Parent = this.Player1WeaponCycleChk;
			this.Player1WeaponCycleChk.Location = new global::System.Drawing.Point(330, 138);
			this.Player1WeaponCycleChk.Name = "Player1WeaponCycleChk";
			this.Player1WeaponCycleChk.ShadowDecoration.BorderRadius = 0;
			this.Player1WeaponCycleChk.ShadowDecoration.Parent = this.Player1WeaponCycleChk;
			this.Player1WeaponCycleChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player1WeaponCycleChk.TabIndex = 132;
			this.Player1WeaponCycleChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player1WeaponCycleChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player1WeaponCycleChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1WeaponCycleChk.UncheckedState.Parent = this.Player1WeaponCycleChk;
			this.Player1WeaponCycleChk.CheckedChanged += new global::System.EventHandler(this.P1WeaponCycle_CheckedChanged);
			this.P1CritLbl.AutoSize = true;
			this.P1CritLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P1CritLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P1CritLbl.ForeColor = global::System.Drawing.Color.White;
			this.P1CritLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P1CritLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P1CritLbl.Name = "P1CritLbl";
			this.P1CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P1CritLbl.TabIndex = 131;
			this.P1CritLbl.Text = "CRITICAL KILL";
			this.Player1OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player1OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player1OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1OnlyCritChk.CheckedState.Parent = this.Player1OnlyCritChk;
			this.Player1OnlyCritChk.Location = new global::System.Drawing.Point(330, 97);
			this.Player1OnlyCritChk.Name = "Player1OnlyCritChk";
			this.Player1OnlyCritChk.ShadowDecoration.BorderRadius = 0;
			this.Player1OnlyCritChk.ShadowDecoration.Parent = this.Player1OnlyCritChk;
			this.Player1OnlyCritChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player1OnlyCritChk.TabIndex = 130;
			this.Player1OnlyCritChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player1OnlyCritChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player1OnlyCritChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1OnlyCritChk.UncheckedState.Parent = this.Player1OnlyCritChk;
			this.Player1OnlyCritChk.CheckedChanged += new global::System.EventHandler(this.P1Critical_CheckedChanged);
			this.P1RapidLbl.AutoSize = true;
			this.P1RapidLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P1RapidLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P1RapidLbl.ForeColor = global::System.Drawing.Color.White;
			this.P1RapidLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P1RapidLbl.Location = new global::System.Drawing.Point(368, 180);
			this.P1RapidLbl.Name = "P1RapidLbl";
			this.P1RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P1RapidLbl.TabIndex = 129;
			this.P1RapidLbl.Text = "RAPID FIRE";
			this.Player1RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player1RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player1RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1RapidFireChk.CheckedState.Parent = this.Player1RapidFireChk;
			this.Player1RapidFireChk.Location = new global::System.Drawing.Point(330, 179);
			this.Player1RapidFireChk.Name = "Player1RapidFireChk";
			this.Player1RapidFireChk.ShadowDecoration.BorderRadius = 0;
			this.Player1RapidFireChk.ShadowDecoration.Parent = this.Player1RapidFireChk;
			this.Player1RapidFireChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player1RapidFireChk.TabIndex = 128;
			this.Player1RapidFireChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player1RapidFireChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player1RapidFireChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1RapidFireChk.UncheckedState.Parent = this.Player1RapidFireChk;
			this.Player1RapidFireChk.CheckedChanged += new global::System.EventHandler(this.P1RapidFire_CheckedChanged);
			this.P1AmmoLbl.AutoSize = true;
			this.P1AmmoLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P1AmmoLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P1AmmoLbl.ForeColor = global::System.Drawing.Color.White;
			this.P1AmmoLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P1AmmoLbl.Location = new global::System.Drawing.Point(72, 139);
			this.P1AmmoLbl.Name = "P1AmmoLbl";
			this.P1AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P1AmmoLbl.TabIndex = 127;
			this.P1AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player1UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player1UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player1UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedAmmoChk.CheckedState.Parent = this.Player1UnlimitedAmmoChk;
			this.Player1UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 138);
			this.Player1UnlimitedAmmoChk.Name = "Player1UnlimitedAmmoChk";
			this.Player1UnlimitedAmmoChk.ShadowDecoration.BorderRadius = 0;
			this.Player1UnlimitedAmmoChk.ShadowDecoration.Parent = this.Player1UnlimitedAmmoChk;
			this.Player1UnlimitedAmmoChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player1UnlimitedAmmoChk.TabIndex = 126;
			this.Player1UnlimitedAmmoChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player1UnlimitedAmmoChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player1UnlimitedAmmoChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1UnlimitedAmmoChk.UncheckedState.Parent = this.Player1UnlimitedAmmoChk;
			this.Player1UnlimitedAmmoChk.CheckedChanged += new global::System.EventHandler(this.P1Ammo_CheckedChanged);
			this.P1PointsLbl.AutoSize = true;
			this.P1PointsLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P1PointsLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P1PointsLbl.ForeColor = global::System.Drawing.Color.White;
			this.P1PointsLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P1PointsLbl.Location = new global::System.Drawing.Point(73, 98);
			this.P1PointsLbl.Name = "P1PointsLbl";
			this.P1PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P1PointsLbl.TabIndex = 125;
			this.P1PointsLbl.Text = "UNLIMITED POINTS";
			this.Player1UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player1UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player1UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedPointsChk.CheckedState.Parent = this.Player1UnlimitedPointsChk;
			this.Player1UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 97);
			this.Player1UnlimitedPointsChk.Name = "Player1UnlimitedPointsChk";
			this.Player1UnlimitedPointsChk.ShadowDecoration.BorderRadius = 0;
			this.Player1UnlimitedPointsChk.ShadowDecoration.Parent = this.Player1UnlimitedPointsChk;
			this.Player1UnlimitedPointsChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player1UnlimitedPointsChk.TabIndex = 124;
			this.Player1UnlimitedPointsChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player1UnlimitedPointsChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player1UnlimitedPointsChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1UnlimitedPointsChk.UncheckedState.Parent = this.Player1UnlimitedPointsChk;
			this.Player1UnlimitedPointsChk.CheckedChanged += new global::System.EventHandler(this.P1Points_CheckedChanged);
			this.P1GodmodeLbl.AutoSize = true;
			this.P1GodmodeLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P1GodmodeLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P1GodmodeLbl.ForeColor = global::System.Drawing.Color.White;
			this.P1GodmodeLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P1GodmodeLbl.Location = new global::System.Drawing.Point(369, 58);
			this.P1GodmodeLbl.Name = "P1GodmodeLbl";
			this.P1GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P1GodmodeLbl.TabIndex = 123;
			this.P1GodmodeLbl.Text = "GODMODE";
			this.Player1GodChk.CheckedState.BorderRadius = 10;
			this.Player1GodChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player1GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1GodChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1GodChk.CheckedState.Parent = this.Player1GodChk;
			this.Player1GodChk.Location = new global::System.Drawing.Point(330, 57);
			this.Player1GodChk.Name = "Player1GodChk";
			this.Player1GodChk.ShadowDecoration.BorderRadius = 0;
			this.Player1GodChk.ShadowDecoration.Parent = this.Player1GodChk;
			this.Player1GodChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player1GodChk.TabIndex = 122;
			this.Player1GodChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player1GodChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player1GodChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1GodChk.UncheckedState.Parent = this.Player1GodChk;
			this.Player1GodChk.CheckedChanged += new global::System.EventHandler(this.P1God_CheckedChanged);
			this.Player2OptionsPnl.Controls.Add(this.label18);
			this.Player2OptionsPnl.Controls.Add(this.Player2AFNRChk);
			this.Player2OptionsPnl.Controls.Add(this.P2Name);
			this.Player2OptionsPnl.Controls.Add(this.P2CycleLbl);
			this.Player2OptionsPnl.Controls.Add(this.Player2WeaponCycleChk);
			this.Player2OptionsPnl.Controls.Add(this.P2CritLbl);
			this.Player2OptionsPnl.Controls.Add(this.Player2OnlyCritChk);
			this.Player2OptionsPnl.Controls.Add(this.P2RapidLbl);
			this.Player2OptionsPnl.Controls.Add(this.Player2RapidFireChk);
			this.Player2OptionsPnl.Controls.Add(this.P2AmmoLbl);
			this.Player2OptionsPnl.Controls.Add(this.Player2UnlimitedAmmoChk);
			this.Player2OptionsPnl.Controls.Add(this.P2PointsLbl);
			this.Player2OptionsPnl.Controls.Add(this.Player2UnlimitedPointsChk);
			this.Player2OptionsPnl.Controls.Add(this.P2GodmodeLbl);
			this.Player2OptionsPnl.Controls.Add(this.Player2GodChk);
			this.Player2OptionsPnl.Location = new global::System.Drawing.Point(0, 0);
			this.Player2OptionsPnl.Name = "Player2OptionsPnl";
			this.Player2OptionsPnl.Size = new global::System.Drawing.Size(548, 270);
			this.Player2OptionsPnl.TabIndex = 139;
			this.label18.AutoSize = true;
			this.label18.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label18.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.White;
			this.label18.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label18.Location = new global::System.Drawing.Point(72, 180);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(196, 19);
			this.label18.TabIndex = 139;
			this.label18.Text = "AUTO FIRE | NO RECOIL";
			this.Player2AFNRChk.CheckedState.BorderRadius = 10;
			this.Player2AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player2AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player2AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player2AFNRChk.CheckedState.Parent = this.Player2AFNRChk;
			this.Player2AFNRChk.Location = new global::System.Drawing.Point(34, 179);
			this.Player2AFNRChk.Name = "Player2AFNRChk";
			this.Player2AFNRChk.ShadowDecoration.BorderRadius = 0;
			this.Player2AFNRChk.ShadowDecoration.Parent = this.Player2AFNRChk;
			this.Player2AFNRChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player2AFNRChk.TabIndex = 138;
			this.Player2AFNRChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player2AFNRChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player2AFNRChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2AFNRChk.UncheckedState.Parent = this.Player2AFNRChk;
			this.P2Name.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.P2Name.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.P2Name.Font = new global::System.Drawing.Font("Arial Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.P2Name.ForeColor = global::System.Drawing.Color.White;
			this.P2Name.Location = new global::System.Drawing.Point(17, 54);
			this.P2Name.Multiline = true;
			this.P2Name.Name = "P2Name";
			this.P2Name.Size = new global::System.Drawing.Size(294, 26);
			this.P2Name.TabIndex = 136;
			this.P2Name.Text = "PLAYER 2 NAME";
			this.P2Name.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.P2CycleLbl.AutoSize = true;
			this.P2CycleLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P2CycleLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P2CycleLbl.ForeColor = global::System.Drawing.Color.White;
			this.P2CycleLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P2CycleLbl.Location = new global::System.Drawing.Point(368, 138);
			this.P2CycleLbl.Name = "P2CycleLbl";
			this.P2CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P2CycleLbl.TabIndex = 133;
			this.P2CycleLbl.Text = "WEAPON CYCLE";
			this.Player2WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player2WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player2WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2WeaponCycleChk.CheckedState.Parent = this.Player2WeaponCycleChk;
			this.Player2WeaponCycleChk.Location = new global::System.Drawing.Point(330, 138);
			this.Player2WeaponCycleChk.Name = "Player2WeaponCycleChk";
			this.Player2WeaponCycleChk.ShadowDecoration.BorderRadius = 0;
			this.Player2WeaponCycleChk.ShadowDecoration.Parent = this.Player2WeaponCycleChk;
			this.Player2WeaponCycleChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player2WeaponCycleChk.TabIndex = 132;
			this.Player2WeaponCycleChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player2WeaponCycleChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player2WeaponCycleChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2WeaponCycleChk.UncheckedState.Parent = this.Player2WeaponCycleChk;
			this.Player2WeaponCycleChk.CheckedChanged += new global::System.EventHandler(this.P2WeaponCycle_CheckedChanged);
			this.P2CritLbl.AutoSize = true;
			this.P2CritLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P2CritLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P2CritLbl.ForeColor = global::System.Drawing.Color.White;
			this.P2CritLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P2CritLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P2CritLbl.Name = "P2CritLbl";
			this.P2CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P2CritLbl.TabIndex = 131;
			this.P2CritLbl.Text = "CRITICAL KILL";
			this.Player2OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player2OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player2OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2OnlyCritChk.CheckedState.Parent = this.Player2OnlyCritChk;
			this.Player2OnlyCritChk.Location = new global::System.Drawing.Point(330, 97);
			this.Player2OnlyCritChk.Name = "Player2OnlyCritChk";
			this.Player2OnlyCritChk.ShadowDecoration.BorderRadius = 0;
			this.Player2OnlyCritChk.ShadowDecoration.Parent = this.Player2OnlyCritChk;
			this.Player2OnlyCritChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player2OnlyCritChk.TabIndex = 130;
			this.Player2OnlyCritChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player2OnlyCritChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player2OnlyCritChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2OnlyCritChk.UncheckedState.Parent = this.Player2OnlyCritChk;
			this.Player2OnlyCritChk.CheckedChanged += new global::System.EventHandler(this.P2Critical_CheckedChanged);
			this.P2RapidLbl.AutoSize = true;
			this.P2RapidLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P2RapidLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P2RapidLbl.ForeColor = global::System.Drawing.Color.White;
			this.P2RapidLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P2RapidLbl.Location = new global::System.Drawing.Point(368, 180);
			this.P2RapidLbl.Name = "P2RapidLbl";
			this.P2RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P2RapidLbl.TabIndex = 129;
			this.P2RapidLbl.Text = "RAPID FIRE";
			this.Player2RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player2RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player2RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2RapidFireChk.CheckedState.Parent = this.Player2RapidFireChk;
			this.Player2RapidFireChk.Location = new global::System.Drawing.Point(330, 179);
			this.Player2RapidFireChk.Name = "Player2RapidFireChk";
			this.Player2RapidFireChk.ShadowDecoration.BorderRadius = 0;
			this.Player2RapidFireChk.ShadowDecoration.Parent = this.Player2RapidFireChk;
			this.Player2RapidFireChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player2RapidFireChk.TabIndex = 128;
			this.Player2RapidFireChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player2RapidFireChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player2RapidFireChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2RapidFireChk.UncheckedState.Parent = this.Player2RapidFireChk;
			this.Player2RapidFireChk.CheckedChanged += new global::System.EventHandler(this.P2RapidFire_CheckedChanged);
			this.P2AmmoLbl.AutoSize = true;
			this.P2AmmoLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P2AmmoLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P2AmmoLbl.ForeColor = global::System.Drawing.Color.White;
			this.P2AmmoLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P2AmmoLbl.Location = new global::System.Drawing.Point(72, 139);
			this.P2AmmoLbl.Name = "P2AmmoLbl";
			this.P2AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P2AmmoLbl.TabIndex = 127;
			this.P2AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player2UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player2UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player2UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedAmmoChk.CheckedState.Parent = this.Player2UnlimitedAmmoChk;
			this.Player2UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 138);
			this.Player2UnlimitedAmmoChk.Name = "Player2UnlimitedAmmoChk";
			this.Player2UnlimitedAmmoChk.ShadowDecoration.BorderRadius = 0;
			this.Player2UnlimitedAmmoChk.ShadowDecoration.Parent = this.Player2UnlimitedAmmoChk;
			this.Player2UnlimitedAmmoChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player2UnlimitedAmmoChk.TabIndex = 126;
			this.Player2UnlimitedAmmoChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player2UnlimitedAmmoChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player2UnlimitedAmmoChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedAmmoChk.UncheckedState.Parent = this.Player2UnlimitedAmmoChk;
			this.Player2UnlimitedAmmoChk.CheckedChanged += new global::System.EventHandler(this.P2Ammo_CheckedChanged);
			this.P2PointsLbl.AutoSize = true;
			this.P2PointsLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P2PointsLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P2PointsLbl.ForeColor = global::System.Drawing.Color.White;
			this.P2PointsLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P2PointsLbl.Location = new global::System.Drawing.Point(73, 98);
			this.P2PointsLbl.Name = "P2PointsLbl";
			this.P2PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P2PointsLbl.TabIndex = 125;
			this.P2PointsLbl.Text = "UNLIMITED POINTS";
			this.Player2UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player2UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player2UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedPointsChk.CheckedState.Parent = this.Player2UnlimitedPointsChk;
			this.Player2UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 97);
			this.Player2UnlimitedPointsChk.Name = "Player2UnlimitedPointsChk";
			this.Player2UnlimitedPointsChk.ShadowDecoration.BorderRadius = 0;
			this.Player2UnlimitedPointsChk.ShadowDecoration.Parent = this.Player2UnlimitedPointsChk;
			this.Player2UnlimitedPointsChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player2UnlimitedPointsChk.TabIndex = 124;
			this.Player2UnlimitedPointsChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player2UnlimitedPointsChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player2UnlimitedPointsChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedPointsChk.UncheckedState.Parent = this.Player2UnlimitedPointsChk;
			this.Player2UnlimitedPointsChk.CheckedChanged += new global::System.EventHandler(this.P2Points_CheckedChanged);
			this.P2GodmodeLbl.AutoSize = true;
			this.P2GodmodeLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P2GodmodeLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P2GodmodeLbl.ForeColor = global::System.Drawing.Color.White;
			this.P2GodmodeLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P2GodmodeLbl.Location = new global::System.Drawing.Point(369, 58);
			this.P2GodmodeLbl.Name = "P2GodmodeLbl";
			this.P2GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P2GodmodeLbl.TabIndex = 123;
			this.P2GodmodeLbl.Text = "GODMODE";
			this.Player2GodChk.CheckedState.BorderRadius = 10;
			this.Player2GodChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player2GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2GodChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2GodChk.CheckedState.Parent = this.Player2GodChk;
			this.Player2GodChk.Location = new global::System.Drawing.Point(330, 57);
			this.Player2GodChk.Name = "Player2GodChk";
			this.Player2GodChk.ShadowDecoration.BorderRadius = 0;
			this.Player2GodChk.ShadowDecoration.Parent = this.Player2GodChk;
			this.Player2GodChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player2GodChk.TabIndex = 122;
			this.Player2GodChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player2GodChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player2GodChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2GodChk.UncheckedState.Parent = this.Player2GodChk;
			this.Player2GodChk.CheckedChanged += new global::System.EventHandler(this.P2God_CheckedChanged);
			this.Player3OptionsPnl.Controls.Add(this.label19);
			this.Player3OptionsPnl.Controls.Add(this.Player3AFNRChk);
			this.Player3OptionsPnl.Controls.Add(this.P3Name);
			this.Player3OptionsPnl.Controls.Add(this.P3CycleLbl);
			this.Player3OptionsPnl.Controls.Add(this.Player3WeaponCycleChk);
			this.Player3OptionsPnl.Controls.Add(this.P3CritLbl);
			this.Player3OptionsPnl.Controls.Add(this.Player3OnlyCritChk);
			this.Player3OptionsPnl.Controls.Add(this.P3RapidLbl);
			this.Player3OptionsPnl.Controls.Add(this.Player3RapidFireChk);
			this.Player3OptionsPnl.Controls.Add(this.P3AmmoLbl);
			this.Player3OptionsPnl.Controls.Add(this.Player3UnlimitedAmmoChk);
			this.Player3OptionsPnl.Controls.Add(this.P3PointsLbl);
			this.Player3OptionsPnl.Controls.Add(this.Player3UnlimitedPointsChk);
			this.Player3OptionsPnl.Controls.Add(this.P3GodmodeLbl);
			this.Player3OptionsPnl.Controls.Add(this.Player3GodChk);
			this.Player3OptionsPnl.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.Player3OptionsPnl.Location = new global::System.Drawing.Point(0, 0);
			this.Player3OptionsPnl.Name = "Player3OptionsPnl";
			this.Player3OptionsPnl.Size = new global::System.Drawing.Size(548, 270);
			this.Player3OptionsPnl.TabIndex = 138;
			this.label19.AutoSize = true;
			this.label19.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label19.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.ForeColor = global::System.Drawing.Color.White;
			this.label19.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label19.Location = new global::System.Drawing.Point(72, 180);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(196, 19);
			this.label19.TabIndex = 139;
			this.label19.Text = "AUTO FIRE | NO RECOIL";
			this.Player3AFNRChk.CheckedState.BorderRadius = 10;
			this.Player3AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player3AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player3AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player3AFNRChk.CheckedState.Parent = this.Player3AFNRChk;
			this.Player3AFNRChk.Location = new global::System.Drawing.Point(34, 179);
			this.Player3AFNRChk.Name = "Player3AFNRChk";
			this.Player3AFNRChk.ShadowDecoration.BorderRadius = 0;
			this.Player3AFNRChk.ShadowDecoration.Parent = this.Player3AFNRChk;
			this.Player3AFNRChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player3AFNRChk.TabIndex = 138;
			this.Player3AFNRChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player3AFNRChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player3AFNRChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3AFNRChk.UncheckedState.Parent = this.Player3AFNRChk;
			this.P3Name.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.P3Name.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.P3Name.Font = new global::System.Drawing.Font("Arial Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.P3Name.ForeColor = global::System.Drawing.Color.White;
			this.P3Name.Location = new global::System.Drawing.Point(17, 54);
			this.P3Name.Multiline = true;
			this.P3Name.Name = "P3Name";
			this.P3Name.Size = new global::System.Drawing.Size(294, 26);
			this.P3Name.TabIndex = 136;
			this.P3Name.Text = "PLAYER 3 NAME";
			this.P3Name.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.P3CycleLbl.AutoSize = true;
			this.P3CycleLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P3CycleLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P3CycleLbl.ForeColor = global::System.Drawing.Color.White;
			this.P3CycleLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P3CycleLbl.Location = new global::System.Drawing.Point(368, 138);
			this.P3CycleLbl.Name = "P3CycleLbl";
			this.P3CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P3CycleLbl.TabIndex = 133;
			this.P3CycleLbl.Text = "WEAPON CYCLE";
			this.Player3WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player3WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player3WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3WeaponCycleChk.CheckedState.Parent = this.Player3WeaponCycleChk;
			this.Player3WeaponCycleChk.Location = new global::System.Drawing.Point(330, 138);
			this.Player3WeaponCycleChk.Name = "Player3WeaponCycleChk";
			this.Player3WeaponCycleChk.ShadowDecoration.BorderRadius = 0;
			this.Player3WeaponCycleChk.ShadowDecoration.Parent = this.Player3WeaponCycleChk;
			this.Player3WeaponCycleChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player3WeaponCycleChk.TabIndex = 132;
			this.Player3WeaponCycleChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player3WeaponCycleChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player3WeaponCycleChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3WeaponCycleChk.UncheckedState.Parent = this.Player3WeaponCycleChk;
			this.P3CritLbl.AutoSize = true;
			this.P3CritLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P3CritLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P3CritLbl.ForeColor = global::System.Drawing.Color.White;
			this.P3CritLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P3CritLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P3CritLbl.Name = "P3CritLbl";
			this.P3CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P3CritLbl.TabIndex = 131;
			this.P3CritLbl.Text = "CRITICAL KILL";
			this.Player3OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player3OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player3OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3OnlyCritChk.CheckedState.Parent = this.Player3OnlyCritChk;
			this.Player3OnlyCritChk.Location = new global::System.Drawing.Point(330, 97);
			this.Player3OnlyCritChk.Name = "Player3OnlyCritChk";
			this.Player3OnlyCritChk.ShadowDecoration.BorderRadius = 0;
			this.Player3OnlyCritChk.ShadowDecoration.Parent = this.Player3OnlyCritChk;
			this.Player3OnlyCritChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player3OnlyCritChk.TabIndex = 130;
			this.Player3OnlyCritChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player3OnlyCritChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player3OnlyCritChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3OnlyCritChk.UncheckedState.Parent = this.Player3OnlyCritChk;
			this.Player3OnlyCritChk.CheckedChanged += new global::System.EventHandler(this.P3Critical_CheckedChanged);
			this.P3RapidLbl.AutoSize = true;
			this.P3RapidLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P3RapidLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P3RapidLbl.ForeColor = global::System.Drawing.Color.White;
			this.P3RapidLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P3RapidLbl.Location = new global::System.Drawing.Point(368, 180);
			this.P3RapidLbl.Name = "P3RapidLbl";
			this.P3RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P3RapidLbl.TabIndex = 129;
			this.P3RapidLbl.Text = "RAPID FIRE";
			this.Player3RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player3RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player3RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3RapidFireChk.CheckedState.Parent = this.Player3RapidFireChk;
			this.Player3RapidFireChk.Location = new global::System.Drawing.Point(330, 179);
			this.Player3RapidFireChk.Name = "Player3RapidFireChk";
			this.Player3RapidFireChk.ShadowDecoration.BorderRadius = 0;
			this.Player3RapidFireChk.ShadowDecoration.Parent = this.Player3RapidFireChk;
			this.Player3RapidFireChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player3RapidFireChk.TabIndex = 128;
			this.Player3RapidFireChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player3RapidFireChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player3RapidFireChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3RapidFireChk.UncheckedState.Parent = this.Player3RapidFireChk;
			this.Player3RapidFireChk.CheckedChanged += new global::System.EventHandler(this.P3RapidFire_CheckedChanged);
			this.P3AmmoLbl.AutoSize = true;
			this.P3AmmoLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P3AmmoLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P3AmmoLbl.ForeColor = global::System.Drawing.Color.White;
			this.P3AmmoLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P3AmmoLbl.Location = new global::System.Drawing.Point(72, 139);
			this.P3AmmoLbl.Name = "P3AmmoLbl";
			this.P3AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P3AmmoLbl.TabIndex = 127;
			this.P3AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player3UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player3UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player3UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedAmmoChk.CheckedState.Parent = this.Player3UnlimitedAmmoChk;
			this.Player3UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 138);
			this.Player3UnlimitedAmmoChk.Name = "Player3UnlimitedAmmoChk";
			this.Player3UnlimitedAmmoChk.ShadowDecoration.BorderRadius = 0;
			this.Player3UnlimitedAmmoChk.ShadowDecoration.Parent = this.Player3UnlimitedAmmoChk;
			this.Player3UnlimitedAmmoChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player3UnlimitedAmmoChk.TabIndex = 126;
			this.Player3UnlimitedAmmoChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player3UnlimitedAmmoChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player3UnlimitedAmmoChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedAmmoChk.UncheckedState.Parent = this.Player3UnlimitedAmmoChk;
			this.Player3UnlimitedAmmoChk.CheckedChanged += new global::System.EventHandler(this.P3Ammo_CheckedChanged);
			this.P3PointsLbl.AutoSize = true;
			this.P3PointsLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P3PointsLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P3PointsLbl.ForeColor = global::System.Drawing.Color.White;
			this.P3PointsLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P3PointsLbl.Location = new global::System.Drawing.Point(73, 98);
			this.P3PointsLbl.Name = "P3PointsLbl";
			this.P3PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P3PointsLbl.TabIndex = 125;
			this.P3PointsLbl.Text = "UNLIMITED POINTS";
			this.Player3UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player3UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player3UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedPointsChk.CheckedState.Parent = this.Player3UnlimitedPointsChk;
			this.Player3UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 97);
			this.Player3UnlimitedPointsChk.Name = "Player3UnlimitedPointsChk";
			this.Player3UnlimitedPointsChk.ShadowDecoration.BorderRadius = 0;
			this.Player3UnlimitedPointsChk.ShadowDecoration.Parent = this.Player3UnlimitedPointsChk;
			this.Player3UnlimitedPointsChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player3UnlimitedPointsChk.TabIndex = 124;
			this.Player3UnlimitedPointsChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player3UnlimitedPointsChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player3UnlimitedPointsChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedPointsChk.UncheckedState.Parent = this.Player3UnlimitedPointsChk;
			this.Player3UnlimitedPointsChk.CheckedChanged += new global::System.EventHandler(this.P3Points_CheckedChanged);
			this.P3GodmodeLbl.AutoSize = true;
			this.P3GodmodeLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P3GodmodeLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P3GodmodeLbl.ForeColor = global::System.Drawing.Color.White;
			this.P3GodmodeLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P3GodmodeLbl.Location = new global::System.Drawing.Point(369, 58);
			this.P3GodmodeLbl.Name = "P3GodmodeLbl";
			this.P3GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P3GodmodeLbl.TabIndex = 123;
			this.P3GodmodeLbl.Text = "GODMODE";
			this.Player3GodChk.CheckedState.BorderRadius = 10;
			this.Player3GodChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player3GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3GodChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3GodChk.CheckedState.Parent = this.Player3GodChk;
			this.Player3GodChk.Location = new global::System.Drawing.Point(330, 57);
			this.Player3GodChk.Name = "Player3GodChk";
			this.Player3GodChk.ShadowDecoration.BorderRadius = 0;
			this.Player3GodChk.ShadowDecoration.Parent = this.Player3GodChk;
			this.Player3GodChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player3GodChk.TabIndex = 122;
			this.Player3GodChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player3GodChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player3GodChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3GodChk.UncheckedState.Parent = this.Player3GodChk;
			this.Player3GodChk.CheckedChanged += new global::System.EventHandler(this.P3God_CheckedChanged);
			this.Player4OptionsPnl.Controls.Add(this.label20);
			this.Player4OptionsPnl.Controls.Add(this.Player4AFNRChk);
			this.Player4OptionsPnl.Controls.Add(this.P4Name);
			this.Player4OptionsPnl.Controls.Add(this.P4CycleLbl);
			this.Player4OptionsPnl.Controls.Add(this.Player4WeaponCycleChk);
			this.Player4OptionsPnl.Controls.Add(this.P4CritLbl);
			this.Player4OptionsPnl.Controls.Add(this.Player4OnlyCritChk);
			this.Player4OptionsPnl.Controls.Add(this.P4RapidLbl);
			this.Player4OptionsPnl.Controls.Add(this.Player4RapidFireChk);
			this.Player4OptionsPnl.Controls.Add(this.P4AmmoLbl);
			this.Player4OptionsPnl.Controls.Add(this.Player4UnlimitedAmmoChk);
			this.Player4OptionsPnl.Controls.Add(this.P4PointsLbl);
			this.Player4OptionsPnl.Controls.Add(this.Player4UnlimitedPointsChk);
			this.Player4OptionsPnl.Controls.Add(this.P4GodmodeLbl);
			this.Player4OptionsPnl.Controls.Add(this.Player4GodChk);
			this.Player4OptionsPnl.Location = new global::System.Drawing.Point(0, 0);
			this.Player4OptionsPnl.Name = "Player4OptionsPnl";
			this.Player4OptionsPnl.Size = new global::System.Drawing.Size(548, 270);
			this.Player4OptionsPnl.TabIndex = 137;
			this.label20.AutoSize = true;
			this.label20.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label20.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label20.ForeColor = global::System.Drawing.Color.White;
			this.label20.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label20.Location = new global::System.Drawing.Point(72, 180);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(196, 19);
			this.label20.TabIndex = 139;
			this.label20.Text = "AUTO FIRE | NO RECOIL";
			this.Player4AFNRChk.CheckedState.BorderRadius = 10;
			this.Player4AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player4AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player4AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player4AFNRChk.CheckedState.Parent = this.Player4AFNRChk;
			this.Player4AFNRChk.Location = new global::System.Drawing.Point(34, 179);
			this.Player4AFNRChk.Name = "Player4AFNRChk";
			this.Player4AFNRChk.ShadowDecoration.BorderRadius = 0;
			this.Player4AFNRChk.ShadowDecoration.Parent = this.Player4AFNRChk;
			this.Player4AFNRChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player4AFNRChk.TabIndex = 138;
			this.Player4AFNRChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player4AFNRChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player4AFNRChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4AFNRChk.UncheckedState.Parent = this.Player4AFNRChk;
			this.P4Name.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.P4Name.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.P4Name.Font = new global::System.Drawing.Font("Arial Black", 12f, global::System.Drawing.FontStyle.Bold);
			this.P4Name.ForeColor = global::System.Drawing.Color.White;
			this.P4Name.Location = new global::System.Drawing.Point(17, 54);
			this.P4Name.Multiline = true;
			this.P4Name.Name = "P4Name";
			this.P4Name.Size = new global::System.Drawing.Size(294, 26);
			this.P4Name.TabIndex = 136;
			this.P4Name.Text = "PLAYER 4 NAME";
			this.P4Name.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.P4CycleLbl.AutoSize = true;
			this.P4CycleLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P4CycleLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P4CycleLbl.ForeColor = global::System.Drawing.Color.White;
			this.P4CycleLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P4CycleLbl.Location = new global::System.Drawing.Point(368, 138);
			this.P4CycleLbl.Name = "P4CycleLbl";
			this.P4CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P4CycleLbl.TabIndex = 133;
			this.P4CycleLbl.Text = "WEAPON CYCLE";
			this.Player4WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player4WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player4WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4WeaponCycleChk.CheckedState.Parent = this.Player4WeaponCycleChk;
			this.Player4WeaponCycleChk.Location = new global::System.Drawing.Point(330, 138);
			this.Player4WeaponCycleChk.Name = "Player4WeaponCycleChk";
			this.Player4WeaponCycleChk.ShadowDecoration.BorderRadius = 0;
			this.Player4WeaponCycleChk.ShadowDecoration.Parent = this.Player4WeaponCycleChk;
			this.Player4WeaponCycleChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player4WeaponCycleChk.TabIndex = 132;
			this.Player4WeaponCycleChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player4WeaponCycleChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player4WeaponCycleChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4WeaponCycleChk.UncheckedState.Parent = this.Player4WeaponCycleChk;
			this.Player4WeaponCycleChk.CheckedChanged += new global::System.EventHandler(this.P4WeaponCycle_CheckedChanged);
			this.P4CritLbl.AutoSize = true;
			this.P4CritLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P4CritLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P4CritLbl.ForeColor = global::System.Drawing.Color.White;
			this.P4CritLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P4CritLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P4CritLbl.Name = "P4CritLbl";
			this.P4CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P4CritLbl.TabIndex = 131;
			this.P4CritLbl.Text = "CRITICAL KILL";
			this.Player4OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player4OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player4OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4OnlyCritChk.CheckedState.Parent = this.Player4OnlyCritChk;
			this.Player4OnlyCritChk.Location = new global::System.Drawing.Point(330, 97);
			this.Player4OnlyCritChk.Name = "Player4OnlyCritChk";
			this.Player4OnlyCritChk.ShadowDecoration.BorderRadius = 0;
			this.Player4OnlyCritChk.ShadowDecoration.Parent = this.Player4OnlyCritChk;
			this.Player4OnlyCritChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player4OnlyCritChk.TabIndex = 130;
			this.Player4OnlyCritChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player4OnlyCritChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player4OnlyCritChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4OnlyCritChk.UncheckedState.Parent = this.Player4OnlyCritChk;
			this.Player4OnlyCritChk.CheckedChanged += new global::System.EventHandler(this.P4Critical_CheckedChanged);
			this.P4RapidLbl.AutoSize = true;
			this.P4RapidLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P4RapidLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P4RapidLbl.ForeColor = global::System.Drawing.Color.White;
			this.P4RapidLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P4RapidLbl.Location = new global::System.Drawing.Point(368, 180);
			this.P4RapidLbl.Name = "P4RapidLbl";
			this.P4RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P4RapidLbl.TabIndex = 129;
			this.P4RapidLbl.Text = "RAPID FIRE";
			this.Player4RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player4RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player4RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4RapidFireChk.CheckedState.Parent = this.Player4RapidFireChk;
			this.Player4RapidFireChk.Location = new global::System.Drawing.Point(330, 179);
			this.Player4RapidFireChk.Name = "Player4RapidFireChk";
			this.Player4RapidFireChk.ShadowDecoration.BorderRadius = 0;
			this.Player4RapidFireChk.ShadowDecoration.Parent = this.Player4RapidFireChk;
			this.Player4RapidFireChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player4RapidFireChk.TabIndex = 128;
			this.Player4RapidFireChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player4RapidFireChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player4RapidFireChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4RapidFireChk.UncheckedState.Parent = this.Player4RapidFireChk;
			this.Player4RapidFireChk.CheckedChanged += new global::System.EventHandler(this.P4RapidFire_CheckedChanged);
			this.P4AmmoLbl.AutoSize = true;
			this.P4AmmoLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P4AmmoLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P4AmmoLbl.ForeColor = global::System.Drawing.Color.White;
			this.P4AmmoLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P4AmmoLbl.Location = new global::System.Drawing.Point(72, 139);
			this.P4AmmoLbl.Name = "P4AmmoLbl";
			this.P4AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P4AmmoLbl.TabIndex = 127;
			this.P4AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player4UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player4UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player4UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedAmmoChk.CheckedState.Parent = this.Player4UnlimitedAmmoChk;
			this.Player4UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 138);
			this.Player4UnlimitedAmmoChk.Name = "Player4UnlimitedAmmoChk";
			this.Player4UnlimitedAmmoChk.ShadowDecoration.BorderRadius = 0;
			this.Player4UnlimitedAmmoChk.ShadowDecoration.Parent = this.Player4UnlimitedAmmoChk;
			this.Player4UnlimitedAmmoChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player4UnlimitedAmmoChk.TabIndex = 126;
			this.Player4UnlimitedAmmoChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player4UnlimitedAmmoChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player4UnlimitedAmmoChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedAmmoChk.UncheckedState.Parent = this.Player4UnlimitedAmmoChk;
			this.Player4UnlimitedAmmoChk.CheckedChanged += new global::System.EventHandler(this.P4Ammo_CheckedChanged);
			this.P4PointsLbl.AutoSize = true;
			this.P4PointsLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P4PointsLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P4PointsLbl.ForeColor = global::System.Drawing.Color.White;
			this.P4PointsLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P4PointsLbl.Location = new global::System.Drawing.Point(73, 98);
			this.P4PointsLbl.Name = "P4PointsLbl";
			this.P4PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P4PointsLbl.TabIndex = 125;
			this.P4PointsLbl.Text = "UNLIMITED POINTS";
			this.Player4UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player4UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player4UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedPointsChk.CheckedState.Parent = this.Player4UnlimitedPointsChk;
			this.Player4UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 97);
			this.Player4UnlimitedPointsChk.Name = "Player4UnlimitedPointsChk";
			this.Player4UnlimitedPointsChk.ShadowDecoration.BorderRadius = 0;
			this.Player4UnlimitedPointsChk.ShadowDecoration.Parent = this.Player4UnlimitedPointsChk;
			this.Player4UnlimitedPointsChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player4UnlimitedPointsChk.TabIndex = 124;
			this.Player4UnlimitedPointsChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player4UnlimitedPointsChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player4UnlimitedPointsChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedPointsChk.UncheckedState.Parent = this.Player4UnlimitedPointsChk;
			this.Player4UnlimitedPointsChk.CheckedChanged += new global::System.EventHandler(this.P4Points_CheckedChanged);
			this.P4GodmodeLbl.AutoSize = true;
			this.P4GodmodeLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.P4GodmodeLbl.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.P4GodmodeLbl.ForeColor = global::System.Drawing.Color.White;
			this.P4GodmodeLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.P4GodmodeLbl.Location = new global::System.Drawing.Point(369, 58);
			this.P4GodmodeLbl.Name = "P4GodmodeLbl";
			this.P4GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P4GodmodeLbl.TabIndex = 123;
			this.P4GodmodeLbl.Text = "GODMODE";
			this.Player4GodChk.CheckedState.BorderRadius = 10;
			this.Player4GodChk.CheckedState.FillColor = global::System.Drawing.Color.White;
			this.Player4GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4GodChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4GodChk.CheckedState.Parent = this.Player4GodChk;
			this.Player4GodChk.Location = new global::System.Drawing.Point(330, 57);
			this.Player4GodChk.Name = "Player4GodChk";
			this.Player4GodChk.ShadowDecoration.BorderRadius = 0;
			this.Player4GodChk.ShadowDecoration.Parent = this.Player4GodChk;
			this.Player4GodChk.Size = new global::System.Drawing.Size(35, 20);
			this.Player4GodChk.TabIndex = 122;
			this.Player4GodChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.Player4GodChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Player4GodChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4GodChk.UncheckedState.Parent = this.Player4GodChk;
			this.Player4GodChk.CheckedChanged += new global::System.EventHandler(this.P4God_CheckedChanged);
			this.MainBackgroundImage.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.MainBackgroundImage.Location = new global::System.Drawing.Point(0, 0);
			this.MainBackgroundImage.Name = "MainBackgroundImage";
			this.MainBackgroundImage.Size = new global::System.Drawing.Size(644, 401);
			this.MainBackgroundImage.TabIndex = 58;
			this.MainBackgroundImage.TabStop = false;
			this.MainBackgroundImage.Click += new global::System.EventHandler(this.MainBackgroundImage_Click);
			this.MainBackgroundImage.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.MainBackgroundImage.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			this.MainBackgroundImage.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(644, 401);
			base.ControlBox = false;
			base.Controls.Add(this.MainBackPnl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FRENZY SERVICES";
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			this.MainBackPnl.ResumeLayout(false);
			this.homePanel.ResumeLayout(false);
			this.homePanel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			this.daPanel.ResumeLayout(false);
			this.daPanel.PerformLayout();
			this.papPanel.ResumeLayout(false);
			this.papPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.a1.ResumeLayout(false);
			this.a1.PerformLayout();
			this.a2.ResumeLayout(false);
			this.a2.PerformLayout();
			this.a3.ResumeLayout(false);
			this.PlayerAllOptionsPnl.ResumeLayout(false);
			this.PlayerAllOptionsPnl.PerformLayout();
			this.Player1OptionsPnl.ResumeLayout(false);
			this.Player1OptionsPnl.PerformLayout();
			this.Player2OptionsPnl.ResumeLayout(false);
			this.Player2OptionsPnl.PerformLayout();
			this.Player3OptionsPnl.ResumeLayout(false);
			this.Player3OptionsPnl.PerformLayout();
			this.Player4OptionsPnl.ResumeLayout(false);
			this.Player4OptionsPnl.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.MainBackgroundImage).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource3).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400046E RID: 1134
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400046F RID: 1135
		public global::System.Windows.Forms.Panel a1;

		// Token: 0x04000470 RID: 1136
		public global::System.Windows.Forms.Panel a2;

		// Token: 0x04000471 RID: 1137
		public global::System.Windows.Forms.Panel a3;

		// Token: 0x04000472 RID: 1138
		public global::System.Windows.Forms.Panel Player1OptionsPnl;

		// Token: 0x04000473 RID: 1139
		public global::System.ComponentModel.BackgroundWorker BGWorker;

		// Token: 0x04000474 RID: 1140
		public global::System.ComponentModel.BackgroundWorker DiscoWorker;

		// Token: 0x04000475 RID: 1141
		public global::System.ComponentModel.BackgroundWorker RapidFireWorker;

		// Token: 0x04000476 RID: 1142
		public global::System.Windows.Forms.Timer P1Cycle;

		// Token: 0x04000477 RID: 1143
		public global::System.Windows.Forms.Timer P2Cycle;

		// Token: 0x04000478 RID: 1144
		public global::System.Windows.Forms.Timer P3Cycle;

		// Token: 0x04000479 RID: 1145
		public global::System.Windows.Forms.Timer P4Cycle;

		// Token: 0x0400047A RID: 1146
		public global::System.ComponentModel.BackgroundWorker AntiDebugWorker;

		// Token: 0x0400047B RID: 1147
		public global::System.Windows.Forms.Panel Player2OptionsPnl;

		// Token: 0x0400047C RID: 1148
		public global::System.Windows.Forms.Panel Player3OptionsPnl;

		// Token: 0x0400047D RID: 1149
		public global::System.Windows.Forms.Panel Player4OptionsPnl;

		// Token: 0x0400047E RID: 1150
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400047F RID: 1151
		private global::System.Windows.Forms.TextBox UsernameLbl;

		// Token: 0x04000480 RID: 1152
		private global::Siticone.UI.WinForms.SiticoneRoundedButton DiscordBtn;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000482 RID: 1154
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000483 RID: 1155
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000484 RID: 1156
		private global::System.Windows.Forms.Label TPCLbl;

		// Token: 0x04000485 RID: 1157
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch OneShotZombiesChk;

		// Token: 0x04000486 RID: 1158
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch TPZC;

		// Token: 0x04000487 RID: 1159
		public global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar WeaponCycleIntervalTrackBar;

		// Token: 0x04000488 RID: 1160
		public global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar ZombieTPDistTrackBar;

		// Token: 0x04000489 RID: 1161
		public global::System.Windows.Forms.Button TPZombie;

		// Token: 0x0400048A RID: 1162
		private global::System.Windows.Forms.Label P1CycleLbl;

		// Token: 0x0400048B RID: 1163
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1WeaponCycleChk;

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Forms.Label P1CritLbl;

		// Token: 0x0400048D RID: 1165
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1OnlyCritChk;

		// Token: 0x0400048E RID: 1166
		private global::System.Windows.Forms.Label P1RapidLbl;

		// Token: 0x0400048F RID: 1167
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1RapidFireChk;

		// Token: 0x04000490 RID: 1168
		private global::System.Windows.Forms.Label P1AmmoLbl;

		// Token: 0x04000491 RID: 1169
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1UnlimitedAmmoChk;

		// Token: 0x04000492 RID: 1170
		private global::System.Windows.Forms.Label P1PointsLbl;

		// Token: 0x04000493 RID: 1171
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1UnlimitedPointsChk;

		// Token: 0x04000494 RID: 1172
		private global::System.Windows.Forms.Label P1GodmodeLbl;

		// Token: 0x04000495 RID: 1173
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1GodChk;

		// Token: 0x04000496 RID: 1174
		private global::System.Windows.Forms.Label P2CycleLbl;

		// Token: 0x04000497 RID: 1175
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2WeaponCycleChk;

		// Token: 0x04000498 RID: 1176
		private global::System.Windows.Forms.Label P2CritLbl;

		// Token: 0x04000499 RID: 1177
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2OnlyCritChk;

		// Token: 0x0400049A RID: 1178
		private global::System.Windows.Forms.Label P2RapidLbl;

		// Token: 0x0400049B RID: 1179
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2RapidFireChk;

		// Token: 0x0400049C RID: 1180
		private global::System.Windows.Forms.Label P2AmmoLbl;

		// Token: 0x0400049D RID: 1181
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2UnlimitedAmmoChk;

		// Token: 0x0400049E RID: 1182
		private global::System.Windows.Forms.Label P2PointsLbl;

		// Token: 0x0400049F RID: 1183
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2UnlimitedPointsChk;

		// Token: 0x040004A0 RID: 1184
		private global::System.Windows.Forms.Label P2GodmodeLbl;

		// Token: 0x040004A1 RID: 1185
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2GodChk;

		// Token: 0x040004A2 RID: 1186
		private global::System.Windows.Forms.Label P3CycleLbl;

		// Token: 0x040004A3 RID: 1187
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3WeaponCycleChk;

		// Token: 0x040004A4 RID: 1188
		private global::System.Windows.Forms.Label P3CritLbl;

		// Token: 0x040004A5 RID: 1189
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3OnlyCritChk;

		// Token: 0x040004A6 RID: 1190
		private global::System.Windows.Forms.Label P3RapidLbl;

		// Token: 0x040004A7 RID: 1191
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3RapidFireChk;

		// Token: 0x040004A8 RID: 1192
		private global::System.Windows.Forms.Label P3AmmoLbl;

		// Token: 0x040004A9 RID: 1193
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3UnlimitedAmmoChk;

		// Token: 0x040004AA RID: 1194
		private global::System.Windows.Forms.Label P3PointsLbl;

		// Token: 0x040004AB RID: 1195
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3UnlimitedPointsChk;

		// Token: 0x040004AC RID: 1196
		private global::System.Windows.Forms.Label P3GodmodeLbl;

		// Token: 0x040004AD RID: 1197
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3GodChk;

		// Token: 0x040004AE RID: 1198
		private global::System.Windows.Forms.Label P4CycleLbl;

		// Token: 0x040004AF RID: 1199
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4WeaponCycleChk;

		// Token: 0x040004B0 RID: 1200
		private global::System.Windows.Forms.Label P4CritLbl;

		// Token: 0x040004B1 RID: 1201
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4OnlyCritChk;

		// Token: 0x040004B2 RID: 1202
		private global::System.Windows.Forms.Label P4RapidLbl;

		// Token: 0x040004B3 RID: 1203
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4RapidFireChk;

		// Token: 0x040004B4 RID: 1204
		private global::System.Windows.Forms.Label P4AmmoLbl;

		// Token: 0x040004B5 RID: 1205
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4UnlimitedAmmoChk;

		// Token: 0x040004B6 RID: 1206
		private global::System.Windows.Forms.Label P4PointsLbl;

		// Token: 0x040004B7 RID: 1207
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4UnlimitedPointsChk;

		// Token: 0x040004B8 RID: 1208
		private global::System.Windows.Forms.Label P4GodmodeLbl;

		// Token: 0x040004B9 RID: 1209
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4GodChk;

		// Token: 0x040004BA RID: 1210
		private global::System.Windows.Forms.Label CycleValue;

		// Token: 0x040004BB RID: 1211
		private global::System.Windows.Forms.Label TPValue;

		// Token: 0x040004BC RID: 1212
		private global::System.Windows.Forms.Label PlayerSpeedValue;

		// Token: 0x040004BD RID: 1213
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ToggleSPEED;

		// Token: 0x040004BE RID: 1214
		public global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar SpeedTrackBar;

		// Token: 0x040004BF RID: 1215
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040004C0 RID: 1216
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004C1 RID: 1217
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ToggleDCamo;

		// Token: 0x040004C2 RID: 1218
		private global::System.Windows.Forms.TextBox InjectLbl;

		// Token: 0x040004C3 RID: 1219
		private global::System.Windows.Forms.TextBox AttachedStateLbl;

		// Token: 0x040004C4 RID: 1220
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x040004C5 RID: 1221
		private global::Siticone.UI.WinForms.SiticoneRoundedComboBox WeaponSelectorCombo;

		// Token: 0x040004C6 RID: 1222
		public global::System.Windows.Forms.Panel PlayerAllOptionsPnl;

		// Token: 0x040004C7 RID: 1223
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040004C8 RID: 1224
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLCycle;

		// Token: 0x040004C9 RID: 1225
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040004CA RID: 1226
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLCritical;

		// Token: 0x040004CB RID: 1227
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040004CC RID: 1228
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLRapidFire;

		// Token: 0x040004CD RID: 1229
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040004CE RID: 1230
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLAmmo;

		// Token: 0x040004CF RID: 1231
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040004D0 RID: 1232
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLPoints;

		// Token: 0x040004D1 RID: 1233
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040004D2 RID: 1234
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLGod;

		// Token: 0x040004D3 RID: 1235
		public global::System.Windows.Forms.TextBox P1Name;

		// Token: 0x040004D4 RID: 1236
		public global::System.Windows.Forms.TextBox P2Name;

		// Token: 0x040004D5 RID: 1237
		public global::System.Windows.Forms.TextBox P3Name;

		// Token: 0x040004D6 RID: 1238
		public global::System.Windows.Forms.TextBox P4Name;

		// Token: 0x040004D7 RID: 1239
		public global::System.ComponentModel.BackgroundWorker ZombieWorker;

		// Token: 0x040004D8 RID: 1240
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040004D9 RID: 1241
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLFreeze;

		// Token: 0x040004DA RID: 1242
		public global::System.Windows.Forms.TextBox ZMCountLbl;

		// Token: 0x040004DB RID: 1243
		public global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040004DC RID: 1244
		private global::Siticone.UI.WinForms.SiticoneRoundedComboBox TeleportSelectorCombo;

		// Token: 0x040004DD RID: 1245
		public global::System.Windows.Forms.Button KillAll;

		// Token: 0x040004DE RID: 1246
		public global::System.Windows.Forms.Button TPAllMe;

		// Token: 0x040004DF RID: 1247
		public global::System.ComponentModel.BackgroundWorker LocationWorker;

		// Token: 0x040004E0 RID: 1248
		private global::Siticone.UI.WinForms.SiticoneControlBox CloseBtn;

		// Token: 0x040004E1 RID: 1249
		private global::System.Windows.Forms.Panel MainBackPnl;

		// Token: 0x040004E2 RID: 1250
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040004E3 RID: 1251
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLAFKDA;

		// Token: 0x040004E4 RID: 1252
		public global::System.ComponentModel.BackgroundWorker AutoFireWorker;

		// Token: 0x040004E5 RID: 1253
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040004E6 RID: 1254
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1AFNRChk;

		// Token: 0x040004E7 RID: 1255
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040004E8 RID: 1256
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2AFNRChk;

		// Token: 0x040004E9 RID: 1257
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040004EA RID: 1258
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3AFNRChk;

		// Token: 0x040004EB RID: 1259
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040004EC RID: 1260
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4AFNRChk;

		// Token: 0x040004ED RID: 1261
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040004EE RID: 1262
		private global::System.Windows.Forms.BindingSource bindingSource1;

		// Token: 0x040004EF RID: 1263
		private global::System.Windows.Forms.BindingSource bindingSource2;

		// Token: 0x040004F0 RID: 1264
		private global::System.Windows.Forms.BindingSource bindingSource3;

		// Token: 0x040004F1 RID: 1265
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton HomeBtn;

		// Token: 0x040004F2 RID: 1266
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;

		// Token: 0x040004F3 RID: 1267
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;

		// Token: 0x040004F4 RID: 1268
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;

		// Token: 0x040004F5 RID: 1269
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;

		// Token: 0x040004F6 RID: 1270
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;

		// Token: 0x040004F7 RID: 1271
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;

		// Token: 0x040004F8 RID: 1272
		private global::System.Windows.Forms.Label label24;

		// Token: 0x040004F9 RID: 1273
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x040004FA RID: 1274
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040004FB RID: 1275
		private global::System.Windows.Forms.PictureBox MainBackgroundImage;

		// Token: 0x040004FC RID: 1276
		private global::System.Windows.Forms.Panel daPanel;

		// Token: 0x040004FD RID: 1277
		private global::System.Windows.Forms.Label label22;

		// Token: 0x040004FE RID: 1278
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;

		// Token: 0x040004FF RID: 1279
		public global::System.Windows.Forms.Button button1;

		// Token: 0x04000500 RID: 1280
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton10;

		// Token: 0x04000501 RID: 1281
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton9;

		// Token: 0x04000502 RID: 1282
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton8;

		// Token: 0x04000503 RID: 1283
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton7;

		// Token: 0x04000504 RID: 1284
		private global::System.Windows.Forms.Panel papPanel;

		// Token: 0x04000505 RID: 1285
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000506 RID: 1286
		public global::System.Windows.Forms.Button button3;

		// Token: 0x04000507 RID: 1287
		public global::System.Windows.Forms.Button button2;

		// Token: 0x04000508 RID: 1288
		private global::Guna.UI2.WinForms.Guna2TextBox outputBox;

		// Token: 0x04000509 RID: 1289
		private global::Guna.UI2.WinForms.Guna2ComboBox comboBox2;

		// Token: 0x0400050A RID: 1290
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400050B RID: 1291
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400050C RID: 1292
		private global::System.Windows.Forms.Panel homePanel;

		// Token: 0x0400050D RID: 1293
		private global::System.Windows.Forms.Label label28;

		// Token: 0x0400050E RID: 1294
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400050F RID: 1295
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch siticoneToggleSwitch1;

		// Token: 0x04000510 RID: 1296
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04000511 RID: 1297
		public global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar1;

		// Token: 0x04000512 RID: 1298
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000513 RID: 1299
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000514 RID: 1300
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch siticoneToggleSwitch2;

		// Token: 0x04000515 RID: 1301
		public global::System.Windows.Forms.Button button6;

		// Token: 0x04000516 RID: 1302
		public global::System.Windows.Forms.Button button7;

		// Token: 0x04000517 RID: 1303
		public global::System.Windows.Forms.Button button4;

		// Token: 0x04000518 RID: 1304
		public global::System.Windows.Forms.Button button5;

		// Token: 0x04000519 RID: 1305
		public global::System.Windows.Forms.Button button8;
	}
}
