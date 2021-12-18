soma = 0

for i in range(0, 15):
    i = i + 1
    num = int(input("Digite o valor do número {}: ".format(i)))

    if num > 0:
        f = 1
        cont = 1

        while cont <= num:
            f *= cont
            cont = cont + 1
        soma = soma + f

print("A soma dos fatoriais desses números é igual a {}".format(soma))