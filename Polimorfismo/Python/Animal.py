class Animal:
    def male_sound(self):
        return "some sound"
    
class dog(Animal):
    def make_sound(self):
        return "bark"
    
class cat(Animal):
    def make_sound(self):
        return "mewo mewo"
    
dog = dog()
cat = cat()

print(dog.make_sound())
print(cat.make_sound())