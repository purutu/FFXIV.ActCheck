using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFActCheck
{
	static class Junction
	{
		internal enum Result
		{
			Ok,
			Fail,
			NotEqual,       // 소스와 타깃이 다름
			NotJunction,	// 타깃이 정션이 아님
			NotExist		// 타깃이 없음
		}

		internal static string ResultToString(Result r)
		{
			switch(r)
			{
				case Result.Ok: return "JunctionOk";
				case Result.NotEqual: return "JunctionNotEqual";
				case Result.NotJunction: return "JunctionNotJunction";
				case Result.NotExist: return "JunctionNotExist";
				case Result.Fail: 
				default: return "JunctionFail";
			}
		}

		internal static Result Check(string srcname, string tgtname)
		{
			try
			{
				if (!JunctionPoint.Exists(tgtname))
					return Result.NotExist;	// 설정이 필요함
				else
				{
					if (!string.Equals(JunctionPoint.GetTarget(tgtname), srcname))
						return Result.NotEqual; // 다른 프로그램에서 설정

					return Result.Ok;
				}
			}
			catch
			{
				// 정션이 아님
				return Result.NotJunction;	// 다른 프로그램이 만든 디렉터리
			}
		}

		internal static void Make(string srcname, string tgtname)
		{
			if (Directory.Exists(tgtname))
			{
				if (JunctionPoint.Exists(tgtname))
					JunctionPoint.Delete(tgtname);
				else
				{
					DirectoryInfo di = new DirectoryInfo(tgtname);
					FileInfo[] fs = di.GetFiles("*.*", SearchOption.AllDirectories);

					foreach (var f in fs)
						f.Attributes = FileAttributes.Normal;

					Directory.Delete(tgtname, true);
				}
			}

			JunctionPoint.Create(srcname, tgtname, true);
		}
	}
}
