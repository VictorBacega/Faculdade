#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>

#define AL 3
#define PG 5

///VICTOR BACEGA FARIA 3001318

main(void)
{
    setlocale(LC_ALL, "portuguese");

    int contador = 0, verificador = 0, existe = 0, coluna = 0, aluno = 0;

    char gabarito[PG][2];


    struct cartao
    {

        char nome[50];
        char resposta[PG][1];
        int acerto;

    };

    struct cartao alunos[AL];

    for(contador = 0; contador <AL; contador++)
    {
        alunos[contador].acerto = 0;
    }

    /*for (aluno = 0; aluno < AL; aluno++)
    {
       for(contador = 0; contador < PG; contador++)
       {
           alunos[aluno].resposta[contador] = "0";
       }
    }*/


    printf("Insira o gabarito das perguntas:\n");

    for(contador = 0; contador < PG; contador++)
    {


        do
        {
            fflush(stdin);
            printf("Pergunta [%i]: ", contador);
            gabarito[contador][0] = toupper(getchar());

            if ( (gabarito[contador][0] < 65 ) || (gabarito[contador][0] > 69) )
            {
                printf("Entre com uma resposta valida!\n");

                verificador = 1;
            }
            else
            {
                verificador = 0;
            }

        }
        while(verificador == 1);


    }

    for (aluno = 0; aluno < AL; aluno++)
    {
        system("cls");
        printf("\n****CADASTRO DOS ALUNOS****\n");
        printf("Insira o Nome do Aluno: ");
        fflush(stdin);
        gets(alunos[aluno].nome);

        printf("Insira as respostas: ");
        for(coluna = 0; coluna < PG; coluna++)
        {
            do
            {
                fflush(stdin);
                printf("\nPergunta[%i]: ", coluna);
                alunos[aluno].resposta[coluna][0] = toupper(getchar());
                //gets(alunos[aluno].resposta[coluna]);
                ///VERIFICADOR DE VOGAIS///

                if ( (alunos[aluno].resposta[coluna][0] < 65 ) || (alunos[aluno].resposta[coluna][0] > 69) )
                {
                    printf("Entre com uma resposta valida!\n");

                    verificador = 1;
                }
                else
                {
                    verificador = 0;
                }
            }
            while(verificador == 1);
        }

    }

    ///CORREÇÃO///

    for(aluno = 0; aluno < AL; aluno++)
    {
        printf("\nALUNO[%s]:\t", alunos[aluno].nome);
        for(coluna = 0; coluna < PG; coluna++)
        {
            printf("[%c]\t", alunos[aluno].resposta[coluna][0]);
            if(alunos[aluno].resposta[coluna][0] == gabarito[coluna][0])
            {
                alunos[aluno].acerto++;
            }
        }

        printf("Aluno [%s]: [%i]\n", alunos[aluno].nome, alunos[aluno].acerto);
    }

    verificador = alunos[0].acerto;

    for(contador = 0; contador <AL; contador++)
    {
        if(alunos[contador].acerto > verificador)
        {
            verificador = alunos[contador].acerto;
            aluno = contador;
        }
    }

    printf("****O ALUNO COM MAIS ACERTO É****\n");
    printf("*****[%s] COM [%i] ACERTOS*****", alunos[aluno].nome, alunos[aluno].acerto);






    printf("\n");
    system("pause");


}
