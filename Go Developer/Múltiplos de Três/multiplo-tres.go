package main

import "fmt"

func main() {

	for i := 1; i <= 100; i++ {
		if i%3 == 0 {
			fmt.Println(i, "é um numero múltiplo de três")
		}
	}
}

// O código acima imprime todos os números de 1 a 100 que são múltiplos de três.
