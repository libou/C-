/*
 * 由SharpDevelop创建。
 * 用户： Nilson-PC
 * 日期: 2017/11/18
 * 时间: 10:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */


class Singleton
{
	private Singleton(){               //防止其他类创建实例
	}
	public static Singleton Instance()   //只在调用Instance方式时会创建Singeton实例
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
