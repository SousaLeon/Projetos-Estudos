#include <stdio.h>
#include <stdlib.h>

void main() {
	
	int Nota1, Nota2, Nota3, Cont, Media, QuantAluno;char Nome [30];
	
	printf("Informe a quantidade de alunos: ");scanf("\n%d", &QuantAluno);
	
	for(Cont = 1; Cont <= QuantAluno; Cont++){		
		printf("\nNome do aluno: "); scanf(" %s", Nome);
		
		printf("\nNota 1: ");scanf("%d", &Nota1);
		
		printf("\nNota 2: ");scanf("%d", &Nota2);
		
		printf("\nNota 3: ");scanf("%d", &Nota3);
		
		Media = (Nota1 + Nota2 + Nota3) / 3;
		
		if(Media >= 7){			
			printf("O aluno %s possui as seguintes notas: Nota1 = %d, Nota2 = %d e Nota3 = %d. Sua media foi %d e ele foi aprovado!", Nome, Nota1, Nota2, Nota3, Media);
		}
		else{
			printf("O aluno %s possui as seguintes notas: Nota1 = %d, Nota2 = %d e Nota3 = %d. Sua media foi %d e ele nao foi aprovado!", Nome, Nota1, Nota2, Nota3, Media);
		}		
	}
}
