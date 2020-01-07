using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

namespace WindowsFormsScript.RunTime
{
    public class JSRunTime
    {
        private IJsEngine jsEngine = new V8JsEngine();

        private readonly Action<string> webLogListener;

        public JSRunTime(Action<string> action)
        {
            webLogListener = action;
        }

        public void RegisterJsObject(string itemName, object value)
        {
            jsEngine.EmbedHostObject(itemName, value);
        }

        public void injectJS(string js)
        {
            jsEngine.Execute(js);
        }

        public void injectJS(List<FileInfo> files)
        {
            foreach (var item in files)
            {
                jsEngine.ExecuteFile(item.FullName);
            }
        }

        public void SetVariableValue(string variableName, object value)
        {
            jsEngine.SetVariableValue(variableName, value);
        }

        public void CallFunction(string functionName, params object[] args)
        {
            new Thread(() =>
            {
                try
                {
                    setMessage("执行开始");
                    jsEngine.CallFunction(functionName, args);
                    setMessage("执行结束");
                }
                catch (Exception ex)
                {
                    setMessage(ex.ToString());
                }
            }).Start();
        }

        public void ExecuteScript(string code)
        {
            jsEngine.Execute(code);
        }

        public void setMessage(string msg)
        {
            webLogListener?.Invoke(msg);
        }
    }
}
