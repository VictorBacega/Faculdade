#include <locale.h>
#include <stdlib.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

    int caixaSuperRapido[5], caixaRapido[5], caixaNormal[5], carrinho[7];
    int i;
    int CSR = 0;
    int CR = 0;
    int CN = 0;

    for(i=0; i<7; i++)
    {
        printf("\nQuantos produtos tem no carrinho: \n");
        scanf("%i", &carrinho[i]);

        if(carrinho[i] < 6)
        {
            if( CSR < 5)
            {
                caixaSuperRapido[CSR] = carrinho[i];
                CSR++;
            }
            else
            {
                printf("\nCaixa esta Cheio.");
                i--;
            }
        }
        else if((carrinho[i] >=6) && (carrinho[i]<= 20))
        {
            if( CR < 5)
            {
                caixaRapido[CR] = carrinho[i];
                CR++;
            }
            else
            {
                printf("\nCaixa está cheio.");
                i--;
            }
        }
        else if(carrinho[i] > 20)
        {
            if(CN < 5)
            {
                caixaNormal[CN] = carrinho[i];
                CN++;
            }
            else
            {
                printf("\nCaixa está cheio.");
                i--;
            }
        }
    }
    printf("\nQuantidade de Produtos no caixa Super Rapido: ");
    for(i = 0; i < CSR; i++)
    {
        printf("\n%i", caixaSuperRapido[i]);
    }
    printf("\nQuantidade de Produtos no caixa Rapido: ");
    for(i = 0; i < CR; i++)
    {
        printf("\n%i", caixaRapido[i]);
    }
    printf("\nQuantidade de Produtos no caixa Normal: ");
    for(i = 0; i < CN; i++)
    {
        printf("\n%i", caixaNormal[i]);
    }







  printf("\n");
  system("pause");


}
