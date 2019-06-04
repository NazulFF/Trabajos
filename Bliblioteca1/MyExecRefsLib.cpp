#include<iostream>
#include<conio.h>
#include<stdio.h>
/***********************************************
     Universidad Politécnica de Tulancingo
Ingeniería en electrónica y telecomunicaciones
          Programación de Perifericos
              Felix Franco Nazul
              Matricula: 1830770
************************************************
        	  Libreria estatica
***********************************************/

#include "MathFuncsLib.h"

using namespace std;

int main()
{
    double a = 5.5;
    int b = 99;

    cout << "a + b = " <<
        MathFuncs::MyMathFuncs::Add(a,b) << endl;
    cout << "a - b = " <<
        MathFuncs::MyMathFuncs::Subtract(a,b) << endl;
    cout << "a * b = " <<
        MathFuncs::MyMathFuncs::Multiply(a,b) << endl;
    cout << "a / b = " <<
        MathFuncs::MyMathFuncs::Divide(a,b) << endl;

    return 0;
}
