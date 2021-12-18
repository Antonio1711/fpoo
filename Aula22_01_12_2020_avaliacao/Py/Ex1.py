n1 = float(input("Digite a primeira nota: "))
n2 = float(input("Digite a segunda nota: "))
n3 = float(input("Digite a terceira nota: "))
n4 = float(input("Digite a quarta nota: "))

mf = (n1 + n2 + n3 + n4) / 4

if mf < 5:
    print(f"Sua média é {mf} \nVocê foi reprovado!")
elif mf >= 7:
    print(f"Sua média é {mf} \nVocê foi aprovado!")
else:
    print(f"Sua média é {mf} \nVocê está de recuperação!")

