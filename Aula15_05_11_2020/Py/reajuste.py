salario = float(input("Para descobrir seu reajuste, digite seu salário: "))

if salario < 500:
    novo_salario = salario * 1.15
elif salario >= 500 and salario <= 100:
    novo_salario = salario * 1.10
else: 
    novo_salario = salario * 1.05

print("Seu novo salário é igual: {}".format(round(novo_salario,2)))