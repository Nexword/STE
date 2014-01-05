using System;
using System.IO;
using System.Text;

class ain
{
	static FileStream fs;
	static StreamWriter sw;
	public static void Main()
	{
		fs = File.OpenWrite("out.txt");
		sw = new StreamWriter(fs,  Encoding.GetEncoding (1251));
		for(int i=12;i<13;i++)
		{
			string fname = i.ToString()+".htm";
			if(File.Exists(fname)) reader(fname);
		}
		sw.Close();
		fs.Close();
	}
	static void reader(string w)
	{
		StreamReader sr = new StreamReader(w, Encoding.GetEncoding (1251));
		while("            <div class=\"article\">"!=sr.ReadLine());
		string t = sr.ReadLine();
		while(t!="                <br><br><br>")
		{
			t.Replace("br "," ");
			sw.WriteLine(t);
			t = sr.ReadLine();
		}
	}
}