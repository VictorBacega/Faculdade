#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>
#define MAX 500

///VICTOR BACEGA FARIA
main(void)
{
  setlocale(LC_ALL, "portuguese");

  char censuras[20],censuras2[20],censuras3[20], texto[MAX], texto2[MAX];

    int r, t;
    int i=0, j=1, l=0;

    printf("Digite o Texto: \n");
    gets(texto);

    fflush(stdin);

    printf("Digite a %iª Palavra que Será Censurada: ",i+1);
    gets(censuras);

    printf("Digite a %iª Palavra que Será Censurada: ",i+2);
    gets(censuras2);

    printf("Digite a %iª Palavra que Será Censurada: ",i+3);
    gets(censuras3);

    system("cls");

    printf("Texto Original:\n");
    puts(texto);

    r = strstr(texto, censuras);
    t = strlen(censuras);

    for(i=0; i<MAX; i++)
    {
        texto2[i]=texto[i];
    }
    fflush(stdin);

    for(i=0; i<MAX; i++)
    {
        if(texto[i]==censuras[0] || texto[i]==censuras2[0] || texto[i]==censuras3[0])
        {
            l=i+1;
            while(texto[l]==censuras[j] || texto[l]==censuras2[j] || texto[l]==censuras3[j])
            {
                texto2[l-1]='*';
                texto2[l]='*';
                texto2[l+1]=' ';
                j++;
                l++;
                i=l;
            }
            i++;
            j=1;
        }
        else
        {
            texto2[i]=texto[i];
        }

    }
    printf("\nTexto Corrigido: \n");
    puts(texto2);






  printf("\n");
  system("pause");


}
