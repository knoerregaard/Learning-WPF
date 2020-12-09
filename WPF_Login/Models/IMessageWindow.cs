using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.Models
{
    interface IMessageWindow
    {
        string HeadBarText { get; set; }
        string Message { get; set; }
        void Show();
        void Close();
    }
}
