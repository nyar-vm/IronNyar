using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;

namespace IronNyar.Object.Number.Integer
{
    #region Self
    // Object.Number.Integer
    public class Self : Number.Self 
    {
        public BigInteger _value = 0;
        public const string __name__ = "Object.Number.Integer";
        public Self(object input) => this._value = BigInteger.Parse(input.ToString());
        public Self(string input) => this._value = BigInteger.Parse(input);
        public Self(BigInteger input) => this._value = input;
        public Self(Self input) => this._value = input._value;
    }
    #endregion
    #region Integer
    public sealed class Integer8 : Self
    {
        public new System.SByte _value = 0;
        public Integer8(object input) : base(input)
        {
            this._value = sbyte.Parse(input.ToString());
        }
        public Integer8(string input) : base(input)
        {
            this._value = sbyte.Parse(input);
        }
        public Self asInteger()
        {
            return new Self(this._value);
        }
    }
    public sealed class Integer16 : Self
    {
        public new System.Int16 _value = 0;
        public Integer16(object input) : base(input)
        {
            this._value = short.Parse(input.ToString());
        }
        public Integer16(string input) : base(input)
        {
            this._value = short.Parse(input);
        }
        public Self asInteger()
        {
            return new Self(this._value);
        }
    }
    public sealed class Integer32 : Self
    {
        public new int _value = 0;
        public Integer32(object input) : base(input)
        {
            this._value = int.Parse(input.ToString());
        }
        public Integer32(string input) : base(input)
        {
            this._value = int.Parse(input);
        }
        public Self asInteger()
        {
            return new Self(this._value);
        }
    }
    public sealed class Integer64 : Self
    {

        public new System.Int64 _value = 0;
        public Integer64(object input) : base(input)
        {
            this._value = long.Parse(input.ToString());
        }
        public Integer64(string input) : base(input)
        {
            this._value = long.Parse(input);
        }
        public Self asInteger()
        {
            return new Self(this._value);
        }
    }
    #endregion
    #region Unsigned
    public sealed class Unsigned8 : Self
    {
        public new System.Byte _value = 0;
        public Unsigned8(object input) : base(input)
        {
            this._value = (byte)input;
        }
    }

    public sealed class Unsigned16 : Self
    {

        public new System.UInt16 _value = 0;
        public Unsigned16(object input) : base(input)
        {
            this._value = (ushort)input;
        }
    }
    public sealed class Unsigned32 : Self
    {

        public new System.UInt32 _value = 0;
        public Unsigned32(object input) : base(input)
        {
            this._value = (uint)input;
        }
    }
    public sealed class Unsigned64 : Self
    {

        public new System.UInt64 _value = 0;
        public Unsigned64(object input) : base(input)
        {
            this._value = (ulong)input;
        }
    }
    #endregion
}
