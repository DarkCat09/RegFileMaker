/*
	Copyright © Чечкенёв Андрей
	
	This file is part of RegFileMaker.

	RegFileMaker is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 2 of the License, or
	(at your option) any later version.

	RegFileMaker is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with RegFileMaker.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Windows.Forms;

namespace RegFileMaker
{
	public partial class AboutProgram : Form
	{
		public AboutProgram()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Visible)
			{
				button1.Text = "Показать описание";
				textBox1.Visible = false;
			}
			else
			{
				button1.Text = "Скрыть описание";
				textBox1.Visible = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
