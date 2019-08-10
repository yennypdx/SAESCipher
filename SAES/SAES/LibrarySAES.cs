using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAES
{
    public class LibrarySAES
    {
        public LibrarySAES() { }

        public List<int> ConvertStringOfNumbersToBinary(string inputText)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < inputText.Length; i++)
            {
                int val = (int)Char.GetNumericValue(inputText[i]);
                string binary = Convert.ToString(val, 2);
                if (binary.Length != 4) {
                    string newBinary = binary.PadLeft(4, '0');
                    foreach (var s in newBinary) {
                        int temp = (int)Char.GetNumericValue(s);
                        output.Add(temp);
                    }
                } else {
                    foreach (var s in binary) {
                        int temp = (int)Char.GetNumericValue(s);
                        output.Add(temp);
                    }
                }
            }
            return output;
        }

        public List<int> PermutationOne(List<int> inputList)
        {
            List<int> output = new List<int>();
            output.Add(inputList[14]);  // 0>14
            output.Add(inputList[5]);   // 1>5
            output.Add(inputList[0]);   // 2>0
            output.Add(inputList[11]);  // 3>11
            output.Add(inputList[7]);   // 4>7
            output.Add(inputList[12]);  // 5>12
            output.Add(inputList[2]);   // 6>2
            output.Add(inputList[13]);  // 7>13
            output.Add(inputList[10]);  // 8>10
            output.Add(inputList[8]);   // 9>8
            output.Add(inputList[4]);   // 10>4
            output.Add(inputList[6]);   // 11>6
            output.Add(inputList[1]);   // 12>1
            output.Add(inputList[15]);  // 13>15
            output.Add(inputList[9]);   // 14>9
            output.Add(inputList[3]);   // 15>3
            return output;
        }

        public List<int> ExorEvaluation(List<int> messageBinary, List<int> keyBinary)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < messageBinary.Count; i++)
            {
                var tempVal = 0;
                if (messageBinary[i] == 0 && keyBinary[i] == 1)
                    tempVal = 1;
                else if (messageBinary[i] == 1 && keyBinary[i] == 0)
                    tempVal = 1;
                else
                    tempVal = 0;

                output.Add(tempVal);
            }
            return output;
        }

        public List<int> ShiftOneRight(List<int> inputList)
        {
            List<int> output = new List<int>();
            output.Add(inputList[15]);      
            for (int i = 1; i < inputList.Count; i++) {   
                output.Add(inputList[i - 1]);
            }
            return output;
        }

        public List<int> ShiftRowsSingleRound(List<int> inputList)
        {
            List<int> output = new List<int>();
            List<int> row0 = new List<int>();
            List<int> row1 = new List<int>();
            List<int> row2 = new List<int>();
            List<int> row3 = new List<int>();

            for(int i = 0; i < inputList.Count; i++)
            {
                if (i < 4)
                    row0.Add(inputList[i]);
                else if (i > 3 && i < 8)
                    row1.Add(inputList[i]);
                else if (i > 7 && i < 12)
                    row2.Add(inputList[i]);
                else
                    row3.Add(inputList[i]);
            }

            output = row0;
            ShiftOneLeftRowOne(row1);            
            output.AddRange(row1);
            ShiftTwoLeftRowTwo(row2);
            output.AddRange(row2);
            ShiftThreeLeftRowThree(row3);
            output.AddRange(row3);

            return output;
        }

        public List<int> ShiftOneLeftRowOne(List<int> inputList)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < inputList.Count; i++) {
                if (i == 3)
                    output.Add(inputList[0]);
                else
                    output.Add(inputList[i + 1]);
            }
            return output;
        }

        public List<int> ShiftTwoLeftRowTwo(List<int> inputList)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < inputList.Count; i++) {
                if (i < 2)
                    output.Add(inputList[i + 2]);
                else
                    output.Add(inputList[i - 2]);
            }
            return output;
        }

        public List<int> ShiftThreeLeftRowThree(List<int> inputList)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < inputList.Count; i++) {
                if (i < 1)
                    output.Add(inputList[i + 3]);
                else
                    output.Add(inputList[i - 1]);
            }
            return output;
        }

    }
}
