peso = float(input("Ingrese su peso (kg): "))
altura = float(input("Ingrese su altura (m): "))

imc = peso / (altura ** 2)

print("IMC:", imc)

if imc < 18.5:
    print("Bajo peso")
elif imc < 25:
    print("Peso normal")
elif imc < 30:
    print("Sobrepeso")
else:
    print("Obesidad")