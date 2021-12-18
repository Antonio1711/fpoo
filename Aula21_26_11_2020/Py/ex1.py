num = float(input("Digite o número: "))

quo = num / 2
resto = num - 2 * quo

if resto == 0:
    print("Par")
else:
    print("Ímpar")