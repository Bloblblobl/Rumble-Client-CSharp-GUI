/*
 * Created by SharpDevelop.
 * User: S
 * Date: 6/26/2015
 * Time: 6:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rumble_Client_GUI
{
	partial class LoginDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer MainSplitContainer;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.TextBox UsernameBox;
		private System.Windows.Forms.Label HandleLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.CheckBox PasswordCheckBox;
		private System.Windows.Forms.TextBox HandleBox;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Button RegisterButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.LoginButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.UsernameBox = new System.Windows.Forms.TextBox();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.PasswordCheckBox = new System.Windows.Forms.CheckBox();
			this.HandleBox = new System.Windows.Forms.TextBox();
			this.HandleLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainSplitContainer
			// 
			this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.MainSplitContainer.Name = "MainSplitContainer";
			// 
			// MainSplitContainer.Panel1
			// 
			this.MainSplitContainer.Panel1.Controls.Add(this.LoginButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.PasswordLabel);
			this.MainSplitContainer.Panel1.Controls.Add(this.UsernameLabel);
			this.MainSplitContainer.Panel1.Controls.Add(this.PasswordBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.UsernameBox);
			// 
			// MainSplitContainer.Panel2
			// 
			this.MainSplitContainer.Panel2.Controls.Add(this.RegisterButton);
			this.MainSplitContainer.Panel2.Controls.Add(this.PasswordCheckBox);
			this.MainSplitContainer.Panel2.Controls.Add(this.HandleBox);
			this.MainSplitContainer.Panel2.Controls.Add(this.HandleLabel);
			this.MainSplitContainer.Size = new System.Drawing.Size(284, 186);
			this.MainSplitContainer.SplitterDistance = 142;
			this.MainSplitContainer.TabIndex = 0;
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(13, 136);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(101, 23);
			this.LoginButton.TabIndex = 4;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.Location = new System.Drawing.Point(13, 62);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(100, 23);
			this.PasswordLabel.TabIndex = 3;
			this.PasswordLabel.Text = "Password:";
			this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.Location = new System.Drawing.Point(12, 9);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(100, 23);
			this.UsernameLabel.TabIndex = 2;
			this.UsernameLabel.Text = "Username:";
			this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Location = new System.Drawing.Point(13, 88);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.Size = new System.Drawing.Size(100, 20);
			this.PasswordBox.TabIndex = 1;
			// 
			// UsernameBox
			// 
			this.UsernameBox.Location = new System.Drawing.Point(12, 35);
			this.UsernameBox.Name = "UsernameBox";
			this.UsernameBox.Size = new System.Drawing.Size(100, 20);
			this.UsernameBox.TabIndex = 0;
			// 
			// RegisterButton
			// 
			this.RegisterButton.Location = new System.Drawing.Point(15, 136);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(100, 23);
			this.RegisterButton.TabIndex = 5;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			// 
			// PasswordCheckBox
			// 
			this.PasswordCheckBox.Location = new System.Drawing.Point(15, 84);
			this.PasswordCheckBox.Name = "PasswordCheckBox";
			this.PasswordCheckBox.Size = new System.Drawing.Size(104, 24);
			this.PasswordCheckBox.TabIndex = 2;
			this.PasswordCheckBox.Text = "Show Password";
			this.PasswordCheckBox.UseVisualStyleBackColor = true;
			// 
			// HandleBox
			// 
			this.HandleBox.Location = new System.Drawing.Point(15, 35);
			this.HandleBox.Name = "HandleBox";
			this.HandleBox.Size = new System.Drawing.Size(100, 20);
			this.HandleBox.TabIndex = 1;
			// 
			// HandleLabel
			// 
			this.HandleLabel.Location = new System.Drawing.Point(15, 9);
			this.HandleLabel.Name = "HandleLabel";
			this.HandleLabel.Size = new System.Drawing.Size(100, 23);
			this.HandleLabel.TabIndex = 0;
			this.HandleLabel.Text = "Handle:";
			this.HandleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// LoginDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 186);
			this.Controls.Add(this.MainSplitContainer);
			this.Name = "LoginDialog";
			this.Text = "LoginDialog";
			this.MainSplitContainer.Panel1.ResumeLayout(false);
			this.MainSplitContainer.Panel1.PerformLayout();
			this.MainSplitContainer.Panel2.ResumeLayout(false);
			this.MainSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
			this.MainSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
