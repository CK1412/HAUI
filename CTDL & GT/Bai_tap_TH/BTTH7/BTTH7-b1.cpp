#include <bits/stdc++.h>
using namespace std;

#define MAX 100

char s[] = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

struct Stack {
	int a[MAX];
	int top;
};

Stack S;

void createStack(Stack &S) {
	S.top = -1;
}

bool isEmpty(Stack S) {
	return (S.top == -1);
}

bool isFull(Stack S) {
	return (S.top == MAX - 1);
}

int push(Stack &S, int x) {
	if (isFull(S))
		return 0;
	else {
		S.top++;
		S.a[S.top] = x;
		return 1;
	}
}

int pop(Stack &S, int &x) {
	if (isEmpty(S))
		return 0;
	else {
		x = S.a[S.top];
		S.top--;
		return 1;
	}
}

void change(Stack &S, int n, int k) {
	createStack(S);
	while (n > 0 && push(S, n % k))
		n = n / k;
}

void show(Stack S) {
	int b[MAX];
	int count = 0;
	while (pop(S, b[count])) {
		cout << s[b[count]];
		count++;
	}
}

int main() {
	int n;
	cout << "n = ";
	cin >> n;
	int k;
	cout << "Chuyen sang he: ";
	cin >> k;
	change(S, n, k);
	show(S);
	return 0;
}

