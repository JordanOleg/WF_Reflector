using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WF_Reflector_dotNET
{
    internal class Decompiler
    {
        string path = string.Empty;
        Assembly assembly = null;
        public Decompiler(string path)
        {
            if (path == string.Empty)
            {
                throw new ArgumentNullException("path");
            }
            this.path = path;
            assembly = Assembly.LoadFrom(path);
        }
        public Assembly Assembly { get { return assembly; } }
        public List<MethodInfo> GetMethodInfoList(Type type)
        {
            List<MethodInfo> methods = new List<MethodInfo>();
            MethodInfo[] methodInfos = type.GetMethods();
            for (int i = 0; i < methodInfos.Length; i++)
            {
                MethodInfo methodInfo = methodInfos[i];
                if (!Regex.IsMatch(methodInfo.Name, "^(get_\\w+|set_\\w+)") || methodInfo.IsConstructor)
                {
                    methods.Add(methodInfo);
                }
            }
            return methods;
        }
        public List<PropertyInfo> GetPropertyInfoList(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();
            return properties.ToList();
        }
        public List<Type> GetTypeList()
        {
            Assembly asm = this.assembly;
            Type[] types = asm.GetTypes();
            return types.ToList();
        }
        public List<Type> GetTypeList(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();
            return types.ToList();
        }
    }
}
