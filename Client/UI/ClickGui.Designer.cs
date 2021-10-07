namespace Client.UI
{
	// Token: 0x0200000A RID: 10
	public partial class ClickGui : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002B90 File Offset: 0x00000D90
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002BB0 File Offset: 0x00000DB0
		private void InitializeComponent()
		{
            this.ClientName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TriggerBot = new System.Windows.Forms.Button();
            this.Combat = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Glide = new System.Windows.Forms.Button();
            this.Flight = new System.Windows.Forms.Button();
            this.CCFly = new System.Windows.Forms.Button();
            this.BounceGlide = new System.Windows.Forms.Button();
            this.Speed = new System.Windows.Forms.Button();
            this.AirWalk = new System.Windows.Forms.Button();
            this.AirJump = new System.Windows.Forms.Button();
            this.Movement = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.FullBright = new System.Windows.Forms.Button();
            this.Visual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.BackColor = System.Drawing.Color.Black;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.ForeColor = System.Drawing.Color.Red;
            this.ClientName.Location = new System.Drawing.Point(9, 9);
            this.ClientName.Margin = new System.Windows.Forms.Padding(0);
            this.ClientName.MinimumSize = new System.Drawing.Size(100, 33);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(100, 33);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "ClickGUI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(27, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 381);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.TriggerBot);
            this.panel2.Controls.Add(this.Combat);
            this.panel2.Location = new System.Drawing.Point(10, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 357);
            this.panel2.TabIndex = 0;
            // 
            // TriggerBot
            // 
            this.TriggerBot.Location = new System.Drawing.Point(3, 60);
            this.TriggerBot.Name = "TriggerBot";
            this.TriggerBot.Size = new System.Drawing.Size(143, 35);
            this.TriggerBot.TabIndex = 1;
            this.TriggerBot.Text = "TriggerBot";
            this.TriggerBot.UseVisualStyleBackColor = true;
            this.TriggerBot.Click += new System.EventHandler(this.TriggerBot_Click);
            // 
            // Combat
            // 
            this.Combat.AutoSize = true;
            this.Combat.Location = new System.Drawing.Point(29, 14);
            this.Combat.Name = "Combat";
            this.Combat.Size = new System.Drawing.Size(65, 20);
            this.Combat.TabIndex = 0;
            this.Combat.Text = "Combat";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(223, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 381);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.Glide);
            this.panel4.Controls.Add(this.Flight);
            this.panel4.Controls.Add(this.CCFly);
            this.panel4.Controls.Add(this.BounceGlide);
            this.panel4.Controls.Add(this.Speed);
            this.panel4.Controls.Add(this.AirWalk);
            this.panel4.Controls.Add(this.AirJump);
            this.panel4.Controls.Add(this.Movement);
            this.panel4.Location = new System.Drawing.Point(10, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 357);
            this.panel4.TabIndex = 0;
            // 
            // Glide
            // 
            this.Glide.Location = new System.Drawing.Point(3, 246);
            this.Glide.Name = "Glide";
            this.Glide.Size = new System.Drawing.Size(143, 35);
            this.Glide.TabIndex = 7;
            this.Glide.Text = "Glide";
            this.Glide.UseVisualStyleBackColor = true;
            this.Glide.Click += new System.EventHandler(this.button1_Click);
            // 
            // Flight
            // 
            this.Flight.Location = new System.Drawing.Point(3, 215);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(143, 35);
            this.Flight.TabIndex = 6;
            this.Flight.Text = "Flight";
            this.Flight.UseVisualStyleBackColor = true;
            this.Flight.Click += new System.EventHandler(this.Flight_Click);
            // 
            // CCFly
            // 
            this.CCFly.Location = new System.Drawing.Point(3, 184);
            this.CCFly.Name = "CCFly";
            this.CCFly.Size = new System.Drawing.Size(143, 35);
            this.CCFly.TabIndex = 5;
            this.CCFly.Text = "CCFly";
            this.CCFly.UseVisualStyleBackColor = true;
            this.CCFly.Click += new System.EventHandler(this.CCFly_Click);
            // 
            // BounceGlide
            // 
            this.BounceGlide.Location = new System.Drawing.Point(3, 152);
            this.BounceGlide.Name = "BounceGlide";
            this.BounceGlide.Size = new System.Drawing.Size(143, 35);
            this.BounceGlide.TabIndex = 4;
            this.BounceGlide.Text = "BounceGlide";
            this.BounceGlide.UseVisualStyleBackColor = true;
            this.BounceGlide.Click += new System.EventHandler(this.BounceGlide_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(3, 122);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(143, 35);
            this.Speed.TabIndex = 3;
            this.Speed.Text = "Speed";
            this.Speed.UseVisualStyleBackColor = true;
            this.Speed.Click += new System.EventHandler(this.Speed_Click);
            // 
            // AirWalk
            // 
            this.AirWalk.Location = new System.Drawing.Point(3, 91);
            this.AirWalk.Name = "AirWalk";
            this.AirWalk.Size = new System.Drawing.Size(143, 35);
            this.AirWalk.TabIndex = 2;
            this.AirWalk.Text = "AirWalk";
            this.AirWalk.UseVisualStyleBackColor = true;
            this.AirWalk.Click += new System.EventHandler(this.AirWalk_Click);
            // 
            // AirJump
            // 
            this.AirJump.Location = new System.Drawing.Point(3, 60);
            this.AirJump.Name = "AirJump";
            this.AirJump.Size = new System.Drawing.Size(143, 35);
            this.AirJump.TabIndex = 1;
            this.AirJump.Text = "AirJump";
            this.AirJump.UseVisualStyleBackColor = true;
            this.AirJump.Click += new System.EventHandler(this.AirJump_Click);
            // 
            // Movement
            // 
            this.Movement.AutoSize = true;
            this.Movement.Location = new System.Drawing.Point(22, 14);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(83, 20);
            this.Movement.TabIndex = 0;
            this.Movement.Text = "Movement";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(418, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 381);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.Step);
            this.panel6.Controls.Add(this.Player);
            this.panel6.Location = new System.Drawing.Point(10, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 357);
            this.panel6.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jesus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(3, 91);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(143, 35);
            this.Step.TabIndex = 1;
            this.Step.Text = "Step";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(45, 14);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(52, 20);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(621, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 381);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.FullBright);
            this.panel8.Controls.Add(this.Visual);
            this.panel8.Location = new System.Drawing.Point(10, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(149, 357);
            this.panel8.TabIndex = 0;
            // 
            // FullBright
            // 
            this.FullBright.Location = new System.Drawing.Point(3, 60);
            this.FullBright.Name = "FullBright";
            this.FullBright.Size = new System.Drawing.Size(143, 35);
            this.FullBright.TabIndex = 1;
            this.FullBright.Text = "FullBright";
            this.FullBright.UseVisualStyleBackColor = true;
            this.FullBright.Click += new System.EventHandler(this.FullBright_Click);
            // 
            // Visual
            // 
            this.Visual.AutoSize = true;
            this.Visual.Location = new System.Drawing.Point(45, 14);
            this.Visual.Name = "Visual";
            this.Visual.Size = new System.Drawing.Size(52, 20);
            this.Visual.TabIndex = 0;
            this.Visual.Text = "Visual";
            // 
            // ClickGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 479);
            this.ControlBox = false;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClickGui";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClickGui";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClickGui_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label ClientName;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label Combat;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button TriggerBot;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button AirJump;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label Movement;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button AirWalk;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button Speed;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button BounceGlide;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button CCFly;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Button Flight;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Button Glide;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button Step;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label Player;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Button FullBright;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label Visual;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Button button1;
	}
}
