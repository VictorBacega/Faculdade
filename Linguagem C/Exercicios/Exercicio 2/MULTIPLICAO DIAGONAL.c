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
    int linha,coluna, diagonal, diagonalSuperior, diagonalInferior;

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

  printf("\nDigite o valor da multiplicação da Diagonal:\n ");
  scanf("%i", &diagonal);
  printf("\nDigite o valor da multiplicação Superior:\n ");
  scanf("%i", &diagonalSuperior);
  printf("\nDigite o valor da multiplicação Inferior:\n ");
  scanf("%i", &diagonalInferior);

  printf("MULTIPLICAÇÃO DA MATRIZ\n");

for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          if( linha < coluna)
          {
              matriz1[linha][coluna] = matriz1[linha][coluna] * diagonalSuperior;

              printf("%i \t", matriz1[linha][coluna]);
          }
          else if (linha > coluna)
          {
              matriz1[linha][coluna] = matriz1[linha][coluna] * diagonalInferior;

              printf("%i \t", matriz1[linha][coluna]);
          }
          else
          {
              matriz1[linha][coluna] = matriz1[linha][coluna] * diagonal;
              printf("%i \t", matriz1[linha][coluna]);
          }
      }
      printf("\n");
  }







  printf("\n");
  system("pause");


}
