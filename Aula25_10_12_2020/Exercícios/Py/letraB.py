matrizA = [1, 1, 1, 1, 1, 1, 1, 1]
matrizB = [1, 1, 1, 1, 1, 1, 1, 1]

for i in range(0, 8, 1):
    matrizA[i] = int(input(f"Informe o elemento {i}: "))
    matrizB[i] = matrizA[i] * 3
    
for x in range(0, 8, 1):
    print(f"Índice {x} = Vetor A: {matrizA[x]} e Vetor B: {matrizB[x]}")