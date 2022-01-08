programa
{
	
	funcao inicio()
	{
		inteiro contador,limite,resultado
		contador = 0
		//limite = 10
		real valor

		escreva("Digite o valor que deseja de tabuada para resolvermos para você ")
		leia(valor)
		escreva("Digite o valor do limite desejado ")
		leia(limite)

		faca 
		{
			
		resultado = valor * contador
		escreva(valor + " X " + contador + "=" + resultado + "\n")	
		contador ++
		
		} enquanto(contador<=limite) // O que está dentro do loop ele vai repetir o comando enquanto for menor que o limite
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 333; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */