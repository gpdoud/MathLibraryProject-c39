namespace StringLib;
public class StringLibrary {

    public static string ToUpperCase(string str) {
        var ucStr = "";
        foreach(var ch in str.ToCharArray()) {
            if(!char.IsLetter(ch)) {
                ucStr += ch.ToString();
                continue;
            }
            // we have a letter
            var aCh = ch switch {
                'a' => 'A',
                'b' => 'B',
                'c' => 'C',
                'd' => 'D',
                'e' => 'E',
                'f' => 'F',
                'g' => 'G',
                'h' => 'H',
                'i' => 'I',
                'j' => 'J',
                'k' => 'K',
                'l' => 'L',
                'm' => 'M',
                'n' => 'N',
                'o' => 'O',
                'p' => 'P',
                'q' => 'Q',
                'r' => 'R',
                's' => 'S',
                't' => 'T',
                'u' => 'U',
                'v' => 'V',
                'w' => 'W',
                'x' => 'X',
                'y' => 'Y',
                'z' => 'Z',
                _ => ch
            };
            ucStr += aCh;
        }
        return ucStr;
    }

    /*
     * s = "ABC"; s[0] = "A"
     * sreversed = ""; sreversed += "A"; sreversed += "B" // "AB"
     */
    public static string Reverse(string str) {
        //var revStr = string.Empty; // ""
        //for(int idx = str.Length - 1; idx >= 0; idx--) {
        //    revStr += str[idx];
        //}
        //return revStr;

        var arrStr = str.ToCharArray();
        var arrStr2 = arrStr.Reverse();
        return string.Join("", arrStr2);
    }

}
