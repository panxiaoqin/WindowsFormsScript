using System;
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
