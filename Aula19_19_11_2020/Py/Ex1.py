num = int(input("Digite o número: "))

if num == 0:
    print("O fatorial de 0 é 0")
else:
    f = 1
    i = 1
while i <= num:
    f *= i
    i += 1
print("Fatorial é {}".format(f))