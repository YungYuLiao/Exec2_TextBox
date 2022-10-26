namespace Q2
{
	partial class frmJudge
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lblInput = new System.Windows.Forms.Label();
			this.btnJudge = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(79, 39);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(100, 22);
			this.txtInput.TabIndex = 0;
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInput.Location = new System.Drawing.Point(12, 41);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(63, 17);
			this.lblInput.TabIndex = 1;
			this.lblInput.Text = "輸入日期:";
			// 
			// btnJudge
			// 
			this.btnJudge.BackColor = System.Drawing.SystemColors.Control;
			this.btnJudge.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnJudge.Location = new System.Drawing.Point(190, 38);
			this.btnJudge.Name = "btnJudge";
			this.btnJudge.Size = new System.Drawing.Size(75, 23);
			this.btnJudge.TabIndex = 2;
			this.btnJudge.Text = "判斷";
			this.btnJudge.UseVisualStyleBackColor = false;
			this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(12, 86);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(0, 27);
			this.lblResult.TabIndex = 3;
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInfo.Location = new System.Drawing.Point(13, 13);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(165, 16);
			this.lblInfo.TabIndex = 4;
			this.lblInfo.Text = "輸入日期須以，/ -或空白分隔";
			// 
			// frmJudge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 146);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnJudge);
			this.Controls.Add(this.lblInput);
			this.Controls.Add(this.txtInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmJudge";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "日期判斷器";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.Button btnJudge;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblInfo;
	}
}

