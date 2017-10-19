namespace LiczbyPierwszeVer_1.Models {
    public class PrimaryNumbers {
        public static bool IsPrimary(int number) {
            for (var i = 2; i * i < number; i++) {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}