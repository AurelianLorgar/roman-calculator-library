namespace RomanCalculator {
    public class Check {

        public static bool CheckRead(string checkString) {
            bool result;

            if (checkString.Equals("-")) {
                result = false;
            } else {
                result = true;
            }
            return result;
        }

        public static bool CheckDoubleSigns(string numbers) {

            bool result = false;
            bool resultMiddle = false;
            char[] arrayOfNumbersChar = numbers.ToCharArray();
            char[] mathSignsChar = { '+', '-', '*', '/' };

            for (int i = 1; i < arrayOfNumbersChar.Length; i++) {
                for (int j = 0; j < mathSignsChar.Length; j++) {
                    if ((arrayOfNumbersChar[i - 1].Equals(mathSignsChar[j]))) {
                        resultMiddle = true;
                    }
                    if (resultMiddle) {
                        for (int k = 0; k < mathSignsChar.Length; k++) {
                            if ((arrayOfNumbersChar[i].Equals(mathSignsChar[k]))) {
                                return result = true;
                            } else {
                                resultMiddle = false;
                            }
                        }
                        
                    }
                }
            }
            return result;
        }

        public static bool CheckTransfer(char[] arrayOfNumbersCheck) {
            char[] romanNumbersSignsChar = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            int errTest = 0;
            int err = 0;
            bool result;

            for (int i = 0; i < arrayOfNumbersCheck.Length; i++) {
                for (int j = 0; j < romanNumbersSignsChar.Length; j++) {
                    if (romanNumbersSignsChar[j] != arrayOfNumbersCheck[i]) {
                        errTest++;
                    }
                }
                if (errTest != 7) {
                    errTest = 0;
                } else {
                    err++;
                }
            }
            if (err > 0) {
                result = false;
            } else {
                result = true;
            }
            return result;
        }
    }
}