# 📘 GoLang Studies - Vinicius Garcia

Repositório dedicado ao estudo da linguagem **Go (Golang)**, com projetos práticos desenvolvidos durante o aprendizado. Cada exemplo foca em conceitos fundamentais da linguagem, como manipulação de dados, estruturas de controle, chamadas HTTP, canais e mais.

---

## 📂 Projetos Incluídos

### 1. 🧾 API de Clientes

Uma API simples que consome um JSON hospedado no GitHub com dados de clientes. Utiliza `net/http`, `gorilla/mux` e `encoding/json` para expor rotas com diferentes clientes.

- 📌 Rotas disponíveis:
  - `/` → Todos os clientes
  - `/Customer1` a `/Customer4` → Clientes individuais

> Demonstra: requisições HTTP, unmarshalling de JSON externo, uso de `mux` e tratamento de rotas.

---

### 2. 🧮 Calculadora

Funções para realizar as 4 operações matemáticas básicas (soma, subtração, multiplicação e divisão), utilizando `variadic parameters` (`...int`).

> Demonstra: funções, laços `for`, slices e lógica aritmética.

---

### 3. 🌡️ Conversão de Temperaturas

Converte a temperatura de ebulição da água de Kelvin para Celsius utilizando `const`.

> Demonstra: constantes, operações matemáticas e conversões de escala.

---

### 4. 🎯 Jogo Numérico "Pan e Pin"

Imprime números de 1 a 100 substituindo múltiplos de 3 por “Pin” e de 5 por “Pan”.

> Demonstra: condicionais (`if`, `else`), operadores modulares e laços.

---

### 5. 🔢 Múltiplos de Três

Imprime todos os números de 1 a 100 que são múltiplos de três.

> Demonstra: condicionais simples e mod (`%`).

---

### 6. 🏓 Ping Pong com Canais

Um exemplo de concorrência com goroutines e canais (`chan`), imprimindo continuamente “Ping” e “Pong” alternados a cada segundo.

> Demonstra: concorrência em Go, goroutines, canais e `time.Sleep`.

---

### 7. 🔁 Teste de Calculadora

Repetição do projeto da calculadora com chamadas diretas e impressão no terminal.

---

## 🛠️ Como executar

1. Instale o Go: [https://golang.org/dl](https://golang.org/dl)
2. Clone o repositório:
```bash
git clone https://github.com/viniciusgarciam/Golang
cd seu-repo
