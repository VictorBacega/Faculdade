#include <locale.h>
#include <stdlib.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

  int contadorP = 0;
  int contadorN = 0;
  int valor[100];
  int v;
  int positivo[100];
  int maior = 0;
  int p = 0;
  int negativo[100];
  int menor;
  int n = 0;


  for (v = 0;v < 100;v++)
  {

      printf("Digite um Numero:");
      scanf("%i", &valor[v]);

      if(valor[v] > 0)
      {
          contadorP++;
          positivo[p] = valor[v];
          if(positivo[p] >= maior)
          {
              maior = positivo[p];
          }
          p++;
      }
      else
      {
          contadorN++;
          negativo[n] = valor[v];
          if(negativo[n] <= menor)
          {
              menor = negativo[n];
          }
          n++;
      }

  }



  printf("\nA Quantidade de Numeros Positivos é: %i", contadorP);
  printf("\nA Quantidade de Numeros Negativos é: %i", contadorN);


  printf("\nO maior numero  é: %i", maior);
  printf("\nO menor numero  é: %i", menor);








  printf("\n");
  system("pause");


}
