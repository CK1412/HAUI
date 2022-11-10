#include<bits/stdc++.h>
using namespace std;

struct Node {
	int infor;
	Node* next;
};
struct Queue {
	Node* front;
	Node* rear;	
};
int Empty(Queue Q) {
	return Q.rear == NULL;
}
void Add(Queue &Q, int x) {
	Node* P = new Node;
	P->infor = x;
	P->next = NULL;
	if(Empty(Q)) {
		Q.front = P;
		Q.rear = P;
	}
	else {
		Q.rear->next = P;
		Q.rear = P;
	}
}
void Create(Queue &Q) {
	Q.front = NULL;
	Q.rear = NULL;
}
void Xuat(Queue Q) {
	if(Empty(Q))
		cout << "\nHang doi rong.\n";
	else {
		Node* L = Q.front;
		while(L != NULL) {
			cout << " " << L->infor;
			L = L->next;
		}
		cout << endl;
	}
}
void Lap(Queue &Q, int n) {
	do {
		Node* x = Q.front;
		Q.front = Q.front->next;
		Add(Q, x->infor);
		Add(Q, x->infor);
		n--;
	} while(n != 1);
}
int main()
{
	Queue Q;
	Create(Q);
	for(int i = 1; i <= 5; i++)
		Add(Q, i);
	cout << "Hang doi ban dau: ";	
	Xuat(Q);
	
	Lap(Q, 5);
	cout << "Hang doi sau 5 lan lap: ";
	Xuat(Q);
	cout << "So dau tien sau 5 lan lap: " << Q.front->infor << endl;
	return 0;
}

