/*
 * Created by SharpDevelop.
 * User: S
 * Date: 6/21/2015
 * Time: 5:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RumbleClientLib;

namespace Rumble_Client_GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private RumbleClientLib.RumbleClient _client = new RumbleClientLib.RumbleClient();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RichTextBox1KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                e.Handled = e.SuppressKeyPress = true;
                if (e.KeyCode == Keys.Enter)
                {
                    var t = (RichTextBox)sender;
                    string text = t.Text;
                    // _client.Send(text);
                    InputBox.Text = "";
                }
            }
		}
	}
}
