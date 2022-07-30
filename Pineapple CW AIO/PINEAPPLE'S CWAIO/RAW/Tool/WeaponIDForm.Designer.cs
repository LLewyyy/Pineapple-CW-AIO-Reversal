namespace RAW.Tool
{
	// Token: 0x020000B3 RID: 179
	public partial class WeaponIDForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x0003845E File Offset: 0x0003845E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00038480 File Offset: 0x00038480
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RAW.Tool.WeaponIDForm));
			this.InjectLbl = new global::System.Windows.Forms.TextBox();
			this.AttachedStateLbl = new global::System.Windows.Forms.TextBox();
			this.a2 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.TPValue = new global::System.Windows.Forms.Label();
			this.ToggleDCamo = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.PlayerSpeedValue = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.OneShotZombiesChk = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.TPZombie = new global::System.Windows.Forms.Button();
			this.TPZC = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.CycleValue = new global::System.Windows.Forms.Label();
			this.TPCLbl = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.ToggleSPEED = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.WeaponCycleIntervalTrackBar = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.ZombieTPDistTrackBar = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.SpeedTrackBar = new global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
			this.a1 = new global::System.Windows.Forms.Panel();
			this.DiscordBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.UsernameLbl = new global::System.Windows.Forms.TextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.a3 = new global::System.Windows.Forms.Panel();
			this.PlayerAllOptionsPnl = new global::System.Windows.Forms.Panel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.ALLAFKDA = new global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
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
			this.TeleportSelectorCombo = new global::Siticone.UI.WinForms.SiticoneRoundedComboBox();
			this.WeaponSelectorCombo = new global::Siticone.UI.WinForms.SiticoneRoundedComboBox();
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
			this.BGWorker = new global::System.ComponentModel.BackgroundWorker();
			this.DiscoWorker = new global::System.ComponentModel.BackgroundWorker();
			this.RapidFireWorker = new global::System.ComponentModel.BackgroundWorker();
			this.P1Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.P2Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.P3Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.P4Cycle = new global::System.Windows.Forms.Timer(this.components);
			this.AntiDebugWorker = new global::System.ComponentModel.BackgroundWorker();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.MainBackgroundImage = new global::System.Windows.Forms.PictureBox();
			this.ZombieWorker = new global::System.ComponentModel.BackgroundWorker();
			this.LocationWorker = new global::System.ComponentModel.BackgroundWorker();
			this.HomeBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.MainBackPnl = new global::System.Windows.Forms.Panel();
			this.GlobalBtn = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.PlayerAll = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.Player4 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.Player3 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.Player2 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.Player1 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
			this.CloseBtn = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.AutoFireWorker = new global::System.ComponentModel.BackgroundWorker();
			this.a2.SuspendLayout();
			this.a1.SuspendLayout();
			this.a3.SuspendLayout();
			this.PlayerAllOptionsPnl.SuspendLayout();
			this.Player1OptionsPnl.SuspendLayout();
			this.Player2OptionsPnl.SuspendLayout();
			this.Player3OptionsPnl.SuspendLayout();
			this.Player4OptionsPnl.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.MainBackgroundImage).BeginInit();
			this.MainBackPnl.SuspendLayout();
			base.SuspendLayout();
			this.InjectLbl.BackColor = global::System.Drawing.Color.FromArgb(29, 30, 28);
			this.InjectLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.InjectLbl.Font = new global::System.Drawing.Font("Arial", 11f, global::System.Drawing.FontStyle.Bold);
			this.InjectLbl.ForeColor = global::System.Drawing.Color.White;
			this.InjectLbl.Location = new global::System.Drawing.Point(204, 165);
			this.InjectLbl.Multiline = true;
			this.InjectLbl.Name = "InjectLbl";
			this.InjectLbl.Size = new global::System.Drawing.Size(141, 21);
			this.InjectLbl.TabIndex = 68;
			this.InjectLbl.Text = "INJECT STATUS";
			this.InjectLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.AttachedStateLbl.BackColor = global::System.Drawing.Color.FromArgb(29, 30, 28);
			this.AttachedStateLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.AttachedStateLbl.Font = new global::System.Drawing.Font("Arial", 11f, global::System.Drawing.FontStyle.Bold);
			this.AttachedStateLbl.ForeColor = global::System.Drawing.Color.Blue;
			this.AttachedStateLbl.Location = new global::System.Drawing.Point(204, 186);
			this.AttachedStateLbl.Multiline = true;
			this.AttachedStateLbl.Name = "AttachedStateLbl";
			this.AttachedStateLbl.Size = new global::System.Drawing.Size(141, 21);
			this.AttachedStateLbl.TabIndex = 67;
			this.AttachedStateLbl.Text = "DISCONNECTED";
			this.AttachedStateLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.a2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.a2.Controls.Add(this.label1);
			this.a2.Controls.Add(this.TPValue);
			this.a2.Controls.Add(this.ToggleDCamo);
			this.a2.Controls.Add(this.PlayerSpeedValue);
			this.a2.Controls.Add(this.label3);
			this.a2.Controls.Add(this.OneShotZombiesChk);
			this.a2.Controls.Add(this.TPZombie);
			this.a2.Controls.Add(this.TPZC);
			this.a2.Controls.Add(this.CycleValue);
			this.a2.Controls.Add(this.TPCLbl);
			this.a2.Controls.Add(this.label7);
			this.a2.Controls.Add(this.ToggleSPEED);
			this.a2.Controls.Add(this.label9);
			this.a2.Controls.Add(this.label8);
			this.a2.Controls.Add(this.WeaponCycleIntervalTrackBar);
			this.a2.Controls.Add(this.ZombieTPDistTrackBar);
			this.a2.Controls.Add(this.SpeedTrackBar);
			this.a2.Location = new global::System.Drawing.Point(51, 207);
			this.a2.Name = "a2";
			this.a2.Size = new global::System.Drawing.Size(548, 209);
			this.a2.TabIndex = 16;
			this.label1.AutoSize = true;
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(424, 64);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(107, 16);
			this.label1.TabIndex = 176;
			this.label1.Text = "DISCO CAMOS";
			this.TPValue.AutoSize = true;
			this.TPValue.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.TPValue.ForeColor = global::System.Drawing.Color.White;
			this.TPValue.Location = new global::System.Drawing.Point(399, 143);
			this.TPValue.Name = "TPValue";
			this.TPValue.Size = new global::System.Drawing.Size(31, 16);
			this.TPValue.TabIndex = 183;
			this.TPValue.Text = "150";
			this.ToggleDCamo.CheckedState.BorderRadius = 10;
			this.ToggleDCamo.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ToggleDCamo.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleDCamo.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleDCamo.CheckedState.Parent = this.ToggleDCamo;
			this.ToggleDCamo.Location = new global::System.Drawing.Point(384, 62);
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
			this.PlayerSpeedValue.AutoSize = true;
			this.PlayerSpeedValue.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.PlayerSpeedValue.ForeColor = global::System.Drawing.Color.White;
			this.PlayerSpeedValue.Location = new global::System.Drawing.Point(409, 107);
			this.PlayerSpeedValue.Name = "PlayerSpeedValue";
			this.PlayerSpeedValue.Size = new global::System.Drawing.Size(15, 16);
			this.PlayerSpeedValue.TabIndex = 182;
			this.PlayerSpeedValue.Text = "1";
			this.label3.AutoSize = true;
			this.label3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new global::System.Drawing.Point(256, 64);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(79, 16);
			this.label3.TabIndex = 98;
			this.label3.Text = "ONE SHOT";
			this.OneShotZombiesChk.CheckedState.BorderRadius = 10;
			this.OneShotZombiesChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.OneShotZombiesChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.OneShotZombiesChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.OneShotZombiesChk.CheckedState.Parent = this.OneShotZombiesChk;
			this.OneShotZombiesChk.Location = new global::System.Drawing.Point(218, 62);
			this.OneShotZombiesChk.Name = "OneShotZombiesChk";
			this.OneShotZombiesChk.ShadowDecoration.BorderRadius = 0;
			this.OneShotZombiesChk.ShadowDecoration.Parent = this.OneShotZombiesChk;
			this.OneShotZombiesChk.Size = new global::System.Drawing.Size(35, 20);
			this.OneShotZombiesChk.TabIndex = 97;
			this.OneShotZombiesChk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.OneShotZombiesChk.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.OneShotZombiesChk.UncheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.OneShotZombiesChk.UncheckedState.Parent = this.OneShotZombiesChk;
			this.TPZombie.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.TPZombie.FlatAppearance.BorderSize = 0;
			this.TPZombie.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TPZombie.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.TPZombie.ForeColor = global::System.Drawing.Color.White;
			this.TPZombie.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TPZombie.Location = new global::System.Drawing.Point(204, 14);
			this.TPZombie.Name = "TPZombie";
			this.TPZombie.Size = new global::System.Drawing.Size(140, 29);
			this.TPZombie.TabIndex = 93;
			this.TPZombie.Text = "TP LOCATION";
			this.TPZombie.UseVisualStyleBackColor = false;
			this.TPZombie.Click += new global::System.EventHandler(this.TPZL_Click);
			this.TPZC.CheckedState.BorderRadius = 10;
			this.TPZC.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.TPZC.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TPZC.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TPZC.CheckedState.Parent = this.TPZC;
			this.TPZC.Location = new global::System.Drawing.Point(18, 62);
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
			this.CycleValue.AutoSize = true;
			this.CycleValue.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.CycleValue.ForeColor = global::System.Drawing.Color.White;
			this.CycleValue.Location = new global::System.Drawing.Point(420, 176);
			this.CycleValue.Name = "CycleValue";
			this.CycleValue.Size = new global::System.Drawing.Size(15, 16);
			this.CycleValue.TabIndex = 184;
			this.CycleValue.Text = "2";
			this.TPCLbl.AutoSize = true;
			this.TPCLbl.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TPCLbl.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.TPCLbl.ForeColor = global::System.Drawing.Color.White;
			this.TPCLbl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TPCLbl.Location = new global::System.Drawing.Point(56, 64);
			this.TPCLbl.Name = "TPCLbl";
			this.TPCLbl.Size = new global::System.Drawing.Size(110, 16);
			this.TPCLbl.TabIndex = 102;
			this.TPCLbl.Text = "TP CROSSHAIR";
			this.label7.AutoSize = true;
			this.label7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new global::System.Drawing.Point(125, 110);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(96, 16);
			this.label7.TabIndex = 109;
			this.label7.Text = "TP DISTANCE";
			this.ToggleSPEED.CheckedState.BorderRadius = 10;
			this.ToggleSPEED.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ToggleSPEED.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleSPEED.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ToggleSPEED.CheckedState.Parent = this.ToggleSPEED;
			this.ToggleSPEED.Location = new global::System.Drawing.Point(119, 143);
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
			this.label9.AutoSize = true;
			this.label9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new global::System.Drawing.Point(159, 145);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(53, 16);
			this.label9.TabIndex = 178;
			this.label9.Text = "SPEED";
			this.label8.AutoSize = true;
			this.label8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new global::System.Drawing.Point(114, 179);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(119, 16);
			this.label8.TabIndex = 111;
			this.label8.Text = "WEAPON CYCLE";
			this.WeaponCycleIntervalTrackBar.Enabled = false;
			this.WeaponCycleIntervalTrackBar.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.WeaponCycleIntervalTrackBar.HoverState.Parent = this.WeaponCycleIntervalTrackBar;
			this.WeaponCycleIntervalTrackBar.Location = new global::System.Drawing.Point(239, 175);
			this.WeaponCycleIntervalTrackBar.Maximum = 10;
			this.WeaponCycleIntervalTrackBar.Minimum = 2;
			this.WeaponCycleIntervalTrackBar.Name = "WeaponCycleIntervalTrackBar";
			this.WeaponCycleIntervalTrackBar.Size = new global::System.Drawing.Size(173, 23);
			this.WeaponCycleIntervalTrackBar.Style = 1;
			this.WeaponCycleIntervalTrackBar.TabIndex = 112;
			this.WeaponCycleIntervalTrackBar.ThumbColor = global::System.Drawing.Color.SlateBlue;
			this.WeaponCycleIntervalTrackBar.Value = 2;
			this.WeaponCycleIntervalTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.WeaponCycleIntervalTrackBar_Scroll);
			this.ZombieTPDistTrackBar.Enabled = false;
			this.ZombieTPDistTrackBar.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.ZombieTPDistTrackBar.HoverState.Parent = this.ZombieTPDistTrackBar;
			this.ZombieTPDistTrackBar.Location = new global::System.Drawing.Point(228, 107);
			this.ZombieTPDistTrackBar.Maximum = 500;
			this.ZombieTPDistTrackBar.Minimum = 25;
			this.ZombieTPDistTrackBar.Name = "ZombieTPDistTrackBar";
			this.ZombieTPDistTrackBar.Size = new global::System.Drawing.Size(173, 23);
			this.ZombieTPDistTrackBar.Style = 1;
			this.ZombieTPDistTrackBar.TabIndex = 110;
			this.ZombieTPDistTrackBar.ThumbColor = global::System.Drawing.Color.SlateBlue;
			this.ZombieTPDistTrackBar.Value = 150;
			this.ZombieTPDistTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.TPZCDistance_Scroll);
			this.SpeedTrackBar.Enabled = false;
			this.SpeedTrackBar.FillColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.SpeedTrackBar.HoverState.Parent = this.SpeedTrackBar;
			this.SpeedTrackBar.LargeChange = 2;
			this.SpeedTrackBar.Location = new global::System.Drawing.Point(219, 142);
			this.SpeedTrackBar.Maximum = 15;
			this.SpeedTrackBar.Minimum = 1;
			this.SpeedTrackBar.Name = "SpeedTrackBar";
			this.SpeedTrackBar.Size = new global::System.Drawing.Size(172, 23);
			this.SpeedTrackBar.Style = 1;
			this.SpeedTrackBar.TabIndex = 179;
			this.SpeedTrackBar.ThumbColor = global::System.Drawing.Color.SlateBlue;
			this.SpeedTrackBar.Value = 1;
			this.SpeedTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.SpeedTrackBar_Scroll);
			this.a1.BackColor = global::System.Drawing.Color.FromArgb(29, 30, 28);
			this.a1.Controls.Add(this.InjectLbl);
			this.a1.Controls.Add(this.DiscordBtn);
			this.a1.Controls.Add(this.UsernameLbl);
			this.a1.Controls.Add(this.AttachedStateLbl);
			this.a1.Controls.Add(this.textBox1);
			this.a1.Location = new global::System.Drawing.Point(51, 207);
			this.a1.Name = "a1";
			this.a1.Size = new global::System.Drawing.Size(548, 209);
			this.a1.TabIndex = 15;
			this.DiscordBtn.Animated = false;
			this.DiscordBtn.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.DiscordBtn.BorderColor = global::System.Drawing.Color.Blue;
			this.DiscordBtn.BorderThickness = 1;
			this.DiscordBtn.CheckedState.Parent = this.DiscordBtn;
			this.DiscordBtn.CustomImages.Parent = this.DiscordBtn;
			this.DiscordBtn.FillColor = global::System.Drawing.Color.Blue;
			this.DiscordBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold);
			this.DiscordBtn.ForeColor = global::System.Drawing.Color.Black;
			this.DiscordBtn.HoveredState.BorderColor = global::System.Drawing.Color.SlateBlue;
			this.DiscordBtn.HoveredState.Parent = this.DiscordBtn;
			this.DiscordBtn.Image = global::RAW.Properties.Resources.Discord;
			this.DiscordBtn.Location = new global::System.Drawing.Point(200, 96);
			this.DiscordBtn.Name = "DiscordBtn";
			this.DiscordBtn.ShadowDecoration.Parent = this.DiscordBtn;
			this.DiscordBtn.Size = new global::System.Drawing.Size(149, 30);
			this.DiscordBtn.TabIndex = 62;
			this.DiscordBtn.Click += new global::System.EventHandler(this.DiscordBtn_Click);
			this.UsernameLbl.BackColor = global::System.Drawing.Color.FromArgb(29, 30, 28);
			this.UsernameLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.UsernameLbl.Font = new global::System.Drawing.Font("Arial Black", 8f, global::System.Drawing.FontStyle.Bold);
			this.UsernameLbl.ForeColor = global::System.Drawing.Color.Blue;
			this.UsernameLbl.Location = new global::System.Drawing.Point(109, 44);
			this.UsernameLbl.Multiline = true;
			this.UsernameLbl.Name = "UsernameLbl";
			this.UsernameLbl.Size = new global::System.Drawing.Size(330, 26);
			this.UsernameLbl.TabIndex = 1;
			this.UsernameLbl.Text = "Pineapple\ud83c\udf4d#9375";
			this.UsernameLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(29, 30, 28);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new global::System.Drawing.Font("Arial Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(109, 23);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(330, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "USERNAME";
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.a3.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.a3.Controls.Add(this.PlayerAllOptionsPnl);
			this.a3.Controls.Add(this.TeleportSelectorCombo);
			this.a3.Controls.Add(this.WeaponSelectorCombo);
			this.a3.Controls.Add(this.Player1OptionsPnl);
			this.a3.Controls.Add(this.Player2OptionsPnl);
			this.a3.Controls.Add(this.Player3OptionsPnl);
			this.a3.Controls.Add(this.Player4OptionsPnl);
			this.a3.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.a3.Location = new global::System.Drawing.Point(51, 207);
			this.a3.Name = "a3";
			this.a3.Size = new global::System.Drawing.Size(548, 209);
			this.a3.TabIndex = 16;
			this.PlayerAllOptionsPnl.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.PlayerAllOptionsPnl.Controls.Add(this.label10);
			this.PlayerAllOptionsPnl.Controls.Add(this.ALLAFKDA);
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
			this.PlayerAllOptionsPnl.Size = new global::System.Drawing.Size(548, 209);
			this.PlayerAllOptionsPnl.TabIndex = 141;
			this.label10.AutoSize = true;
			this.label10.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label10.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new global::System.Drawing.Point(54, 19);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(163, 19);
			this.label10.TabIndex = 192;
			this.label10.Text = "AFK DARK AETHER";
			this.ALLAFKDA.CheckedState.BorderRadius = 10;
			this.ALLAFKDA.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLAFKDA.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLAFKDA.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLAFKDA.CheckedState.Parent = this.ALLAFKDA;
			this.ALLAFKDA.Location = new global::System.Drawing.Point(13, 17);
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
			this.KillAll.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.KillAll.FlatAppearance.BorderSize = 0;
			this.KillAll.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.KillAll.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.KillAll.ForeColor = global::System.Drawing.Color.White;
			this.KillAll.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.KillAll.Location = new global::System.Drawing.Point(384, 14);
			this.KillAll.Name = "KillAll";
			this.KillAll.Size = new global::System.Drawing.Size(140, 29);
			this.KillAll.TabIndex = 190;
			this.KillAll.Text = "TP ALL TO JAIL";
			this.KillAll.UseVisualStyleBackColor = false;
			this.KillAll.Click += new global::System.EventHandler(this.TPAllToJailBtn);
			this.ZMCountLbl.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ZMCountLbl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ZMCountLbl.Font = new global::System.Drawing.Font("Arial Black", 7f, global::System.Drawing.FontStyle.Bold);
			this.ZMCountLbl.ForeColor = global::System.Drawing.Color.SlateBlue;
			this.ZMCountLbl.Location = new global::System.Drawing.Point(317, 187);
			this.ZMCountLbl.Multiline = true;
			this.ZMCountLbl.Name = "ZMCountLbl";
			this.ZMCountLbl.Size = new global::System.Drawing.Size(114, 13);
			this.ZMCountLbl.TabIndex = 142;
			this.ZMCountLbl.Text = "COUNT";
			this.ZMCountLbl.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ALLGod.CheckedState.BorderRadius = 10;
			this.ALLGod.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLGod.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLGod.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLGod.CheckedState.Parent = this.ALLGod;
			this.ALLGod.Location = new global::System.Drawing.Point(56, 57);
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
			this.TPAllMe.Location = new global::System.Drawing.Point(230, 14);
			this.TPAllMe.Name = "TPAllMe";
			this.TPAllMe.Size = new global::System.Drawing.Size(140, 29);
			this.TPAllMe.TabIndex = 189;
			this.TPAllMe.Text = "TP ALL TO ME";
			this.TPAllMe.UseVisualStyleBackColor = false;
			this.TPAllMe.Click += new global::System.EventHandler(this.TPAllToMeBtn);
			this.label14.AutoSize = true;
			this.label14.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label14.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.ForeColor = global::System.Drawing.Color.White;
			this.label14.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label14.Location = new global::System.Drawing.Point(94, 140);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(149, 19);
			this.label14.TabIndex = 127;
			this.label14.Text = "UNLIMITED AMMO";
			this.textBox2.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new global::System.Drawing.Font("Arial Black", 7f, global::System.Drawing.FontStyle.Bold);
			this.textBox2.ForeColor = global::System.Drawing.Color.White;
			this.textBox2.Location = new global::System.Drawing.Point(317, 174);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(114, 22);
			this.textBox2.TabIndex = 137;
			this.textBox2.Text = "ZOMBIES LEFT";
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ALLRapidFire.CheckedState.BorderRadius = 10;
			this.ALLRapidFire.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLRapidFire.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLRapidFire.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLRapidFire.CheckedState.Parent = this.ALLRapidFire;
			this.ALLRapidFire.Location = new global::System.Drawing.Point(56, 179);
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
			this.ALLAmmo.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLAmmo.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLAmmo.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLAmmo.CheckedState.Parent = this.ALLAmmo;
			this.ALLAmmo.Location = new global::System.Drawing.Point(56, 139);
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
			this.label6.Location = new global::System.Drawing.Point(361, 58);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(107, 19);
			this.label6.TabIndex = 136;
			this.label6.Text = "FREEZE ALL";
			this.label13.AutoSize = true;
			this.label13.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label13.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.White;
			this.label13.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label13.Location = new global::System.Drawing.Point(94, 180);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(100, 19);
			this.label13.TabIndex = 129;
			this.label13.Text = "RAPID FIRE";
			this.ALLFreeze.CheckedState.BorderRadius = 10;
			this.ALLFreeze.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLFreeze.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLFreeze.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLFreeze.CheckedState.Parent = this.ALLFreeze;
			this.ALLFreeze.Location = new global::System.Drawing.Point(323, 57);
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
			this.label15.Location = new global::System.Drawing.Point(94, 97);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(161, 19);
			this.label15.TabIndex = 125;
			this.label15.Text = "UNLIMITED POINTS";
			this.ALLCritical.CheckedState.BorderRadius = 10;
			this.ALLCritical.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLCritical.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLCritical.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLCritical.CheckedState.Parent = this.ALLCritical;
			this.ALLCritical.Location = new global::System.Drawing.Point(323, 96);
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
			this.label11.Location = new global::System.Drawing.Point(361, 140);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(140, 19);
			this.label11.TabIndex = 133;
			this.label11.Text = "WEAPON CYCLE";
			this.ALLPoints.CheckedState.BorderRadius = 10;
			this.ALLPoints.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLPoints.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLPoints.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLPoints.CheckedState.Parent = this.ALLPoints;
			this.ALLPoints.Location = new global::System.Drawing.Point(56, 96);
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
			this.label12.Location = new global::System.Drawing.Point(361, 97);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(124, 19);
			this.label12.TabIndex = 131;
			this.label12.Text = "CRITICAL KILL";
			this.ALLCycle.CheckedState.BorderRadius = 10;
			this.ALLCycle.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.ALLCycle.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.ALLCycle.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.ALLCycle.CheckedState.Parent = this.ALLCycle;
			this.ALLCycle.Location = new global::System.Drawing.Point(323, 139);
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
			this.label16.Location = new global::System.Drawing.Point(94, 58);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(93, 19);
			this.label16.TabIndex = 123;
			this.label16.Text = "GODMODE";
			this.TeleportSelectorCombo.BackColor = global::System.Drawing.Color.Transparent;
			this.TeleportSelectorCombo.BorderColor = global::System.Drawing.Color.SlateBlue;
			this.TeleportSelectorCombo.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.TeleportSelectorCombo.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TeleportSelectorCombo.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TeleportSelectorCombo.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.TeleportSelectorCombo.FocusedColor = global::System.Drawing.Color.SlateBlue;
			this.TeleportSelectorCombo.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.TeleportSelectorCombo.ForeColor = global::System.Drawing.Color.SlateBlue;
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
			this.TeleportSelectorCombo.Location = new global::System.Drawing.Point(4, 171);
			this.TeleportSelectorCombo.MaxDropDownItems = 10;
			this.TeleportSelectorCombo.Name = "TeleportSelectorCombo";
			this.TeleportSelectorCombo.ShadowDecoration.Parent = this.TeleportSelectorCombo;
			this.TeleportSelectorCombo.Size = new global::System.Drawing.Size(259, 36);
			this.TeleportSelectorCombo.StartIndex = 0;
			this.TeleportSelectorCombo.TabIndex = 143;
			this.TeleportSelectorCombo.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.TeleportSelectorCombo.SelectedIndexChanged += new global::System.EventHandler(this.TeleportSelectorCombo_SelectedIndexChanged);
			this.WeaponSelectorCombo.BackColor = global::System.Drawing.Color.Transparent;
			this.WeaponSelectorCombo.BorderColor = global::System.Drawing.Color.SlateBlue;
			this.WeaponSelectorCombo.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.WeaponSelectorCombo.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WeaponSelectorCombo.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.WeaponSelectorCombo.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.WeaponSelectorCombo.FocusedColor = global::System.Drawing.Color.SlateBlue;
			this.WeaponSelectorCombo.Font = new global::System.Drawing.Font("Arial", 10f, global::System.Drawing.FontStyle.Bold);
			this.WeaponSelectorCombo.ForeColor = global::System.Drawing.Color.SlateBlue;
			this.WeaponSelectorCombo.HoveredState.Parent = this.WeaponSelectorCombo;
			this.WeaponSelectorCombo.ItemHeight = 30;
			this.WeaponSelectorCombo.Items.AddRange(new object[]
			{
				"",
				"WEAPONS",
				"0",
				"1 ",
				"2 ",
				"3 ",
				"4 ",
				"5 ",
				"6 ",
				"7 ",
				"8 ",
				"9 ",
				"10 ",
				"11 ",
				"12 ",
				"13 ",
				"14 ",
				"15 ",
				"16 ",
				"17 ",
				"18 ",
				"19 ",
				"20 ",
				"21 ",
				"22 ",
				"23 ",
				"24 ",
				"25 ",
				"26 ",
				"27 ",
				"28 ",
				"29 ",
				"30 ",
				"31 ",
				"32 ",
				"33 ",
				"34 ",
				"35 ",
				"36 ",
				"37 ",
				"38 ",
				"39 ",
				"40 ",
				"41 ",
				"42 ",
				"43 ",
				"44 ",
				"45 ",
				"46 ",
				"47 ",
				"48 ",
				"49 ",
				"50 ",
				"51 ",
				"52 ",
				"53 ",
				"54 ",
				"55 ",
				"56 ",
				"57 ",
				"58 ",
				"59 ",
				"60 ",
				"61 ",
				"62 ",
				"63 ",
				"64 ",
				"65 ",
				"66 ",
				"67 ",
				"68 ",
				"69 ",
				"70 ",
				"71 ",
				"72 ",
				"73 ",
				"74 ",
				"75 ",
				"76 ",
				"77 ",
				"78 ",
				"79 ",
				"80 ",
				"81 ",
				"82 ",
				"83 ",
				"84 ",
				"85 ",
				"86 ",
				"87 ",
				"88 ",
				"89 ",
				"90 ",
				"91 ",
				"92 ",
				"93 ",
				"94 ",
				"95 ",
				"96 ",
				"97 ",
				"98 ",
				"99 ",
				"100 ",
				"101 ",
				"102 ",
				"103 ",
				"104 ",
				"105 ",
				"106",
				"107 ",
				"108",
				"109 ",
				"110 ",
				"111 ",
				"112 ",
				"113 ",
				"114 ",
				"115 ",
				"116 ",
				"117 ",
				"118 ",
				"119 ",
				"120 ",
				"121 ",
				"122 ",
				"123 ",
				"124 ",
				"125 ",
				"126 ",
				"127 ",
				"128 ",
				"129 ",
				"130 ",
				"131 ",
				"132 ",
				"133 ",
				"134 ",
				"135 ",
				"136 ",
				"137 ",
				"138 ",
				"139 ",
				"140 ",
				"141 ",
				"142 ",
				"143 ",
				"144 ",
				"145 ",
				"146 ",
				"147 ",
				"148 ",
				"149 ",
				"150 ",
				"151 ",
				"152 ",
				"153 ",
				"154 ",
				"155 ",
				"156 ",
				"157 ",
				"158 ",
				"159",
				"160 ",
				"161 ",
				"162 ",
				"163 ",
				"164 ",
				"165 ",
				"166 ",
				"167 ",
				"168 ",
				"169 ",
				"170 ",
				"171 ",
				"172 ",
				"173 ",
				"174 ",
				"175 ",
				"176 ",
				"177 ",
				"178 ",
				"179 ",
				"180 ",
				"181 ",
				"182 ",
				"183 ",
				"184 ",
				"185 ",
				"186 ",
				"187 ",
				"188 ",
				"189 ",
				"190 ",
				"191 ",
				"192 ",
				"193 ",
				"194 ",
				"195 ",
				"196 ",
				"197 ",
				"198 ",
				"199",
				"200 ",
				"201 ",
				"202 ",
				"203 ",
				"204 ",
				"205",
				"206 ",
				"207 ",
				"208 ",
				"209 ",
				"210 ",
				"211 ",
				"212 ",
				"213 ",
				"214 ",
				"215 ",
				"216 ",
				"217 ",
				"218 ",
				"219 ",
				"220 ",
				"221 ",
				"222 ",
				"223 ",
				"224 ",
				"225 ",
				"226 ",
				"227 ",
				"228 ",
				"229 ",
				"230 ",
				"231 ",
				"232 ",
				"233 ",
				"234 ",
				"235 ",
				"236 ",
				"237 ",
				"238 ",
				"239 ",
				"240 ",
				"241 ",
				"242 ",
				"243 ",
				"244 ",
				"245 ",
				"246 ",
				"247 ",
				"248 ",
				"249 ",
				"250 ",
				"251 ",
				"252 ",
				"253 ",
				"254 ",
				"255 ",
				"256 ",
				"257 ",
				"258 ",
				"259 ",
				"260 ",
				"261 ",
				"262 ",
				"263 ",
				"264 ",
				"265 ",
				"266 ",
				"267 ",
				"268 ",
				"269 ",
				"270 ",
				"271 ",
				"272 ",
				"273 ",
				"274 ",
				"275 ",
				"276 ",
				"277 ",
				"278 ",
				"279 ",
				"280 ",
				"281 ",
				"282 ",
				"283 ",
				"284 ",
				"285 ",
				"286 ",
				"287 ",
				"288 ",
				"289 ",
				"290 ",
				"291 ",
				"292 ",
				"293 ",
				"294 ",
				"295 ",
				"296 ",
				"297 ",
				"298 ",
				"299 ",
				"300 ",
				"301 ",
				"302 ",
				"303 ",
				"304 ",
				"305 ",
				"306 ",
				"307 ",
				"308 ",
				"309 ",
				"310 ",
				"311 ",
				"312",
				"313 ",
				"314 ",
				"315 ",
				"316 ",
				"317 ",
				"318 ",
				"319 ",
				"320 ",
				"321 ",
				"322 ",
				"323 ",
				"324 ",
				"325 ",
				"326 ",
				"327 ",
				"328 ",
				"329 ",
				"330 ",
				"331 ",
				"332 ",
				"333 ",
				"334 ",
				"335 ",
				"336 ",
				"337 ",
				"338 ",
				"339 ",
				"340 ",
				"341 ",
				"342 ",
				"343 ",
				"344 ",
				"345 ",
				"346 ",
				"347 ",
				"348 ",
				"349 ",
				"350 ",
				"351 ",
				"352 ",
				"353 ",
				"354 ",
				"355 ",
				"356 ",
				"357 ",
				"358 ",
				"359 ",
				"360 ",
				"361 ",
				"362 ",
				"363 ",
				"364 ",
				"365 ",
				"366 ",
				"367 ",
				"368 ",
				"369 ",
				"370 ",
				"371 ",
				"372 ",
				"373 ",
				"374 ",
				"375 ",
				"376 ",
				"377 ",
				"378 ",
				"379 ",
				"380 ",
				"381 ",
				"382 ",
				"383 ",
				"384 ",
				"385 ",
				"386 ",
				"387 ",
				"388 ",
				"389 ",
				"390 ",
				"391 ",
				"392 ",
				"393 ",
				"394 ",
				"395 ",
				"396 ",
				"397 ",
				"398 ",
				"399 ",
				"400 ",
				"401 ",
				"402 ",
				"403 ",
				"404 ",
				"405 ",
				"406 ",
				"407 ",
				"408 ",
				"409 ",
				"410 ",
				"411 ",
				"412 ",
				"413 ",
				"414 ",
				"415 ",
				"416 ",
				"417 ",
				"418 ",
				"419 ",
				"420 ",
				"421 ",
				"422 ",
				"423 ",
				"424 ",
				"425 ",
				"426 ",
				"427 ",
				"428 ",
				"429 ",
				"430 ",
				"431 ",
				"432 ",
				"433 ",
				"434 ",
				"435 ",
				"436 ",
				"437 ",
				"438 ",
				"439 ",
				"440 ",
				"441 ",
				"442 ",
				"443 ",
				"444 ",
				"445 ",
				"446 ",
				"447 ",
				"448 ",
				"449 ",
				"450 ",
				"451 ",
				"452 ",
				"453 ",
				"454 ",
				"455 ",
				"456 ",
				"457 ",
				"458 ",
				"459 ",
				"460 ",
				"461 ",
				"462 ",
				"463 ",
				"464 ",
				"465 ",
				"466 ",
				"467 ",
				"468 ",
				"469 ",
				"470 ",
				"471 ",
				"472 ",
				"473 ",
				"474 ",
				"475 ",
				"476 ",
				"477 ",
				"478 ",
				"479 ",
				"480 ",
				"481 ",
				"482 ",
				"483 ",
				"484 ",
				"485 ",
				"486 ",
				"487 ",
				"488 ",
				"489 ",
				"490 ",
				"491 ",
				"492 ",
				"493 ",
				"494 ",
				"495 ",
				"496 ",
				"497 ",
				"498 ",
				"499 ",
				"500 ",
				"501 ",
				"502 ",
				"503 ",
				"504 ",
				"505 ",
				"506 ",
				"507 ",
				"508 ",
				"509 ",
				"510 ",
				"511 ",
				"512 ",
				"513 ",
				"514 ",
				"515 ",
				"516 ",
				"517 ",
				"518 ",
				"519 ",
				"520 ",
				"521 ",
				"522 ",
				"523 ",
				"524 ",
				"525 ",
				"526 ",
				"527 ",
				"528 ",
				"529 ",
				"530 ",
				"531 ",
				"532 ",
				"533 ",
				"534 ",
				"535 ",
				"536 ",
				"537 ",
				"538 ",
				"539 ",
				"540 ",
				"541 ",
				"542 ",
				"543 ",
				"544 ",
				"545 ",
				"546 ",
				"547 ",
				"548 ",
				"549 ",
				"550 "
			});
			this.WeaponSelectorCombo.ItemsAppearance.Parent = this.WeaponSelectorCombo;
			this.WeaponSelectorCombo.Location = new global::System.Drawing.Point(285, 171);
			this.WeaponSelectorCombo.MaxDropDownItems = 10;
			this.WeaponSelectorCombo.Name = "WeaponSelectorCombo";
			this.WeaponSelectorCombo.ShadowDecoration.Parent = this.WeaponSelectorCombo;
			this.WeaponSelectorCombo.Size = new global::System.Drawing.Size(259, 36);
			this.WeaponSelectorCombo.StartIndex = 1;
			this.WeaponSelectorCombo.TabIndex = 67;
			this.WeaponSelectorCombo.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.WeaponSelectorCombo.SelectedIndexChanged += new global::System.EventHandler(this.WeaponSelectorCombo_SelectedIndexChanged);
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
			this.Player1OptionsPnl.Size = new global::System.Drawing.Size(548, 170);
			this.Player1OptionsPnl.TabIndex = 140;
			this.label17.AutoSize = true;
			this.label17.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label17.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label17.Location = new global::System.Drawing.Point(72, 140);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(196, 19);
			this.label17.TabIndex = 137;
			this.label17.Text = "AUTO FIRE | NO RECOIL";
			this.Player1AFNRChk.CheckedState.BorderRadius = 10;
			this.Player1AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player1AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1AFNRChk.CheckedState.Parent = this.Player1AFNRChk;
			this.Player1AFNRChk.Location = new global::System.Drawing.Point(34, 139);
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
			this.P1Name.ForeColor = global::System.Drawing.Color.SlateBlue;
			this.P1Name.Location = new global::System.Drawing.Point(17, 14);
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
			this.P1CycleLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P1CycleLbl.Name = "P1CycleLbl";
			this.P1CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P1CycleLbl.TabIndex = 133;
			this.P1CycleLbl.Text = "WEAPON CYCLE";
			this.Player1WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player1WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player1WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1WeaponCycleChk.CheckedState.Parent = this.Player1WeaponCycleChk;
			this.Player1WeaponCycleChk.Location = new global::System.Drawing.Point(330, 98);
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
			this.P1CritLbl.Location = new global::System.Drawing.Point(368, 58);
			this.P1CritLbl.Name = "P1CritLbl";
			this.P1CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P1CritLbl.TabIndex = 131;
			this.P1CritLbl.Text = "CRITICAL KILL";
			this.Player1OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player1OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player1OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1OnlyCritChk.CheckedState.Parent = this.Player1OnlyCritChk;
			this.Player1OnlyCritChk.Location = new global::System.Drawing.Point(330, 57);
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
			this.P1RapidLbl.Location = new global::System.Drawing.Point(368, 140);
			this.P1RapidLbl.Name = "P1RapidLbl";
			this.P1RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P1RapidLbl.TabIndex = 129;
			this.P1RapidLbl.Text = "RAPID FIRE";
			this.Player1RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player1RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player1RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1RapidFireChk.CheckedState.Parent = this.Player1RapidFireChk;
			this.Player1RapidFireChk.Location = new global::System.Drawing.Point(330, 139);
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
			this.P1AmmoLbl.Location = new global::System.Drawing.Point(72, 99);
			this.P1AmmoLbl.Name = "P1AmmoLbl";
			this.P1AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P1AmmoLbl.TabIndex = 127;
			this.P1AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player1UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player1UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player1UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedAmmoChk.CheckedState.Parent = this.Player1UnlimitedAmmoChk;
			this.Player1UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 98);
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
			this.P1PointsLbl.Location = new global::System.Drawing.Point(73, 58);
			this.P1PointsLbl.Name = "P1PointsLbl";
			this.P1PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P1PointsLbl.TabIndex = 125;
			this.P1PointsLbl.Text = "UNLIMITED POINTS";
			this.Player1UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player1UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player1UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1UnlimitedPointsChk.CheckedState.Parent = this.Player1UnlimitedPointsChk;
			this.Player1UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 57);
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
			this.P1GodmodeLbl.Location = new global::System.Drawing.Point(369, 18);
			this.P1GodmodeLbl.Name = "P1GodmodeLbl";
			this.P1GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P1GodmodeLbl.TabIndex = 123;
			this.P1GodmodeLbl.Text = "GODMODE";
			this.Player1GodChk.CheckedState.BorderRadius = 10;
			this.Player1GodChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player1GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player1GodChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player1GodChk.CheckedState.Parent = this.Player1GodChk;
			this.Player1GodChk.Location = new global::System.Drawing.Point(330, 17);
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
			this.Player2OptionsPnl.Size = new global::System.Drawing.Size(548, 170);
			this.Player2OptionsPnl.TabIndex = 139;
			this.label18.AutoSize = true;
			this.label18.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label18.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.White;
			this.label18.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label18.Location = new global::System.Drawing.Point(72, 140);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(196, 19);
			this.label18.TabIndex = 139;
			this.label18.Text = "AUTO FIRE | NO RECOIL";
			this.Player2AFNRChk.CheckedState.BorderRadius = 10;
			this.Player2AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player2AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player2AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player2AFNRChk.CheckedState.Parent = this.Player2AFNRChk;
			this.Player2AFNRChk.Location = new global::System.Drawing.Point(34, 139);
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
			this.P2Name.ForeColor = global::System.Drawing.Color.SlateBlue;
			this.P2Name.Location = new global::System.Drawing.Point(17, 14);
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
			this.P2CycleLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P2CycleLbl.Name = "P2CycleLbl";
			this.P2CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P2CycleLbl.TabIndex = 133;
			this.P2CycleLbl.Text = "WEAPON CYCLE";
			this.Player2WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player2WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player2WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2WeaponCycleChk.CheckedState.Parent = this.Player2WeaponCycleChk;
			this.Player2WeaponCycleChk.Location = new global::System.Drawing.Point(330, 98);
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
			this.P2CritLbl.Location = new global::System.Drawing.Point(368, 58);
			this.P2CritLbl.Name = "P2CritLbl";
			this.P2CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P2CritLbl.TabIndex = 131;
			this.P2CritLbl.Text = "CRITICAL KILL";
			this.Player2OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player2OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player2OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2OnlyCritChk.CheckedState.Parent = this.Player2OnlyCritChk;
			this.Player2OnlyCritChk.Location = new global::System.Drawing.Point(330, 57);
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
			this.P2RapidLbl.Location = new global::System.Drawing.Point(368, 140);
			this.P2RapidLbl.Name = "P2RapidLbl";
			this.P2RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P2RapidLbl.TabIndex = 129;
			this.P2RapidLbl.Text = "RAPID FIRE";
			this.Player2RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player2RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player2RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2RapidFireChk.CheckedState.Parent = this.Player2RapidFireChk;
			this.Player2RapidFireChk.Location = new global::System.Drawing.Point(330, 139);
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
			this.P2AmmoLbl.Location = new global::System.Drawing.Point(72, 99);
			this.P2AmmoLbl.Name = "P2AmmoLbl";
			this.P2AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P2AmmoLbl.TabIndex = 127;
			this.P2AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player2UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player2UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player2UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedAmmoChk.CheckedState.Parent = this.Player2UnlimitedAmmoChk;
			this.Player2UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 98);
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
			this.P2PointsLbl.Location = new global::System.Drawing.Point(73, 58);
			this.P2PointsLbl.Name = "P2PointsLbl";
			this.P2PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P2PointsLbl.TabIndex = 125;
			this.P2PointsLbl.Text = "UNLIMITED POINTS";
			this.Player2UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player2UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player2UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2UnlimitedPointsChk.CheckedState.Parent = this.Player2UnlimitedPointsChk;
			this.Player2UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 57);
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
			this.P2GodmodeLbl.Location = new global::System.Drawing.Point(369, 18);
			this.P2GodmodeLbl.Name = "P2GodmodeLbl";
			this.P2GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P2GodmodeLbl.TabIndex = 123;
			this.P2GodmodeLbl.Text = "GODMODE";
			this.Player2GodChk.CheckedState.BorderRadius = 10;
			this.Player2GodChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player2GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2GodChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2GodChk.CheckedState.Parent = this.Player2GodChk;
			this.Player2GodChk.Location = new global::System.Drawing.Point(330, 17);
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
			this.Player3OptionsPnl.Size = new global::System.Drawing.Size(548, 170);
			this.Player3OptionsPnl.TabIndex = 138;
			this.label19.AutoSize = true;
			this.label19.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label19.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.ForeColor = global::System.Drawing.Color.White;
			this.label19.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label19.Location = new global::System.Drawing.Point(72, 140);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(196, 19);
			this.label19.TabIndex = 139;
			this.label19.Text = "AUTO FIRE | NO RECOIL";
			this.Player3AFNRChk.CheckedState.BorderRadius = 10;
			this.Player3AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player3AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player3AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player3AFNRChk.CheckedState.Parent = this.Player3AFNRChk;
			this.Player3AFNRChk.Location = new global::System.Drawing.Point(34, 139);
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
			this.P3Name.ForeColor = global::System.Drawing.Color.SlateBlue;
			this.P3Name.Location = new global::System.Drawing.Point(17, 14);
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
			this.P3CycleLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P3CycleLbl.Name = "P3CycleLbl";
			this.P3CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P3CycleLbl.TabIndex = 133;
			this.P3CycleLbl.Text = "WEAPON CYCLE";
			this.Player3WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player3WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player3WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3WeaponCycleChk.CheckedState.Parent = this.Player3WeaponCycleChk;
			this.Player3WeaponCycleChk.Location = new global::System.Drawing.Point(330, 98);
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
			this.P3CritLbl.Location = new global::System.Drawing.Point(368, 58);
			this.P3CritLbl.Name = "P3CritLbl";
			this.P3CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P3CritLbl.TabIndex = 131;
			this.P3CritLbl.Text = "CRITICAL KILL";
			this.Player3OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player3OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player3OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3OnlyCritChk.CheckedState.Parent = this.Player3OnlyCritChk;
			this.Player3OnlyCritChk.Location = new global::System.Drawing.Point(330, 57);
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
			this.P3RapidLbl.Location = new global::System.Drawing.Point(368, 140);
			this.P3RapidLbl.Name = "P3RapidLbl";
			this.P3RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P3RapidLbl.TabIndex = 129;
			this.P3RapidLbl.Text = "RAPID FIRE";
			this.Player3RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player3RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player3RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3RapidFireChk.CheckedState.Parent = this.Player3RapidFireChk;
			this.Player3RapidFireChk.Location = new global::System.Drawing.Point(330, 139);
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
			this.P3AmmoLbl.Location = new global::System.Drawing.Point(72, 99);
			this.P3AmmoLbl.Name = "P3AmmoLbl";
			this.P3AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P3AmmoLbl.TabIndex = 127;
			this.P3AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player3UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player3UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player3UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedAmmoChk.CheckedState.Parent = this.Player3UnlimitedAmmoChk;
			this.Player3UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 98);
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
			this.P3PointsLbl.Location = new global::System.Drawing.Point(73, 58);
			this.P3PointsLbl.Name = "P3PointsLbl";
			this.P3PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P3PointsLbl.TabIndex = 125;
			this.P3PointsLbl.Text = "UNLIMITED POINTS";
			this.Player3UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player3UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player3UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3UnlimitedPointsChk.CheckedState.Parent = this.Player3UnlimitedPointsChk;
			this.Player3UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 57);
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
			this.P3GodmodeLbl.Location = new global::System.Drawing.Point(369, 18);
			this.P3GodmodeLbl.Name = "P3GodmodeLbl";
			this.P3GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P3GodmodeLbl.TabIndex = 123;
			this.P3GodmodeLbl.Text = "GODMODE";
			this.Player3GodChk.CheckedState.BorderRadius = 10;
			this.Player3GodChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player3GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3GodChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3GodChk.CheckedState.Parent = this.Player3GodChk;
			this.Player3GodChk.Location = new global::System.Drawing.Point(330, 17);
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
			this.Player4OptionsPnl.Size = new global::System.Drawing.Size(548, 170);
			this.Player4OptionsPnl.TabIndex = 137;
			this.label20.AutoSize = true;
			this.label20.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label20.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label20.ForeColor = global::System.Drawing.Color.White;
			this.label20.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label20.Location = new global::System.Drawing.Point(72, 140);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(196, 19);
			this.label20.TabIndex = 139;
			this.label20.Text = "AUTO FIRE | NO RECOIL";
			this.Player4AFNRChk.CheckedState.BorderRadius = 10;
			this.Player4AFNRChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player4AFNRChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.Black;
			this.Player4AFNRChk.CheckedState.InnerColor = global::System.Drawing.Color.Black;
			this.Player4AFNRChk.CheckedState.Parent = this.Player4AFNRChk;
			this.Player4AFNRChk.Location = new global::System.Drawing.Point(34, 139);
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
			this.P4Name.ForeColor = global::System.Drawing.Color.SlateBlue;
			this.P4Name.Location = new global::System.Drawing.Point(17, 14);
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
			this.P4CycleLbl.Location = new global::System.Drawing.Point(368, 98);
			this.P4CycleLbl.Name = "P4CycleLbl";
			this.P4CycleLbl.Size = new global::System.Drawing.Size(140, 19);
			this.P4CycleLbl.TabIndex = 133;
			this.P4CycleLbl.Text = "WEAPON CYCLE";
			this.Player4WeaponCycleChk.CheckedState.BorderRadius = 10;
			this.Player4WeaponCycleChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player4WeaponCycleChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4WeaponCycleChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4WeaponCycleChk.CheckedState.Parent = this.Player4WeaponCycleChk;
			this.Player4WeaponCycleChk.Location = new global::System.Drawing.Point(330, 98);
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
			this.P4CritLbl.Location = new global::System.Drawing.Point(368, 58);
			this.P4CritLbl.Name = "P4CritLbl";
			this.P4CritLbl.Size = new global::System.Drawing.Size(124, 19);
			this.P4CritLbl.TabIndex = 131;
			this.P4CritLbl.Text = "CRITICAL KILL";
			this.Player4OnlyCritChk.CheckedState.BorderRadius = 10;
			this.Player4OnlyCritChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player4OnlyCritChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4OnlyCritChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4OnlyCritChk.CheckedState.Parent = this.Player4OnlyCritChk;
			this.Player4OnlyCritChk.Location = new global::System.Drawing.Point(330, 57);
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
			this.P4RapidLbl.Location = new global::System.Drawing.Point(368, 140);
			this.P4RapidLbl.Name = "P4RapidLbl";
			this.P4RapidLbl.Size = new global::System.Drawing.Size(100, 19);
			this.P4RapidLbl.TabIndex = 129;
			this.P4RapidLbl.Text = "RAPID FIRE";
			this.Player4RapidFireChk.CheckedState.BorderRadius = 10;
			this.Player4RapidFireChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player4RapidFireChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4RapidFireChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4RapidFireChk.CheckedState.Parent = this.Player4RapidFireChk;
			this.Player4RapidFireChk.Location = new global::System.Drawing.Point(330, 139);
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
			this.P4AmmoLbl.Location = new global::System.Drawing.Point(72, 99);
			this.P4AmmoLbl.Name = "P4AmmoLbl";
			this.P4AmmoLbl.Size = new global::System.Drawing.Size(149, 19);
			this.P4AmmoLbl.TabIndex = 127;
			this.P4AmmoLbl.Text = "UNLIMITED AMMO";
			this.Player4UnlimitedAmmoChk.CheckedState.BorderRadius = 10;
			this.Player4UnlimitedAmmoChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player4UnlimitedAmmoChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedAmmoChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedAmmoChk.CheckedState.Parent = this.Player4UnlimitedAmmoChk;
			this.Player4UnlimitedAmmoChk.Location = new global::System.Drawing.Point(34, 98);
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
			this.P4PointsLbl.Location = new global::System.Drawing.Point(73, 58);
			this.P4PointsLbl.Name = "P4PointsLbl";
			this.P4PointsLbl.Size = new global::System.Drawing.Size(161, 19);
			this.P4PointsLbl.TabIndex = 125;
			this.P4PointsLbl.Text = "UNLIMITED POINTS";
			this.Player4UnlimitedPointsChk.CheckedState.BorderRadius = 10;
			this.Player4UnlimitedPointsChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player4UnlimitedPointsChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedPointsChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4UnlimitedPointsChk.CheckedState.Parent = this.Player4UnlimitedPointsChk;
			this.Player4UnlimitedPointsChk.Location = new global::System.Drawing.Point(34, 57);
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
			this.P4GodmodeLbl.Location = new global::System.Drawing.Point(369, 18);
			this.P4GodmodeLbl.Name = "P4GodmodeLbl";
			this.P4GodmodeLbl.Size = new global::System.Drawing.Size(93, 19);
			this.P4GodmodeLbl.TabIndex = 123;
			this.P4GodmodeLbl.Text = "GODMODE";
			this.Player4GodChk.CheckedState.BorderRadius = 10;
			this.Player4GodChk.CheckedState.FillColor = global::System.Drawing.Color.SlateBlue;
			this.Player4GodChk.CheckedState.InnerBorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4GodChk.CheckedState.InnerColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4GodChk.CheckedState.Parent = this.Player4GodChk;
			this.Player4GodChk.Location = new global::System.Drawing.Point(330, 17);
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
			this.BGWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
			this.DiscoWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.DiscoWorker_DoWork);
			this.RapidFireWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.RapidFireWorker_DoWork);
			this.P1Cycle.Tick += new global::System.EventHandler(this.P1Cycle_Tick);
			this.P2Cycle.Tick += new global::System.EventHandler(this.P2Cycle_Tick);
			this.P3Cycle.Tick += new global::System.EventHandler(this.P3Cycle_Tick);
			this.P4Cycle.Tick += new global::System.EventHandler(this.P4Cycle_Tick);
			this.AntiDebugWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.AntiDebugWorker_DoWork);
			this.siticoneDragControl1.TargetControl = this.MainBackgroundImage;
			this.MainBackgroundImage.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("MainBackgroundImage.BackgroundImage");
			this.MainBackgroundImage.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MainBackgroundImage.Image");
			this.MainBackgroundImage.Location = new global::System.Drawing.Point(0, 0);
			this.MainBackgroundImage.Name = "MainBackgroundImage";
			this.MainBackgroundImage.Size = new global::System.Drawing.Size(644, 448);
			this.MainBackgroundImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.MainBackgroundImage.TabIndex = 0;
			this.MainBackgroundImage.TabStop = false;
			this.MainBackgroundImage.Click += new global::System.EventHandler(this.MainBackgroundImage_Click);
			this.ZombieWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.ZombieWorker_DoWork);
			this.ZombieWorker.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.ZombieWorker_RunWorkerCompleted);
			this.LocationWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.LocationWorker_DoWork);
			this.HomeBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.BorderColor = global::System.Drawing.Color.Empty;
			this.HomeBtn.ButtonMode = 1;
			this.HomeBtn.Checked = true;
			this.HomeBtn.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.HomeBtn.CheckedState.Parent = this.HomeBtn;
			this.HomeBtn.CustomImages.Parent = this.HomeBtn;
			this.HomeBtn.DisabledState.Parent = this.HomeBtn;
			this.HomeBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.HomeBtn.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.HomeBtn.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.HomeBtn.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.HomeBtn.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.HomeBtn.HoverState.Parent = this.HomeBtn;
			this.HomeBtn.Location = new global::System.Drawing.Point(39, 96);
			this.HomeBtn.Name = "HomeBtn";
			this.HomeBtn.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
			this.HomeBtn.Size = new global::System.Drawing.Size(82, 77);
			this.HomeBtn.TabIndex = 0;
			this.HomeBtn.UseTransparentBackground = true;
			this.HomeBtn.Click += new global::System.EventHandler(this.HomeBtn_Click);
			this.MainBackPnl.Controls.Add(this.HomeBtn);
			this.MainBackPnl.Controls.Add(this.GlobalBtn);
			this.MainBackPnl.Controls.Add(this.PlayerAll);
			this.MainBackPnl.Controls.Add(this.Player4);
			this.MainBackPnl.Controls.Add(this.Player3);
			this.MainBackPnl.Controls.Add(this.Player2);
			this.MainBackPnl.Controls.Add(this.Player1);
			this.MainBackPnl.Controls.Add(this.a1);
			this.MainBackPnl.Controls.Add(this.a2);
			this.MainBackPnl.Controls.Add(this.a3);
			this.MainBackPnl.Controls.Add(this.CloseBtn);
			this.MainBackPnl.Controls.Add(this.MainBackgroundImage);
			this.MainBackPnl.Location = new global::System.Drawing.Point(0, 0);
			this.MainBackPnl.Name = "MainBackPnl";
			this.MainBackPnl.Size = new global::System.Drawing.Size(644, 448);
			this.MainBackPnl.TabIndex = 69;
			this.GlobalBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.BorderColor = global::System.Drawing.Color.Empty;
			this.GlobalBtn.ButtonMode = 1;
			this.GlobalBtn.Checked = true;
			this.GlobalBtn.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.GlobalBtn.CheckedState.Parent = this.GlobalBtn;
			this.GlobalBtn.CustomImages.Parent = this.GlobalBtn;
			this.GlobalBtn.DisabledState.Parent = this.GlobalBtn;
			this.GlobalBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.GlobalBtn.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.GlobalBtn.ForeColor = global::System.Drawing.Color.White;
			this.GlobalBtn.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.GlobalBtn.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.GlobalBtn.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.GlobalBtn.HoverState.Parent = this.GlobalBtn;
			this.GlobalBtn.Location = new global::System.Drawing.Point(127, 97);
			this.GlobalBtn.Name = "GlobalBtn";
			this.GlobalBtn.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.GlobalBtn.ShadowDecoration.Parent = this.GlobalBtn;
			this.GlobalBtn.Size = new global::System.Drawing.Size(76, 77);
			this.GlobalBtn.TabIndex = 52;
			this.GlobalBtn.UseTransparentBackground = true;
			this.GlobalBtn.Click += new global::System.EventHandler(this.GlobalSettingsBtn_Click);
			this.PlayerAll.BackColor = global::System.Drawing.Color.Transparent;
			this.PlayerAll.BorderColor = global::System.Drawing.Color.Empty;
			this.PlayerAll.ButtonMode = 1;
			this.PlayerAll.Checked = true;
			this.PlayerAll.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.PlayerAll.CheckedState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.PlayerAll.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.PlayerAll.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.PlayerAll.CheckedState.Parent = this.PlayerAll;
			this.PlayerAll.CustomImages.Parent = this.PlayerAll;
			this.PlayerAll.DisabledState.Parent = this.PlayerAll;
			this.PlayerAll.FillColor = global::System.Drawing.Color.Transparent;
			this.PlayerAll.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.PlayerAll.ForeColor = global::System.Drawing.Color.White;
			this.PlayerAll.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.PlayerAll.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.PlayerAll.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.PlayerAll.HoverState.Parent = this.PlayerAll;
			this.PlayerAll.Location = new global::System.Drawing.Point(206, 96);
			this.PlayerAll.Name = "PlayerAll";
			this.PlayerAll.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.PlayerAll.ShadowDecoration.Parent = this.PlayerAll;
			this.PlayerAll.Size = new global::System.Drawing.Size(76, 77);
			this.PlayerAll.TabIndex = 57;
			this.PlayerAll.UseTransparentBackground = true;
			this.PlayerAll.Click += new global::System.EventHandler(this.ALLPlayers_Click);
			this.Player4.BackColor = global::System.Drawing.Color.Transparent;
			this.Player4.BorderColor = global::System.Drawing.Color.Empty;
			this.Player4.ButtonMode = 1;
			this.Player4.Checked = true;
			this.Player4.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.Player4.CheckedState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.Player4.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.Player4.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.Player4.CheckedState.Parent = this.Player4;
			this.Player4.CustomImages.Parent = this.Player4;
			this.Player4.DisabledState.Parent = this.Player4;
			this.Player4.FillColor = global::System.Drawing.Color.Transparent;
			this.Player4.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.Player4.ForeColor = global::System.Drawing.Color.White;
			this.Player4.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.Player4.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.Player4.HoverState.Parent = this.Player4;
			this.Player4.Location = new global::System.Drawing.Point(530, 96);
			this.Player4.Name = "Player4";
			this.Player4.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player4.ShadowDecoration.Parent = this.Player4;
			this.Player4.Size = new global::System.Drawing.Size(82, 77);
			this.Player4.TabIndex = 56;
			this.Player4.UseTransparentBackground = true;
			this.Player4.Click += new global::System.EventHandler(this.Player4_Click);
			this.Player3.BackColor = global::System.Drawing.Color.Transparent;
			this.Player3.BorderColor = global::System.Drawing.Color.Empty;
			this.Player3.ButtonMode = 1;
			this.Player3.Checked = true;
			this.Player3.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.Player3.CheckedState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.Player3.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.Player3.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.Player3.CheckedState.Parent = this.Player3;
			this.Player3.CustomImages.Parent = this.Player3;
			this.Player3.DisabledState.Parent = this.Player3;
			this.Player3.FillColor = global::System.Drawing.Color.Transparent;
			this.Player3.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.Player3.ForeColor = global::System.Drawing.Color.White;
			this.Player3.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.Player3.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.Player3.HoverState.Parent = this.Player3;
			this.Player3.Location = new global::System.Drawing.Point(448, 96);
			this.Player3.Name = "Player3";
			this.Player3.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player3.ShadowDecoration.Parent = this.Player3;
			this.Player3.Size = new global::System.Drawing.Size(76, 77);
			this.Player3.TabIndex = 55;
			this.Player3.UseTransparentBackground = true;
			this.Player3.Click += new global::System.EventHandler(this.Player3_Click);
			this.Player2.BackColor = global::System.Drawing.Color.Transparent;
			this.Player2.BorderColor = global::System.Drawing.Color.Empty;
			this.Player2.ButtonMode = 1;
			this.Player2.Checked = true;
			this.Player2.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.Player2.CheckedState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.Player2.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.Player2.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.Player2.CheckedState.Parent = this.Player2;
			this.Player2.CustomImages.Parent = this.Player2;
			this.Player2.DisabledState.Parent = this.Player2;
			this.Player2.FillColor = global::System.Drawing.Color.Transparent;
			this.Player2.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.Player2.ForeColor = global::System.Drawing.Color.White;
			this.Player2.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.Player2.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.Player2.HoverState.Parent = this.Player2;
			this.Player2.Location = new global::System.Drawing.Point(368, 96);
			this.Player2.Name = "Player2";
			this.Player2.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player2.ShadowDecoration.Parent = this.Player2;
			this.Player2.Size = new global::System.Drawing.Size(76, 77);
			this.Player2.TabIndex = 54;
			this.Player2.UseTransparentBackground = true;
			this.Player2.Click += new global::System.EventHandler(this.Player2_Click);
			this.Player1.BackColor = global::System.Drawing.Color.Transparent;
			this.Player1.BorderColor = global::System.Drawing.Color.Empty;
			this.Player1.ButtonMode = 1;
			this.Player1.Checked = true;
			this.Player1.CheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.Player1.CheckedState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.Player1.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.Player1.CheckedState.ForeColor = global::System.Drawing.Color.Black;
			this.Player1.CheckedState.Parent = this.Player1;
			this.Player1.CustomImages.Parent = this.Player1;
			this.Player1.DisabledState.Parent = this.Player1;
			this.Player1.FillColor = global::System.Drawing.Color.Transparent;
			this.Player1.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.Player1.ForeColor = global::System.Drawing.Color.White;
			this.Player1.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.Player1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1.HoverState.ForeColor = global::System.Drawing.Color.White;
			this.Player1.HoverState.Parent = this.Player1;
			this.Player1.Location = new global::System.Drawing.Point(287, 96);
			this.Player1.Name = "Player1";
			this.Player1.PressedColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.Player1.ShadowDecoration.Parent = this.Player1;
			this.Player1.Size = new global::System.Drawing.Size(76, 77);
			this.Player1.TabIndex = 53;
			this.Player1.UseTransparentBackground = true;
			this.Player1.Click += new global::System.EventHandler(this.Player1_Click);
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
			this.CloseBtn.Location = new global::System.Drawing.Point(611, 15);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.PressedColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
			this.CloseBtn.Size = new global::System.Drawing.Size(22, 21);
			this.CloseBtn.TabIndex = 50;
			this.CloseBtn.Click += new global::System.EventHandler(this.CloseBtn_Click);
			this.AutoFireWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.AutoFireWorker_DoWork);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(644, 448);
			base.ControlBox = false;
			base.Controls.Add(this.MainBackPnl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "WeaponIDForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FRENZY'S [WEAPON ID TOOL]";
			this.a2.ResumeLayout(false);
			this.a2.PerformLayout();
			this.a1.ResumeLayout(false);
			this.a1.PerformLayout();
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
			this.MainBackPnl.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400052E RID: 1326
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400052F RID: 1327
		public global::System.Windows.Forms.Panel a1;

		// Token: 0x04000530 RID: 1328
		public global::System.Windows.Forms.Panel a2;

		// Token: 0x04000531 RID: 1329
		public global::System.Windows.Forms.Panel a3;

		// Token: 0x04000532 RID: 1330
		public global::System.Windows.Forms.Panel Player1OptionsPnl;

		// Token: 0x04000533 RID: 1331
		public global::System.ComponentModel.BackgroundWorker BGWorker;

		// Token: 0x04000534 RID: 1332
		public global::System.ComponentModel.BackgroundWorker DiscoWorker;

		// Token: 0x04000535 RID: 1333
		public global::System.ComponentModel.BackgroundWorker RapidFireWorker;

		// Token: 0x04000536 RID: 1334
		public global::System.Windows.Forms.Timer P1Cycle;

		// Token: 0x04000537 RID: 1335
		public global::System.Windows.Forms.Timer P2Cycle;

		// Token: 0x04000538 RID: 1336
		public global::System.Windows.Forms.Timer P3Cycle;

		// Token: 0x04000539 RID: 1337
		public global::System.Windows.Forms.Timer P4Cycle;

		// Token: 0x0400053A RID: 1338
		public global::System.ComponentModel.BackgroundWorker AntiDebugWorker;

		// Token: 0x0400053B RID: 1339
		public global::System.Windows.Forms.Panel Player2OptionsPnl;

		// Token: 0x0400053C RID: 1340
		public global::System.Windows.Forms.Panel Player3OptionsPnl;

		// Token: 0x0400053D RID: 1341
		public global::System.Windows.Forms.Panel Player4OptionsPnl;

		// Token: 0x0400053E RID: 1342
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400053F RID: 1343
		private global::System.Windows.Forms.TextBox UsernameLbl;

		// Token: 0x04000540 RID: 1344
		private global::Siticone.UI.WinForms.SiticoneRoundedButton DiscordBtn;

		// Token: 0x04000541 RID: 1345
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000542 RID: 1346
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000543 RID: 1347
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000544 RID: 1348
		private global::System.Windows.Forms.Label TPCLbl;

		// Token: 0x04000545 RID: 1349
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch OneShotZombiesChk;

		// Token: 0x04000546 RID: 1350
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch TPZC;

		// Token: 0x04000547 RID: 1351
		public global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar WeaponCycleIntervalTrackBar;

		// Token: 0x04000548 RID: 1352
		public global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar ZombieTPDistTrackBar;

		// Token: 0x04000549 RID: 1353
		public global::System.Windows.Forms.Button TPZombie;

		// Token: 0x0400054A RID: 1354
		private global::System.Windows.Forms.Label P1CycleLbl;

		// Token: 0x0400054B RID: 1355
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1WeaponCycleChk;

		// Token: 0x0400054C RID: 1356
		private global::System.Windows.Forms.Label P1CritLbl;

		// Token: 0x0400054D RID: 1357
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1OnlyCritChk;

		// Token: 0x0400054E RID: 1358
		private global::System.Windows.Forms.Label P1RapidLbl;

		// Token: 0x0400054F RID: 1359
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1RapidFireChk;

		// Token: 0x04000550 RID: 1360
		private global::System.Windows.Forms.Label P1AmmoLbl;

		// Token: 0x04000551 RID: 1361
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1UnlimitedAmmoChk;

		// Token: 0x04000552 RID: 1362
		private global::System.Windows.Forms.Label P1PointsLbl;

		// Token: 0x04000553 RID: 1363
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1UnlimitedPointsChk;

		// Token: 0x04000554 RID: 1364
		private global::System.Windows.Forms.Label P1GodmodeLbl;

		// Token: 0x04000555 RID: 1365
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1GodChk;

		// Token: 0x04000556 RID: 1366
		private global::System.Windows.Forms.Label P2CycleLbl;

		// Token: 0x04000557 RID: 1367
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2WeaponCycleChk;

		// Token: 0x04000558 RID: 1368
		private global::System.Windows.Forms.Label P2CritLbl;

		// Token: 0x04000559 RID: 1369
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2OnlyCritChk;

		// Token: 0x0400055A RID: 1370
		private global::System.Windows.Forms.Label P2RapidLbl;

		// Token: 0x0400055B RID: 1371
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2RapidFireChk;

		// Token: 0x0400055C RID: 1372
		private global::System.Windows.Forms.Label P2AmmoLbl;

		// Token: 0x0400055D RID: 1373
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2UnlimitedAmmoChk;

		// Token: 0x0400055E RID: 1374
		private global::System.Windows.Forms.Label P2PointsLbl;

		// Token: 0x0400055F RID: 1375
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2UnlimitedPointsChk;

		// Token: 0x04000560 RID: 1376
		private global::System.Windows.Forms.Label P2GodmodeLbl;

		// Token: 0x04000561 RID: 1377
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2GodChk;

		// Token: 0x04000562 RID: 1378
		private global::System.Windows.Forms.Label P3CycleLbl;

		// Token: 0x04000563 RID: 1379
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3WeaponCycleChk;

		// Token: 0x04000564 RID: 1380
		private global::System.Windows.Forms.Label P3CritLbl;

		// Token: 0x04000565 RID: 1381
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3OnlyCritChk;

		// Token: 0x04000566 RID: 1382
		private global::System.Windows.Forms.Label P3RapidLbl;

		// Token: 0x04000567 RID: 1383
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3RapidFireChk;

		// Token: 0x04000568 RID: 1384
		private global::System.Windows.Forms.Label P3AmmoLbl;

		// Token: 0x04000569 RID: 1385
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3UnlimitedAmmoChk;

		// Token: 0x0400056A RID: 1386
		private global::System.Windows.Forms.Label P3PointsLbl;

		// Token: 0x0400056B RID: 1387
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3UnlimitedPointsChk;

		// Token: 0x0400056C RID: 1388
		private global::System.Windows.Forms.Label P3GodmodeLbl;

		// Token: 0x0400056D RID: 1389
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3GodChk;

		// Token: 0x0400056E RID: 1390
		private global::System.Windows.Forms.Label P4CycleLbl;

		// Token: 0x0400056F RID: 1391
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4WeaponCycleChk;

		// Token: 0x04000570 RID: 1392
		private global::System.Windows.Forms.Label P4CritLbl;

		// Token: 0x04000571 RID: 1393
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4OnlyCritChk;

		// Token: 0x04000572 RID: 1394
		private global::System.Windows.Forms.Label P4RapidLbl;

		// Token: 0x04000573 RID: 1395
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4RapidFireChk;

		// Token: 0x04000574 RID: 1396
		private global::System.Windows.Forms.Label P4AmmoLbl;

		// Token: 0x04000575 RID: 1397
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4UnlimitedAmmoChk;

		// Token: 0x04000576 RID: 1398
		private global::System.Windows.Forms.Label P4PointsLbl;

		// Token: 0x04000577 RID: 1399
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4UnlimitedPointsChk;

		// Token: 0x04000578 RID: 1400
		private global::System.Windows.Forms.Label P4GodmodeLbl;

		// Token: 0x04000579 RID: 1401
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4GodChk;

		// Token: 0x0400057A RID: 1402
		private global::System.Windows.Forms.Label CycleValue;

		// Token: 0x0400057B RID: 1403
		private global::System.Windows.Forms.Label TPValue;

		// Token: 0x0400057C RID: 1404
		private global::System.Windows.Forms.Label PlayerSpeedValue;

		// Token: 0x0400057D RID: 1405
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ToggleSPEED;

		// Token: 0x0400057E RID: 1406
		public global::Siticone.Desktop.UI.WinForms.SiticoneTrackBar SpeedTrackBar;

		// Token: 0x0400057F RID: 1407
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000580 RID: 1408
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000581 RID: 1409
		public global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ToggleDCamo;

		// Token: 0x04000582 RID: 1410
		private global::System.Windows.Forms.TextBox InjectLbl;

		// Token: 0x04000583 RID: 1411
		private global::System.Windows.Forms.TextBox AttachedStateLbl;

		// Token: 0x04000584 RID: 1412
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000585 RID: 1413
		private global::Siticone.UI.WinForms.SiticoneRoundedComboBox WeaponSelectorCombo;

		// Token: 0x04000586 RID: 1414
		public global::System.Windows.Forms.Panel PlayerAllOptionsPnl;

		// Token: 0x04000587 RID: 1415
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000588 RID: 1416
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLCycle;

		// Token: 0x04000589 RID: 1417
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400058A RID: 1418
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLCritical;

		// Token: 0x0400058B RID: 1419
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400058C RID: 1420
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLRapidFire;

		// Token: 0x0400058D RID: 1421
		private global::System.Windows.Forms.Label label14;

		// Token: 0x0400058E RID: 1422
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLAmmo;

		// Token: 0x0400058F RID: 1423
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000590 RID: 1424
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLPoints;

		// Token: 0x04000591 RID: 1425
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000592 RID: 1426
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLGod;

		// Token: 0x04000593 RID: 1427
		public global::System.Windows.Forms.TextBox P1Name;

		// Token: 0x04000594 RID: 1428
		public global::System.Windows.Forms.TextBox P2Name;

		// Token: 0x04000595 RID: 1429
		public global::System.Windows.Forms.TextBox P3Name;

		// Token: 0x04000596 RID: 1430
		public global::System.Windows.Forms.TextBox P4Name;

		// Token: 0x04000597 RID: 1431
		public global::System.ComponentModel.BackgroundWorker ZombieWorker;

		// Token: 0x04000598 RID: 1432
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000599 RID: 1433
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLFreeze;

		// Token: 0x0400059A RID: 1434
		public global::System.Windows.Forms.TextBox ZMCountLbl;

		// Token: 0x0400059B RID: 1435
		public global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400059C RID: 1436
		private global::Siticone.UI.WinForms.SiticoneRoundedComboBox TeleportSelectorCombo;

		// Token: 0x0400059D RID: 1437
		public global::System.Windows.Forms.Button KillAll;

		// Token: 0x0400059E RID: 1438
		public global::System.Windows.Forms.Button TPAllMe;

		// Token: 0x0400059F RID: 1439
		public global::System.ComponentModel.BackgroundWorker LocationWorker;

		// Token: 0x040005A0 RID: 1440
		public global::System.Windows.Forms.PictureBox MainBackgroundImage;

		// Token: 0x040005A1 RID: 1441
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton HomeBtn;

		// Token: 0x040005A2 RID: 1442
		private global::Siticone.UI.WinForms.SiticoneControlBox CloseBtn;

		// Token: 0x040005A3 RID: 1443
		private global::System.Windows.Forms.Panel MainBackPnl;

		// Token: 0x040005A4 RID: 1444
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton PlayerAll;

		// Token: 0x040005A5 RID: 1445
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton Player4;

		// Token: 0x040005A6 RID: 1446
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton Player3;

		// Token: 0x040005A7 RID: 1447
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton Player2;

		// Token: 0x040005A8 RID: 1448
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton Player1;

		// Token: 0x040005A9 RID: 1449
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton GlobalBtn;

		// Token: 0x040005AA RID: 1450
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040005AB RID: 1451
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch ALLAFKDA;

		// Token: 0x040005AC RID: 1452
		public global::System.ComponentModel.BackgroundWorker AutoFireWorker;

		// Token: 0x040005AD RID: 1453
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040005AE RID: 1454
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player1AFNRChk;

		// Token: 0x040005AF RID: 1455
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040005B0 RID: 1456
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player2AFNRChk;

		// Token: 0x040005B1 RID: 1457
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040005B2 RID: 1458
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player3AFNRChk;

		// Token: 0x040005B3 RID: 1459
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040005B4 RID: 1460
		private global::Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch Player4AFNRChk;
	}
}
