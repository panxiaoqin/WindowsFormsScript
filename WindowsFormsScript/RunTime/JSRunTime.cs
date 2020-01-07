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
                    jsEngine.CallFunction(functionName, args);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }).Start();
        }

        public void ExecuteScript(string code)
        {
            jsEngine.Execute(code);
        }
    }
}
