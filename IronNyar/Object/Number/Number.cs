using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace IronNyar.Object.Number {
    public abstract class Self : Object.Self {
        private dynamic _value;
        public string[] __attribute__ = new string[] {
            "locked", "protected"
        };
        public override string __code__ {
            get {
                return this._value;
            }

        }
        public static bool operator ==(Self a, Self b) {
            return a._value == b._value;
        }
        public static bool operator !=(Self a, Self b) {
            return a._value != b._value;
        }

        public override bool Equals(object obj) {
            return obj is Self self && EqualityComparer<dynamic>.Default.Equals(_value, self._value);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
