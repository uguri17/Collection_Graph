using System;
using System.Collections.Generic; // Generic: 데이터 타입 일반화 // 컴파일 시에 타입을 지정하여 사용 // List<int>, Dictionary<string, int> 등

namespace Collection_Graph
{
	public class Graph<T>
	{
		private Dictionary<T, List<T>> adjList = new Dictionary<T, List<T>>();

		// 꼭짓점 추가 method()
		public void AddVertex(T vertex)
		{
			if (!adjList.ContainsKey(vertex))
			{
				adjList[vertex] = new List<T>();
			}
		}

		// edge를 추가하는 method(방향그래프_Directed)
		public void AddEdge(T source, T destination) // edge의 시작점, edge의 끝점
		{
			AddVertex(source);
			AddVertex(destination);
			adjList[source].Add(destination);
        }	

		public void PrintGraph()
		{
			foreach (var vertex in adjList)
			{
				Console.WriteLine($"{vertex.Key}");
				foreach (var neighbor in vertex.Value)
				{
					Console.Write($"{neighbor}");
				}
				Console.WriteLine();
			}
		}
    }

	class Program
	{
		static void Main(string[] args) // 정적 메서드 // 객체 생성 없이 호출 가능한 Main method()
		{
			Graph<string> graph = new Graph<string>();

			// graph에 edge 추가
			graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("C", "D");

			Console.WriteLine("그래프의 인접 리스트 출력");
			graph.PrintGraph();
        }
	}
}
