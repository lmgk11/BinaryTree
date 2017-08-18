#pragma once
#include "node.h"

class BinaryTree
{
	

public:
	Node* root;

	BinaryTree();
	void put(int x);
	bool contains(int x);
	void write();
	void printOut(Node* root);
};

