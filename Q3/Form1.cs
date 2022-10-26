using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btmJudge_Click(object sender, EventArgs e)
		{
			//輸入生日
			DateTime birthday;
			try
			{
				birthday = GetDateTime();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//判斷是否滿13歲
			string result = Judgement(birthday);
			//顯示結果
			lblResult.Text = result;
		}

		private string Judgement(DateTime dt)
		{
			DateTime now = DateTime.Now;
			DateTime birthday = GetDateTime();
			int nowYear  = now.Year;
			int birthYear = birthday.Year;
			int yearsOld = nowYear - birthYear;
			int standard = 13;
			return yearsOld >= standard ? $"已年滿{standard}歲" : $"尚未年滿{standard}歲";
		}

		private DateTime GetDateTime()
		{
			TextBox txt = txtInput;
			string dt = txt.Text;
			bool isDateTime = DateTime.TryParse(dt, out DateTime birthday);
			return isDateTime == false ? throw new Exception("請輸入正確日期") : birthday;
		}
	}
}
