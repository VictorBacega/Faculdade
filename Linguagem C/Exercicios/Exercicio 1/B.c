#include <locale.h>
#include <stdlib.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

    int ap;
    printf("\nQuantos Apartamentos tem no seu condominio: ");
    scanf("%i", &ap);
    ap--;

    int i;
    float valorBruto[ap];
    int vagasNaGaragem[ap];
    float valorLiquido[ap];

    for(i = 0; i <= ap; i++ )
    {
        printf("\nQual o valor do condominio do Apartamento %i: ",i);
        scanf("%f", &valorBruto[i]);
    }
    for(i = 0; i <= ap; i++ )
    {
        do{
        printf("\nQuantas Garagens tem o Apartamento %i: ",i);
        scanf("%i", &vagasNaGaragem[i]);
          }
        while(vagasNaGaragem[i] < 0);
    }
    for(i = 0; i <= ap; i++ )
    {
        if(vagasNaGaragem[i] < 2)
        {
            valorLiquido[i] = valorBruto[i];
        }
        else if((vagasNaGaragem[i] > 1) && (vagasNaGaragem[i] <4))
        {
            valorLiquido[i] = valorBruto[i] + (valorBruto[i]*0.1);
        }
        else if(vagasNaGaragem >= 4)
        {
             valorLiquido[i] = valorBruto[i] + (valorBruto[i]*0.2);
        }
        printf("\nApartamento %i: %.2f", i, valorLiquido[i]);
    }

  printf("\n");
  system("pause");


}
