#include<bits/stdc++.h>
#include<conio.h>
using namespace std;
#define max 100

struct Queue {
	int front, rear;
	char E[max];
};

void Create(Queue &Q) {
	Q.front = 0;
	Q.rear = -1;
}

int Empty(Queue Q) {
	return Q.rear == -1;
}

int Full(Queue Q) {
	return Q.rear == max-1;
}

void Add(Queue &Q, char x) {
	if(Full(Q))
		cout << "\nHang doi da day.\n";
	else {
		Q.rear++;
		Q.E[Q.rear] = x;
	}
}

void pop(Queue &Q, char &x) {
	if (!Empty(Q)) {
		x = Q.E[Q.front];
		Q.front++;
	}
}

void Nhap_chuoi(Queue &Q) {
	Create(Q);
	char x, c;
	cout << "Nhap lan luot tung ki tu(An ESC de ket thuc): \n";
	do {
		fflush(stdin);
		cin >> x;
		Add(Q, x);
		c = getch();
	} while(c != 27);
}

void Xuat_chuoi(Queue Q) {
	if(!Empty(Q)) {
		for(int i = Q.front; i <= Q.rear; i++)
			cout << Q.E[i];
	}
}

void Delete(Queue &Q, int k) {
	k = Q.front + k;
	Queue Q1;
	Create(Q1);
	while (true) {
		if (Q.front == k - 1) {
			pop(Q, Q.E[Q.front]);
			break;
		}
		Add(Q1, Q.E[Q.front]);
		Q.front++;
	}
	while (true) {
		if (Q.front > Q.rear)
			break;
		Add(Q1, Q.E[Q.front]);
		Q.front++;
	}
	Create(Q);
	while (true) {
		if (Q1.front > Q1.rear)
			break;
		Add(Q, Q1.E[Q1.front]);
		Q1.front++;
	}
	cout << endl;
	Xuat_chuoi(Q);
}

void Delete(Queue &Q) {
	Q.front++;
}

int main()
{
	Queue Q;
	Nhap_chuoi(Q);
	cout << "Chuoi da nhap: ";
	Xuat_chuoi(Q);
	
	Delete(Q);
	Delete(Q);
	cout << endl;
	Xuat_chuoi(Q);
	Delete(Q, 5);
	return 0;
}

