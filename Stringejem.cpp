/***********************************************
     Universidad Politécnica de Tulancingo
Ingeniería en electrónica y telecomunicaciones
          Programación de Perifericos
              Felix Franco Nazul
              Matricula: 1830770
************************************************
        		String simple
***********************************************/
#include<conio.h>
#include<iostream>
#include<string>
#include<sstream>
int main(){
    std::string myText("Hola-Buen-Día-¿Como se encuentra?");
    std::istringstream iss(myText);
    std::string token;
    while (std::getline(iss, token, '-'))
    {
        std::cout << token << std::endl;
    }
    return 0;
}
