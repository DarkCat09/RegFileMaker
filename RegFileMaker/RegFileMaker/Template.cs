using System;
using System.Collections.Generic;

namespace RegFileMaker
{
	class Template
	{
		string name = "";
		string description = "";
		double version = 1.0;
		double rfm_version = 1.0;

		Dictionary<string, Type> tmplVars = new Dictionary<string, Type>();
	}
}
