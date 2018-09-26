#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>
#define L 3
#define C 3

main(void)
{
  setlocale(LC_ALL, "portuguese");


    int matriz1[L][C];
    int linha,coluna, auxiliar;

    for(linha = 0; linha < L; linha++)
        {
            for(coluna = 0; coluna < C; coluna++)
            {
                printf("\nColoque o valor da posição [%i][%i]:", linha,coluna);
                scanf("%i", &matriz1[linha][coluna]);

            }

        }
    printf("IMPRESSÃO DA MATRIZ\n");
    for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          printf("%i \t", matriz1[linha][coluna]);
      }
      printf("\n");
  }
  printf("INVERSÃO DA MATRIZ\n");

for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          if( linha < coluna)
          {
              auxiliar = matriz1[linha][coluna];
              matriz1[linha][coluna] = matriz1[coluna][linha];
              matriz1[coluna][linha] = auxiliar;

              printf("%i \t", matriz1[linha][coluna]);
          }
          else
          {
              printf("%i \t", matriz1[linha][coluna]);
          }
      }
      printf("\n");
  }







  printf("\n");
  system("pause");


}
