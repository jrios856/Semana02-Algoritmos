Algoritmo IMC
    Definir peso, altura, indice Como Real
    
    Escribir "Ingrese su peso (kg):"
    Leer peso
    
    Escribir "Ingrese su altura (m):"
    Leer altura
    
    indice <- peso / (altura * altura)
    
    Escribir "IMC: ", indice
    
    Si indice < 18.5 Entonces
        Escribir "Bajo peso"
    Sino
        Si indice < 25 Entonces
            Escribir "Peso normal"
        Sino
            Si indice < 30 Entonces
                Escribir "Sobrepeso"
            Sino
                Escribir "Obesidad"
            FinSi
        FinSi
    FinSi
FinAlgoritmo