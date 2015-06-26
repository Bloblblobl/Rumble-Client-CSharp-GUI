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
		private System.Windows.Forms.TabPage LoginTab;
		private System.Windows.Forms.ListBox MessageBox;
		private System.Windows.Forms.RichTextBox InputBox;
		private System.Windows.Forms.SplitContainer UsersSplitContainer;
		private System.Windows.Forms.ListBox MembersListBox;
		private System.Windows.Forms.ListBox FriendsListBox;
		
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
			this.TabControl = new System.Windows.Forms.TabControl();
			this.UsersTab = new System.Windows.Forms.TabPage();
			this.UsersSplitContainer = new System.Windows.Forms.SplitContainer();
			this.LoginTab = new System.Windows.Forms.TabPage();
			this.MembersListBox = new System.Windows.Forms.ListBox();
			this.FriendsListBox = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
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
			this.MainSplitContainer.Panel2.Controls.Add(this.TabControl);
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
			// TabControl
			// 
			this.TabControl.Controls.Add(this.UsersTab);
			this.TabControl.Controls.Add(this.LoginTab);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(260, 582);
			this.TabControl.TabIndex = 0;
			// 
			// UsersTab
			// 
			this.UsersTab.Controls.Add(this.UsersSplitContainer);
			this.UsersTab.Location = new System.Drawing.Point(4, 22);
			this.UsersTab.Name = "UsersTab";
			this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
			this.UsersTab.Size = new System.Drawing.Size(252, 556);
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
			this.UsersSplitContainer.Size = new System.Drawing.Size(246, 550);
			this.UsersSplitContainer.SplitterDistance = 382;
			this.UsersSplitContainer.TabIndex = 0;
			// 
			// LoginTab
			// 
			this.LoginTab.Location = new System.Drawing.Point(4, 22);
			this.LoginTab.Name = "LoginTab";
			this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
			this.LoginTab.Size = new System.Drawing.Size(252, 556);
			this.LoginTab.TabIndex = 1;
			this.LoginTab.Text = "Login";
			this.LoginTab.UseVisualStyleBackColor = true;
			// 
			// MembersListBox
			// 
			this.MembersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MembersListBox.FormattingEnabled = true;
			this.MembersListBox.Location = new System.Drawing.Point(0, 0);
			this.MembersListBox.Name = "MembersListBox";
			this.MembersListBox.Size = new System.Drawing.Size(246, 382);
			this.MembersListBox.TabIndex = 0;
			// 
			// FriendsListBox
			// 
			this.FriendsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FriendsListBox.FormattingEnabled = true;
			this.FriendsListBox.Location = new System.Drawing.Point(0, 0);
			this.FriendsListBox.Name = "FriendsListBox";
			this.FriendsListBox.Size = new System.Drawing.Size(246, 164);
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
