# Definición de una clase en Python
class Person:
# Definición de método inicial de la clase
    def __init__(self, name, age):
        self.Name = name
        self.Age = age
# Definición de método para impresión de infomación
    def print(self):
        print(f"Hola, soy {self.Name} y tengo {self.Age} años.")
