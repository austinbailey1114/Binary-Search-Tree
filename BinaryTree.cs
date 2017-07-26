using System;
using System.IO;
using System.Collections;

class BinaryTree
{

	int data;
	BinaryTree left;
	BinaryTree right;

	public bool isLeaf()
	{
		if (this.left == null && this.right == null) return true;
		return false;
	}

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

	public int getHeight()
	{
		/* returns the maximum height of the binary search tree */
		if (this.isLeaf())
		{
			return 0;
		}
		else if (this.left != null && this.right == null)
		{
			return 1 + this.left.getHeight();
		}
		else if (this.left == null && this.right != null)
		{
			return 1 + this.right.getHeight();
		}
		else return Math.Max(this.left.getHeight(), this.right.getHeight());

	}

	public String levelOrder()
	{
		/*
		 * Returns a string with nodes printed in level order*/
		if (this.isLeaf())
		{
			return Convert.ToString(this.data);
		}
		Queue aQ = new Queue();
		String s = "";
		aQ.Enqueue(this);
		BinaryTree newTree = new BinaryTree();
		while (aQ.Count > 0)
		{
			newTree = (BinaryTree)aQ.Dequeue();
			s += newTree.data + " ";
			if (newTree.left != null) aQ.Enqueue(newTree.left);
			if (newTree.right != null) aQ.Enqueue(newTree.right);
		}
		s = s.Substring(2);
		return s;
	}
	public int totalSum()
	{
		/* returns the sum of all node data in the tree */
		if (this.isLeaf())
		{
			return this.data;
		}
		else if (this.left != null && this.right == null)
		{
			return this.data + this.left.totalSum();
		}
		else if (this.left == null && this.right != null)
		{
			return this.data + this.right.totalSum();
		}
		else return this.data + this.left.totalSum() + this.right.totalSum();
	}
	public int leafCount()
	{
		if (isLeaf())
		{
			return 1;
		}
		else if (this.left != null && this.right == null)
		{
			return 0 + this.left.leafCount();
		}
		else if (this.left == null && this.right != null)
		{
			return 0 + this.right.leafCount();
		}
		else return 0 + this.left.leafCount() + this.right.leafCount();
	}
	public int treeSize()
	{
		if (isLeaf())
		{
			return 1;
		}
		else if (this.left != null && this.right == null)
		{
			return 1 + this.left.treeSize();
		}
		else if (this.left == null && this.right != null)
		{
			return 1 + this.right.treeSize();
		}
		else return 1 + this.left.treeSize() + this.right.treeSize();
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
		Console.WriteLine();
		Console.WriteLine("Tree size: " + head.treeSize());
		Console.WriteLine("Height: " + head.getHeight());
		Console.WriteLine("Level Order: " + head.levelOrder());
		Console.WriteLine("Total Sum: " + head.totalSum());
		Console.WriteLine("Leaf Count: " + head.leafCount());


	}
}