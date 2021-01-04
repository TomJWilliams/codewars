using NUnit.Framework;
using core;

namespace test
{
  public class CountingDuplicatesTest
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NoDuplicates_Count_Is_Zero()
    {
      var input = "abc";
      var result = CountingDuplicates.DuplicateCount(input);
      var expected = 0;
      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Duplicates_Count_Is_Not_Zero()
    {
      var input = "abca";
      var result = CountingDuplicates.DuplicateCount(input);
      var expected = 1;
      Assert.AreEqual(expected, result);
    }
  }
}