using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtMethods;
internal static class MyExtensionMethods {

    public static bool And(this bool aBool, bool bBool) {
        return aBool && bBool;
    }
    public static bool Or(this bool aBool, bool bBool) {
        return aBool || bBool;
    }
    public static bool Not(this bool aBool) {
        return !aBool;
    }

    /*
     * decimal currency = 123456.78m;
     * currency.ToCurrency();
     */
    public static string ToCurrency(this decimal currency) {
        return $"{currency:C}";
    }

    /*
     * string aStr = "ABC123";
     * aStr.Print();
     */
    public static void Print(this string s) {
        Console.WriteLine(s);
    }

}
