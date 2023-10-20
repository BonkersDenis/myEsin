using System.Collections.Generic;

namespace myEsin
{
    public class Graph
    {
        private bool _directed;
        private Dictionary<string, List<(string, int)>> _adjacencyList;
        
        // Конструкторы
        public Graph(bool directed = false)
        {
            _directed = directed;
            _adjacencyList = new Dictionary<string, List<(string, int)>>();
        }

        public Graph(string fileName)
        {
            //LoadFromFile(fileName);
        }

        public Graph(Graph other)
        {
            _directed = other._directed;
            _adjacencyList = new Dictionary<string, List<(string, int)>>(other._adjacencyList);
        }

        // Методы

    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
