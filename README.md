# BinaryTrees
### Features ###
This repository is meant to be for practice with the Binary Tree data structure. It contains a main class called 
BinaryTree which can be used to instantiate different types of binary trees. Right now, the repo contains just a BinarySearchTree
class which contains functions insert(), getHeight(), findMin(), findMax() levelOrder(), totalSum(), leafCount(), treeSize(),
 searchData(), and sort(). 
 ### How to use it ###
 After using cloning the repository, run the BinaryTree class and follow the console instructions. The console will build a binary tree by 
 inserting the nodes in the order in which the user enters them. Then the program will print information about the tree
 found using the funcitons of the BinarySearchTree class.
 ### In Development ###
 In the future, I plan to add more types of Binary Tree's that can be used in the main BinaryTree class.
### Example Output ### 
Enter node data in the following format: node1,node2,node3,node4,etc.
 
The tree will be built in the order that the node data is entered.

Enter here: 5,8,6,7,2,4,3

Tree size: 7

Height: 3

Level Order: [5,0][2,4][8,1][4,5][6,2][3,6][7,3]

Total Sum: 35

Leaf Count: 2

Key from searchData(): 0

Min, Max: 2, 8

Data Sorted: 2 3 4 5 6 7 8 
