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
	/// Summary description for fExtraDescs.
	/// </summary>
	public class fExtraDescs : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbExtraDescs;
		private System.Windows.Forms.Button bExtraDescRemoveDesc;
		private System.Windows.Forms.Button bExtraDescAddDesc;
		private System.Windows.Forms.ListBox lboxExtraDescs;
		private System.Windows.Forms.GroupBox gbExtraDescKeywords;
		private System.Windows.Forms.TextBox tbExtraDescKeywords;
		private System.Windows.Forms.GroupBox gbExtraDescDescription;
		private System.Windows.Forms.TextBox tbExtraDescDescription;

		private SortedList currentExtraDescriptions = new SortedList();

		private int extraDescKeywordMax = 0;
		private int extraDescDescriptionMax = 0;

		private bool extraDescsChanged = false;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fExtraDescs()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public fExtraDescs(SortedList theExtraDescriptions, int theKeywordMax, int theDescriptionMax)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			currentExtraDescriptions = theExtraDescriptions;
			extraDescKeywordMax = theKeywordMax;
			extraDescDescriptionMax = theDescriptionMax;
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
			this.gbExtraDescs = new System.Windows.Forms.GroupBox();
			this.bExtraDescRemoveDesc = new System.Windows.Forms.Button();
			this.bExtraDescAddDesc = new System.Windows.Forms.Button();
			this.lboxExtraDescs = new System.Windows.Forms.ListBox();
			this.gbExtraDescKeywords = new System.Windows.Forms.GroupBox();
			this.tbExtraDescKeywords = new System.Windows.Forms.TextBox();
			this.gbExtraDescDescription = new System.Windows.Forms.GroupBox();
			this.tbExtraDescDescription = new System.Windows.Forms.TextBox();
			this.gbExtraDescs.SuspendLayout();
			this.gbExtraDescKeywords.SuspendLayout();
			this.gbExtraDescDescription.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbExtraDescs
			// 
			this.gbExtraDescs.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.bExtraDescRemoveDesc,
																					   this.bExtraDescAddDesc,
																					   this.lboxExtraDescs,
																					   this.gbExtraDescKeywords,
																					   this.gbExtraDescDescription});
			this.gbExtraDescs.Location = new System.Drawing.Point(8, 0);
			this.gbExtraDescs.Name = "gbExtraDescs";
			this.gbExtraDescs.Size = new System.Drawing.Size(696, 464);
			this.gbExtraDescs.TabIndex = 0;
			this.gbExtraDescs.TabStop = false;
			this.gbExtraDescs.Text = "Extra Descriptions (Double-Click Entry to Edit)";
			// 
			// bExtraDescRemoveDesc
			// 
			this.bExtraDescRemoveDesc.Enabled = false;
			this.bExtraDescRemoveDesc.Location = new System.Drawing.Point(592, 184);
			this.bExtraDescRemoveDesc.Name = "bExtraDescRemoveDesc";
			this.bExtraDescRemoveDesc.Size = new System.Drawing.Size(88, 23);
			this.bExtraDescRemoveDesc.TabIndex = 4;
			this.bExtraDescRemoveDesc.Text = "Remove Desc";
			this.bExtraDescRemoveDesc.Click += new System.EventHandler(this.bExtraDescRemoveDesc_Click);
			// 
			// bExtraDescAddDesc
			// 
			this.bExtraDescAddDesc.Location = new System.Drawing.Point(496, 184);
			this.bExtraDescAddDesc.Name = "bExtraDescAddDesc";
			this.bExtraDescAddDesc.Size = new System.Drawing.Size(88, 23);
			this.bExtraDescAddDesc.TabIndex = 3;
			this.bExtraDescAddDesc.Text = "Add Desc";
			this.bExtraDescAddDesc.Click += new System.EventHandler(this.bExtraDescAddDesc_Click);
			// 
			// lboxExtraDescs
			// 
			this.lboxExtraDescs.Location = new System.Drawing.Point(16, 16);
			this.lboxExtraDescs.Name = "lboxExtraDescs";
			this.lboxExtraDescs.Size = new System.Drawing.Size(664, 147);
			this.lboxExtraDescs.TabIndex = 0;
			this.lboxExtraDescs.DoubleClick += new System.EventHandler(this.lboxExtraDescs_DoubleClick);
			this.lboxExtraDescs.SelectedIndexChanged += new System.EventHandler(this.lboxExtraDescs_SelectedIndexChanged);
			// 
			// gbExtraDescKeywords
			// 
			this.gbExtraDescKeywords.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.tbExtraDescKeywords});
			this.gbExtraDescKeywords.Location = new System.Drawing.Point(8, 168);
			this.gbExtraDescKeywords.Name = "gbExtraDescKeywords";
			this.gbExtraDescKeywords.Size = new System.Drawing.Size(480, 48);
			this.gbExtraDescKeywords.TabIndex = 1;
			this.gbExtraDescKeywords.TabStop = false;
			this.gbExtraDescKeywords.Text = "Keywords";
			// 
			// tbExtraDescKeywords
			// 
			this.tbExtraDescKeywords.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbExtraDescKeywords.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbExtraDescKeywords.Location = new System.Drawing.Point(8, 16);
			this.tbExtraDescKeywords.Name = "tbExtraDescKeywords";
			this.tbExtraDescKeywords.Size = new System.Drawing.Size(464, 22);
			this.tbExtraDescKeywords.TabIndex = 0;
			this.tbExtraDescKeywords.Text = "";
			// 
			// gbExtraDescDescription
			// 
			this.gbExtraDescDescription.Controls.AddRange(new System.Windows.Forms.Control[] {
																								 this.tbExtraDescDescription});
			this.gbExtraDescDescription.Location = new System.Drawing.Point(8, 216);
			this.gbExtraDescDescription.Name = "gbExtraDescDescription";
			this.gbExtraDescDescription.Size = new System.Drawing.Size(680, 240);
			this.gbExtraDescDescription.TabIndex = 2;
			this.gbExtraDescDescription.TabStop = false;
			this.gbExtraDescDescription.Text = "Description";
			// 
			// tbExtraDescDescription
			// 
			this.tbExtraDescDescription.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbExtraDescDescription.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbExtraDescDescription.Location = new System.Drawing.Point(8, 16);
			this.tbExtraDescDescription.Multiline = true;
			this.tbExtraDescDescription.Name = "tbExtraDescDescription";
			this.tbExtraDescDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbExtraDescDescription.Size = new System.Drawing.Size(664, 216);
			this.tbExtraDescDescription.TabIndex = 0;
			this.tbExtraDescDescription.Text = "";
			// 
			// fExtraDescs
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(712, 470);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gbExtraDescs});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fExtraDescs";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Extra Descriptions";
			this.Load += new System.EventHandler(this.fExtraDesc_Load);
			this.Closed += new System.EventHandler(this.fExtraDesc_Closed);
			this.gbExtraDescs.ResumeLayout(false);
			this.gbExtraDescKeywords.ResumeLayout(false);
			this.gbExtraDescDescription.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void fExtraDesc_Load(object sender, System.EventArgs e)
		{
			for(int i = 0; i < currentExtraDescriptions.Count; i++)
			{
				lboxExtraDescs.Items.Add(((fMain.ExtraDescription)currentExtraDescriptions.GetByIndex(i)).Keywords);
			}

			tbExtraDescKeywords.Focus();
		}

		private void fExtraDesc_Closed(object sender, System.EventArgs e)
		{
			if(extraDescsChanged == true)
			{
				this.DialogResult = DialogResult.Yes;
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
		}

		private void lboxExtraDescs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lboxExtraDescs.SelectedIndex != -1)
			{
				bExtraDescRemoveDesc.Enabled = true;
			}
			else
			{
				bExtraDescRemoveDesc.Enabled = false;
			}
		}

		private void lboxExtraDescs_DoubleClick(object sender, System.EventArgs e)
		{
			if(lboxExtraDescs.SelectedIndex != -1)
			{
				tbExtraDescKeywords.Text = ((fMain.ExtraDescription)currentExtraDescriptions.GetByIndex(lboxExtraDescs.SelectedIndex)).Keywords;
				tbExtraDescDescription.Text = ((fMain.ExtraDescription)currentExtraDescriptions.GetByIndex(lboxExtraDescs.SelectedIndex)).Description;
			}
		}

		private void bExtraDescAddDesc_Click(object sender, System.EventArgs e)
		{
			if(tbExtraDescKeywords.Text.Length > 0)
			{
				SortedList myExtraDescriptions = currentExtraDescriptions;
				fMain.ExtraDescription myDescription = new fMain.ExtraDescription(tbExtraDescKeywords.Text, tbExtraDescDescription.Text);

				if(myExtraDescriptions.Count > 0)
				{
					myExtraDescriptions.Add((int.Parse(myExtraDescriptions.GetKey(myExtraDescriptions.Count - 1).ToString()) + 1), myDescription);
				}
				else
				{
					myExtraDescriptions.Add(0, myDescription);
				}

				lboxExtraDescs.Items.Add(myDescription.Keywords);

				tbExtraDescKeywords.Clear();
				tbExtraDescDescription.Clear();
				lboxExtraDescs.SelectedIndex = -1;
				bExtraDescRemoveDesc.Enabled = false;

				extraDescsChanged = true;
			}
		}

		private void bExtraDescRemoveDesc_Click(object sender, System.EventArgs e)
		{
			if(lboxExtraDescs.SelectedIndex != -1)
			{
				currentExtraDescriptions.RemoveAt(lboxExtraDescs.SelectedIndex);
				lboxExtraDescs.Items.RemoveAt(lboxExtraDescs.SelectedIndex);

				tbExtraDescKeywords.Clear();
				tbExtraDescDescription.Clear();
				lboxExtraDescs.SelectedIndex = -1;
				bExtraDescRemoveDesc.Enabled = false;

				extraDescsChanged = true;
			}
		}
	}
}
