#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

    char frase[50];
    int i;
    printf("Escreva uma frase: ");
    gets(frase);

    for(i = 0; frase[i] != '\0'; i++)
    {
        printf("\n%c", frase[i]);
    }

  printf("\n");
  system("pause");


}
