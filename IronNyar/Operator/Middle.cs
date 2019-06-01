using System.Dynamic;
using System.Numerics;

namespace IronNyar.Operator {
    public class Middle : DynamicObject {
        #region Equal ==
        public static Object.Number.Integer.Self Equal(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value - rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
        #region Plus +
        public static Object.Number.Integer.Self Plus(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value + rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        public static Object.Number.Integer.Integer64 Plus(Object.Number.Integer.Integer64 lhs, Object.Number.Integer.Integer64 rhs) {
            long output = lhs._value + rhs._value;
            return new Object.Number.Integer.Integer64(output);
        }
        public static Object.Number.Integer.Integer32 Plus(Object.Number.Integer.Integer32 lhs, Object.Number.Integer.Integer32 rhs) {
            int output = lhs._value + rhs._value;
            return new Object.Number.Integer.Integer32(output);
        }
        /*
        public static Object.Number.Integer.Integer16 Plus(Object.Number.Integer.Integer16 lhs, Object.Number.Integer.Integer16 rhs)
        {
            short output = lhs._value + rhs._value;
            return new Object.Number.Integer.Integer16(output);
        }
        public static Object.Number.Integer.Integer8 Plus(Object.Number.Integer.Integer8 lhs, Object.Number.Integer.Integer8 rhs)
        {
            sbyte output = lhs._value + rhs._value;
            return new Object.Number.Integer.Integer8(output);
        }
        */
        #endregion
        #region Minus - 
        public static Object.Number.Integer.Self Minus(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value - rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
        #region Times * 
        public static Object.Number.Integer.Self Times(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value * rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
        #region Divide /
        public static Object.Number.Integer.Self Divide(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value - rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
        #region Remainder //
        public static Object.Number.Integer.Self Quotient(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value / rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
        #region Modulo  %
        public static Object.Number.Integer.Self Modulo(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value - rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
    }
}
