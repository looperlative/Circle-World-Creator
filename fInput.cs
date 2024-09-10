// Circle World Creator
// Copyright 1999-2004 Alan K. Miles <silvertower@comcast.net>
// Licensed under Version 2 of the GNU Public License
// See 'License.txt' for more details.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Circle_World_Creator
{
	/// <summary>
	/// Summary description for fInput.
	/// </summary>
	public class fInput : System.Windows.Forms.Form
	{
		private System.Windows.Forms.NumericUpDown nudInputValue;
		private System.Windows.Forms.Button bInputCancel;
		private System.Windows.Forms.Button bInputOK;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fInput()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public fInput(string theText)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.Text = theText;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.nudInputValue = new System.Windows.Forms.NumericUpDown();
			this.bInputCancel = new System.Windows.Forms.Button();
			this.bInputOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudInputValue)).BeginInit();
			this.SuspendLayout();
			// 
			// nudInputValue
			// 
			this.nudInputValue.Location = new System.Drawing.Point(8, 8);
			this.nudInputValue.Maximum = new System.Decimal(new int[] {
																		  999999,
																		  0,
																		  0,
																		  0});
			this.nudInputValue.Minimum = new System.Decimal(new int[] {
																		  999999,
																		  0,
																		  0,
																		  -2147483648});
			this.nudInputValue.Name = "nudInputValue";
			this.nudInputValue.Size = new System.Drawing.Size(200, 20);
			this.nudInputValue.TabIndex = 0;
			// 
			// bInputCancel
			// 
			this.bInputCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bInputCancel.Location = new System.Drawing.Point(112, 40);
			this.bInputCancel.Name = "bInputCancel";
			this.bInputCancel.Size = new System.Drawing.Size(88, 24);
			this.bInputCancel.TabIndex = 2;
			this.bInputCancel.Text = "Cancel";
			// 
			// bInputOK
			// 
			this.bInputOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bInputOK.Location = new System.Drawing.Point(16, 40);
			this.bInputOK.Name = "bInputOK";
			this.bInputOK.Size = new System.Drawing.Size(88, 24);
			this.bInputOK.TabIndex = 1;
			this.bInputOK.Text = "OK";
			this.bInputOK.Click += new System.EventHandler(this.bInputOK_Click);
			// 
			// fInput
			// 
			this.AcceptButton = this.bInputOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.bInputCancel;
			this.ClientSize = new System.Drawing.Size(216, 70);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.bInputCancel,
																		  this.bInputOK,
																		  this.nudInputValue});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fInput";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.fInput_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudInputValue)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void bInputOK_Click(object sender, System.EventArgs e)
		{
			fMain.inputResult = decimal.ToInt64(nudInputValue.Value);
		}

		private void fInput_Load(object sender, System.EventArgs e)
		{
			nudInputValue.Focus();
		}
	}
}
