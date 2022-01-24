using FluentAssertions;
using Xunit;

namespace Rubiks.Logic.Tests;

public class VectorTests
{
    [Fact]
    public void GivenSingleValueArrayVectorCreatesCorrectValues()
    {
        var input = new[]
        {
            1
        };

        var expected = new[,]
        {
            { 1 }
        };

        var vector = new Vector(input);

        vector.GetVector().Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GivenSingleValueVectorCreatesCorrectValues()
    {
        var expected = new[,]
        {
            { 10 }
        };

        var vector = new Vector(10);

        vector.GetVector().Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GivenMultiValueArrayVectorCreatesCorrectValues()
    {
        var input = new[]
        {
            1,
            2,
            3
        };

        var expected = new[,]
        {
            { 1 },
            { 2 },
            { 3 }
        };

        var vector = new Vector(input);

        vector.GetVector().Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GivenMultipleValuesVectorCreatesCorrectValues()
    {
        var expected = new[,]
        {
            { 10 },
            { 20 },
            { 30 }
        };

        var vector = new Vector(10, 20, 30);

        vector.GetVector().Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GivenSingleValueWhenAddScalarThenAddsToValue()
    {
        var expected = new[,]
        {
            { 6 }
        };

        var vector = new Vector(1);
        vector.Add(5);

        vector.GetVector().Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void GivenMultipleValuesWhenAddScalarThenAddsToValues()
    {
        var expected = new[,]
        {
            { 6 },
            { 7 },
            { 8 }
        };

        var vector = new Vector(1, 2, 3);
        vector.Add(5);

        vector.GetVector().Should().BeEquivalentTo(expected);
    }
}
