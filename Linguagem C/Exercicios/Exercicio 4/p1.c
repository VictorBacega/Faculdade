#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>
#define AL 3 // ARRAY DE ALUNOS

#define DC 5 // ARRAY DE DISCIPLINAS

///VITOR BACEGA FARIA


main(void)
{
  setlocale(LC_ALL, "portuguese");

  char alunos[AL][50];
  char materia[DC][50];
  float nota[AL+1][DC+1];
  int linha, coluna, contador, existe;

  ///INSIRIR ALUNOS
  for(linha = 0; linha < AL; linha++)
  {
  	printf("Digite o nome do Aluno: ");
  	gets(alunos[linha]);
  }
  ///INSIRIR
  for(linha = 0; linha < DC; linha++)
  {
  	do
  	{
  		existe = 0;
  		fflush(stdin);
  		printf("\nDigite o nome da Disciplina %i: ", linha+1);
  		gets(materia[linha]);

  		for(contador = 0; contador < linha; contador++)
  		{
  			if(strcmp(materia[contador], materia[linha])==0)//ACHOU A DISCIPLINA
  			{
  				existe =1;
			}
		}
		if(existe ==1)
		{
			printf("\nO nome de disciplina [%s] já existe! Digite uma nova.\n", materia[linha]);
		}
	}
	while(existe == 1);
  }

  for(linha = 0; linha < AL; linha++)
  {
  	printf("\nDigite a notas do aluno [%s]: \n", alunos[linha]);

  	for(coluna = 0; coluna < DC; coluna++)
  	{
  	    nota[linha][coluna]=0;
  	    fflush(stdin);
  		printf("Disciplina [%s]: \n", materia[coluna]);
  		fflush(stdin);
  		scanf("%f", &nota[linha][coluna]);


  		nota[linha][DC] += nota[linha][coluna];
  		nota[AL][coluna] += nota[linha][coluna];

	}
  }

  for(linha=0; linha<AL; linha++)
  {
      nota[linha][DC] = (float) (nota[linha][DC]/DC);
  }
  for(coluna=0; coluna<DC; coluna++)
  {
      nota[AL][coluna] = (float) (nota[AL][coluna]/AL);
  }


  //APARTIR DAQUI VOU FAZER SEM O GABARITO PARA TENTAR PROFESSOR
  printf("ALUNOS\t\t\t\t\t\tMEDIA");
  for(linha=0; linha < AL; linha++)
  {
  	printf("\n[%s]\t", alunos[linha]);

  	for(coluna=0; coluna < DC+1; coluna++)
  	{
  		printf("[%.1f]\t", nota[linha][coluna]);
	}
  }
  printf("\n");
  for(coluna=0; coluna < DC; coluna++)
  {
      printf("\t[%.1f]", nota[AL][coluna]);
  }
  printf("\n\n");
  printf("Disciplinas: ");

  for(contador=0; contador < DC; contador++)
  {
      printf("\t[%s]", materia[contador]);
  }





  printf("\n");
  system("pause");


}
