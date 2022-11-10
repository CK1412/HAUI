#include <bits/stdc++.h>
using namespace std;

#define MAX 100

struct Stack {
	int a[MAX];
	int top;
};

Stack S;

void create(Stack &S) {
	S.top = -1;
}

bool isEmpty(Stack S) {
	return S.top == -1;
}

bool isFull(Stack S) {
	return S.top == MAX - 1;
}

void push(Stack &S, int x) {
	if (!isFull(S)) {
		S.top++;
		S.a[S.top] = x;
	}
}

void pop(Stack &S, int &x) {
	if (!isEmpty(S)) {
		x = S.a[S.top];
		S.top--;
	}
}

void nhapS(Stack &S, int n) {
	create(S);
	if (isFull(S))
		cout << "\nNgan xep da day";
	else {
		while (S.top < n - 1) {
			S.top++;
			cin >> S.a[S.top];
		}
	}
}

void show(Stack S) {
	while (S.top != -1) {
		cout << S.a[S.top] << " ";
		S.top--;
	}
}

void xoaPTT2(Stack &S) {
	Stack S1;
	create(S1);
	while (true) {
		if (S.top == 1) {
			pop(S, S.a[S.top]);
			break;
		}
		push(S1, S.a[S.top]);
		S.top--;
	}
	while (S1.top > -1) {
		push(S, S1.a[S1.top]);
		pop(S1, S1.a[S1.top]);
	}
	cout << endl;
	show(S);
}

void sapXep(Stack &S) {
	Stack SLe, SChan;
	create(SLe);
	create(SChan);
	while (S.top > -1) {
		if (S.a[S.top] % 2 == 0) {
			push(SChan, S.a[S.top]);
			pop(S, S.a[S.top]);
		}
		else {
			push(SLe, S.a[S.top]);
			pop(S, S.a[S.top]);
		}
	}
	while (SLe.top > -1) {
		push(S, SLe.a[SLe.top]);
		pop(SLe, SLe.a[SLe.top]);
	}
	while (SChan.top > -1) {
		push(S, SChan.a[SChan.top]);
		pop(SChan, SChan.a[SChan.top]);
	}
	cout << endl;
	show(S);
}

int main() {
	int n;
	cout << "n = ";
	cin >> n;
	nhapS(S, n);
	show(S);
	xoaPTT2(S);
	sapXep(S);
	return 0;
}

