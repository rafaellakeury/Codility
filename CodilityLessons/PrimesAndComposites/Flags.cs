
namespace CodilityLessons.PrimesAndComposites
{
    public class Flags
    {
        public int Solution(int[] A)
        {
            int nextPeak = A.Length;
            int[] peaks = new int[A.Length];
            peaks[A.Length - 1] = nextPeak;

            for (int i = A.Length - 2; i > 0; i--) {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                    nextPeak = i;
                peaks[i] = nextPeak;
            }

            peaks[0] = nextPeak;
            int current_guess = 0;
            int next_guess = 0;

            while (canPlaceFlags(peaks, next_guess)) {
                current_guess = next_guess;
                next_guess += 1;
            }

            return current_guess;
        }

        private bool canPlaceFlags(int[] peaks, int flagsToPlace) {
            int currentPosition = 1 - flagsToPlace;
            for (int i = 0; i < flagsToPlace; i++) {
                if (currentPosition + flagsToPlace > peaks.Length - 1)
                    return false;
                currentPosition = peaks[currentPosition + flagsToPlace];
            }
            return currentPosition < peaks.Length;
        }

    }
}