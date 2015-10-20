using System;

namespace Test.PermutationSignature
{
	using System.Collections.Generic;
	using System.Linq;

	public struct Permutation {
		public List<int> currentList;
		public string remainingSignature;
		public int highest;
		public Permutation(List<int> c, string r, int h) {
			this.currentList = c;
			this.remainingSignature = r;
			this.highest = h;
		}

		public static Permutation InitialPermutation(string signature) {
			return new Permutation (new List<int> { 1 }, signature, 1);
		}
	}

	public class PermutationSignature
	{
		private Permutation TransformSignature(Permutation currentPermutation) {
			if (currentPermutation.remainingSignature.Length == 0) {
				return currentPermutation;
			}
			if (currentPermutation.remainingSignature [0] == 'I') {
				currentPermutation.currentList.Add (currentPermutation.highest + 1);
				return TransformSignature (new Permutation(
					currentPermutation.currentList,
					currentPermutation.remainingSignature.Substring(1),
					currentPermutation.highest + 1
				));
			} else { // 'D'
				int i;
				for (i = currentPermutation.currentList.Count - 1; i >= 1; i--) {
					if (currentPermutation.currentList [i - 1] > currentPermutation.currentList [i]) {
						currentPermutation.currentList [i] += 1;
					} else {
						break;
					}
				}

				currentPermutation.currentList [i] += 1;

				currentPermutation.currentList.Add (currentPermutation.currentList.Last() - 1);
				return TransformSignature (new Permutation(
					currentPermutation.currentList,
					currentPermutation.remainingSignature.Substring(1),
					Math.Max(currentPermutation.highest, currentPermutation.currentList[i])
				));
			}
		}

		public int[] reconstruct(string signature) {
			return TransformSignature (Permutation.InitialPermutation(signature)).currentList.ToArray();
		}
	}
}

