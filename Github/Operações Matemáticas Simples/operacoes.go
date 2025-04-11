package main

import (
	"fmt"
)

func main() {
	var num1, num2 float64

	fmt.Print("Digite o primeiro número: ")
	fmt.Scanln(&num1)

	fmt.Print("Digite o segundo número: ")
	fmt.Scanln(&num2)

	soma := num1 + num2
	subtracao := num1 - num2
	multiplicacao := num1 * num2
	divisao := num1 / num2

	fmt.Println("Soma:", soma)
	fmt.Println("Subtração:", subtracao)
	fmt.Println("Multiplicação:", multiplicacao)
	fmt.Println("Divisão:", divisao)
}
