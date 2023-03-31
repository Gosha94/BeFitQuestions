using System.Collections;

namespace BeFitQuestions.TopologicalGraphSort.Tests.TestCases
{
    internal class GraphNotQuarterArrTestCases : IEnumerable<object[]>
    {
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return GetNotQuarterArray_TwoFour();
            yield return GetNotQuarterArrays_ThreeFour();
        }

        static object[] GetNotQuarterArray_TwoFour()
        {

            var testCases = new double[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 }
            };

            return new object[] { testCases };
        }

        static object[] GetNotQuarterArrays_ThreeFour()
        {

            var testCases = new double[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 0 }
            };

            return new object[] { testCases };
        }
    }
}


