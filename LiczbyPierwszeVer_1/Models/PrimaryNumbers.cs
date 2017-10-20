using System.Collections.Generic;

namespace LiczbyPierwszeVer_1.Models {
    public class PrimaryNumbers {
        public  bool IsPrimary(int number) {
            for (var i = 2; i < number; i++) {
                if (number % i == 0) return false;
            }
            return true;
        }

        public List<int> GetAllPrimary(int limit) {
            List<int> list = new List<int>();
            for (int i = 2; i <= limit; i++) {
                if(IsPrimary(i)) list.Add(i);
            }
            return list;
        }
    }
}