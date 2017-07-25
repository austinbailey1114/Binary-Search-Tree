using System;
using System.IO;

class BinaryTree
{

	int data;
	BinaryTree left;
	BinaryTree right;

	public void insert(int data)
	{
		if (data < this.data)
		{
			if (this.left == null)
			{
				BinaryTree newTree = new BinaryTree();
				newTree.data = data;
				this.left = newTree;
				return;
			}
			else this.left.insert(data);
		}
		else if (data > this.data)
		{
			if (this.right == null)
			{
				BinaryTree newTree = new BinaryTree();
				newTree.data = data;
				this.right = newTree;
				return;
			}
			else this.right.insert(data);
		}
	}

	public void levelOrder()
	{
		Console.WriteLine("hi emaad");
		Console.WriteLine("test");
	}
	static void Main(String[] args)
	{
		Console.WriteLine("Enter nodes in the following format: node1,node2,node3,node4");
		string[] nodeData = Console.ReadLine().Split(',');
		BinaryTree head = new BinaryTree();
		for (int i = 0; i < nodeData.Length; i++)
		{
			head.insert(Convert.ToInt32(nodeData[i]));
		}
		head.levelOrder();

	}
}