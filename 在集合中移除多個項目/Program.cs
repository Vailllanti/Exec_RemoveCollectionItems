using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 在集合中移除多個項目
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> list = new List<string>() 
			{
				"aa",
				"bb",
				"cc",
				"c",
				"dd",

			};
			list.Remove("cc");
			list.Remove("dd");
			list.Clear();
		}
	}
}
