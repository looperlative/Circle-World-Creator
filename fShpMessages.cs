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
	/// Summary description for fShpMessages.
	/// </summary>
	public class fShpMessages : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbShpMessagesBuyNotExist;
		private System.Windows.Forms.TextBox tbShpMessagesBuyNotExist;
		private System.Windows.Forms.GroupBox gbShpMessagesSellNotExist;
		private System.Windows.Forms.TextBox tbShpMessagesSellNotExist;
		private System.Windows.Forms.GroupBox gbShpMessagesDoesNotBuy;
		private System.Windows.Forms.TextBox tbShpMessagesDoesNotBuy;
		private System.Windows.Forms.GroupBox gbShpMessagesShopNoAfford;
		private System.Windows.Forms.TextBox tbShpMessagesShopNoAfford;
		private System.Windows.Forms.GroupBox gbShpMessagesPlayerNoAfford;
		private System.Windows.Forms.TextBox tbShpMessagesPlayerNoAfford;
		private System.Windows.Forms.GroupBox gbShpMessagesBuySuccess;
		private System.Windows.Forms.TextBox tbShpMessagesBuySuccess;
		private System.Windows.Forms.GroupBox gbShpMessagesSellSuccess;
		private System.Windows.Forms.TextBox tbShpMessagesSellSuccess;

		private fMain.Shop currentShop;

		private bool shpMessagesChanged;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fShpMessages()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public fShpMessages(fMain.Shop theShop)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			currentShop = theShop;
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
			this.gbShpMessagesBuyNotExist = new System.Windows.Forms.GroupBox();
			this.tbShpMessagesBuyNotExist = new System.Windows.Forms.TextBox();
			this.gbShpMessagesSellNotExist = new System.Windows.Forms.GroupBox();
			this.tbShpMessagesSellNotExist = new System.Windows.Forms.TextBox();
			this.gbShpMessagesDoesNotBuy = new System.Windows.Forms.GroupBox();
			this.tbShpMessagesDoesNotBuy = new System.Windows.Forms.TextBox();
			this.gbShpMessagesShopNoAfford = new System.Windows.Forms.GroupBox();
			this.tbShpMessagesShopNoAfford = new System.Windows.Forms.TextBox();
			this.gbShpMessagesPlayerNoAfford = new System.Windows.Forms.GroupBox();
			this.tbShpMessagesPlayerNoAfford = new System.Windows.Forms.TextBox();
			this.gbShpMessagesBuySuccess = new System.Windows.Forms.GroupBox();
			this.tbShpMessagesBuySuccess = new System.Windows.Forms.TextBox();
			this.gbShpMessagesSellSuccess = new System.Windows.Forms.GroupBox();
			this.tbShpMessagesSellSuccess = new System.Windows.Forms.TextBox();
			this.gbShpMessagesBuyNotExist.SuspendLayout();
			this.gbShpMessagesSellNotExist.SuspendLayout();
			this.gbShpMessagesDoesNotBuy.SuspendLayout();
			this.gbShpMessagesShopNoAfford.SuspendLayout();
			this.gbShpMessagesPlayerNoAfford.SuspendLayout();
			this.gbShpMessagesBuySuccess.SuspendLayout();
			this.gbShpMessagesSellSuccess.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbShpMessagesBuyNotExist
			// 
			this.gbShpMessagesBuyNotExist.Controls.AddRange(new System.Windows.Forms.Control[] {
																								   this.tbShpMessagesBuyNotExist});
			this.gbShpMessagesBuyNotExist.Location = new System.Drawing.Point(8, 0);
			this.gbShpMessagesBuyNotExist.Name = "gbShpMessagesBuyNotExist";
			this.gbShpMessagesBuyNotExist.Size = new System.Drawing.Size(664, 48);
			this.gbShpMessagesBuyNotExist.TabIndex = 0;
			this.gbShpMessagesBuyNotExist.TabStop = false;
			this.gbShpMessagesBuyNotExist.Text = "Shop Does Not Have Item Wanted";
			// 
			// tbShpMessagesBuyNotExist
			// 
			this.tbShpMessagesBuyNotExist.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbShpMessagesBuyNotExist.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbShpMessagesBuyNotExist.Location = new System.Drawing.Point(8, 16);
			this.tbShpMessagesBuyNotExist.Name = "tbShpMessagesBuyNotExist";
			this.tbShpMessagesBuyNotExist.Size = new System.Drawing.Size(648, 22);
			this.tbShpMessagesBuyNotExist.TabIndex = 0;
			this.tbShpMessagesBuyNotExist.Text = "";
			this.tbShpMessagesBuyNotExist.TextChanged += new System.EventHandler(this.messageChanged);
			// 
			// gbShpMessagesSellNotExist
			// 
			this.gbShpMessagesSellNotExist.Controls.AddRange(new System.Windows.Forms.Control[] {
																									this.tbShpMessagesSellNotExist});
			this.gbShpMessagesSellNotExist.Location = new System.Drawing.Point(8, 48);
			this.gbShpMessagesSellNotExist.Name = "gbShpMessagesSellNotExist";
			this.gbShpMessagesSellNotExist.Size = new System.Drawing.Size(664, 48);
			this.gbShpMessagesSellNotExist.TabIndex = 1;
			this.gbShpMessagesSellNotExist.TabStop = false;
			this.gbShpMessagesSellNotExist.Text = "Player Does Not Have Item Offered";
			// 
			// tbShpMessagesSellNotExist
			// 
			this.tbShpMessagesSellNotExist.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbShpMessagesSellNotExist.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbShpMessagesSellNotExist.Location = new System.Drawing.Point(8, 16);
			this.tbShpMessagesSellNotExist.Name = "tbShpMessagesSellNotExist";
			this.tbShpMessagesSellNotExist.Size = new System.Drawing.Size(648, 22);
			this.tbShpMessagesSellNotExist.TabIndex = 0;
			this.tbShpMessagesSellNotExist.Text = "";
			this.tbShpMessagesSellNotExist.TextChanged += new System.EventHandler(this.messageChanged);
			// 
			// gbShpMessagesDoesNotBuy
			// 
			this.gbShpMessagesDoesNotBuy.Controls.AddRange(new System.Windows.Forms.Control[] {
																								  this.tbShpMessagesDoesNotBuy});
			this.gbShpMessagesDoesNotBuy.Location = new System.Drawing.Point(8, 96);
			this.gbShpMessagesDoesNotBuy.Name = "gbShpMessagesDoesNotBuy";
			this.gbShpMessagesDoesNotBuy.Size = new System.Drawing.Size(664, 48);
			this.gbShpMessagesDoesNotBuy.TabIndex = 2;
			this.gbShpMessagesDoesNotBuy.TabStop = false;
			this.gbShpMessagesDoesNotBuy.Text = "Shop Does Not Buy Item Offered";
			// 
			// tbShpMessagesDoesNotBuy
			// 
			this.tbShpMessagesDoesNotBuy.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbShpMessagesDoesNotBuy.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbShpMessagesDoesNotBuy.Location = new System.Drawing.Point(8, 16);
			this.tbShpMessagesDoesNotBuy.Name = "tbShpMessagesDoesNotBuy";
			this.tbShpMessagesDoesNotBuy.Size = new System.Drawing.Size(648, 22);
			this.tbShpMessagesDoesNotBuy.TabIndex = 0;
			this.tbShpMessagesDoesNotBuy.Text = "";
			this.tbShpMessagesDoesNotBuy.TextChanged += new System.EventHandler(this.messageChanged);
			// 
			// gbShpMessagesShopNoAfford
			// 
			this.gbShpMessagesShopNoAfford.Controls.AddRange(new System.Windows.Forms.Control[] {
																									this.tbShpMessagesShopNoAfford});
			this.gbShpMessagesShopNoAfford.Location = new System.Drawing.Point(8, 144);
			this.gbShpMessagesShopNoAfford.Name = "gbShpMessagesShopNoAfford";
			this.gbShpMessagesShopNoAfford.Size = new System.Drawing.Size(664, 48);
			this.gbShpMessagesShopNoAfford.TabIndex = 3;
			this.gbShpMessagesShopNoAfford.TabStop = false;
			this.gbShpMessagesShopNoAfford.Text = "Shop Cannot Afford Item";
			// 
			// tbShpMessagesShopNoAfford
			// 
			this.tbShpMessagesShopNoAfford.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbShpMessagesShopNoAfford.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbShpMessagesShopNoAfford.Location = new System.Drawing.Point(8, 16);
			this.tbShpMessagesShopNoAfford.Name = "tbShpMessagesShopNoAfford";
			this.tbShpMessagesShopNoAfford.Size = new System.Drawing.Size(648, 22);
			this.tbShpMessagesShopNoAfford.TabIndex = 0;
			this.tbShpMessagesShopNoAfford.Text = "";
			this.tbShpMessagesShopNoAfford.TextChanged += new System.EventHandler(this.messageChanged);
			// 
			// gbShpMessagesPlayerNoAfford
			// 
			this.gbShpMessagesPlayerNoAfford.Controls.AddRange(new System.Windows.Forms.Control[] {
																									  this.tbShpMessagesPlayerNoAfford});
			this.gbShpMessagesPlayerNoAfford.Location = new System.Drawing.Point(8, 192);
			this.gbShpMessagesPlayerNoAfford.Name = "gbShpMessagesPlayerNoAfford";
			this.gbShpMessagesPlayerNoAfford.Size = new System.Drawing.Size(664, 48);
			this.gbShpMessagesPlayerNoAfford.TabIndex = 4;
			this.gbShpMessagesPlayerNoAfford.TabStop = false;
			this.gbShpMessagesPlayerNoAfford.Text = "Player Cannot Afford Item";
			// 
			// tbShpMessagesPlayerNoAfford
			// 
			this.tbShpMessagesPlayerNoAfford.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbShpMessagesPlayerNoAfford.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbShpMessagesPlayerNoAfford.Location = new System.Drawing.Point(8, 16);
			this.tbShpMessagesPlayerNoAfford.Name = "tbShpMessagesPlayerNoAfford";
			this.tbShpMessagesPlayerNoAfford.Size = new System.Drawing.Size(648, 22);
			this.tbShpMessagesPlayerNoAfford.TabIndex = 0;
			this.tbShpMessagesPlayerNoAfford.Text = "";
			this.tbShpMessagesPlayerNoAfford.TextChanged += new System.EventHandler(this.messageChanged);
			// 
			// gbShpMessagesBuySuccess
			// 
			this.gbShpMessagesBuySuccess.Controls.AddRange(new System.Windows.Forms.Control[] {
																								  this.tbShpMessagesBuySuccess});
			this.gbShpMessagesBuySuccess.Location = new System.Drawing.Point(8, 240);
			this.gbShpMessagesBuySuccess.Name = "gbShpMessagesBuySuccess";
			this.gbShpMessagesBuySuccess.Size = new System.Drawing.Size(664, 48);
			this.gbShpMessagesBuySuccess.TabIndex = 5;
			this.gbShpMessagesBuySuccess.TabStop = false;
			this.gbShpMessagesBuySuccess.Text = "Buy Success (Use %d in place of item price.)";
			// 
			// tbShpMessagesBuySuccess
			// 
			this.tbShpMessagesBuySuccess.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbShpMessagesBuySuccess.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbShpMessagesBuySuccess.Location = new System.Drawing.Point(8, 16);
			this.tbShpMessagesBuySuccess.Name = "tbShpMessagesBuySuccess";
			this.tbShpMessagesBuySuccess.Size = new System.Drawing.Size(648, 22);
			this.tbShpMessagesBuySuccess.TabIndex = 0;
			this.tbShpMessagesBuySuccess.Text = "";
			this.tbShpMessagesBuySuccess.TextChanged += new System.EventHandler(this.messageChanged);
			// 
			// gbShpMessagesSellSuccess
			// 
			this.gbShpMessagesSellSuccess.Controls.AddRange(new System.Windows.Forms.Control[] {
																								   this.tbShpMessagesSellSuccess});
			this.gbShpMessagesSellSuccess.Location = new System.Drawing.Point(8, 288);
			this.gbShpMessagesSellSuccess.Name = "gbShpMessagesSellSuccess";
			this.gbShpMessagesSellSuccess.Size = new System.Drawing.Size(664, 48);
			this.gbShpMessagesSellSuccess.TabIndex = 6;
			this.gbShpMessagesSellSuccess.TabStop = false;
			this.gbShpMessagesSellSuccess.Text = "Sell Success (Use %d in place of item price.)";
			// 
			// tbShpMessagesSellSuccess
			// 
			this.tbShpMessagesSellSuccess.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tbShpMessagesSellSuccess.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbShpMessagesSellSuccess.Location = new System.Drawing.Point(8, 16);
			this.tbShpMessagesSellSuccess.Name = "tbShpMessagesSellSuccess";
			this.tbShpMessagesSellSuccess.Size = new System.Drawing.Size(648, 22);
			this.tbShpMessagesSellSuccess.TabIndex = 0;
			this.tbShpMessagesSellSuccess.Text = "";
			this.tbShpMessagesSellSuccess.TextChanged += new System.EventHandler(this.messageChanged);
			// 
			// fShpMessages
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(680, 342);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gbShpMessagesSellSuccess,
																		  this.gbShpMessagesBuySuccess,
																		  this.gbShpMessagesPlayerNoAfford,
																		  this.gbShpMessagesShopNoAfford,
																		  this.gbShpMessagesDoesNotBuy,
																		  this.gbShpMessagesSellNotExist,
																		  this.gbShpMessagesBuyNotExist});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fShpMessages";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Shopkeeper Messages";
			this.Load += new System.EventHandler(this.fShpMessages_Load);
			this.Closed += new System.EventHandler(this.fShpMessages_Closed);
			this.gbShpMessagesBuyNotExist.ResumeLayout(false);
			this.gbShpMessagesSellNotExist.ResumeLayout(false);
			this.gbShpMessagesDoesNotBuy.ResumeLayout(false);
			this.gbShpMessagesShopNoAfford.ResumeLayout(false);
			this.gbShpMessagesPlayerNoAfford.ResumeLayout(false);
			this.gbShpMessagesBuySuccess.ResumeLayout(false);
			this.gbShpMessagesSellSuccess.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void fShpMessages_Load(object sender, System.EventArgs e)
		{
			tbShpMessagesBuyNotExist.Text = currentShop.MessageBuyItemDoesNotExist;
			tbShpMessagesBuyNotExist.MaxLength = fMain.shpMessageMax;
			tbShpMessagesSellNotExist.Text = currentShop.MessageSellItemDoesNotExist;
			tbShpMessagesSellNotExist.MaxLength = fMain.shpMessageMax;
			tbShpMessagesDoesNotBuy.Text = currentShop.MessageShopDoesNotBuyItem;
			tbShpMessagesDoesNotBuy.MaxLength = fMain.shpMessageMax;
			tbShpMessagesShopNoAfford.Text = currentShop.MessageShopCanNotAffordItem;
			tbShpMessagesShopNoAfford.MaxLength = fMain.shpMessageMax;
			tbShpMessagesPlayerNoAfford.Text = currentShop.MessagePlayerCanNotAffordItem;
			tbShpMessagesPlayerNoAfford.MaxLength = fMain.shpMessageMax;
			tbShpMessagesBuySuccess.Text = currentShop.MessageBuySuccess;
			tbShpMessagesBuySuccess.MaxLength = fMain.shpMessageMax;
			tbShpMessagesSellSuccess.Text = currentShop.MessageSellSuccess;
			tbShpMessagesSellSuccess.MaxLength = fMain.shpMessageMax;

			shpMessagesChanged = false;

			tbShpMessagesBuyNotExist.Focus();
		}

		private void fShpMessages_Closed(object sender, System.EventArgs e)
		{
			currentShop.MessageBuyItemDoesNotExist = tbShpMessagesBuyNotExist.Text;
			currentShop.MessageSellItemDoesNotExist = tbShpMessagesSellNotExist.Text;
			currentShop.MessageShopDoesNotBuyItem = tbShpMessagesDoesNotBuy.Text;
			currentShop.MessageShopCanNotAffordItem = tbShpMessagesShopNoAfford.Text;
			currentShop.MessagePlayerCanNotAffordItem = tbShpMessagesPlayerNoAfford.Text;
			currentShop.MessageBuySuccess = tbShpMessagesBuySuccess.Text;
			currentShop.MessageSellSuccess = tbShpMessagesSellSuccess.Text;

			if(shpMessagesChanged == true)
			{
				this.DialogResult = DialogResult.Yes;
			}
			else
			{
				this.DialogResult = DialogResult.No;
			}
		}

		private void messageChanged(object sender, System.EventArgs e)
		{
			shpMessagesChanged = true;
		}
	}
}
