#include <stdio.h>
#include <locale.h>
#include <stdlib.h>

main(void)
{
  setlocale(LC_ALL, "portuguese");


  int i;
  float salarioBruto[2], salarioLiquido[2], porcentagem[2];
  int filhos[2];

  for(i = 0; i<=1; i++)
  {
      printf("\nQual o Salario bruto do Funcionario: ");
      scanf("%f", &salarioBruto[i]);

      printf("\nQuantos filhos o funcionario tem: ");
      scanf("%i", &filhos[i]);
  }

  for(i = 0; i<=1; i++)
  {
      porcentagem[i] = filhos[i] * 0.1;
      salarioLiquido[i] = salarioBruto[i] + (porcentagem[i] * salarioBruto[i]);
      printf("\nO salario liquido do Funcionario %i: %.2f", i,salarioLiquido[i]);
  }




  printf("\n");
  system("pause");


}
