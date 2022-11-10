#include <bits/stdc++.h>
using namespace std;

#define MAX 100

struct Stack {
	char a[MAX];
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

int push(Stack &S, char x) {
	if (isFull(S))
		return 0;
	else {
		S.top++;
		S.a[S.top] = x;
		return 1;
	}
}

int pop(Stack &S, char &x) {
	if (isEmpty(S))
		return 0;
	else {
		x = S.a[S.top];
		S.top--;
		return 1;
	}
}

void check(Stack S, char *s, int count) {
	createStack(S);
	int mark = 1;
	for (int i = 0; i <= count; i++) {
		if (s[i] == '(' && push(S, s[i])) {
			mark = 1;
		}
		else if (s[i] == ')') {
			if (pop(S, s[i]))
				mark = 1;
			else {
				mark = 0;
				break;
			}	
		}
	}
	int mark2 = 0;
	if (isEmpty(S))
		mark2 = 1;
	if (mark2 == 1 && mark == 1)
		cout << "\nDay ngoac hop le";
	else {
		cout << "\nDay ngoac ko hop le";
	}
}

int main() {
	char s[MAX];
	fflush(stdin);
	gets(s);
	int count = 0;
	while (true) {
		if (s[count] == '(' || s[count] == ')')
			count++;
		else
			break;
	}
	for (int i = 0; i <= count; i++)
		cout << s[i];
		
	check(S, s, count);
	return 0;
}

