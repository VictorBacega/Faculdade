#include <stdio.h>

#define LINHA 3
#define COLUN 4
#define PROFU 3

main()
{
  int matriz[LINHA][COLUN][PROFU] = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,
                                     19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36};

  int lin, col, pro;

  for(lin = 0; lin < LINHA; lin++)
  {
    for(col = 0; col < COLUN; col++)
    {
      for(pro = 0; pro < PROFU; pro++)
      {
        printf("\nMatriz[%2i][%2i][%2i] =  %2i", lin, col, pro, matriz[lin][col][pro]);
      }
    }
  }

}
