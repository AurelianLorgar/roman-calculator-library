
namespace RomanCalculator {
    public class RomanToArabic {

        char[] numbers = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };

        public int Transfer(char[] arrayOfNumbers) {

            if (Check.CheckTransfer(arrayOfNumbers) == false) {
                return -1;
            }

            int arabicNumberInt = 0;

            for (int pos = 0; pos < arrayOfNumbers.Length; pos++) {

                switch (arrayOfNumbers[pos]) {
                    case 'M':
                        arabicNumberInt += arabicNumbers(arrayOfNumbers, pos, 0);
                        break;
                    case 'D':
                        arabicNumberInt += arabicNumbers(arrayOfNumbers, pos, 1);
                        break;
                    case 'C':
                        arabicNumberInt += arabicNumbers(arrayOfNumbers, pos, 2);
                        break;
                    case 'L':
                        arabicNumberInt += arabicNumbers(arrayOfNumbers, pos, 3);
                        break;
                    case 'X':
                        arabicNumberInt += arabicNumbers(arrayOfNumbers, pos, 4);
                        break;
                    case 'V':
                        arabicNumberInt += arabicNumbers(arrayOfNumbers, pos, 5);
                        break;
                    case 'I':
                        arabicNumberInt += arabicNumbers(arrayOfNumbers, pos, 6);
                        break;
                    default:
                        break;
                }
            }
            return arabicNumberInt;
        }

        private int arabicNumbers(char[] arrayOfNumbers, int pos, int numberPos) {

            if (numberPos == 0) {
                return 1000;
            }

            switch (numberPos) {
                case 1:
                    if ((pos + 1) < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos].Equals(numbers[numberPos])) {
                            return -500;
                        }
                    }
                    return 500;
                case 2:
                    if ((pos + 1) < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos].Equals(numbers[numberPos])) {
                            return -100;
                        }
                    }
                    return 100;
                case 3:
                    if ((pos + 1) < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos].Equals(numbers[numberPos])) {
                            return -50;
                        }
                    }
                    return 50;
                case 4:
                    if ((pos + 1) < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos].Equals(numbers[numberPos])) {
                            return -10;
                        }
                    }
                    return 10;
                case 5:
                    if ((pos + 1) < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos].Equals(numbers[numberPos])) {
                            return -5;
                        }
                    }
                    return 5;
                case 6:
                    if ((pos + 1) < arrayOfNumbers.Length) {
                        if (arrayOfNumbers[pos].Equals(numbers[numberPos])) {
                            return -1;
                        }
                    }
                    return 1;
            }

            return 0;
        }
    }
}