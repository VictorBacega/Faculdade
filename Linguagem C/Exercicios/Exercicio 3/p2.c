#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>
#define S 30
/// VICTOR BACEGA FARIA
main(void)
{
  setlocale(LC_ALL, "portuguese");

    char string[S], string2[S];
    int i,tamanho;

    printf("Digite a palavra 1:\n");
    gets(string);

    printf("Digite a palavra 2:\n");
    gets(string2);

    fflush(stdin);

    printf("Palavra1: %s\nPalavra2: %s\n",string,string2);

    for(i=0;i<S;i++)
    {
       if(string[i]=='\0')
       {
           tamanho = i;
       }
    }

    for(i=0;i<tamanho+1;i++)
    {
        string2[i]= string[i];
    }

    printf("A palavra 1 foi copiada para a palavra 2:\n Palavra1: %s \n Palavra2: %s",string,string2);

  printf("\n");
  system("pause");


}
