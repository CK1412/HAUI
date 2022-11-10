#include <bits/stdc++.h>
using namespace std;

#define MAX 100

struct Stack {
	char a[MAX];
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

void push(Stack &S, char x) {
	if (!isFull(S)) {
		S.top++;
		S.a[S.top] = x;
	}
}

void pop(Stack &S, char &x) {
	if (!isEmpty(S)) {
		x = S.a[S.top];
		S.top--;
	}
}

void show(Stack S) {
	while (S.top != -1) {
		cout << S.a[S.top];
		S.top--;
	}
}

void daoNguocChuoi(Stack &S, char *s, int count) {
	create(S);
	for (int i = 0; i < count; i++) {
		push(S, s[i]);
	}
	cout << endl;
	show(S);
}

int main() {
	char s[MAX];
	fflush(stdin);
	gets(s);
	int count = 0;
	while (true) {
		if (s[count] == '\0')
			break;
		count++;
	}
	daoNguocChuoi(S, s, count);
	return 0;
}

