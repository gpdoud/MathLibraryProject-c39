﻿namespace MathLib;
public class MathLibrary {

    public static int Add(int a, int b) {
        return a + b;
    }

    public static int Sub(int a, int b) {
        return a - b;
    }

    public static int Mult(int a, int b) {
        return a * b;
    }

    public static int Div(int a, int b) {
        return a / b;
    }

    public static int Mod(int a, int b) {
        return a - (a / b * b);
    }

}
