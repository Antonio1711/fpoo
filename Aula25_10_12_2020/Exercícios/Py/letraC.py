matrizA = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,]
matrizB = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,]
matrizC = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,]

print("Matriz A:")
for i in range(1, 21, 1):
    matrizA[i] = int(input(f"Digite o {i}º número: "))

print("Matriz B:")
for i in range(1, 21, 1):
    matrizB[i] = int(input(f"Digite o {i}º número: "))

print("Matriz C:")
for i in range(1, 21, 1):
    matrizC[i] = matrizA[i] - matrizB[i]

    print(f"{i}º número = {matrizC[i]}")