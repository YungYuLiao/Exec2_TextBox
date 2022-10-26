namespace Q4
{
	partial class frmFeeCalc
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
			this.lblPeople = new System.Windows.Forms.Label();
			this.txtPeople = new System.Windows.Forms.TextBox();
			this.txtCar = new System.Windows.Forms.TextBox();
			this.lblCar = new System.Windows.Forms.Label();
			this.btnCalc = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPeople
			// 
			this.lblPeople.AutoSize = true;
			this.lblPeople.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPeople.Location = new System.Drawing.Point(31, 31);
			this.lblPeople.Name = "lblPeople";
			this.lblPeople.Size = new System.Drawing.Size(37, 17);
			this.lblPeople.TabIndex = 0;
			this.lblPeople.Text = "人頭:";
			this.lblPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPeople
			// 
			this.txtPeople.Location = new System.Drawing.Point(71, 29);
			this.txtPeople.Name = "txtPeople";
			this.txtPeople.Size = new System.Drawing.Size(116, 22);
			this.txtPeople.TabIndex = 1;
			// 
			// txtCar
			// 
			this.txtCar.Location = new System.Drawing.Point(70, 86);
			this.txtCar.Name = "txtCar";
			this.txtCar.Size = new System.Drawing.Size(116, 22);
			this.txtCar.TabIndex = 2;
			// 
			// lblCar
			// 
			this.lblCar.AutoSize = true;
			this.lblCar.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblCar.Location = new System.Drawing.Point(29, 88);
			this.lblCar.Name = "lblCar";
			this.lblCar.Size = new System.Drawing.Size(40, 17);
			this.lblCar.TabIndex = 3;
			this.lblCar.Text = "車輛: ";
			this.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCalc
			// 
			this.btnCalc.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCalc.Location = new System.Drawing.Point(215, 38);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(75, 61);
			this.btnCalc.TabIndex = 4;
			this.btnCalc.Text = "計算";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(31, 140);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(0, 17);
			this.lblResult.TabIndex = 5;
			// 
			// frmFeeCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 225);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.lblCar);
			this.Controls.Add(this.txtCar);
			this.Controls.Add(this.txtPeople);
			this.Controls.Add(this.lblPeople);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFeeCalc";
			this.Text = "入場費計算";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPeople;
		private System.Windows.Forms.TextBox txtPeople;
		private System.Windows.Forms.TextBox txtCar;
		private System.Windows.Forms.Label lblCar;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Label lblResult;
	}
}

