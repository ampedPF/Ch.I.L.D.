/*
 * Created by SharpDevelop.
 * User: ampedPF
 * Date: 25/05/2014
 * Time: 17:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Champion_Item_List_Downloader
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_Download = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.ll_LolFlavor = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Download
			// 
			this.btn_Download.Location = new System.Drawing.Point(12, 38);
			this.btn_Download.Name = "btn_Download";
			this.btn_Download.Size = new System.Drawing.Size(75, 23);
			this.btn_Download.TabIndex = 0;
			this.btn_Download.Text = "Download";
			this.btn_Download.UseVisualStyleBackColor = true;
			this.btn_Download.Click += new System.EventHandler(this.Btn_DownloadClick);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 12);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(237, 23);
			this.progressBar.Step = 1;
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 1;
			// 
			// ll_LolFlavor
			// 
			this.ll_LolFlavor.Location = new System.Drawing.Point(118, 38);
			this.ll_LolFlavor.Name = "ll_LolFlavor";
			this.ll_LolFlavor.Size = new System.Drawing.Size(131, 23);
			this.ll_LolFlavor.TabIndex = 2;
			this.ll_LolFlavor.TabStop = true;
			this.ll_LolFlavor.Text = "http://www.lolflavor.com";
			this.ll_LolFlavor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ll_LolFlavor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ll_LolFlavorLinkClicked);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(89, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "from";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 72);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ll_LolFlavor);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.btn_Download);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "ampedPF\'s Ch.I.L.D.";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel ll_LolFlavor;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button btn_Download;
		
	}
}
