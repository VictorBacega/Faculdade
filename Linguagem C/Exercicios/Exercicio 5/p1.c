#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>
#define JG 3
#define CT 5
#define CP 2

///VICTOR BACEGA FARIA 3001318

main(void)
{
    setlocale(LC_ALL, "portuguese");

    char jogador[JG][50] = {"Juninho", "Zequinha", "Ronaldinho"};
    char categoria[CT][50] = {"Gols Marcados","Passes certos","Passes Errados","Desarmes","Assistencias"};
    char campeonato[CP][50] = {"Varzea I", "Varzea II"};
    int jogo[JG][CT][CP];
    int contador,linha,coluna,tabela;

    ///ENTRANDO NO ARRAY DE JOGADOR


    ///ENTRANDO NO ARRAY DE TABELA
    for(tabela = 0; tabela < CP; tabela++)
    {
        printf("Campeonato[%i]: [%s]\n", tabela, campeonato[tabela]);
        ///ENTRANDO NA LINHA DE JOGADORES
        for(linha = 0; linha < JG; linha++)
        {
            printf("Jogador[%i]: [%s]\n", linha, jogador[linha]);
            ///ENTRANDO NAS CATEGORIA POR JOGADOR
            for(coluna =0; coluna < CT; coluna++)
            {
                jogo[linha][coluna][tabela] = 0;
                printf("Insira o ponto da Categoria[%s]: \n", categoria[coluna]);
                scanf("%i", &jogo[linha][coluna][tabela]);
            }

        }
    }

    ///IMPRESSÃO DA MATRIZ
    for(tabela = 0; tabela < CP; tabela++)
    {
        printf("Campeonato [%s] \n", campeonato[tabela]);
        printf("Categoria:");
        for(contador = 0; contador < CT; contador++)
        {

            printf("\t[%s]", categoria[contador]);

        }
        printf("\n");

        for(linha = 0; linha < JG; linha++)
        {
            printf("\n[%s]\t", jogador[linha]);

            for(coluna = 0; coluna < CT; coluna++)
            {
                printf("[%i]\t", jogo[linha][coluna][tabela]);
            }

        }

        printf("\n\n");
    }







    printf("\n");
    system("pause");


}
