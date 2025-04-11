package main

import (
	"fmt"
)

func main() {
	var info1, info2 string

	fmt.Print("Digite a primeira informação: ")
	fmt.Scanln(&info1)

	fmt.Print("Digite a segunda informação: ")
	fmt.Scanln(&info2)

	concatenacao := info1 + info2

	fmt.Println("Resultado da concatenação:", concatenacao)
}
