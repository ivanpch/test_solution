﻿namespace Calculator;

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Substract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }

    public int Divide(int x, int y)
    {
        if (y == 0)
        {
            throw new ArgumentException($"{nameof(y)} can not be 0");
        }

        return x / y;
    }
}