package main

import (
	"fmt"
	"strings"
)

func main() {
	var texto string
	var repeticoes int

	fmt.Print("Digite o texto a ser repetido: ")
	fmt.Scanln(&texto)

	fmt.Print("Quantas vezes deseja repetir o texto? ")
	fmt.Scanln(&repeticoes)

	// Repetindo o texto usando strings.Repeat
	resultado := strings.Repeat(texto, repeticoes)

	fmt.Println("Resultado:", resultado)
}
