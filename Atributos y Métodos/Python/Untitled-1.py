class Person:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def __del__(self):
        print(f"El objeto {self.name} ha sido eliminado")

# Crear una instancia de Persona
juan = Person("Juan", 30)

# Eliminar la instancia (esto llamará al método __del__)
del juan