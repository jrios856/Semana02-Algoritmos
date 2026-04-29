num1 = float(input("Ingrese el primer numero: "))
num2 = float(input("Ingrese el segundo numero: "))

print("Seleccione una opcion:")
print("1. Suma")
print("2. Resta")
print("3. Multiplicacion")
print("4. Division")

opcion = int(input("Opcion: "))

if opcion == 1:
    print("Resultado:", num1 + num2)
elif opcion == 2:
    print("Resultado:", num1 - num2)
elif opcion == 3:
    print("Resultado:", num1 * num2)
elif opcion == 4:
    if num2 != 0:
        print("Resultado:", num1 / num2)
    else:
        print("Error: No se puede dividir entre 0")
else:
    print("Opcion invalida")