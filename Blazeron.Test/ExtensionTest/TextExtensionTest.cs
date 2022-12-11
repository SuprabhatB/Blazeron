namespace Blazeron.Test.ExtensionTest
{
    using Blazeron.Utilities.Extensions;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="TextExtensionTest" />.
    /// </summary>
    [TestFixture]
    public class TextExtensionTest
    {
        /// <summary>
        /// Tests the convert to title case.
        /// </summary>
        [Test]
        public void TestConvertToTitleCase()
        {
            var word = "loreum ipsum";
            var titleCaseWord = word.ToTitleCase();

            Assert.AreEqual("Loreum Ipsum", titleCaseWord);
        }

        /// <summary>
        /// Tests the convert to title case from empty string.
        /// </summary>
        [Test]
        public void TestConvertToTitleCaseFromEmptyString()
        {
            var word = string.Empty;
            var titleCaseWord = word.ToTitleCase();

            Assert.AreEqual(null, titleCaseWord);
        }

        /// <summary>
        /// Tests the convert to title case from default string.
        /// </summary>
        [Test]
        public void TestConvertToTitleCaseFromDefaultString()
        {
            var word = default(string);
            var titleCaseWord = word.ToTitleCase();

            Assert.AreEqual(null, titleCaseWord);
        }

        /// <summary>
        /// Tests the convert to camel case.
        /// </summary>
        [Test]
        public void TestConvertToCamelCase()
        {
            var word = "LoreumIpsum";
            var titleCaseWord = word.ToCamelCase();

            Assert.AreEqual("loreumIpsum", titleCaseWord);
        }

        /// <summary>
        /// Tests the convert to camel case from empty string.
        /// </summary>
        [Test]
        public void TestConvertToCamelCaseFromEmptyString()
        {
            var word = string.Empty;
            var titleCaseWord = word.ToCamelCase();

            Assert.AreEqual(null, titleCaseWord);
        }

        /// <summary>
        /// Tests the convert to camel case from default string.
        /// </summary>
        [Test]
        public void TestConvertToCamelCaseFromDefaultString()
        {
            var word = default(string);
            var titleCaseWord = word.ToCamelCase();

            Assert.AreEqual(null, titleCaseWord);
        }
    }
}
