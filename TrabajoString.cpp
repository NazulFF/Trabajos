#include<stdlib.h>
#include <string>
#include <string.h>
#include<iostream>
#include<conio.h>

using namespace std;
	
int main(){
	
	string cadena,token;
	int lon=0;
	
	getline(cin,cadena);
	string delimita="/";
	size_t pos=0;
	while((pos=cadena.find(delimita))!= string::npos)
	{
		token=cadena.substr(0,pos);
		cout<<token<<endl;
		cadena.erase(0,pos+delimita.length());
	}
	string ncadena=cadena;
	lon=strlen(ncadena*_str);
	
	cout<<cadena;
	cout<<ncadena;
	return 0;
}
