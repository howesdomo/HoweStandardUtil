using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Util_Font
{
	/// <summary>
	/// V 1.0.1 - 2020-07-31 10:13:04
	/// 1 修改 namespace
	/// 2 弃用 GetName 方法
	/// 3 优化 GetFontFamily_TypeOf_System_Drawing 的 fontName 
	/// 
	/// V 1.0.0 - 2020-03-13 13:38:14
	/// 首次创建 方便获取指定字体
	/// </summary>
	public class FontFamilyUtils
	{
		//[Obsolete] // 1.0.1 Winform 与 WPF 不再共同使用本方法进行获取字体名称
		//public static string GetFontName(string fontFilePath)
		//{
		//	var glyphTypeface = new System.Windows.Media.GlyphTypeface(new Uri(fontFilePath));
		//	return glyphTypeface.FamilyNames.Values.FirstOrDefault(); // 获取字体名
		//}

		//public static System.Windows.Media.FontFamily GetFontFamily_TypeOf_System_Windows_Media(string fontFilePath)
		//{
		//	var glyphTypeface = new System.Windows.Media.GlyphTypeface(new Uri(fontFilePath));
		//	string fontName = glyphTypeface.FamilyNames.Values.FirstOrDefault(); // 获取字体名

		//	var directory = System.IO.Path.GetDirectoryName(fontFilePath);
		//	var fontUri = $"{new Uri(directory).AbsoluteUri}/#{fontName}";

		//	return new System.Windows.Media.FontFamily(fontUri);
		//}

		public static System.Drawing.FontFamily GetFontFamily_TypeOf_System_Drawing(string fontFilePath)
		{
			var collection = new System.Drawing.Text.PrivateFontCollection();
			collection.AddFontFile(fontFilePath);

			string fontName = collection.Families[0].Name;

			//// (供参考)检测字体类型是否可用
			//var regular = collection.Families[0].IsStyleAvailable(System.Drawing.FontStyle.Regular);
			//var bold = collection.Families[0].IsStyleAvailable(System.Drawing.FontStyle.Bold);

			return new System.Drawing.FontFamily(fontName, collection);
		}
	}
}
