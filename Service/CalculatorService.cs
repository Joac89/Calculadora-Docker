using System;
using System.Collections.Generic;

public class CalculatorService
{
    public ResponseBase<decimal> Execution { get; set; }

    public CalculatorService()
    {
        Execution = new ResponseBase<decimal>()
        {
            Code = 200
        };
    }

    public ResponseBase<decimal> Addition(string numbers)
    {
        var result = new ResponseBase<decimal>();
        var sum = Calculate(numbers, Operations.ADD);

        result.Code = Execution.Code;
        result.Data = sum;
        result.Message = "Addition::" + Execution.Message;

        return result;
    }
    public ResponseBase<decimal> Substraction(string numbers)
    {
        var result = new ResponseBase<decimal>();
        var subs = Calculate(numbers, Operations.SUBS);

        result.Code = Execution.Code;
        result.Data = subs;
        result.Message = "Substraction::" + Execution.Message;

        return result;
    }
    public ResponseBase<decimal> Multiplication(string numbers)
    {
        var result = new ResponseBase<decimal>();
        var mult = Calculate(numbers, Operations.MULT);

        result.Code = Execution.Code;
        result.Data = mult;
        result.Message = "Multiplication::" + Execution.Message;

        return result;
    }

    public ResponseBase<decimal> Division(string numbers)
    {
        var result = new ResponseBase<decimal>();
        var div = Calculate(numbers, Operations.DIV);

        result.Code = Execution.Code;
        result.Data = div;
        result.Message = "Division::" + Execution.Message;

        return result;
    }

    private enum Operations
    {
        ADD = 1,
        SUBS = 2,
        MULT = 3,
        DIV = 4
    }
    private decimal Calculate(string nums, Operations operation)
    {
        var value = 0M;
        var numbers = new List<decimal>();

        if (!string.IsNullOrWhiteSpace(nums))
        {
            numbers = Transform(nums);
            switch (operation)
            {
                case Operations.ADD:
                    {
                        foreach (var i in numbers) value = value + i;
                        break;
                    }
                case Operations.SUBS:
                    {
                        foreach (var i in numbers) value = value - i;
                        break;
                    }
                case Operations.MULT:
                    value = 1;
                    {
                        foreach (var i in numbers) value = value * i;
                        break;
                    }
                case Operations.DIV:
                    value = 1;
                    {
                        value = ValidateDivision(numbers);
                        break;
                    }
            }
        }
        else
        {
            Execution.Code = 404;
            Execution.Message = "Parameters is empty";
        }

        return value;
    }

    private List<decimal> Transform(string numbers)
    {
        var splitter = numbers.Split('/');
        var result = new List<decimal>();

        for (var i = 0; i < splitter.Length; ++i)
        {
            var isEmpty = string.IsNullOrWhiteSpace(splitter[i].ToString());
            var isNumber = decimal.TryParse(splitter[i], out decimal n);

            if (!isEmpty && isNumber) result.Add(Convert.ToDecimal(splitter[i]));
        }

        return result;
    }

    private decimal ValidateDivision(List<decimal> numbers)
    {
        var value = 0M;

        foreach (var i in numbers)
        {
            try
            {
                value = value / i;
            }
            catch (DivideByZeroException ex)
            {
                Execution.Code = 500;
                Execution.Message = ex.Message;
                value = 0;

                break;
            }
        }

        return value;
    }
}