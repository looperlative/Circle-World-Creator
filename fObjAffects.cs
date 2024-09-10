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
	/// Summary description for fObjAffects.
	/// </summary>
	public class fObjAffects : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbObjAffects;
		private System.Windows.Forms.Button bObjAffectRemoveAffect;
		private System.Windows.Forms.Button bObjAffectAddAffect;
		private System.Windows.Forms.ListBox lboxObjAffects;
		private System.Windows.Forms.GroupBox gbObjAffectType;
		private System.Windows.Forms.ComboBox cboxObjAffectType;
		private System.Windows.Forms.GroupBox gbObjAffectValue;
		private System.Windows.Forms.NumericUpDown nudObjAffectValue;

		private fMain.Object currentObject;

		private bool objAffectsChanged = false;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fObjAffects()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public fObjAffects(fMain.Object theObject)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			currentObject = theObject;
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
			this.gbObjAffects = new System.Windows.Forms.GroupBox();
			this.gbObjAffectType = new System.Windows.Forms.GroupBox();
			this.cboxObjAffectType = new System.Windows.Forms.ComboBox();
			this.gbObjAffectValue = new System.Windows.Forms.GroupBox();
			this.nudObjAffectValue = new System.Windows.Forms.NumericUpDown();
			this.bObjAffectRemoveAffect = new System.Windows.Forms.Button();
			this.bObjAffectAddAffect = new System.Windows.Forms.Button();
			this.lboxObjAffects = new System.Windows.Forms.ListBox();
			this.gbObjAffects.SuspendLayout();
			this.gbObjAffectType.SuspendLayout();
			this.gbObjAffectValue.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudObjAffectValue)).BeginInit();
			this.SuspendLayout();
			// 
			// gbObjAffects
			// 
			this.gbObjAffects.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.gbObjAffectType,
																					   this.gbObjAffectValue,
																					   this.bObjAffectRemoveAffect,
																					   this.bObjAffectAddAffect,
																					   this.lboxObjAffects});
			this.gbObjAffects.Location = new System.Drawing.Point(8, 0);
			this.gbObjAffects.Name = "gbObjAffects";
			this.gbObjAffects.Size = new System.Drawing.Size(680, 224);
			this.gbObjAffects.TabIndex = 0;
			this.gbObjAffects.TabStop = false;
			this.gbObjAffects.Text = "Affects (Double-Click Entry to Edit)";
			// 
			// gbObjAffectType
			// 
			this.gbObjAffectType.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gbObjAffectType.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.cboxObjAffectType});
			this.gbObjAffectType.Location = new System.Drawing.Point(8, 168);
			this.gbObjAffectType.Name = "gbObjAffectType";
			this.gbObjAffectType.Size = new System.Drawing.Size(376, 48);
			this.gbObjAffectType.TabIndex = 1;
			this.gbObjAffectType.TabStop = false;
			this.gbObjAffectType.Text = "Affect Type";
			// 
			// cboxObjAffectType
			// 
			this.cboxObjAffectType.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cboxObjAffectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxObjAffectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboxObjAffectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboxObjAffectType.Location = new System.Drawing.Point(8, 16);
			this.cboxObjAffectType.MaxDropDownItems = 16;
			this.cboxObjAffectType.Name = "cboxObjAffectType";
			this.cboxObjAffectType.Size = new System.Drawing.Size(360, 21);
			this.cboxObjAffectType.TabIndex = 0;
			this.cboxObjAffectType.SelectedIndexChanged += new System.EventHandler(this.cboxObjAffectType_SelectedIndexChanged);
			// 
			// gbObjAffectValue
			// 
			this.gbObjAffectValue.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.gbObjAffectValue.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.nudObjAffectValue});
			this.gbObjAffectValue.Location = new System.Drawing.Point(392, 168);
			this.gbObjAffectValue.Name = "gbObjAffectValue";
			this.gbObjAffectValue.Size = new System.Drawing.Size(88, 48);
			this.gbObjAffectValue.TabIndex = 2;
			this.gbObjAffectValue.TabStop = false;
			this.gbObjAffectValue.Text = "Affect Value";
			// 
			// nudObjAffectValue
			// 
			this.nudObjAffectValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudObjAffectValue.Location = new System.Drawing.Point(8, 16);
			this.nudObjAffectValue.Maximum = new System.Decimal(new int[] {
																			  999999,
																			  0,
																			  0,
																			  0});
			this.nudObjAffectValue.Minimum = new System.Decimal(new int[] {
																			  999999,
																			  0,
																			  0,
																			  -2147483648});
			this.nudObjAffectValue.Name = "nudObjAffectValue";
			this.nudObjAffectValue.Size = new System.Drawing.Size(72, 22);
			this.nudObjAffectValue.TabIndex = 0;
			// 
			// bObjAffectRemoveAffect
			// 
			this.bObjAffectRemoveAffect.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.bObjAffectRemoveAffect.Enabled = false;
			this.bObjAffectRemoveAffect.Location = new System.Drawing.Point(584, 184);
			this.bObjAffectRemoveAffect.Name = "bObjAffectRemoveAffect";
			this.bObjAffectRemoveAffect.Size = new System.Drawing.Size(88, 23);
			this.bObjAffectRemoveAffect.TabIndex = 4;
			this.bObjAffectRemoveAffect.Text = "Remove Affect";
			this.bObjAffectRemoveAffect.Click += new System.EventHandler(this.bObjAffectRemoveAffect_Click);
			// 
			// bObjAffectAddAffect
			// 
			this.bObjAffectAddAffect.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.bObjAffectAddAffect.Location = new System.Drawing.Point(488, 184);
			this.bObjAffectAddAffect.Name = "bObjAffectAddAffect";
			this.bObjAffectAddAffect.Size = new System.Drawing.Size(88, 23);
			this.bObjAffectAddAffect.TabIndex = 3;
			this.bObjAffectAddAffect.Text = "Add Affect";
			this.bObjAffectAddAffect.Click += new System.EventHandler(this.bObjAffectAddAffect_Click);
			// 
			// lboxObjAffects
			// 
			this.lboxObjAffects.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.lboxObjAffects.Location = new System.Drawing.Point(8, 16);
			this.lboxObjAffects.Name = "lboxObjAffects";
			this.lboxObjAffects.Size = new System.Drawing.Size(664, 147);
			this.lboxObjAffects.TabIndex = 0;
			this.lboxObjAffects.DoubleClick += new System.EventHandler(this.lboxObjAffects_DoubleClick);
			this.lboxObjAffects.SelectedIndexChanged += new System.EventHandler(this.lboxObjAffects_SelectedIndexChanged);
			// 
			// fObjAffects
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(696, 232);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gbObjAffects});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fObjAffects";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Object Affects";
			this.Load += new System.EventHandler(this.fObjAffect_Load);
			this.Closed += new System.EventHandler(this.fObjAffects_Closed);
			this.gbObjAffects.ResumeLayout(false);
			this.gbObjAffectType.ResumeLayout(false);
			this.gbObjAffectValue.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudObjAffectValue)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void fObjAffect_Load(object sender, System.EventArgs e)
		{
			fMain.Affect myAffect;
			for(int i = 0; i < currentObject.Affects.Count; i++)
			{
				myAffect = ((fMain.Affect)currentObject.Affects.GetByIndex(i));

				lboxObjAffects.Items.Add(fMain.objAffects[fMain.objAffects.IndexOf(myAffect.Location.ToString()) + 1] + ": " + myAffect.Value.ToString());
			}

			for(int i = 1; i < fMain.objAffects.Count; i += 2)
			{
				cboxObjAffectType.Items.Add(fMain.objAffects[i]);
			}

			if(currentObject.Affects.Count > 0)
			{
				lboxObjAffects.SelectedIndex = 0;
			}
			else
			{
				if(fMain.defaultObject.Affect != null)
				{
					cboxObjAffectType.SelectedItem = fMain.defaultObject.Affect;
				}
				else
				{
					cboxObjAffectType.SelectedIndex = 0;
				}
			}
		}

		private void fObjAffects_Closed(object sender, System.EventArgs e)
		{
			if(objAffectsChanged == true)
			{
				this.DialogResult = DialogResult.Yes;
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
		}

		private void lboxObjAffects_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lboxObjAffects.SelectedIndex != -1)
			{
				bObjAffectRemoveAffect.Enabled = true;
			}
			else
			{
				bObjAffectRemoveAffect.Enabled = false;
			}
		}

		private void lboxObjAffects_DoubleClick(object sender, System.EventArgs e)
		{
			if(lboxObjAffects.SelectedIndex != -1)
			{
				fMain.Affect myAffect = ((fMain.Affect)currentObject.Affects.GetByIndex(lboxObjAffects.SelectedIndex));

				cboxObjAffectType.SelectedItem = fMain.objAffects[fMain.objAffects.IndexOf(myAffect.Location.ToString()) + 1];
				nudObjAffectValue.Value = myAffect.Value;
			}
		}

		private void cboxObjAffectType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(nudObjAffectValue.Minimum > 0)
			{
				nudObjAffectValue.Value = nudObjAffectValue.Minimum;
			}
			else
			{
				nudObjAffectValue.Value = 0;
			}
		}

		private void bObjAffectAddAffect_Click(object sender, System.EventArgs e)
		{
			int myKey = int.Parse(fMain.objAffects[cboxObjAffectType.SelectedIndex * 2]);

			if(currentObject.Affects.ContainsKey(myKey.ToString()) == true)
			{
				currentObject.Affects.Remove(myKey.ToString());
			}
			if(currentObject.Affects.Count < fMain.objAffectsMax)
			{
				currentObject.Affects.Add(myKey.ToString(), new fMain.Affect(myKey, decimal.ToInt64(nudObjAffectValue.Value)));
				
				fMain.Affect myAffect;
				lboxObjAffects.Items.Clear();
				for(int i = 0; i < currentObject.Affects.Count; i++)
				{
					myAffect = ((fMain.Affect)currentObject.Affects.GetByIndex(i));

					lboxObjAffects.Items.Add(fMain.objAffects[fMain.objAffects.IndexOf(myAffect.Location.ToString()) + 1] + ": " + myAffect.Value.ToString());
				}
			}

			objAffectsChanged = true;
		}

		private void bObjAffectRemoveAffect_Click(object sender, System.EventArgs e)
		{
			if(lboxObjAffects.SelectedIndex != -1)
			{
				currentObject.Affects.RemoveAt(lboxObjAffects.SelectedIndex);
				lboxObjAffects.Items.RemoveAt(lboxObjAffects.SelectedIndex);

				bObjAffectRemoveAffect.Enabled = false;
			}

			objAffectsChanged = true;
		}
	}
}
