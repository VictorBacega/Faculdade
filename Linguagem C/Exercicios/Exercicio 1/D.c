#include <locale.h>
#include <stdlib.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");

    int array[8];
    int i, a, b, auxA,auxB;
    a = 0;
    b = 1;
    for(i=0;i<8;i++)
    {
        printf("Digite um Numero para o Array:");
        scanf("%i", &array[i]);
    }
        printf("\n%i\t%i\t%i\t%i\t%i\t%i\t%i\t%i", array[0],array[1],array[2],array[3],array[4],array[5],array[6],array[7]);
    for(i = 0; i<7; i++)
    {
        //printf("\nVARIAVEL A: %i\nVARIAVEL B: %i", a,b); //PROFESSOR NÃO DESCOBRI O ERRO, MAS QUANDO ESSA LINHA ESTA ATIVA O PROGRAMA FUNCIONA POREM, COMENTE ELA E O PROGRAMA NAO FUNCIONAR MAIS E É SÓ UM PRINTF!!!

        if(array[a] > array[b])
        {
            auxA = array[a];
            auxB = array[b];
            //printf("\nArray A[%i] = %i\n Array B[%i] = %i", a,array[a],b,array[b]);
            //printf("\nAuxA = %i\n AuxB = %i", auxA, auxB);
            array[b] = auxA;
            array[a] = auxB;
            //printf("\n TROCADOS: Array A = %i\n Array B = %i", array[a], array[b]);
            a++;
            b++;
        }
        else
        {
            a++;
            b++;
        }
        printf("\n%i\t%i\t%i\t%i\t%i\t%i\t%i\t%i", array[0],array[1],array[2],array[3],array[4],array[5],array[6],array[7]);
    }





  printf("\n");
  system("pause");


}
