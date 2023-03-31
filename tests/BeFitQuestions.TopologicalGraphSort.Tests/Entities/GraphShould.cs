using System.Collections;
using BeFitQuestions.TopologicalGraphSort.Entities;
using BeFitQuestions.TopologicalGraphSort.Exceptions;
using BeFitQuestions.TopologicalGraphSort.Tests.TestCases;
using Xunit;

namespace BeFitQuestions.TopologicalGraphSort.Tests.Entities;

public class GraphShould
{

    [Theory]
    [ClassData(typeof(GraphNotQuarterArrTestCases))]
    public void CreateGraph_WithNotSquareMatrix_ThrowsMatrixNotSquareException(double[,] testCaseData)
    {
        // Arrange

        // Act

        // Assert
        Assert.Throws<MatrixNotSquareException>(() => Graph.Create(testCaseData));
    }


    [Theory]
    [ClassData(typeof(GraphCorrectArrayTestCases))]
    public void CreateGraph_WithCorrectMatrix_SuccessResultHitInTheResultsList(double[,] testCaseData, List<int>[] expectedDataArr)
    {
        // Arrange
        var sut = Graph.Create(testCaseData);

        // Act
        var actualResult = sut.TopologicalSort();

        // Assert
        Assert.True(actualResult.Intersect(expectedDataArr[0]).Any() ||
                    actualResult.Intersect(expectedDataArr[1]).Any());
    }



}