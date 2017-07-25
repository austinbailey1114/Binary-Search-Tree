using System;
using System.IO;
using System.Collections;

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

	public int getHeight()
	{
		if (this.left == null && this.right == null)
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
		if (this.left == null && this.right == null)
		{
			return Convert.ToString(this.data);
		}
		Queue aQ = new Queue();
		String s = "";
		aQ.Enqueue(this);
		int length = this.getHeight();
		while (aQ.Count > 0)
		{
			length = aQ.Count;
			while (length > 0)
			{
				BinaryTree temp = (BinaryTree)aQ.Dequeue();
				s += temp.data + " ";
				if (temp.left != null) aQ.Enqueue(temp.left);
				if (temp.right != null) aQ.Enqueue(temp.right);
				length--;
			}
		}
		s = s.Substring(2);
		return s;
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
		Console.WriteLine(head.getHeight());
		Console.WriteLine(head.levelOrder());

	}
}