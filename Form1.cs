using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Reflector_dotNET
{
    public partial class Form1 : Form
    {
        Decompiler decompiler = null;
        public Form1()
        {
            InitializeComponent();
            listBox.Items.Clear();
        }

        private void ToolStripMenuItem_Click_DecompilerAssemblies(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                decompiler = new Decompiler(path);
                listBox.Items.Add("Path: " + path);
                listBox.Items.Add($"СБОРКА: {decompiler.Assembly.FullName} ");
                listBox.Items.Add($"Attrebutes: ");
                var listAtr = decompiler.Assembly.CustomAttributes;
                List<Type> listType = decompiler.GetTypeList();
                foreach(var t in listAtr )
                {
                    listBox.Items.Add($" - {t}");
                }
                listBox.Items.Add("------------ TYPES ------------");
                foreach(Type type in listType)
                {
                    listBox.Items.Add($"Type: \t{type}");
                    List<MethodInfo> listMethod = decompiler.GetMethodInfoList(type);
                    foreach(var m in listMethod)
                    {
                        listBox.Items.Add($" - Method: \t{m.Name}");
                        listBox.Items.Add($"     -- R_Type: \t{m.ReturnType}");
                        try
                        {
                            listBox.Items.Add($"     -- C_Byte: \t{m.GetMethodBody().GetILAsByteArray()}");
                        }
                        catch
                        {
                            listBox.Items.Add($"     -- C_Byte: \t{m.GetHashCode()}");
                        }
                    }
                    List<PropertyInfo> listProperty = decompiler.GetPropertyInfoList(type);
                    foreach(PropertyInfo p in listProperty)
                    {
                        listBox.Items.Add($" - Property: \t{p.Name}");
                        listBox.Items.Add($"     -- R_Type: \t{p.PropertyType}");
                    }
                    listBox.Items.Add(" -------------------------- ");
                }
                listBox.Items.Add("----------------------");
                listBox.Items.Add("");
            }

        }
    }
}
