using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class frmJudge : Form
	{
		public frmJudge()
		{
			InitializeComponent();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			//輸入數字
			int number;
			try
			{
				number = GetNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			//判斷是否在1~99之間
			string result = Judge(number);
			//顯示結果
			lblResult.Text = result;
		}

		private string Judge(int number)
		{
			number = GetNumber();
			return number > 99  || number < 1 ? $"{number}\r\n沒有介於1~99之間"
				                              : $"{number}\r\n介於1~99之間";
		}

		private int GetNumber()
		{
			TextBox textBox = txtNumber;
			string number = txtNumber.Text;
			bool isInt = int.TryParse(number, out int value);
			return isInt == false  ? throw new Exception("請輸入整數") : value;
		}
	}
}
