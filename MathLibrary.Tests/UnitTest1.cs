
using Xunit;

using MathLibrary;

namespace MathLibrary.Tests;

/// <summary>



/// </summary>

public class CalculatorTests
{

    [Fact]

    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        int a = 2, b = 3;

        // Act

        int result = Calculator.Multiply(a, b);

        // Assert

        Assert.Equal(6, result);
    }

    [Fact]

    public void Multiply_NumberWithZero_ReturnsZero()
    {




        int a = 0, b = 5;

        //Act

        int result = Calculator.Multiply(a, b);

        // Assert

        Assert.Equal(0, result);

    }

    [Fact]

    public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
    {



        // Arrange

        int a = -2, b = 3;



        int result = Calculator.Multiply(a, b);

        // Assert

        Assert.Equal(-6, result);
    }

    [Fact]

    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {

        // Arrange

        int a = -2, b = -3;

        int result = Calculator.Multiply(a, b);

        // Assert

        Assert.Equal(6, result);
    }
  
    }

