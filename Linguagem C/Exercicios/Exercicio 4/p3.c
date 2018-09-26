#include<stdio.h>
#include<string.h>
#include<conio.h>
#include<locale.h>


///VICTOR BACEGA FARIA
char consultar[100];
int ascii, opcao;
int contador=0, qtd=0;
struct agenda
{
    char nome[100];
    char telefone[25];
};
struct agenda agendas[10];



void lista()
{
    system("cls");
    for(ascii = 65; ascii < 91; ascii++)
    {
        for(contador = 0; contador < 10; contador++)
        {
           if(toupper(agendas[contador].nome[0]) == ascii)
           {
               printf("%s\n", agendas[contador].nome);
               printf("%s\n", agendas[contador].telefone);
           }
        }

    }
    system("pause");
    return(main());
}


void cadastrar()
{
    system("cls");
    fflush(stdin);
    printf("Insira o Nome:\n");
        gets(agendas[qtd].nome);

    printf("Insira o Telefone:");
        gets(agendas[qtd].telefone);

    printf("***CADASTRADO COM SUCESSO***");
    system("pause");
    qtd++;
    return(main());
}


void buscar()
{
    system("cls");
    fflush(stdin);
    printf("Qual nome gostaria de buscar: \n");
    gets(consultar);

    for(contador=0; contador<qtd; contador++)
    {
        if(strcmp(consultar, agendas[contador].nome)==0)
        {

            printf("    Nome: %s\n", agendas[contador].nome);
            printf("Telefone: %s\n", agendas[contador].telefone);
            printf("\n");
            system("pause");
        }
    }
    system("pause");
    return (main());
}

 int main (void)
{
  setlocale(LC_ALL, "portuguese");
    system("cls");
    printf("******AGENDA******\n");
    printf("* 1 -> Cadastrar *\n");
    printf("* 2 -> Consultar *\n");
    printf("* 3 -> Listar    *\n");
    printf("******************\n");
    scanf("%i", &opcao);

    switch(opcao)
    {
        case 1:
            cadastrar();
            break;
        case 2:
            buscar();
            break;
        case 3:
            lista();
            break;
    }

  printf("\n");
  system("pause");


}





