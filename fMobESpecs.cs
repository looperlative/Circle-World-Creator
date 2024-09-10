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
	/// Summary description for fMobESpecs.
	/// </summary>
	public class fMobESpecs : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbMobESpecs;
		private System.Windows.Forms.GroupBox gbMobESpecType;
		private System.Windows.Forms.ComboBox cboxMobESpecType;
		private System.Windows.Forms.GroupBox gbMobESpecValue;
		private System.Windows.Forms.NumericUpDown nudMobESpecValue;
		private System.Windows.Forms.Button bMobESpecRemoveSpec;
		private System.Windows.Forms.Button bMobESpecAddSpec;
		private System.Windows.Forms.ListBox lboxMobESpecs;
		private System.Windows.Forms.ComboBox cboxMobESpecValue;

		private SortedList theESpecs = new SortedList();

		private fMain.Mobile currentMobile;

		private bool valueChanging = false;
		private bool mobESpecsChanged = false;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fMobESpecs()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public fMobESpecs(fMain.Mobile theMobile, SortedList theESpecs2)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			currentMobile = theMobile;
			theESpecs = theESpecs2;
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
			this.gbMobESpecs = new System.Windows.Forms.GroupBox();
			this.gbMobESpecType = new System.Windows.Forms.GroupBox();
			this.cboxMobESpecType = new System.Windows.Forms.ComboBox();
			this.gbMobESpecValue = new System.Windows.Forms.GroupBox();
			this.cboxMobESpecValue = new System.Windows.Forms.ComboBox();
			this.nudMobESpecValue = new System.Windows.Forms.NumericUpDown();
			this.bMobESpecRemoveSpec = new System.Windows.Forms.Button();
			this.bMobESpecAddSpec = new System.Windows.Forms.Button();
			this.lboxMobESpecs = new System.Windows.Forms.ListBox();
			this.gbMobESpecs.SuspendLayout();
			this.gbMobESpecType.SuspendLayout();
			this.gbMobESpecValue.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudMobESpecValue)).BeginInit();
			this.SuspendLayout();
			// 
			// gbMobESpecs
			// 
			this.gbMobESpecs.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.gbMobESpecType,
																					  this.gbMobESpecValue,
																					  this.bMobESpecRemoveSpec,
																					  this.bMobESpecAddSpec,
																					  this.lboxMobESpecs});
			this.gbMobESpecs.Location = new System.Drawing.Point(8, 0);
			this.gbMobESpecs.Name = "gbMobESpecs";
			this.gbMobESpecs.Size = new System.Drawing.Size(680, 224);
			this.gbMobESpecs.TabIndex = 0;
			this.gbMobESpecs.TabStop = false;
			this.gbMobESpecs.Text = "E-Specs (Double-Click Entry to Edit)";
			// 
			// gbMobESpecType
			// 
			this.gbMobESpecType.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbMobESpecType.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.cboxMobESpecType});
			this.gbMobESpecType.Location = new System.Drawing.Point(8, 168);
			this.gbMobESpecType.Name = "gbMobESpecType";
			this.gbMobESpecType.Size = new System.Drawing.Size(192, 48);
			this.gbMobESpecType.TabIndex = 1;
			this.gbMobESpecType.TabStop = false;
			this.gbMobESpecType.Text = "E-Spec Type";
			// 
			// cboxMobESpecType
			// 
			this.cboxMobESpecType.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxMobESpecType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMobESpecType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboxMobESpecType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxMobESpecType.Location = new System.Drawing.Point(8, 16);
			this.cboxMobESpecType.MaxDropDownItems = 16;
			this.cboxMobESpecType.Name = "cboxMobESpecType";
			this.cboxMobESpecType.Size = new System.Drawing.Size(176, 21);
			this.cboxMobESpecType.TabIndex = 0;
			this.cboxMobESpecType.SelectedIndexChanged += new System.EventHandler(this.cboxMobESpecType_SelectedIndexChanged);
			// 
			// gbMobESpecValue
			// 
			this.gbMobESpecValue.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbMobESpecValue.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.cboxMobESpecValue,
																						  this.nudMobESpecValue});
			this.gbMobESpecValue.Location = new System.Drawing.Point(208, 168);
			this.gbMobESpecValue.Name = "gbMobESpecValue";
			this.gbMobESpecValue.Size = new System.Drawing.Size(272, 48);
			this.gbMobESpecValue.TabIndex = 2;
			this.gbMobESpecValue.TabStop = false;
			this.gbMobESpecValue.Text = "Spec Value";
			// 
			// cboxMobESpecValue
			// 
			this.cboxMobESpecValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMobESpecValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboxMobESpecValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxMobESpecValue.Location = new System.Drawing.Point(8, 16);
			this.cboxMobESpecValue.MaxDropDownItems = 16;
			this.cboxMobESpecValue.Name = "cboxMobESpecValue";
			this.cboxMobESpecValue.Size = new System.Drawing.Size(176, 21);
			this.cboxMobESpecValue.TabIndex = 0;
			this.cboxMobESpecValue.SelectedIndexChanged += new System.EventHandler(this.cboxMobESpecValue_SelectedIndexChanged);
			// 
			// nudMobESpecValue
			// 
			this.nudMobESpecValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudMobESpecValue.Location = new System.Drawing.Point(192, 16);
			this.nudMobESpecValue.Maximum = new System.Decimal(new int[] {
																			 999999,
																			 0,
																			 0,
																			 0});
			this.nudMobESpecValue.Name = "nudMobESpecValue";
			this.nudMobESpecValue.Size = new System.Drawing.Size(72, 22);
			this.nudMobESpecValue.TabIndex = 1;
			this.nudMobESpecValue.ValueChanged += new System.EventHandler(this.nudMobESpecValue_ValueChanged);
			// 
			// bMobESpecRemoveSpec
			// 
			this.bMobESpecRemoveSpec.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bMobESpecRemoveSpec.Enabled = false;
			this.bMobESpecRemoveSpec.Location = new System.Drawing.Point(584, 184);
			this.bMobESpecRemoveSpec.Name = "bMobESpecRemoveSpec";
			this.bMobESpecRemoveSpec.Size = new System.Drawing.Size(88, 23);
			this.bMobESpecRemoveSpec.TabIndex = 4;
			this.bMobESpecRemoveSpec.Text = "Remove Spec";
			this.bMobESpecRemoveSpec.Click += new System.EventHandler(this.bMobESpecRemoveSpec_Click);
			// 
			// bMobESpecAddSpec
			// 
			this.bMobESpecAddSpec.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bMobESpecAddSpec.Location = new System.Drawing.Point(488, 184);
			this.bMobESpecAddSpec.Name = "bMobESpecAddSpec";
			this.bMobESpecAddSpec.Size = new System.Drawing.Size(88, 23);
			this.bMobESpecAddSpec.TabIndex = 3;
			this.bMobESpecAddSpec.Text = "Add Spec";
			this.bMobESpecAddSpec.Click += new System.EventHandler(this.bMobESpecAddSpec_Click);
			// 
			// lboxMobESpecs
			// 
			this.lboxMobESpecs.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lboxMobESpecs.Location = new System.Drawing.Point(8, 16);
			this.lboxMobESpecs.Name = "lboxMobESpecs";
			this.lboxMobESpecs.Size = new System.Drawing.Size(664, 147);
			this.lboxMobESpecs.TabIndex = 0;
			this.lboxMobESpecs.DoubleClick += new System.EventHandler(this.lboxMobESpecs_DoubleClick);
			this.lboxMobESpecs.SelectedIndexChanged += new System.EventHandler(this.lboxMobESpecs_SelectedIndexChanged);
			// 
			// fMobESpecs
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(696, 232);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gbMobESpecs});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fMobESpecs";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Mobile E-Specs";
			this.Load += new System.EventHandler(this.fMobESpecs_Load);
			this.Closed += new System.EventHandler(this.fMobESpec_Closed);
			this.gbMobESpecs.ResumeLayout(false);
			this.gbMobESpecType.ResumeLayout(false);
			this.gbMobESpecValue.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudMobESpecValue)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void fMobESpecs_Load(object sender, System.EventArgs e)
		{
			fMain.ESpecData myESpecData;
			string myStr;
			for(int i = 0; i < currentMobile.ESpecs.Count; i++)
			{
				myESpecData = ((fMain.ESpecData)theESpecs[currentMobile.ESpecs.GetKey(i).ToString()]);

				myStr = currentMobile.ESpecs.GetKey(i).ToString() + ": ";

				if(((fMain.ESpecData)theESpecs[currentMobile.ESpecs.GetKey(i).ToString()]).Range.Count > 0)
				{
					myStr += myESpecData.Range[myESpecData.Range.IndexOf(currentMobile.ESpecs.GetByIndex(i).ToString()) + 1];
				}
				else
				{
					myStr += currentMobile.ESpecs.GetByIndex(i).ToString();
				}
				lboxMobESpecs.Items.Add(myStr);
			}

			for(int i = 0; i < fMain.mobESpecTypes.Count; i++)
			{
				cboxMobESpecType.Items.Add(fMain.mobESpecTypes[i]);
			}

			if(fMain.defaultMobile.ESpec != null)
			{
				cboxMobESpecType.SelectedItem = fMain.defaultMobile.ESpec;
			}
			else
			{
				cboxMobESpecType.SelectedIndex = 0;
			}
		}

		private void fMobESpec_Closed(object sender, System.EventArgs e)
		{
			if(mobESpecsChanged == true)
			{
				this.DialogResult = DialogResult.Yes;
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
		}

		private void lboxMobESpecs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lboxMobESpecs.SelectedIndex != -1)
			{
				bMobESpecRemoveSpec.Enabled = true;
			}
			else
			{
				bMobESpecRemoveSpec.Enabled = false;
			}
		}

		private void lboxMobESpecs_DoubleClick(object sender, System.EventArgs e)
		{
			if(lboxMobESpecs.SelectedIndex != -1)
			{
				cboxMobESpecType.SelectedItem = currentMobile.ESpecs.GetKey(lboxMobESpecs.SelectedIndex).ToString();
				nudMobESpecValue.Value = long.Parse(currentMobile.ESpecs.GetByIndex(lboxMobESpecs.SelectedIndex).ToString());
			}
		}

		private void cboxMobESpecValue_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				valueChanging = true;
				nudMobESpecValue.Value = int.Parse(((fMain.ESpecData)theESpecs[cboxMobESpecType.SelectedItem.ToString()]).Range[cboxMobESpecValue.SelectedIndex * 2]);
				valueChanging = false;
			}
		}

		private void nudMobESpecValue_ValueChanged(object sender, System.EventArgs e)
		{
			if(valueChanging == false)
			{
				fMain.ESpecData mySpec = ((fMain.ESpecData)theESpecs[cboxMobESpecType.SelectedItem.ToString()]);

				valueChanging = true;
				if(mySpec.Range.Count > 0)
				{
					cboxMobESpecValue.SelectedItem = mySpec.Range[mySpec.Range.IndexOf(nudMobESpecValue.Value.ToString()) + 1];
				}
				valueChanging = false;
			}
		}

		private void cboxMobESpecType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			fMain.ESpecData myESpecData = ((fMain.ESpecData)theESpecs[cboxMobESpecType.SelectedItem.ToString()]);

			nudMobESpecValue.Minimum = myESpecData.SpecMin;
			nudMobESpecValue.Maximum = myESpecData.SpecMax;
			if(nudMobESpecValue.Minimum > 0)
			{
				nudMobESpecValue.Value = nudMobESpecValue.Minimum;
			}
			else
			{
				nudMobESpecValue.Value = 0;
			}

			cboxMobESpecValue.Items.Clear();
			if(myESpecData.Range.Count > 0)
			{
				cboxMobESpecValue.Enabled = true;
				for(int i = 0; i < myESpecData.Range.Count; i += 2)
				{
					cboxMobESpecValue.Items.Add(myESpecData.Range[i + 1]);
				}
			}
			else
			{
				cboxMobESpecValue.Enabled = false;
			}
			
			if((cboxMobESpecValue.Enabled == true) && (currentMobile.ESpecs.Count > 0) && (lboxMobESpecs.SelectedIndex != -1))
			{
				cboxMobESpecValue.SelectedItem = myESpecData.Range[myESpecData.Range.IndexOf(currentMobile.ESpecs.GetByIndex(lboxMobESpecs.SelectedIndex).ToString()) + 1];
			}
			else if(cboxMobESpecValue.Enabled == true)
			{
				cboxMobESpecValue.SelectedIndex = 0;
			}
		}

		private void bMobESpecAddSpec_Click(object sender, System.EventArgs e)
		{
			if(currentMobile.ESpecs.ContainsKey(cboxMobESpecType.SelectedItem.ToString()) == true)
			{
				currentMobile.ESpecs.Remove(cboxMobESpecType.SelectedItem.ToString());
			}
			currentMobile.ESpecs.Add(cboxMobESpecType.SelectedItem.ToString(), decimal.ToInt64(nudMobESpecValue.Value));
			
			fMain.ESpecData myESpecData;
			string myStr;
			lboxMobESpecs.Items.Clear();
			for(int i = 0; i < currentMobile.ESpecs.Count; i++)
			{
				myESpecData = ((fMain.ESpecData)theESpecs[currentMobile.ESpecs.GetKey(i).ToString()]);
				myStr = currentMobile.ESpecs.GetKey(i).ToString() + ": ";
				if(myESpecData.Range.Count > 0)
				{
					myStr += myESpecData.Range[myESpecData.Range.IndexOf(currentMobile.ESpecs.GetByIndex(i).ToString()) + 1];
				}
				else
				{
					myStr += currentMobile.ESpecs.GetByIndex(i).ToString();
				}
				lboxMobESpecs.Items.Add(myStr);
			}

			mobESpecsChanged = true;
		}

		private void bMobESpecRemoveSpec_Click(object sender, System.EventArgs e)
		{
			if(lboxMobESpecs.SelectedIndex != -1)
			{
				currentMobile.ESpecs.RemoveAt(lboxMobESpecs.SelectedIndex);
				lboxMobESpecs.Items.RemoveAt(lboxMobESpecs.SelectedIndex);

				bMobESpecRemoveSpec.Enabled = false;
			}

			mobESpecsChanged = true;
		}
	}
}
