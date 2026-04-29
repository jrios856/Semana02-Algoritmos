Algoritmo Calculadora
    Definir num1, num2 Como Real
    Definir opcion Como Entero
    
    Escribir "Ingrese el primer numero:"
    Leer num1
    
    Escribir "Ingrese el segundo numero:"
    Leer num2
    
    Escribir "Seleccione una opcion:"
    Escribir "1. Suma"
    Escribir "2. Resta"
    Escribir "3. Multiplicacion"
    Escribir "4. Division"
    Leer opcion
    
    Segun opcion Hacer
        1:
            Escribir "Resultado: ", num1 + num2
        2:
            Escribir "Resultado: ", num1 - num2
        3:
            Escribir "Resultado: ", num1 * num2
        4:
            Si num2 <> 0 Entonces
                Escribir "Resultado: ", num1 / num2
            Sino
                Escribir "Error: No se puede dividir entre 0"
            FinSi
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
FinAlgoritmo