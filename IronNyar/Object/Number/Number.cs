using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace IronNyar.Object.Number {
    public abstract class Self : Object.Self {
        public readonly dynamic _value = 0;
        public string[] __attribute__ = new string[] {
            "locked", "protected"
        };
        public override string __code__ {
            get {
                return this._value;
            }
        }
    }
}
