using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WindowsFormsScript.Util
{
    class JSONConfig
    {
        private string filePath;
        private JObject jsonObject;

        public JSONConfig(string name)
        {
            string path = GetPath("Config");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            filePath = path + "\\" + name + ".json";
            jsonObject = !File.Exists(filePath) ? new JObject() : JObject.Parse(File.ReadAllText(filePath));
        }

        public bool ContainsKey(string name)
        {
            return jsonObject.ContainsKey(name);
        }

        public bool ContainsKey(string parent, string name)
        {
            JObject json = Get<JObject>(parent);
            if (json == null)
            {
                return false;
            }
            return json.ContainsKey(name);
        }

        public void Put(string name, object value)
        {
            Put(jsonObject, name, value);
        }

        public void Put(string parent, string name, object value)
        {
            JObject json = Get<JObject>(parent);
            if (json == null)
            {
                json = new JObject();
                Put(parent, json);
            }
            Put(json, name, value);
        }

        public T Get<T>(string name)
        {
            return Get<T>(jsonObject, name);
        }

        public T Get<T>(string parent, string name)
        {
            JObject json = Get<JObject>(parent);
            if (json == null)
            {
                return default(T);
            }
            return Get<T>(json, name);
        }

        public void clear()
        {
            jsonObject.RemoveAll();
        }

        public void Remove(string name)
        {
            jsonObject[name] = null;
            Save();
        }

        public void Save()
        {
            File.WriteAllText(filePath, jsonObject.ToString());
        }

        public JObject GetJson()
        {
            return jsonObject;
        }

        private void Put(JObject json, string name, object value)
        {
            if (value is string)
            {
                json[name] = (string)value;
                Save();
            }
            else if (value is int)
            {
                json[name] = (int)value;
                Save();
            }
            else if (value is long)
            {
                json[name] = (long)value;
                Save();
            }
            else if (value is bool)
            {
                json[name] = (bool)value;
                Save();
            }
            else if (value is JObject)
            {
                json[name] = (JObject)value;
                Save();
            }
            else
            {
                throw new Exception("未定义的类型" + value.GetType());
            }
        }

        private T Get<T>(JObject json, string name)
        {
            if (!json.ContainsKey(name))
            {
                return default(T);
            }
            try
            {
                if (typeof(T).IsAssignableFrom(typeof(string)))
                {
                    return (T)(object)json[name].ToString();
                }

                if (typeof(T).IsAssignableFrom(typeof(int)))
                {
                    return (T)(object)json[name];
                }
                if (typeof(T).IsAssignableFrom(typeof(long)))
                {
                    return (T)(object)json[name];
                }
                if (typeof(T).IsAssignableFrom(typeof(bool)))
                {
                    return (T)(object)json[name];
                }
                if (typeof(T).IsAssignableFrom(typeof(JObject)))
                {
                    return (T)(object)json[name];
                }

                throw new Exception("未定义的类型" + typeof(T));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetPath(string name)
        {
            return AppDomain.CurrentDomain.BaseDirectory + name;
        }
    }
}
