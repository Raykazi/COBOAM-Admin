using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace COBOAM_Admin.Classes
{
// ReSharper disable once InconsistentNaming
    public class DBItem
    {
        private readonly string _text;
        private readonly object _value;

        public DBItem(string text, object value)
        {
            _text = text;
            _value = value;
        }


        public string Text
        {
            get { return _text; }
        }
        public object Value
        {
            get { return _value; }
        }
    }
}