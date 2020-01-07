using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace WindowsFormsScript.RunTime
{
    public class JSScriptItem
    {
        public const string Click = "win_click";
        public const string KeyInput = "win_input";
        public const string Sleep = "win_sleep";
        public const string SelectApp = "win_select";
        public const string Script = "win_script";

        public string FunName;

        public List<string> Params = new List<string>();

        public JSScriptItem(string name)
        {
            FunName = name;
        }

        public JSScriptItem(FileInfo file)
        {
            FunName = Script;
            Params.Add(Path.GetFileNameWithoutExtension(file.FullName));
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            switch (FunName)
            {
                case JSScriptItem.Click: str.Append("点击"); break;
                case JSScriptItem.KeyInput: str.Append("输入"); break;
                case JSScriptItem.Sleep: str.Append("暂停"); break;
                case JSScriptItem.SelectApp: str.Append("选择"); break;
                case JSScriptItem.Script: str.Append("脚本"); break;
            }
            str.Append(": ");
            for (int i = 0; i < Params.Count; i++)
            {
                if (i != 0)
                {
                    str.Append(", ");
                }
                str.Append(Params[i]);
            }

            return str.ToString();
        }

        public string toParams()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < Params.Count; i++)
            {
                if (i != 0)
                {
                    str.Append(", ");
                }
                str.Append("\"").Append(Params[i]).Append("\"");
            }
            return str.ToString();
        }

        public static JSScriptItem Parse(string content)
        {
            int index = content.IndexOf("(", StringComparison.Ordinal);
            var name = content.Substring(0, index);
            JSScriptItem item = new JSScriptItem(name);
            var para = content.Substring(index + 1, content.Length - 3 - index);
            item.Params = para.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim().Trim('\"')).ToList();
            return item;
        }
    }
}
