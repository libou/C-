/*
 * 由SharpDevelop创建。
 * 用户： Nilson-PC
 * 日期: 2017/11/18
 * 时间: 10:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Blank
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Singleton
	{
		private Singleton(){
		}
		public static Singleton Instance()
		{
			return Nested.instance;
		}
		
		class Nested
		{
			static Nested(){	
			}
			internal static readonly Singleton instance=new Singleton();
		}
	}
}