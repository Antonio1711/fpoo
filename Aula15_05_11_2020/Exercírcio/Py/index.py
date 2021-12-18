a = float(input("Digite o valor de A: "))
b = float(input("Digite o valor de B: "))
c = float(input("Digite o valor de C: "))

if a == b and b == c:
    {
        print("É um triângulo equilátero")
    }
elif a == b or a == c or b == c:
    {
        print("É um triângulo isósceles")
    }
else:
    {
        print("É um triângulo escaleno")
    }