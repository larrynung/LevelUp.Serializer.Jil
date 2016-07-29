using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;
using LevelUp.Serializer.Jil.Test.Model;

namespace LevelUp.Serializer.Jil.Test
{
    [TestClass()]
    public class JilSerializerTest
    {
        [TestMethod()]
        public void SerializeToTextTest()
        {
            var larry = new Person("Larry Nung", 35);
            var target = new JilSerializer();
            var expected = @"{""Age"":35,""Name"":""Larry Nung""}";
            var actual = target.SerializeToText(larry);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DeSerializeFromTextTest()
        {
            var target = new JilSerializer();
            var expected = new Person("Larry Nung", 35).ToExpectedObject();
            var actual = target.DeSerializeFromText<Person>(@"{""Age"":35,""Name"":""Larry Nung""}");

            expected.ShouldEqual(actual);
        }
    }
}