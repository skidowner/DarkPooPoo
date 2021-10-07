namespace Client
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002230 File Offset: 0x00000430
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002250 File Offset: 0x00000450
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.ClientName = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.ClientName.AutoSize = true;
			this.ClientName.BackColor = global::System.Drawing.Color.Black;
			this.ClientName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ClientName.ForeColor = global::System.Drawing.Color.Red;
			this.ClientName.Location = new global::System.Drawing.Point(9, 9);
			this.ClientName.Margin = new global::System.Windows.Forms.Padding(0);
			this.ClientName.MinimumSize = new global::System.Drawing.Size(150, 33);
			this.ClientName.Name = "ClientName";
			this.ClientName.Size = new global::System.Drawing.Size(288, 33);
			this.ClientName.TabIndex = 0;
			this.ClientName.Text = "DarkForces Client | Beta";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1106, 709);
			base.ControlBox = false;
			base.Controls.Add(this.ClientName);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form1";
			this.Text = "DarkForces";
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.Color.White;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label ClientName;
	}
}
