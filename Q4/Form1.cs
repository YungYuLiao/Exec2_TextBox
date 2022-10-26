using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class frmFeeCalc : Form
	{
		public frmFeeCalc()
		{
			InitializeComponent();
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			//取得人頭和車輛值
			int people;
			int car;
			try
			{
				people = GetPeople();
				car = GetCar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//按人頭計費
			int peopleFee = CalcPeopleFee(people);
			//按車輛計費
			int carFee = CalcCarFee(car);
			//顯示結果
			string result = Display(peopleFee, carFee);
			lblResult.Text = result;
		}

		private string Display(int peopleFee, int carFee)
		{
			string result = string.Empty;
			string msg = string.Empty;
			if (peopleFee > carFee)
			{
				msg = "以車輛計費較便宜";
			}
			else 
			{
				msg = "以人頭計費較便宜";
			}
			result = $"以人頭計費為{peopleFee}元，以車輛計費為{carFee}元，\r\n{msg}!";
			return result;
		}

		private int CalcCarFee(int cars)
		{
			int carsfee = 200;
			cars = cars * carsfee;
			return cars;
		}

		private int CalcPeopleFee(int people)
		{	
			int peoplefee = 60;
			people = people * peoplefee;
			return people;

		}

		private int GetCar()
		{
			TextBox txt = txtCar;
			string input = GetInput(txt);
			bool isInt = int.TryParse(input, out int number);
			if (isInt == false)
			{
				throw new Exception("請輸入數值");
			}
			if (number < 0)
			{
				throw new Exception("輸入值不可小於0");
			}
			return number;
		}

		private int GetPeople()
		{
			TextBox txt = txtPeople;
			string input = GetInput(txt);
			bool isInt = int.TryParse(input, out int number);
			if (isInt == false)
			{
				throw new Exception("請輸入數值");
			}
			if (number < 0)
			{
				throw new Exception("輸入值不可小於0");
			}
			return number;
		}
		private string GetInput(TextBox txt)
		{
			string input = txt.Text;
			return input;
		}
	}
}
