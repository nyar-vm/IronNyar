using NUnit.Framework;
using IronNyar.Object.Number.Integer;
using IronNyar.Operator;
namespace IronNyarTest {
    public class Integer {
        [SetUp]
        public void Setup() {
        }
        [Test]
        public void SameType() {
            var lhs = new Integer32("20");
            var rhs = new Integer32("5");
            var ans = lhs + rhs;
            Assert.True(lhs + rhs == new Integer32("25"));
            Assert.True(lhs + rhs != new Self("0"));
        }
        [Test]
        public void TypeCast() {
            var lhs = new Integer32("20");
            var rhs = new Integer64("5");
            Assert.True(lhs + rhs == new Self("25"));
            Assert.True(lhs + rhs != new Self("0"));
        }
        [Test]
        public void asInteger() {
            var self = new Integer8("20");
            Assert.True(self.asInteger() == new Self("20"));
            Assert.True(self.asInteger() != new Self("0"));
        }
        [Test]
        public void Plus() {
            var lhs = new Self("20");
            var rhs = new Self("5");
            var ans = Middle.Plus(lhs, rhs);
            Assert.True(lhs + rhs == new Self("+25"));
            Assert.True((Self)ans == new Self("+25"));

        }
        [Test]
        public void Minus() {
            var lhs = new Self("20");
            var rhs = new Self("5");
            Assert.True(lhs - rhs == new Self("+15"));
            Assert.True(rhs - lhs == new Self("-15"));
        }
        [Test]
        public void Times() {
            var lhs = new Self("20");
            var rhs = new Self("5");
            Assert.True(lhs * rhs == new Self("100"));
            Assert.True(lhs * rhs != new Self("0"));
        }
        [Test]
        public void Quotient() {
            var lhs = new Self("64");
            var rhs = new Self("5");
            var ans = Middle.Quotient(lhs, rhs);
            Assert.True(ans == new Self("12"));
            Assert.True(ans != new Self("0"));
        }
        [Test]
        public void Modulo() {
            var lhs = new Self("64");
            var rhs = new Self("5");
            var ans = Middle.Modulo(lhs, rhs);
            Assert.True(ans == new Self("4"));
            Assert.True(ans != new Self("0"));
        }
    }
}
