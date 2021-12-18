print("Digite o número da operação que deseja realizar para posteriormente escolher o(s) número(s): ")

op = int(input("1. Adição(+) \n2. Subtração(-) \n3. Multiplicação(*) \n4. Divisão(/) \n5. Potenciação(^) \n6. Raiz quadrada \n7. Conversão de real para moeda estrangeira \n8. Conversão de moeda estrangeira para real \n9. Conversão de Celsius para Fahrenheit \n10. Conversão de Fahrenheit para Celsius \nDigite o número abaixo: "))

import math

if op == 1:
    num1 = float(input("Digite o primeiro número: "))
    num2 = float(input("Digite o segundo número: "))
    print(num1 + num2)
elif op == 2:
    num1 = float(input("Digite o primeiro número: "))
    num2 = float(input("Digite o segundo número: "))
    print(num1 - num2)
elif op == 3:
    num1 = float(input("Digite o primeiro número: "))
    num2 = float(input("Digite o segundo número: "))
    print(num1 * num2)
elif op == 4:
    num1 = float(input("Digite o primeiro número: "))
    num2 = float(input("Digite o segundo número: "))
    print(num1 / num2)
elif op == 5:
    num1 = float(input("Digite a base: "))
    num2 = float(input("Digite o expoente: "))
    print(num1 ** num2)
elif op == 6:
    num1 = float(input("Digite o número: "))
    print(math.sqrt(num1))
elif op == 7:
    num1 = float(input("Digite o valor em real que deseja converter: "))
    num2 = float(input("1. Dólar americano \n2. Euro \n3. Libra Esterlina \nDigite o número da moeda estrangeira: "))
    if num2 == 1:
        print(num1 * 0.18)
    elif num2 == 2:
        print(num1 * 0.15)
    elif num2 == 3:
        print(num1 * 0.14)
    else:
        print('Número inválido')
elif op == 8:
    num1 = float(input("Digite o valor da moeda estrangeira que deseja converter para real: "))
    num2 = float(input("1. Dólar americano \n2. Euro \n3. Libra Esterlina \nDigite o número da moeda estrangeira: "))
    if num2 == 1:
        print(num1 * 5.43)
    elif num2 == 2:
        print(num1 * 6.46)
    elif num2 == 3:
        print(num1 * 7.19)
    else:
        print("Número inválido")
elif op == 9:
    num1 = float(input("Digite a temperatura em Celsius que deseja converter para Fahrenheit: "))
    print((9 * num1 + 160) / 5)
elif op == 10:
    num1 = float(input("Digite a temperatura em Fahrenheit que deseja converter para Celsius: "))
    print((num1 - 32) * 5/9)
else:
    print("Número inválido, tente novamente")