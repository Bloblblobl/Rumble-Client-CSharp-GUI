/*
 * Created by SharpDevelop.
 * User: S
 * Date: 6/21/2015
 * Time: 5:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rumble_Client_GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer MainSplitContainer;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage UsersTab;
		private System.Windows.Forms.ListBox MessageBox;
		private System.Windows.Forms.RichTextBox InputBox;
		private System.Windows.Forms.SplitContainer UsersSplitContainer;
		private System.Windows.Forms.ListBox MembersListBox;
		private System.Windows.Forms.ListBox FriendsListBox;
		private System.Windows.Forms.Button DialogButton;
		private System.Windows.Forms.SplitContainer SideSplitContainer;
		private System.Windows.Forms.SplitContainer LoginSplitContainer;
		private System.Windows.Forms.Label LoginLabel;
		
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
			this.InputBox = new System.Windows.Forms.RichTextBox();
			this.MessageBox = new System.Windows.Forms.ListBox();
			this.SideSplitContainer = new System.Windows.Forms.SplitContainer();
			this.LoginSplitContainer = new System.Windows.Forms.SplitContainer();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.DialogButton = new System.Windows.Forms.Button();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.UsersTab = new System.Windows.Forms.TabPage();
			this.UsersSplitContainer = new System.Windows.Forms.SplitContainer();
			this.MembersListBox = new System.Windows.Forms.ListBox();
			this.FriendsListBox = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SideSplitContainer)).BeginInit();
			this.SideSplitContainer.Panel1.SuspendLayout();
			this.SideSplitContainer.Panel2.SuspendLayout();
			this.SideSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoginSplitContainer)).BeginInit();
			this.LoginSplitContainer.Panel1.SuspendLayout();
			this.LoginSplitContainer.Panel2.SuspendLayout();
			this.LoginSplitContainer.SuspendLayout();
			this.TabControl.SuspendLayout();
			this.UsersTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UsersSplitContainer)).BeginInit();
			this.UsersSplitContainer.Panel1.SuspendLayout();
			this.UsersSplitContainer.Panel2.SuspendLayout();
			this.UsersSplitContainer.SuspendLayout();
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
			this.MainSplitContainer.Panel1.Controls.Add(this.InputBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.MessageBox);
			// 
			// MainSplitContainer.Panel2
			// 
			this.MainSplitContainer.Panel2.Controls.Add(this.SideSplitContainer);
			this.MainSplitContainer.Size = new System.Drawing.Size(752, 582);
			this.MainSplitContainer.SplitterDistance = 488;
			this.MainSplitContainer.TabIndex = 0;
			// 
			// InputBox
			// 
			this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.InputBox.Location = new System.Drawing.Point(3, 546);
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(482, 33);
			this.InputBox.TabIndex = 1;
			this.InputBox.Text = "";
			this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox1KeyDown);
			// 
			// MessageBox
			// 
			this.MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MessageBox.FormattingEnabled = true;
			this.MessageBox.Location = new System.Drawing.Point(3, 3);
			this.MessageBox.Name = "MessageBox";
			this.MessageBox.Size = new System.Drawing.Size(482, 537);
			this.MessageBox.TabIndex = 0;
			// 
			// SideSplitContainer
			// 
			this.SideSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SideSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.SideSplitContainer.Name = "SideSplitContainer";
			this.SideSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SideSplitContainer.Panel1
			// 
			this.SideSplitContainer.Panel1.Controls.Add(this.LoginSplitContainer);
			// 
			// SideSplitContainer.Panel2
			// 
			this.SideSplitContainer.Panel2.Controls.Add(this.TabControl);
			this.SideSplitContainer.Size = new System.Drawing.Size(260, 582);
			this.SideSplitContainer.SplitterDistance = 43;
			this.SideSplitContainer.TabIndex = 1;
			// 
			// LoginSplitContainer
			// 
			this.LoginSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LoginSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.LoginSplitContainer.Name = "LoginSplitContainer";
			// 
			// LoginSplitContainer.Panel1
			// 
			this.LoginSplitContainer.Panel1.Controls.Add(this.LoginLabel);
			// 
			// LoginSplitContainer.Panel2
			// 
			this.LoginSplitContainer.Panel2.Controls.Add(this.DialogButton);
			this.LoginSplitContainer.Size = new System.Drawing.Size(260, 43);
			this.LoginSplitContainer.SplitterDistance = 152;
			this.LoginSplitContainer.TabIndex = 0;
			// 
			// LoginLabel
			// 
			this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginLabel.Location = new System.Drawing.Point(0, 0);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(152, 43);
			this.LoginLabel.TabIndex = 0;
			this.LoginLabel.Text = "You are not logged in...";
			this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DialogButton
			// 
			this.DialogButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DialogButton.Location = new System.Drawing.Point(0, 0);
			this.DialogButton.Name = "DialogButton";
			this.DialogButton.Size = new System.Drawing.Size(104, 43);
			this.DialogButton.TabIndex = 0;
			this.DialogButton.Text = "Login / Register";
			this.DialogButton.UseVisualStyleBackColor = true;
			this.DialogButton.Click += new System.EventHandler(this.DialogButtonClick);
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.UsersTab);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(260, 535);
			this.TabControl.TabIndex = 0;
			// 
			// UsersTab
			// 
			this.UsersTab.Controls.Add(this.UsersSplitContainer);
			this.UsersTab.Location = new System.Drawing.Point(4, 22);
			this.UsersTab.Name = "UsersTab";
			this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
			this.UsersTab.Size = new System.Drawing.Size(252, 509);
			this.UsersTab.TabIndex = 0;
			this.UsersTab.Text = "Users";
			this.UsersTab.UseVisualStyleBackColor = true;
			// 
			// UsersSplitContainer
			// 
			this.UsersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UsersSplitContainer.Location = new System.Drawing.Point(3, 3);
			this.UsersSplitContainer.Name = "UsersSplitContainer";
			this.UsersSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// UsersSplitContainer.Panel1
			// 
			this.UsersSplitContainer.Panel1.Controls.Add(this.MembersListBox);
			// 
			// UsersSplitContainer.Panel2
			// 
			this.UsersSplitContainer.Panel2.Controls.Add(this.FriendsListBox);
			this.UsersSplitContainer.Size = new System.Drawing.Size(246, 503);
			this.UsersSplitContainer.SplitterDistance = 348;
			this.UsersSplitContainer.TabIndex = 0;
			// 
			// MembersListBox
			// 
			this.MembersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MembersListBox.FormattingEnabled = true;
			this.MembersListBox.Location = new System.Drawing.Point(0, 0);
			this.MembersListBox.Name = "MembersListBox";
			this.MembersListBox.Size = new System.Drawing.Size(246, 348);
			this.MembersListBox.TabIndex = 0;
			// 
			// FriendsListBox
			// 
			this.FriendsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FriendsListBox.FormattingEnabled = true;
			this.FriendsListBox.Location = new System.Drawing.Point(0, 0);
			this.FriendsListBox.Name = "FriendsListBox";
			this.FriendsListBox.Size = new System.Drawing.Size(246, 151);
			this.FriendsListBox.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 582);
			this.Controls.Add(this.MainSplitContainer);
			this.Name = "MainForm";
			this.Text = "Rumble-Client-GUI";
			this.MainSplitContainer.Panel1.ResumeLayout(false);
			this.MainSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
			this.MainSplitContainer.ResumeLayout(false);
			this.SideSplitContainer.Panel1.ResumeLayout(false);
			this.SideSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SideSplitContainer)).EndInit();
			this.SideSplitContainer.ResumeLayout(false);
			this.LoginSplitContainer.Panel1.ResumeLayout(false);
			this.LoginSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LoginSplitContainer)).EndInit();
			this.LoginSplitContainer.ResumeLayout(false);
			this.TabControl.ResumeLayout(false);
			this.UsersTab.ResumeLayout(false);
			this.UsersSplitContainer.Panel1.ResumeLayout(false);
			this.UsersSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UsersSplitContainer)).EndInit();
			this.UsersSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
