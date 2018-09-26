#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <locale.h>

///VICTOR BACEGA FARIA

char senha[100];
int contador, ascii, tamanho=0, maiuscula=0, maiuCont=0, minuscula=0; minusCont=0, numeros=0, numCont=0, especial=0, espeCont=0;

void cadastro()
{
    fflush(stdin);
    system("cls");
    printf("Insira a senha:\n");
    gets(senha);
    tamanho = strlen(senha);
    return(main());
}




main(void)
{
  setlocale(LC_ALL, "portuguese");

  cadastro();

/////MAISCULA
    for(ascii = 65; ascii < 91; ascii++)
    {
        maiuscula = strchr(senha, ascii);
        if(maiuscula != NULL)
        {
            maiuCont++;
        }
    }
/////MINUSCULA
    for(ascii = 97; ascii < 123; ascii++)
    {
        minuscula = strchr(senha, ascii);
        if(minuscula != NULL)
        {
            minusCont++;
        }
    }
////NUMEROS
    for(ascii = 48; ascii <58; ascii++)
    {
        numeros = strchr(senha, ascii);
        if(numeros != NULL)
        {
            numCont++;
        }
    }
////CARACTERE ESPECIAL
    for(ascii = 40; ascii <48; ascii++)
    {
        especial = strchr(senha, ascii);
        if(especial != NULL)
        {
            espeCont++;
        }
    }

////CHECAGEM DE DADOS
    if(tamanho < 10)
    {
        printf("SENHA CURTA DE MAIS!\n");
        system("pause");
        cadastro();
    }
    if (maiuCont < 2)
    {
        printf("PELO MENOS 2 LETRAS MAIUSCULAS\n");
        system("pause");
        cadastro();
    }
    if (minusCont < 3)
    {
        printf("PELO MENOS 3 LETRAS MINUSCULAS\n");
        system("pause");
        cadastro();
    }
    if (numCont < 3)
    {
        printf("PELO MENOS 2 NUMEROS\n");
        system("pause");
        cadastro();
    }
    if (espeCont < 2)
    {
        printf("PELO MENOS 2 CARACTERES ESPECIAIS\n");
        system("pause");
        cadastro();
    }


        printf("SENHA CADASTRADA COM SUCESSO!!\n");








  printf("\n");
  system("pause");


}
