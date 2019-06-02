using System.Dynamic;
using System.Numerics;

namespace IronNyar.Operator {
    public class Middle : DynamicObject {
        #region Equal ==
        #endregion
        #region Plus +
        public static dynamic Plus(dynamic lhs, dynamic rhs) {
            return lhs + rhs;
        }
        #endregion
        #region Minus -
        public static dynamic Minus(dynamic lhs, dynamic rhs) {
            return lhs - rhs;
        }
        #endregion
        #region Times *
        public static dynamic Times(dynamic lhs, dynamic rhs) {
            return lhs * rhs;
        }
        #endregion
        #region Divide /
        public static dynamic Divide(dynamic lhs, dynamic rhs) {
            return lhs / rhs;
        }
        #endregion
        #region Quotient //
        public static Object.Number.Integer.Self Quotient(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value / rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
        #region Modulo  %
        public static Object.Number.Integer.Self Modulo(Object.Number.Integer.Self lhs, Object.Number.Integer.Self rhs) {
            BigInteger output = lhs._value % rhs._value;
            return new Object.Number.Integer.Self(output);
        }
        #endregion
    }
}
