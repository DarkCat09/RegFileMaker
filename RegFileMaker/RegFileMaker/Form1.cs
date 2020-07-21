/*
	Copyright © 2020 Чечкенёв Андрей
	
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			GlobalSettings.InitThemeAndLang(Controls, this);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string boxres = MessageBox.Show("Выйти из приложения?", "Вопрос",
											MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();
			if (boxres == "Yes")
			{
				Close();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AboutProgram about = new AboutProgram();
			about.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SettingsForm sf = new SettingsForm();
			sf.ShowDialog();
			GlobalSettings.InitThemeAndLang(Controls, this);
		}

        private void button2_Click(object sender, EventArgs e)
        {
			SelectTemplateForm stf = new SelectTemplateForm();
			stf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
			_ = MessageBox.Show(
				"Справка \"О нас\" ещё не готова.\n" +
				"Да, и над программой работал один человек.\n" +
				"Так что это скоро будет переименовано в \"О разработчике\"",
				"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information
			);
        }
    }
}
