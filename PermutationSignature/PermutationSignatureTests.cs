using System;
using NUnit.Framework;

namespace Test.PermutationSignature
{
	[TestFixture]
	public class PermutationSignatureTests
	{
		private PermutationSignature m_ps;

		[SetUp]
		public void Setup ()
		{
			m_ps = new PermutationSignature ();
		}

		[Test]
		public void SimpleTests() {
			Assert.AreEqual (new int[] { 2, 1 }, m_ps.reconstruct ("D"));
			Assert.AreEqual (new int[] { 1, 2 }, m_ps.reconstruct ("I"));
			Assert.AreEqual (new int[] { 4, 3, 2, 1 }, m_ps.reconstruct ("DDD"));
			Assert.AreEqual (new int[] { 1, 2, 3, 4 }, m_ps.reconstruct ("III"));
		}

		[Test]
		public void HarderTests() {
			Assert.AreEqual (new int[] { 2, 1, 4, 3 }, m_ps.reconstruct ("DID"));
			Assert.AreEqual (new int[] { 1, 3, 2, 4 }, m_ps.reconstruct ("IDI"));
		}

		[Test]
		public void GivenTests() {
			Assert.AreEqual (new int[] { 1, 2, 3, 4, 5, 6 }, m_ps.reconstruct ("IIIII"));
			Assert.AreEqual (new int[] { 2, 1, 3 }, m_ps.reconstruct ("DI"));
			Assert.AreEqual (new int[] { 1, 2, 3, 4, 6, 5 }, m_ps.reconstruct ("IIIID"));
			Assert.AreEqual (new int[] { 2, 1, 3, 5, 4, 7, 6 }, m_ps.reconstruct ("DIIDID"));
		}
	}
}

