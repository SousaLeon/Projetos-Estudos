#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

void main() {
	
	int Num1, Num2, Resultado;
	char operacao;
	
	printf("Digite o primeiro numero: ");
	scanf("%d", &Num1);

	printf("Informe o tipo de calculo (/, *, -, +): ");
	scanf(" %c", &operacao);
		
	printf("Digite o segundo numero: ");
	scanf("%d", &Num2);
	
	switch(operacao){
		
		case '/':
		case ':':
			Resultado = Num1 / Num2;
			printf("O resultado e: %d", Resultado);
			break;
			
		case 'X':
		case 'x':
			Resultado = Num1 * Num2;
			printf("O resultado e: %d", Resultado);
			break;
		
		case '+':
			Resultado = Num1 + Num2;
			printf("O resultado e: %d", Resultado);
			break;
			
		case '-':
			Resultado = Num1 - Num2;
			printf("O resultado e: %d", Resultado);
			break;
	}
	
}
