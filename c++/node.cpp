#include "node.h"

Node::Node()
{
	left = nullptr;
	right = nullptr;
}

void Node::setValue(int x) {
	this->value = x;
}
