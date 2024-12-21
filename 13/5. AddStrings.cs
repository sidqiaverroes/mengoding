//leetcode 415. Add Strings

public class Solution {
    public string AddStrings(string num1, string num2) {
        Dictionary<char, int> numMap = new()
        {
            {'1', 1},
            {'2', 2},
            {'3', 3},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 7},
            {'8', 8},
            {'9', 9},
            {'0', 0},
        };

        List<int> res = [];
        char[] num1Array = num1.ToCharArray();
        char[] num2Array = num2.ToCharArray();

        int Index1 = num1Array.Length-1;
        int Index2 = num2Array.Length-1;

        int buffer = 0;

        while(true)
        {
            if(Index1 < 0 && Index2 <0 && buffer == 0) break;

            int addRes = 0;

            if(Index1 >= 0 && Index2 >= 0)
            {
                addRes = Add(numMap[num1Array[Index1]], numMap[num2Array[Index2]], buffer);
            }
            else if(Index1 < 0 && Index2 >=0)
            {
                addRes = Add(0, numMap[num2Array[Index2]], buffer);
            }
            else if(Index2 < 0 && Index1 >=0)
            {
                addRes = Add(numMap[num1Array[Index1]], 0, buffer);
            }
            else
            {
                addRes = buffer;
            }
            
            if(addRes < 10)
            {
                res.Add(addRes);
                buffer = 0;
            }
            else
            {
                res.Add(addRes%10);
                buffer = 1;
            }

            Index1--;
            Index2--;
        }

        res = ReverseIntList(res);

        return String.Join("", res.ToArray());
    }

    private int Add(int num1, int num2, int buffer)
    {
        return num1+num2+buffer;
    }

    private List<int> ReverseIntList(List<int> arr)
    {
        int l = 0;
        int r = arr.Count-1;
        
        while(l<r)
        {
            int temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;

            l++;
            r--;
        }

        return arr;
    }
}

//Alternative solution utilizing ASCII value of Char

public class Solution {
    public string AddStrings(string num1, string num2) {
        int Index1 = num1.Length-1;
        int Index2 = num2.Length-1;
        int buffer = 0;

        List<int> res = [];

        while(Index1 >=0 || Index2 >= 0 || buffer != 0)
        {
            int Digit1 = Index1 >=0 ? (int)num1[Index1] - '0' : 0;
            int Digit2 = Index2 >=0 ? (int)num2[Index2] - '0' : 0;

            int sum = Digit1 + Digit2 + buffer;
            res.Add(sum % 10);
            buffer = sum/10;

            Index1--;
            Index2--;
        }

        res.Reverse();

        return String.Join("", res.ToArray());
    }
}

// --------------------------------------------------------------------------
// '5' has the int value 53
// if we write '5'-'0' it evaluates to 53-48, or the int 5
// if we write char c = 'B'+32; then c stores 'b'


// Dec  Char                           Dec  Char     Dec  Char     Dec  Char
// ---------                           ---------     ---------     ----------
//   0  NUL (null)                      32  SPACE     64  @         96  `
//   1  SOH (start of heading)          33  !         65  A         97  a
//   2  STX (start of text)             34  "         66  B         98  b
//   3  ETX (end of text)               35  #         67  C         99  c
//   4  EOT (end of transmission)       36  $         68  D        100  d
//   5  ENQ (enquiry)                   37  %         69  E        101  e
//   6  ACK (acknowledge)               38  &         70  F        102  f
//   7  BEL (bell)                      39  '         71  G        103  g
//   8  BS  (backspace)                 40  (         72  H        104  h
//   9  TAB (horizontal tab)            41  )         73  I        105  i
//  10  LF  (NL line feed, new line)    42  *         74  J        106  j
//  11  VT  (vertical tab)              43  +         75  K        107  k
//  12  FF  (NP form feed, new page)    44  ,         76  L        108  l
//  13  CR  (carriage return)           45  -         77  M        109  m
//  14  SO  (shift out)                 46  .         78  N        110  n
//  15  SI  (shift in)                  47  /         79  O        111  o
//  16  DLE (data link escape)          48  0         80  P        112  p
//  17  DC1 (device control 1)          49  1         81  Q        113  q
//  18  DC2 (device control 2)          50  2         82  R        114  r
//  19  DC3 (device control 3)          51  3         83  S        115  s
//  20  DC4 (device control 4)          52  4         84  T        116  t
//  21  NAK (negative acknowledge)      53  5         85  U        117  u
//  22  SYN (synchronous idle)          54  6         86  V        118  v
//  23  ETB (end of trans. block)       55  7         87  W        119  w
//  24  CAN (cancel)                    56  8         88  X        120  x
//  25  EM  (end of medium)             57  9         89  Y        121  y
//  26  SUB (substitute)                58  :         90  Z        122  z
//  27  ESC (escape)                    59  ;         91  [        123  {
//  28  FS  (file separator)            60  <         92  \        124  |
//  29  GS  (group separator)           61  =         93  ]        125  }
//  30  RS  (record separator)          62  >         94  ^        126  ~
//  31  US  (unit separator)            63  ?         95  _        127  DEL