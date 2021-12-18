ip = int(input("Para descobrir a classe do IPv4 desejado, digite o primeiro octeto: "))

if ip >= 1 and ip <= 127:
    print('Sua classe de IPv4 é A')
elif ip >= 128 and ip <=191:
    print("Sua classe de IPv4 é B")
else:
    print("Sua classe de IPv4 é C")
