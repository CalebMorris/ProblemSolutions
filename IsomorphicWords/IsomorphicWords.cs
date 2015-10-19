using System;

namespace Test.IsomorphicWords
{

	using System.Collections.Generic;
	public class IsomorphicWords
	{
		bool IsIsomorphic(string left, string right) {
			Dictionary<char, char> map = new Dictionary<char, char> ();
			Dictionary<char, char> rmap = new Dictionary<char, char> ();
			for (int i = 0; i < left.Length; i++) {
				if (!map.ContainsKey (left [i]) && !rmap.ContainsKey(right[i])) {
					map [left [i]] = right [i];
					rmap [right [i]] = left [i];
				} else if (
					!map.ContainsKey (left [i]) ||
					!rmap.ContainsKey(right[i]) ||
					map [left [i]] != right [i] ||
					rmap[right[i]] != left[i]
				) {
					return false;
				}
			}
			return true;
		}

		public int countPairs(string[] words) {
			int count = 0;
			for (int i = 0; i < words.Length - 1; i++) {
				for (int j = i + 1; j < words.Length; j++) {
					if (IsIsomorphic (words [i], words [j])) {
						count++;
					}
				}
			}
			return count;
		}
	}
}

