using System;
using NUnit.Framework;

namespace Test.IsomorphicWords
{
	[TestFixture]
	public class IsomorphicWordsTests
	{
		IsomorphicWords handler;
		
		[SetUp]
		public void Setup() {
			handler = new IsomorphicWords ();
		}

		[Test]
		public void Test1() {
			Assert.AreEqual (1, handler.countPairs (new string[] { "abca", "zbxz", "opqr" }));
		}

		[Test]
		public void Test2() {
			Assert.AreEqual (4, handler.countPairs (new string[] {"aa", "ab", "bb", "cc", "cd"}));
		}
	}
}

