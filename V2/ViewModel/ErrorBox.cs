using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace V2.ViewModel
{
    public static class ErrorBox
    {
        public static void ErrorMes(string str)
        {
            MessageBox.Show($"Ошибка: {str}");
        }
    }
}
