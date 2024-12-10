#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

void main() {
	
	int Num1, Num2, Num3, Resultado;
	Num3 = 0;
	char operacao, opcao;
	
	printf(" %d", Resultado);
	
	Inicio: 
	system("cls"); 
	
	printf("\nDigite o primeiro numero: ");
	scanf("%d", &Num1);

	printf("Informe o tipo de calculo (/, X, -, +): ");
	scanf(" %c", &operacao);
		
	printf("Digite o segundo numero: ");
	scanf(" %d", &Num2);
	
	Verificacao:
	
	switch(operacao){
		
		case '/':
		case ':':
			if(Num3 == 0){
				Resultado = Num1 / Num2;
			}	
			else{
				Resultado = Num1 / Num2 / Num3;
			}		
			break;
			
		case 'X':
		case 'x':
			if(Num3 == 0){
				Resultado = Num1 * Num2;
			}
			else{
				Resultado = Num1 * Num2 * Num3;
			}
			break;
		
		case '+':
			if(Num3 == 0){
				Resultado = Num1 + Num2;
			}
			else{
				Resultado = Num1 + Num2 + Num3;
			}
			break;
			
		case '-':
			if(Num3 == 0){
				Resultado = Num1 - Num2;
			}
			else{
				Resultado = Num1 - Num2 - Num3;
			}
			break;
			
		default:
			printf("\nA operacao informada nao e valida ou apresenta caracteres incorretos! \n");
			printf("\nDeseja tentar novamente? S/N: ");
			scanf(" %c", &opcao);
			
			if(opcao == 'S' || opcao == 's'){
				goto Inicio;
			}
	}	
	
	printf("Deseja continuar calculando com este resultado S/N ? ");
	scanf(" %c", &opcao);
	
	if(opcao == 'S' || opcao == 's'){
		
		printf("Informe o valor: ");
		scanf(" %d", &Num3);
		
		printf("Informe o tipo de calculo: ");
		scanf(" %c", &opcao);
		goto Verificacao;		
		
	}else{
		printf("O resultado e: %d", Resultado);
	}
	
	printf("\nDeseja realizar outra operacao S/N ?");
	scanf(" %c", &opcao);
	
	if(opcao == 'S' || opcao == 's'){
		goto Inicio;
	}
	
}
