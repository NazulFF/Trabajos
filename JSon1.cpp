#include<Windows.h>
#include<nlohmann/json.hpp>
#include<iostream>

using namespace std;

using json=lohmann::json

{
	json j;
	j["Pi"]=3.1416;
	j["Feliz"]=true;
	j["Nombre"]="Nazul";
	j["Vacio"]=nullptr;
 
	j["Nuevo"]["valor"]=25;
	j["Lista"]={1, 0, 3};
	j["Lnuevo"]["lista"]={0, 1, 2, 3,};
	j["Objeto"]={{"Moneda", "USD"}{"Valor", 18.91}};

	cout<<j<<endl;

	{
		json j2={{"Pi",3.1416}{"Feliz",true}{"Nombre","Nazul"}{"Vacio",nullptr}{"Nuevo",{"valor",25}}{"Lista",{1,0,3}}
		{"Nuevo",{"Olista",{0,1,2,3}}}{"Objeto",{"Moneda",{"USD",{"Valor",18.81}}}}};
		cout<<j2<<endl;
	}
}