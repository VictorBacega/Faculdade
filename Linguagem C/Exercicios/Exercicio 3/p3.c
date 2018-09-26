#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>
#define S 20

///VICTOR BACEGA FARIA
main(void)
{
  setlocale(LC_ALL, "portuguese");


  char string1[S], string2[S];
  int i, tamanho1, tamanho2, tamanho3;
  fflush(stdin);

  printf("Digite a primeira Palavra:\n");
  gets(string1);
  printf("\nDigite a segunda Palavra:\n");
  gets(string2);

  fflush(stdin);

  for(i = S; i > 0; i--)//STRLEN da String1
  {
      if(string1[i] == '\0')
      {
         tamanho1 = i;
      }
  }
  for(i = S; i > 0; i--)//STRLENG da String2
  {
      if(string2[i] == '\0')
      {
          tamanho2 = i;
      }
  }
  for(i = 0; i < S; i++)//STRCAT
  {
      string1[tamanho1+i] = string2[i];
  }
  fflush(stdin);

  printf("\n O tamanho da Palavra 1 é: %i\n", tamanho1);
  printf("\n O tamanho da Palavra 2 é: %i\n", tamanho2);
  tamanho3 = tamanho1 + tamanho2;

  fflush(stdin);
  if(tamanho3 < S)
  {
      printf("\nO STRCAT é: %s\n", string1);
      printf("\nA palavra 2 é: %s\n", string2);
  }
  else
  {
      printf("\nA variavel não tem espaço suficiente para concatenar as duas variaveis.");
  }


  printf("\n");
  system("pause");


}
