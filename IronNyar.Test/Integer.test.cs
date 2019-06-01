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
            var res = new Integer32("25");
            var ans = Middle.Plus(lhs, rhs);
            Assert.True(res == ans);
        }
        [Test]
        public void TypeCast() {
            var lhs = new Integer32("20");
            var rhs = new Integer64("5");
            var res = new Self("25");
            var ans = Middle.Plus(lhs, rhs);
            Assert.True(res == ans);
        }
        [Test]
        public void Plus() {
            var lhs = new Self("20");
            var rhs = new Self("5");
            Assert.True(lhs + rhs == new Self("+25"));
        }
        [Test]
        public void Minus() {
            var lhs = new Self("20");
            var rhs = new Self("5");
            Assert.True(new Self("+15") == Middle.Minus(lhs, rhs));
            Assert.True(new Self("-15") == Middle.Minus(rhs, lhs));
        }
        [Test]
        public void Times() {
            var lhs = new Self("20");
            var rhs = new Self("5");
            var res = new Self("100");
            var ans = Middle.Times(lhs, rhs);
            Assert.True(res == ans);
        }
        [Test]
        public void Quotient() {
            var lhs = new Self("64");
            var rhs = new Self("5");
            var res = new Self("12");
            var ans = Middle.Quotient(lhs, rhs);
            Assert.True(res == ans);
        }
        [Test]
        public void Modulo() {
            var lhs = new Self("64");
            var rhs = new Self("5");
            var res = new Self("4");
            var ans = Middle.Modulo(lhs, rhs);
            Assert.True(res == ans);
        }
    }
}
