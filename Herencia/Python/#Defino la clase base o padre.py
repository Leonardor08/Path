#Defino la clase base o padre
class Animal:
    def __init__(self, name):
        self.Name = name

    def eat(self):
        print(f"{self.Name} está comiendo")

#clase derivada o hija
class Dog(Animal):
    def bark(self):
        print(f"{self.Name} está ladrando")

# Crear una instancia de la clase
my_Dog = Dog("Max")

my_Dog.eat()
my_Dog.bark()