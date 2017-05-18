using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection_Sample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text;
            Type T = Type.GetType(typeName);
            listBoxMethods.Items.Clear();
            listBoxProperties.Items.Clear();
            listBoxConstructors.Items.Clear();

            MethodInfo[] objMethods =  T.GetMethods();

            foreach (MethodInfo methodInfo in objMethods)
            {
                listBoxMethods.Items.Add(methodInfo.ReturnType + " " + methodInfo.Name);
            }

            PropertyInfo[] objProperties = T.GetProperties();

            foreach (PropertyInfo propertyInfo in objProperties)
            { 
                listBoxProperties.Items.Add(propertyInfo.PropertyType.Name + " " + propertyInfo.Name);
            }

            ConstructorInfo[] objConstructors = T.GetConstructors();

            
            foreach (ConstructorInfo constructorInfo in objConstructors)
            { 
                listBoxConstructors.Items.Add(constructorInfo.ToString());
            }
        }
    }
}
