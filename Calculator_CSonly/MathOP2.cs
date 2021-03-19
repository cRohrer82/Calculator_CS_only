/*********************************
 Name:          Christopher Rohrer
 Program name:  Calculator
 Date:          2 June 2019
 Purpose:       Week4 Assignment
*********************************/
using System;

class MathOP2: MathOP
{
    public MathOP2()
    {
        First = 0;
        Second = 0;
        Operation = Convert.ToChar("*");
    }

    public MathOP2(double first, double second, char operation)
    {
        First = first;
        Second = second;
        Operation = operation;
    }

    public override double GetResult()
    {
        // Run 'MathMult' if operation is plus sign, else run 'MathDiv'
        if (Operation == Convert.ToChar("*"))
        {
            return MathMult();
        }
        else
        {
            return MathDiv();
        }
    }
    
    private double MathMult()
    {
        double result;

        // Perform multiplication on user data and return result
        result = First * Second;
        return result;
    }

    private double MathDiv()
    {
        double result;

        // Perform division on user data and return result
        result = First / Second;
        return result;
    }
}
