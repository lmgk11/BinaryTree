#include "binaryTree.h"
#include<iostream>

using namespace std;

static bool exists(Node* root, int x) {
	if (root == nullptr) {
		if (root->value == x)
			return true;
		else if (root->value > x)
			return exists(root->left, x);
		else if (root->value < x)
			return exists(root->right, x);
	}
	return false;
}

static Node* addToTree(Node* root, int x) {
	if (root == nullptr) {
		Node* n = new Node();
		n->setValue(x);
		return n;
	}
	if (exists(root, root->value)) { return root; }
	if (root->value > x) {
		root->left = addToTree(root->left, x);
		return root;
	} if (root->value < x) {
		root->right = addToTree(root->right, x);
		return root;
	}
	return nullptr;
}

BinaryTree::BinaryTree()
{
	this->root = nullptr;
}

void BinaryTree::put(int x) {
	this->root = addToTree(this->root, x);
}

bool BinaryTree::contains(int x) {
	return exists(this->root, x);
}

void BinaryTree::write() {
	printOut(this->root);
}

void BinaryTree::printOut(Node* root) {
	if (root != nullptr) {
		printOut(root->left);
		cout << root->value << endl;
		printOut(root->right);
	}
}

