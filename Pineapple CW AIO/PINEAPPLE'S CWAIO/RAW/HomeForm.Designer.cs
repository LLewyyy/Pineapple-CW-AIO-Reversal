namespace RAW
{
	// Token: 0x02000098 RID: 152
	public partial class HomeForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00022168 File Offset: 0x00022168
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00022188 File Offset: 0x00022188
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RAW.HomeForm));
			this.guna2ComboBox1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.guna2ComboBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ComboBox1.BorderColor = global::System.Drawing.Color.Blue;
			this.guna2ComboBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox1.FillColor = global::System.Drawing.Color.FromArgb(24, 22, 21);
			this.guna2ComboBox1.FocusedColor = global::System.Drawing.Color.BlueViolet;
			this.guna2ComboBox1.FocusedState.BorderColor = global::System.Drawing.Color.BlueViolet;
			this.guna2ComboBox1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.guna2ComboBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.guna2ComboBox1.ItemHeight = 30;
			this.guna2ComboBox1.Items.AddRange(new object[]
			{
				"CW ZOMBIES TOOL",
				"WEAPON ID TOOL",
				"DARK AETHER TOOL",
				"PACK-A-PUNCH TOOL"
			});
			this.guna2ComboBox1.Location = new global::System.Drawing.Point(70, 80);
			this.guna2ComboBox1.Name = "guna2ComboBox1";
			this.guna2ComboBox1.Size = new global::System.Drawing.Size(232, 36);
			this.guna2ComboBox1.TabIndex = 0;
			this.guna2ComboBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.guna2GradientButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2GradientButton1.BorderRadius = 10;
			this.guna2GradientButton1.BorderThickness = 1;
			this.guna2GradientButton1.CheckedState.BorderColor = global::System.Drawing.Color.Black;
			this.guna2GradientButton1.CheckedState.FillColor = global::System.Drawing.Color.BlueViolet;
			this.guna2GradientButton1.CheckedState.FillColor2 = global::System.Drawing.Color.DarkViolet;
			this.guna2GradientButton1.FillColor = global::System.Drawing.Color.Blue;
			this.guna2GradientButton1.FillColor2 = global::System.Drawing.Color.Blue;
			this.guna2GradientButton1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientButton1.ForeColor = global::System.Drawing.Color.FromArgb(24, 22, 21);
			this.guna2GradientButton1.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientButton1.HoverState.BorderColor = global::System.Drawing.Color.Black;
			this.guna2GradientButton1.HoverState.FillColor = global::System.Drawing.Color.DarkViolet;
			this.guna2GradientButton1.HoverState.FillColor2 = global::System.Drawing.Color.BlueViolet;
			this.guna2GradientButton1.Location = new global::System.Drawing.Point(111, 131);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.Size = new global::System.Drawing.Size(150, 36);
			this.guna2GradientButton1.TabIndex = 1;
			this.guna2GradientButton1.Text = "Load";
			this.guna2GradientButton1.Click += new global::System.EventHandler(this.guna2GradientButton1_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(69, 43);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(233, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "PINEAPPPLE'S CW AIO";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(372, 211);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2GradientButton1);
			base.Controls.Add(this.guna2ComboBox1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "HomeForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PINEAPPLE'S CW AIO";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003DD RID: 989
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003DE RID: 990
		private global::Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;

		// Token: 0x040003DF RID: 991
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;

		// Token: 0x040003E0 RID: 992
		private global::System.Windows.Forms.Label label1;
	}
}
