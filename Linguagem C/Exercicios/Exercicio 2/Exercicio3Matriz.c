#include <locale.h>
#include <stdlib.h>
#include <string.h>
#include <stdio.h>

#define L 3
#define C 3

main(void)
{
  setlocale(LC_ALL, "portuguese");

  int matriz1[L][C], matriz2[L][C], matriz3[L][C], linha, coluna;

  printf("\nMATRIZ 1");
  for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          printf("\nColoque o valor da Posição [%i] [%i]: ", linha,coluna);
          scanf("%i", &matriz1[linha][coluna]);
      }
  }
  printf("\nMATRIZ 2");
  for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          printf("\nColoque o valor da Posição [%i] [%i]: ", linha,coluna);
          scanf("%i", &matriz2[linha][coluna]);
      }
  }
  for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          matriz3[linha][coluna] = matriz1[linha][coluna] * matriz2[linha][coluna];
      }
  }


  printf("\nIMPRESSÃO DAS MATRIZES");
  printf("\nMATRIZ 1\n");
  for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          printf("%i \t", matriz1[linha][coluna]);
      }
      printf("\n");
  }
  printf("\nMATRIZ 2\n");
  for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          printf("%i \t", matriz2[linha][coluna]);
      }
      printf("\n");
  }
  printf("\nMATRIZ 3\n");
  for(linha = 0; linha < L; linha++ )
  {
      for(coluna = 0; coluna < C; coluna++)
      {
          printf("%i \t", matriz3[linha][coluna]);
      }
      printf("\n");
  }








  printf("\n");
  system("pause");


}
