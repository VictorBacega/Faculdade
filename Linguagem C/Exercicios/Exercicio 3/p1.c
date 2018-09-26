#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>

///VICTOR BACEGA FARIA
main(void)
{
  setlocale(LC_ALL, "portuguese");

   char palavraCripto[100];
    int i, Chave, tamanho;



    printf("Digite A palava Cripitografada:\n");
    gets(palavraCripto);

    printf("\nInsira o numero para decodificar:\n");
    scanf("%i",&Chave);

    tamanho = strlen(palavraCripto);


    for(i=0;i<tamanho;i++)
    {
        palavraCripto[i]=palavraCripto[i]-Chave;
    }

    printf("\nA palavra Cripitografada eh: %s",palavraCripto);




  printf("\n");
  system("pause");


}
