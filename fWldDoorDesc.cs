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
	/// Summary description for fWldDoorDesc.
	/// </summary>
	public class fWldDoorDesc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbWldDoorDescKeywords;
		private System.Windows.Forms.TextBox tbWldDoorDescKeywords;
		private System.Windows.Forms.GroupBox gbWldDoorDescDescription;
		private System.Windows.Forms.TextBox tbWldDoorDescDescription;

		private fMain.DirectionData currentDirectionData;

		private bool wldDoorDescChanged = false;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fWldDoorDesc()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public fWldDoorDesc(fMain.DirectionData theDirectionData)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			currentDirectionData = theDirectionData;
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
			this.gbWldDoorDescKeywords = new System.Windows.Forms.GroupBox();
			this.tbWldDoorDescKeywords = new System.Windows.Forms.TextBox();
			this.gbWldDoorDescDescription = new System.Windows.Forms.GroupBox();
			this.tbWldDoorDescDescription = new System.Windows.Forms.TextBox();
			this.gbWldDoorDescKeywords.SuspendLayout();
			this.gbWldDoorDescDescription.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbWldDoorDescKeywords
			// 
			this.gbWldDoorDescKeywords.Controls.AddRange(new System.Windows.Forms.Control[] {
																								this.tbWldDoorDescKeywords});
			this.gbWldDoorDescKeywords.Location = new System.Drawing.Point(8, 0);
			this.gbWldDoorDescKeywords.Name = "gbWldDoorDescKeywords";
			this.gbWldDoorDescKeywords.Size = new System.Drawing.Size(656, 48);
			this.gbWldDoorDescKeywords.TabIndex = 0;
			this.gbWldDoorDescKeywords.TabStop = false;
			this.gbWldDoorDescKeywords.Text = "Keywords";
			// 
			// tbWldDoorDescKeywords
			// 
			this.tbWldDoorDescKeywords.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbWldDoorDescKeywords.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbWldDoorDescKeywords.Location = new System.Drawing.Point(8, 16);
			this.tbWldDoorDescKeywords.Name = "tbWldDoorDescKeywords";
			this.tbWldDoorDescKeywords.Size = new System.Drawing.Size(640, 22);
			this.tbWldDoorDescKeywords.TabIndex = 0;
			this.tbWldDoorDescKeywords.Text = "";
			this.tbWldDoorDescKeywords.TextChanged += new System.EventHandler(this.descChanged);
			// 
			// gbWldDoorDescDescription
			// 
			this.gbWldDoorDescDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																								   this.tbWldDoorDescDescription});
			this.gbWldDoorDescDescription.Location = new System.Drawing.Point(8, 48);
			this.gbWldDoorDescDescription.Name = "gbWldDoorDescDescription";
			this.gbWldDoorDescDescription.Size = new System.Drawing.Size(680, 240);
			this.gbWldDoorDescDescription.TabIndex = 1;
			this.gbWldDoorDescDescription.TabStop = false;
			this.gbWldDoorDescDescription.Text = "Description";
			// 
			// tbWldDoorDescDescription
			// 
			this.tbWldDoorDescDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbWldDoorDescDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbWldDoorDescDescription.Location = new System.Drawing.Point(8, 16);
			this.tbWldDoorDescDescription.Multiline = true;
			this.tbWldDoorDescDescription.Name = "tbWldDoorDescDescription";
			this.tbWldDoorDescDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbWldDoorDescDescription.Size = new System.Drawing.Size(664, 216);
			this.tbWldDoorDescDescription.TabIndex = 0;
			this.tbWldDoorDescDescription.Text = "";
			this.tbWldDoorDescKeywords.TextChanged += new System.EventHandler(this.descChanged);
			// 
			// fWldDoorDesc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(696, 294);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gbWldDoorDescKeywords,
																		  this.gbWldDoorDescDescription});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fWldDoorDesc";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Door Description";
			this.Load += new System.EventHandler(this.fWldDoorDesc_Load);
			this.Closed += new System.EventHandler(this.fWldDoorDesc_Closed);
			this.gbWldDoorDescKeywords.ResumeLayout(false);
			this.gbWldDoorDescDescription.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void fWldDoorDesc_Load(object sender, System.EventArgs e)
		{
			tbWldDoorDescKeywords.MaxLength = fMain.wldDoorDescKeywordMax;
			tbWldDoorDescKeywords.Text = currentDirectionData.Keywords;
			tbWldDoorDescDescription.MaxLength = fMain.wldDoorDescDescriptionMax;
			tbWldDoorDescDescription.Text = currentDirectionData.Description;

			wldDoorDescChanged = false;
		}

		private void fWldDoorDesc_Closed(object sender, System.EventArgs e)
		{
			currentDirectionData.Keywords = tbWldDoorDescKeywords.Text;
			currentDirectionData.Description = tbWldDoorDescDescription.Text;

			if(wldDoorDescChanged == true)
			{
				this.DialogResult = DialogResult.Yes;
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
		}

		private void descChanged(object sender, System.EventArgs e)
		{
			wldDoorDescChanged = true;
		}
	}
}
