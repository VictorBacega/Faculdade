#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

    char letra[100];
    char palavra[100];
    char resposta;


    printf("Por favor insira uma letra\n");
    gets(letra);


    do
    {
        printf("\nAgora coloque uma palavra que comece com a Letra insirida.\n");
        gets(palavra);
        resposta = strstr(palavra, letra);
        if(resposta == NULL)
        {
            printf("\nERROU!");

        }
        else
        {
            printf("ACERTOU");

        }

    }
    while(resposta == NULL);






  printf("\n");
  system("pause");


}
