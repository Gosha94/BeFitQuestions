using BeFitQuestions.TopologicalGraphSort.Exceptions;

namespace BeFitQuestions.TopologicalGraphSort.Entities;

public sealed class Graph
{
    private readonly double[,] _vertexArr;
    private readonly int _dimension;

    private Graph(double[,] matrix)
    {
        _vertexArr = matrix;
        _dimension = matrix.GetLength(0);
    }

    public static Graph Create(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new MatrixNotSquareException("Matrix should have square form");
        }
        
        return new(matrix);
    }

    public IList<int> TopologicalSort()
    {
        var result = new Stack<int>();
        var colorVertexArr = new VertexColor[_dimension];
        var pathStack = new Stack<int>();

        for (int i = 0; i < _dimension; i++)
        {

            int vertex = i;
            int saved = i;

            if (pathStack.Count > 0)
            {
                i--;
                vertex = pathStack.Pop();
                saved = vertex;
            }

            if (colorVertexArr[vertex] == VertexColor.Black)
                continue;

            colorVertexArr[vertex] = VertexColor.Grey;
            pathStack.Push(vertex);

            for (int j = 0; j < _dimension; j++)
            {
                if (_vertexArr[vertex, j] != 0 && colorVertexArr[j] != VertexColor.Black)
                {
                    if (colorVertexArr[j] == VertexColor.Grey)
                        return null;

                    vertex = j;
                    pathStack.Push(vertex);
                    break;
                }
            }

            if (vertex == saved)
            {
                colorVertexArr[vertex] = VertexColor.Black;
                result.Push(vertex);
                pathStack.Pop();
            }
        }

        return result.ToList();
    }
}