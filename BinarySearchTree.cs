using System;
using System.IO;
using System.Collections;

class BinarySearchTree {

    public int data;
    public int key;
    BinarySearchTree left;
    BinarySearchTree right;

    public bool isLeaf() {
        if (this.left == null && this.right == null) return true;
        return false;
    }

    public void insert(int data, int key) { 
        if (data < this.data) {
            if (this.left == null)
            {
                BinarySearchTree newTree = new BinarySearchTree();
                newTree.data = data;
                newTree.key = key;
                this.left = newTree;
                return;
            }
            else this.left.insert(data, key);
        }
        else if (data > this.data) {
            if (this.right == null) {
                BinarySearchTree newTree = new BinarySearchTree();
                newTree.data = data;
                newTree.key = key;
                this.right = newTree;
                return;
            }
            else this.right.insert(data, key);
        }

    }

    public int getHeight() {
        /* returns the maximum height of the binary search tree */
        if (this.isLeaf()) {
            return 1;
        }
        else if (this.left != null && this.right == null) {
            return 1 + this.left.getHeight();
        }
        else if (this.left == null && this.right != null) {
            return 1 + this.right.getHeight();
        }
        else return Math.Max(this.left.getHeight(), this.right.getHeight());

    }
    public int findMin() {
        if (this.left == null) return this.data;
        else return this.left.findMin();
    }
    public int findMax() {
        if (this.right == null) return this.data;
        else return this.right.findMax();
    }


    public String levelOrder() {
        /*
         * Returns a string with nodes printed in level order*/
        if (this.isLeaf()) {
            return Convert.ToString(this.data);
        }
        Queue aQ = new Queue();
        String s = "";
        aQ.Enqueue(this);
        BinarySearchTree newTree = new BinarySearchTree();
        while (aQ.Count > 0) {
            newTree = (BinarySearchTree)aQ.Dequeue();
            s += "[" + newTree.data + "," + newTree.key + "]";
            if (newTree.left != null) aQ.Enqueue(newTree.left);
            if (newTree.right != null) aQ.Enqueue(newTree.right);
        }
        //s = s.Substring(2);
        return s;
    }
    public int totalSum() {
        /* returns the sum of all node data in the tree */
        if (this.isLeaf()) {
            return this.data;
        }
        else if (this.left != null && this.right == null) {
            return this.data + this.left.totalSum();
        }
        else if (this.left == null && this.right != null) {
            return this.data + this.right.totalSum();
        }
        else return this.data + this.left.totalSum() + this.right.totalSum();
    }
    public int leafCount() {
        /* returns the number of leaf nodes in the tree */
        if (isLeaf()) {
            return 1;
        }
        else if (this.left != null && this.right == null) {
            return 0 + this.left.leafCount();
        }
        else if (this.left == null && this.right != null) {
            return 0 + this.right.leafCount();
        }
        else return 0 + this.left.leafCount() + this.right.leafCount();
    }
    public int treeSize() {
        /* returns the number of nodes that exist in the tree */
        if (isLeaf()) {
            return 1;
        }
        else if (this.left != null && this.right == null) {
            return 1 + this.left.treeSize();
        }
        else if (this.left == null && this.right != null) {
            return 1 + this.right.treeSize();
        }
        else return 1 + this.left.treeSize() + this.right.treeSize();
    }
    public BinarySearchTree searchData(int data)  {
        /* returns a node with the data value specified */
        if (this.data == data) {
            return this;
        }
        else if (this.data < data) {
            return this.right.searchData(data);
        }
        else  {
            return this.left.searchData(data);
        }
    }
    public void sortHelper(ArrayList list) {
        if (isLeaf()) {
            list.Add(this.data);
            return;
        }
        else if (this.left != null && this.right == null) {
            this.left.sortHelper(list);
            list.Add(this.data);
        }
        else if (this.left == null && this.right != null) {
            list.Add(this.data);
            this.right.sortHelper(list);
        }
        else {
            this.left.sortHelper(list);
            list.Add(this.data);
            this.right.sortHelper(list);
        }

    }

    public ArrayList sort() {
        ArrayList list = new ArrayList();
        this.sortHelper(list);
        return list;
    }

    public void delete(int key) {

    }
}
