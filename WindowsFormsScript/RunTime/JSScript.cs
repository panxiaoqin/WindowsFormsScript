using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WindowsFormsScript.Util;

namespace WindowsFormsScript.RunTime
{
    public class JSScript
    {
        private string path;
        public string Name;
        public string Remarks;
        public List<JSScriptItem> Items = new List<JSScriptItem>();

        public JSScript(string name)
        {
            this.Name = name.Trim();
            path = JSONConfig.GetPath("script\\" + name + ".js");
            string content = File.ReadAllText(path, Encoding.UTF8);
            int index = content.IndexOf("\n", StringComparison.Ordinal);
            Remarks = content.Substring(2, index - 2).Trim();
            content = content.Substring(index).Trim();
            analysis(content);
        }

        public JSScript(string name, string remarks)
        {
            this.Name = name.Trim();
            path = JSONConfig.GetPath("script\\" + name + ".js");
            Remarks = remarks;
        }

        public void createDirectory()
        {
            var dir = JSONConfig.GetPath("script");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void analysis(string content)
        {
            var arr = content.Split('\n').Skip(1).ToArray();
            arr = arr.Take(arr.Length - 1).Select(t => t.Trim()).ToArray();
            foreach (var item in arr)
            {
                Items.Add(JSScriptItem.Parse(item));
            }
        }

        private string itemToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("//").Append(Remarks).Append("\n");
            str.Append("function ").Append(Name).Append("() {\n");
            foreach (var item in Items)
            {
                str.Append("    ")
                    .Append(item.FunName)
                    .Append("(")
                    .Append(item.toParams())
                    .Append(")")
                    .Append(";\n");
            }
            str.Append("}");
            return str.ToString();
        }

        public void toFile()
        {
            createDirectory();
            File.WriteAllText(path, itemToString(), Encoding.UTF8);
        }

        public static void deleteFile(string name)
        {
            var path = JSONConfig.GetPath("script\\" + name + ".js");
            File.Delete(path);
        }

        public static FileInfo[] getFiles()
        {
            var dir = JSONConfig.GetPath("script");
            var dirInfo = new DirectoryInfo(dir);
            return dirInfo.Exists ? dirInfo.GetFiles("*.js") : new FileInfo[0];
        }

        public static List<JSScriptItem> getFileItems()
        {
            return getFiles().Select(item => new JSScriptItem(item)).ToList();
        }
    }
}
