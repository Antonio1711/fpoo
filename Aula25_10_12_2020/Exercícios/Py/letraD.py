matrizA = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]
matrizB = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]

print("Matriz A:")
for i in range(0, 15, 1):
    matrizA[i] = int(input(f"Digite o {i}º número: "))

    matrizB[i] = matrizA[i] ** 2

print("Matriz B:")
for i in range(0, 15, 1):
    print(f"{i}º número = {matrizB[i]}")