using System;
using System.IO;
using System.Collections;

class BinaryTree {

	
	static void Main(String[] args) {
		Console.WriteLine("Enter nodes in the following format: node1,node2,node3,node4");
		string[] nodeData = Console.ReadLine().Split(',');
		BinarySearchTree head = new BinarySearchTree();
		head.data = Convert.ToInt32(nodeData[0]);
		head.key = 0;
		for (int i = 1; i < nodeData.Length; i++) {
			head.insert(Convert.ToInt32(nodeData[i]), i);
		}
		Console.WriteLine();
		Console.WriteLine("Tree size: " + head.treeSize());
		Console.WriteLine("Height: " + head.getHeight());
		Console.WriteLine("Level Order: " + head.levelOrder());
		Console.WriteLine("Total Sum: " + head.totalSum());
		Console.WriteLine("Leaf Count: " + head.leafCount());
		Console.WriteLine("Key from searchData(): " + head.searchData(5).key);
		Console.WriteLine("Min, Max: " + head.findMin() + ", " + head.findMax());
		string s = "";
		ArrayList sorted = head.sort();
		for (int i = 0; i < sorted.Count; i++) {
			s += sorted[i] + " ";
		}
		Console.WriteLine("Data Sorted: " + s);

	}
}