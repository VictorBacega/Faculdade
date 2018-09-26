#include <locale.h>
#include <stdlib.h>
#include <string.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

    char CNPJ[19];
    int tamanho = 0, posicao;


    do{
        do{
    printf("\nPor favor Digite o CNPJ(XX.XXX.XXX/000Y-ZZ): ");
    gets(CNPJ);
    tamanho = strlen(CNPJ);
    printf("\nSTRLEN: %i", tamanho);
        }
        while(tamanho != 18);
    }
    while(CNPJ[3] != '.' && CNPJ[7] != '.' && CNPJ[11] != '/' && CNPJ[12] != '0' && CNPJ[13] != '0' && CNPJ[14] != '0');
    printf("\nCNPJ DIGITADO CORRETAMENTE %s", CNPJ);



  printf("\n");
  system("pause");


}
