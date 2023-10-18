#Sintaxis básica

#Variables

nombre = "Juan"
edad = 12
altura = 1.15
frutas = ["manzana", "plátano", "uva"]
contador = 0

#imprimir un valor

print(nombre)

#Operaciones matemáticas

suma = edad + 5

multipllicacion = 5 * 10

#Estructuras de control

if edad < 3:
    print("Logica irá acá")
elif edad == 20:
    print("Logica irá acá")
else:
    print("Logica irá acá")

for fruta in frutas:
    print(fruta)

while contador < 5:
    print(f"Contador: {contador}")
    contador += 1