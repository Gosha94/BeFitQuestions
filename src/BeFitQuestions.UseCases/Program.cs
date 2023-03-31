using BeFitQuestions.TopologicalGraphSort.Entities;

namespace BeFitQuestions.UseCases;

internal class Program
{
    static void Main(string[] args)
    {

        double[,] arr = {
            {0,0,0,1},
            {0,0,0,0},
            {0,1,0,0},
            {0,1,1,0}
        };

        var graph = Graph.Create(arr);

        var list = graph.TopologicalSort();

        foreach (var item in list)
        {
            Console.Write("{0} ", item + 1);
        }
    }
}