programa
{
	
	funcao inicio()
	{
	escreva("1 - Abrir Netflix 2 - Abrir Amazon prime 3 - Abrir HBO GO 4 - Sair")
		inteiro menu = 0
		escreva("\n" + "Sua escolha ")
		leia (menu)

		escolha(menu)
		
		{
		caso 1: //Testa se o valor é igual a 1 
		escreva("OK Abrir Netflix")	
		pare
		caso 2: //Testa se o valor é igual a 2		
		escreva("OK Abrir Amazon Prime")	
		pare
		caso 3: //Testa se o valor é igual a 3		
		escreva("OK Abrir HBO GO")	
		pare
		caso 4: //Testa se o valor é igual a 4		
		escreva("Sair")	
		pare

		caso contrario:
		escreva("Você deve escolher entre as opções 1, 2, 3, ou 4")
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 166; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */