using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PredefinedType
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            ListBoxItem listBoxItem = (ListBoxItem)listBox.SelectedItem;
            string typeName = listBoxItem.Content.ToString();
            //string typename = $"((((sender as ListBox).SelectedItem) as ListBoxItem).Content)";
            minValue.Text = "";
            maxValue.Text = "";
            type.Text = "";
            typeCode.Text = "";
            Console.WriteLine($"typeName = {typeName}");
            switch (typeName)
            {
                case "sbyte":
                    displaySbyte();
                    break;
                case "byte":
                    displayByte();
                    break;
                case "short":
                    displayShort();
                    break;
                case "ushort":
                    displayUshort();
                    break;
                case "int":
                    displayInt();
                    break;
                case "uint":
                    displayUint();
                    break;
                case "long":
                    displayLong();
                    break;
                case "ulong":
                    displayUlong();
                    break;
                case "float":
                    displayFloat();
                    break;
                case "double":
                    displayDouble();
                    break;
                case "bool":
                    displayBool();
                    break;
                case "char":
                    displayChar();
                    break;
                case "decimal":
                    displayDecimal();
                    break;
            }
        }
        private void displayDecimal()
        {
            minValue.Text = $"{decimal.MinValue}";
            maxValue.Text = $"{decimal.MaxValue}";
            typeCode.Text = $"{new decimal().GetTypeCode()}";
            type.Text = $"{new decimal().GetType()}";
        }

        private void displayChar()
        {
            minValue.Text = $"{char.MinValue}";
            maxValue.Text = $"{char.MaxValue}";
            typeCode.Text = $"{new char().GetTypeCode()}";
            type.Text = $"{new char().GetType()}";
        }

        private void displayBool()
        {
            minValue.Text = $"{bool.FalseString}";
            maxValue.Text = $"{bool.TrueString}";
            typeCode.Text = $"{new bool().GetTypeCode()}";
            type.Text = $"{new bool().GetType()}";
        }

        private void displayDouble()
        {
            minValue.Text = $"{double.MinValue}";
            maxValue.Text = $"{double.MaxValue}";
            typeCode.Text = $"{new double().GetTypeCode()}";
            type.Text = $"{new double().GetType()}";
        }

        private void displayFloat()
        {
            minValue.Text = $"{float.MinValue}";
            maxValue.Text = $"{float.MaxValue}";
            typeCode.Text = $"{new float().GetTypeCode()}";
            type.Text = $"{new float().GetType()}";
        }

        private void displayUlong()
        {
            minValue.Text = $"{ulong.MinValue}";
            maxValue.Text = $"{ulong.MaxValue}";
            typeCode.Text = $"{new ulong().GetTypeCode()}";
            type.Text = $"{new ulong().GetType()}";
        }

        private void displayLong()
        {
            minValue.Text = $"{long.MinValue}";
            maxValue.Text = $"{long.MaxValue}";
            typeCode.Text = $"{new long().GetTypeCode()}";
            type.Text = $"{new long().GetType()}";
        }

        private void displayUint()
        {
            minValue.Text = $"{uint.MinValue}";
            maxValue.Text = $"{uint.MaxValue}";
            typeCode.Text = $"{new uint().GetTypeCode()}";
            type.Text = $"{new uint().GetType()}";
        }

        private void displayInt()
        {
            minValue.Text = $"{int.MinValue}";
            maxValue.Text = $"{int.MaxValue}";
            typeCode.Text = $"{new int().GetTypeCode()}";
            type.Text = $"{new int().GetType()}";
        }

        private void displayUshort()
        {
            minValue.Text = $"{ushort.MinValue}";
            maxValue.Text = $"{ushort.MaxValue}";
            typeCode.Text = $"{new ushort().GetTypeCode()}";
            type.Text = $"{new ushort().GetType()}";
        }

        private void displayShort()
        {
            minValue.Text = $"{short.MinValue}";
            maxValue.Text = $"{short.MaxValue}";
            typeCode.Text = $"{new short().GetTypeCode()}";
            type.Text = $"{new short().GetType()}";
        }

        private void displayByte()
        {
            minValue.Text = $"{byte.MinValue}";
            maxValue.Text = $"{byte.MaxValue}";
            typeCode.Text = $"{new byte().GetTypeCode()}";
            type.Text = $"{new byte().GetType()}";
        }

        private void displaySbyte()
        {
            minValue.Text = $"{sbyte.MinValue}";
            maxValue.Text = $"{sbyte.MaxValue}";
            typeCode.Text = $"{new sbyte().GetTypeCode()}";
            type.Text = $"{new sbyte().GetType()}";
        }
    }
}
