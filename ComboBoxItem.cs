using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pecaros {
    class ComboBoxItem {
        public object Value;
        public string Text;

        public ComboBoxItem(object value, string text) {
            Value = value;
            Text = text;
        }

        public override string ToString() {
            return Text;
        }
    }
}
