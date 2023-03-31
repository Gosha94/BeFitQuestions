using System.Collections;

namespace BeFitQuestions.TopologicalGraphSort.Tests.TestCases;

internal class GraphCorrectArrayTestCases : IEnumerable<object[]>
{
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return GetCorrectArray_WithOneResult();
        yield return GetCorrectArray_WithTwoResults();
    }

    static object[] GetCorrectArray_WithOneResult()
    {

        var testCases = new double[,]
        {
            { 0, 1, 1, 0, 1 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };

        var expectedDataList = new List<List<int>>
        {
            new List<int> {4, 1, 5, 2, 3}
        };

        return new object[] { testCases, expectedDataList };
    }

    static object[] GetCorrectArray_WithTwoResults()
    {

        var testCases = new double[,]
        {
            { 0, 0, 0, 0 },
            { 1, 0, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 1, 0, 0 }
        };

        var expectedDataList = new List<List<int>>
        {
            new() { 4, 3, 2, 1 },
            new() { 3, 4, 2, 1 }
        };

        return new object[] { testCases, expectedDataList };
    }
}