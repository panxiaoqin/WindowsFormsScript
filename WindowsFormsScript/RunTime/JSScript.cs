using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WindowsFormsScript.Util;

namespace WindowsFormsScript.RunTime
{
    public class JSScript
    {
        private string path;
        public string Remarks;
        public List<JSScriptItem> Items = new List<JSScriptItem>();

        public JSScript(string name)
        {
            path = JSONConfig.GetPath("script/" + name + "js");
            string content = File.ReadAllText(path, Encoding.UTF8);
            int index = content.IndexOf("\n", StringComparison.Ordinal);
            Remarks = content.Substring(2, index).Trim();
            content = content.Substring(index).Trim();
            analysis(content);
        }

        public JSScript(string name, string remarks)
        {
            path = JSONConfig.GetPath("script/" + name + "js");
            Remarks = remarks;
        }

        private void analysis(string content)
        {

        }

        private string itemToString()
        {
            return "";
        }

        public void toFile()
        {
            File.WriteAllText(path, itemToString(), Encoding.UTF8);
        }
    }
}
