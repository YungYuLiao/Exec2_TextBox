using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class frmJudge : Form
	{
		public frmJudge()
		{
			InitializeComponent();
		}

		private void btnJudge_Click(object sender, EventArgs e)
		{
			//輸入日期
			DateTime dt;
			try
			{
				dt = GetDateTime();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			//判斷是否大於今日
			string result = Judgement(dt);
			//呈現結果
			lblResult.Text = result;
		}

		private string Judgement(DateTime dateTime)
		{
			DateTime today = DateTime.Today;
			DateTime input = GetDateTime();
			string result = string.Empty;
			return  result = input > today ? $"{input:yyy/MM/dd}大於今日" 
				                           : $"{input:yyy/MM/dd}不大於今日";
		}

		private DateTime GetDateTime()
		{
			TextBox textBox = txtInput;
			string dt = textBox.Text;
			bool isDateTime = DateTime.TryParse(dt, out DateTime dateTime);
			return isDateTime == false ? throw new Exception("請輸入正確日期") : dateTime;
		}
	}
}
