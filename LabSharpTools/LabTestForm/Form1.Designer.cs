﻿using System;

namespace LabTestForm
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			GC.SuppressFinalize(this.usedComm);
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.cHexBox1 = new Harry.LabTools.LabHexEdit.CHexBox();
			this.button2 = new System.Windows.Forms.Button();
			this.cPanelEx1 = new Harry.LabTools.LabControlPlus.CPanelEx();
			this.cPanelPlus1 = new Harry.LabTools.LabControlPlus.CPanelPlus();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(865, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "调入Flash文件";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cHexBox1
			// 
			this.cHexBox1.BackColor = System.Drawing.Color.White;
			this.cHexBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cHexBox1.Location = new System.Drawing.Point(12, 12);
			this.cHexBox1.mDataFontColorA = System.Drawing.SystemColors.HotTrack;
			this.cHexBox1.mDataFontColorB = System.Drawing.Color.MidnightBlue;
			this.cHexBox1.mExternalLineColor = System.Drawing.Color.DarkGray;
			this.cHexBox1.mExternalLineWidth = 2;
			this.cHexBox1.mFirstRowOffset = 4;
			this.cHexBox1.mFont = new System.Drawing.Font("楷体", 12F);
			this.cHexBox1.mFontBackGroundColor = System.Drawing.Color.White;
			this.cHexBox1.mNewDataChange = false;
			this.cHexBox1.mNowData = new byte[] {
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255)),
        ((byte)(255))};
			this.cHexBox1.mRowDisplayNum = 16;
			this.cHexBox1.mRowStaffWidth = 8;
			this.cHexBox1.mShowChangeBackGroundColor = System.Drawing.Color.Yellow;
			this.cHexBox1.mShowChangeFlag = false;
			this.cHexBox1.mXScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.mXScaleBackGroundRectangleShow = true;
			this.cHexBox1.mXScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox1.mXScaleHeight = 24;
			this.cHexBox1.mXScaleHeightOffset = 2;
			this.cHexBox1.mXScaleShow = true;
			this.cHexBox1.mXScaleShowBit8 = Harry.LabTools.LabHexEdit.CHexBox.XScaleShowBit8.BIT8X16;
			this.cHexBox1.mXScaleStringShow = true;
			this.cHexBox1.mXScaleStringStartWidth = 579;
			this.cHexBox1.mYScaleBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.cHexBox1.mYScaleBackGroundRectangleShow = true;
			this.cHexBox1.mYScaleFontColor = System.Drawing.Color.Black;
			this.cHexBox1.mYScaleOffsetWidth = 32;
			this.cHexBox1.mYScaleShow = true;
			this.cHexBox1.mYScaleShowBit4 = Harry.LabTools.LabHexEdit.CHexBox.YScaleShowBit4.BIT4X4;
			this.cHexBox1.mYScaleWidth = 86;
			this.cHexBox1.Name = "cHexBox1";
			this.cHexBox1.Size = new System.Drawing.Size(837, 696);
			this.cHexBox1.TabIndex = 10;
			this.cHexBox1.Text = "cHexBox1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(865, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "保存Flash文件";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// cPanelEx1
			// 
			this.cPanelEx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cPanelEx1.Location = new System.Drawing.Point(909, 138);
			this.cPanelEx1.Name = "cPanelEx1";
			this.cPanelEx1.Size = new System.Drawing.Size(200, 326);
			this.cPanelEx1.TabIndex = 12;
			// 
			// cPanelPlus1
			// 
			this.cPanelPlus1.BorderMode = Harry.LabTools.LabControlPlus.BorderMode.ThreeD;
			this.cPanelPlus1.Location = new System.Drawing.Point(1131, 138);
			this.cPanelPlus1.Name = "cPanelPlus1";
			this.cPanelPlus1.Size = new System.Drawing.Size(200, 326);
			this.cPanelPlus1.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1432, 720);
			this.Controls.Add(this.cPanelPlus1);
			this.Controls.Add(this.cPanelEx1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.cHexBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private Harry.LabTools.LabHexEdit.CHexBox cHexBox1;
        private System.Windows.Forms.Button button2;
        private Harry.LabTools.LabControlPlus.CPanelEx cPanelEx1;
        private Harry.LabTools.LabControlPlus.CPanelPlus cPanelPlus1;
    }
}

