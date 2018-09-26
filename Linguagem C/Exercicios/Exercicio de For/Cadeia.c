#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

    int manos[5], cadeia[5], febem[5];
    int m, c, f, p;

    f = 0;
    c = 0;

    for(m=0;m<=4;m++)
    {
    printf("Insira a idade dos Manos: ");
    scanf("%i", &manos[m]);

    if(manos[m] < 18)
    {

        febem[f] = manos[m];
        f++;
    }
    else
    {

        cadeia[c] = manos[m];
        c++;
    }
    }
    printf("\nIdade dos Manos na Cadeia %i:", c);
    for(p = 0; p <c; p++)
    {
        printf("\n%i", cadeia[p]);
    }
    printf("\nIdade dos Manos na Febem %i:", f);
    for(p = 0; p <f; p++)
    {
        printf("\n%i", febem[p]);
    }



  printf("\n");
  system("pause");


}
