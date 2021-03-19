/*********************************
 Name:          Christopher Rohrer
 Program name:  Calculator
 Date:          2 June 2019
 Purpose:       Week4 Assignment
*********************************/
using System;

class MathOP
{
    protected double First;
    protected double Second;
    protected char Operation;

    public MathOP()
    {
        First = 0;
        Second = 0;
        Operation = Convert.ToChar("+");
    }

    public MathOP(double first, double second, char operation)
    {
        First = first;
        Second = second;
        Operation = operation;
    }

    public virtual double GetResult()
    {
        // Run 'MathAdd' if operation is plus sign, else run 'MathSub'
        if (Operation == Convert.ToChar("+"))
        {
            return MathAdd();
        }
        else
        {
            return MathSub();
        }
    }

    private double MathAdd()
    {
        double result;

        // Perform addition on user data and return result
        result = First + Second;
        return result;
    }

    private double MathSub()
    {
        double result;

        // Perform subtraction on user data and return result
        result = First - Second;
        return result;
    }
}
