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
	class GlobalSettings
	{
		public static System.Drawing.Color theme = new System.Drawing.Color();
		public static System.Drawing.Color fontcol = new System.Drawing.Color();
		public static Uri serverUrl = new Uri("http://DarkCat09.github.io/RegFileMaker/");
		public static bool minimizeToTray = false;

		public static void InitThemeAndLang(Control.ControlCollection ctrls, Form f)
		{
			System.Collections.Generic.Dictionary<string, string> langFiles = Languages.InitLangs();
			_ = Languages.LoadLang(langFiles[Languages.curlang], langFiles);
			//int errcode = Languages.LoadLang(langFiles[Languages.curlang], langFiles);
			//_ = MessageBox.Show(errcode.ToString());

			f.BackColor = theme;
			foreach (Control ctrl in ctrls)
			{
				if (!(ctrl is Button) && !(ctrl is ComboBox) && !(ctrl is TableLayoutPanel))
					ctrl.ForeColor = GlobalSettings.fontcol;

				//for TableLayoutPanel
				if (ctrl is TableLayoutPanel)
				{
					foreach (Control tablectrl in ((TableLayoutPanel)ctrl).Controls)
					{
						if (tablectrl.Tag != null)
						{
							if (Languages.Lang.ContainsKey(tablectrl.Tag.ToString()))
							{
								tablectrl.Text = Languages.Lang[tablectrl.Tag.ToString()];
							}
						}
					}
				}

				if (ctrl.Tag != null)
				{
					if (Languages.Lang.ContainsKey(ctrl.Tag.ToString()))
					{
						ctrl.Text = Languages.Lang[ctrl.Tag.ToString()];
					}
				}
			}
		}
	}
}
