n = int(input("Para descobrir se o número é divisível 4 e 5, digite o número: ")) 

r_4 = n % 4 
r_5 = n % 5

if r_4 == 0 and r_5 == 0:
     {
        print(n)
    }
else:
    {
        print("Não é divisível por 4 e 5")
    }