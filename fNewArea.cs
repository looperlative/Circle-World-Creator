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
	/// Summary description for fNewArea.
	/// </summary>
	public class fNewArea : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button bNewAreaCreate;
		private System.Windows.Forms.Button bNewAreaCancel;
		private System.Windows.Forms.GroupBox gbNewAreaZoneInformation;
		private System.Windows.Forms.GroupBox gbNewAreaZoneName;
		private System.Windows.Forms.TextBox tbNewAreaZoneName;
		private System.Windows.Forms.CheckBox cbNewAreaAutoGenerateComments;
		private System.Windows.Forms.GroupBox gbNewAreaZoneNumber;
		private System.Windows.Forms.NumericUpDown nudNewAreaZoneNumber;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fNewArea()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.gbNewAreaZoneInformation = new System.Windows.Forms.GroupBox();
			this.gbNewAreaZoneName = new System.Windows.Forms.GroupBox();
			this.tbNewAreaZoneName = new System.Windows.Forms.TextBox();
			this.gbNewAreaZoneNumber = new System.Windows.Forms.GroupBox();
			this.nudNewAreaZoneNumber = new System.Windows.Forms.NumericUpDown();
			this.cbNewAreaAutoGenerateComments = new System.Windows.Forms.CheckBox();
			this.bNewAreaCancel = new System.Windows.Forms.Button();
			this.bNewAreaCreate = new System.Windows.Forms.Button();
			this.gbNewAreaZoneInformation.SuspendLayout();
			this.gbNewAreaZoneName.SuspendLayout();
			this.gbNewAreaZoneNumber.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNewAreaZoneNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// gbNewAreaZoneInformation
			// 
			this.gbNewAreaZoneInformation.Controls.AddRange(new System.Windows.Forms.Control[] {
																								   this.gbNewAreaZoneName,
																								   this.gbNewAreaZoneNumber,
																								   this.cbNewAreaAutoGenerateComments,
																								   this.bNewAreaCancel,
																								   this.bNewAreaCreate});
			this.gbNewAreaZoneInformation.Location = new System.Drawing.Point(8, 0);
			this.gbNewAreaZoneInformation.Name = "gbNewAreaZoneInformation";
			this.gbNewAreaZoneInformation.Size = new System.Drawing.Size(664, 120);
			this.gbNewAreaZoneInformation.TabIndex = 0;
			this.gbNewAreaZoneInformation.TabStop = false;
			this.gbNewAreaZoneInformation.Text = "Zone Information";
			// 
			// gbNewAreaZoneName
			// 
			this.gbNewAreaZoneName.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.tbNewAreaZoneName});
			this.gbNewAreaZoneName.Location = new System.Drawing.Point(8, 16);
			this.gbNewAreaZoneName.Name = "gbNewAreaZoneName";
			this.gbNewAreaZoneName.Size = new System.Drawing.Size(648, 48);
			this.gbNewAreaZoneName.TabIndex = 0;
			this.gbNewAreaZoneName.TabStop = false;
			this.gbNewAreaZoneName.Text = "Zone Name";
			// 
			// tbNewAreaZoneName
			// 
			this.tbNewAreaZoneName.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbNewAreaZoneName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbNewAreaZoneName.Location = new System.Drawing.Point(8, 16);
			this.tbNewAreaZoneName.Name = "tbNewAreaZoneName";
			this.tbNewAreaZoneName.Size = new System.Drawing.Size(632, 20);
			this.tbNewAreaZoneName.TabIndex = 0;
			this.tbNewAreaZoneName.Text = "";
			// 
			// gbNewAreaZoneNumber
			// 
			this.gbNewAreaZoneNumber.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.nudNewAreaZoneNumber});
			this.gbNewAreaZoneNumber.Location = new System.Drawing.Point(8, 64);
			this.gbNewAreaZoneNumber.Name = "gbNewAreaZoneNumber";
			this.gbNewAreaZoneNumber.Size = new System.Drawing.Size(88, 48);
			this.gbNewAreaZoneNumber.TabIndex = 1;
			this.gbNewAreaZoneNumber.TabStop = false;
			this.gbNewAreaZoneNumber.Text = "Number";
			// 
			// nudNewAreaZoneNumber
			// 
			this.nudNewAreaZoneNumber.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.nudNewAreaZoneNumber.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudNewAreaZoneNumber.Location = new System.Drawing.Point(8, 16);
			this.nudNewAreaZoneNumber.Maximum = new System.Decimal(new int[] {
																				 999999,
																				 0,
																				 0,
																				 0});
			this.nudNewAreaZoneNumber.Name = "nudNewAreaZoneNumber";
			this.nudNewAreaZoneNumber.Size = new System.Drawing.Size(72, 22);
			this.nudNewAreaZoneNumber.TabIndex = 0;
			// 
			// cbNewAreaAutoGenerateComments
			// 
			this.cbNewAreaAutoGenerateComments.Location = new System.Drawing.Point(104, 80);
			this.cbNewAreaAutoGenerateComments.Name = "cbNewAreaAutoGenerateComments";
			this.cbNewAreaAutoGenerateComments.Size = new System.Drawing.Size(208, 24);
			this.cbNewAreaAutoGenerateComments.TabIndex = 2;
			this.cbNewAreaAutoGenerateComments.Text = "Auto-Generate Zone File Comments";
			// 
			// bNewAreaCancel
			// 
			this.bNewAreaCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bNewAreaCancel.Location = new System.Drawing.Point(568, 80);
			this.bNewAreaCancel.Name = "bNewAreaCancel";
			this.bNewAreaCancel.Size = new System.Drawing.Size(88, 24);
			this.bNewAreaCancel.TabIndex = 4;
			this.bNewAreaCancel.Text = "Cancel";
			// 
			// bNewAreaCreate
			// 
			this.bNewAreaCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bNewAreaCreate.Location = new System.Drawing.Point(472, 80);
			this.bNewAreaCreate.Name = "bNewAreaCreate";
			this.bNewAreaCreate.Size = new System.Drawing.Size(88, 24);
			this.bNewAreaCreate.TabIndex = 3;
			this.bNewAreaCreate.Text = "Create";
			this.bNewAreaCreate.Click += new System.EventHandler(this.bNewAreaCreate_Click);
			// 
			// fNewArea
			// 
			this.AcceptButton = this.bNewAreaCreate;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.CancelButton = this.bNewAreaCancel;
			this.ClientSize = new System.Drawing.Size(682, 128);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gbNewAreaZoneInformation});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fNewArea";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Area";
			this.Load += new System.EventHandler(this.fNewArea_Load);
			this.gbNewAreaZoneInformation.ResumeLayout(false);
			this.gbNewAreaZoneName.ResumeLayout(false);
			this.gbNewAreaZoneNumber.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudNewAreaZoneNumber)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void bNewAreaCreate_Click(object sender, System.EventArgs e)
		{
			fMain.currentZoneName = tbNewAreaZoneName.Text;
			fMain.currentZoneNumber = decimal.ToInt32(nudNewAreaZoneNumber.Value);

			if(cbNewAreaAutoGenerateComments.Checked == true)
			{
				fMain.autoGenComment = true;
			}
			else
			{
				fMain.autoGenComment = false;
			}
		}

		private void fNewArea_Load(object sender, System.EventArgs e)
		{
			tbNewAreaZoneName.Focus();
		}
	}
}
