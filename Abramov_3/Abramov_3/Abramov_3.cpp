// Abramov_3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	/*int a;
	int n;


	do
	{
		cout << "Введите число " << endl;
		cin >> a;

		if (a % 2 == 0)
		{
			cout << ("-Это чётное число") << endl;
		}
		else
		{
			cout << ("-Это Нечётное число") << endl;
		}
		cout << "1. Продолжить  " << endl;
		cout << "2-9. Закончить " << endl;
		cin >> n;

	} while (n==1);
	cout << "Пока " << endl;*/

	int a; //неотрицательное целое
	int b; //положительное число
	int r, z; // пользовательские переменные
	int n;
	double sum;
	
	do
	{
		cout << "Введите неотрицательное (a > 0) число " << endl;
		cin >> a;

		cout << "Введите положительное (1-9) число " << endl;
		cin >> b;

		cout << "Введите пользовательские числа r i z" << endl;
		cin >> r >> z;
		sum = a % b;

		if (sum == r && sum == z)
		{
			cout << "Условие задачи выполнено правильно" << endl;
		}
		else
		{
			cout << "Условие задачи выполнено не правильно" << endl;
			cout << "Выберите другие числа" << endl;
		}
		cout << "1. Продолжить  " << endl;
		cout << "2-9. Закончить " << endl;
		cin >> n;
	} while (n==1);
}