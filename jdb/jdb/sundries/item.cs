using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace jdb.sundries
{
    class item
    {
        public string Text = "", Value = "";//可以多个
        public item(string _text, string _value)
        {
            Text = _text;
            Value = _value;
        }
        public override string ToString()
        {
            return Text;
        }


    }
}
