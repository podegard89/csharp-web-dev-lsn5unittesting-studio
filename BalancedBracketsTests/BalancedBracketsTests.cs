using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void AnyNumberOfBracketPairsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][][][][][][][][][][][][][][][][][][][][]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void CharactersBetweenBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[ajhdiufhsdoifuoidu234124]"));
        }

        [TestMethod]
        public void OnlyOpenBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void OnlyClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void MatchedPairsSurroundedByAnyOtherCharacters()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("addbnhn[dasfreuu3485]jsahdh3348hh[]dsadffd453[df][]"));
        }

        [TestMethod]
        public void OnlyOpenBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[[[[[[[[[[[[[[["));
        }

        [TestMethod]
        public void AnyAmountOfClosingBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]]]]]]]]]]]]]]]]]]]]]"));
        }

        [TestMethod]
        public void ClosedBracketBeforeOpenBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void AnyAmountOfRandomBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]][]][[][[[[][[][][]][][][[]]]]][][]["));
        }

        [TestMethod]
        public void AnyAmountOfNestedBracketPairsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[[[[[[[[[[[a]]]]]]]]]]]]]]"));
        }
    }
}
