from abc import ABC, abstractmethod
import math

class IShape(ABC):
    @abstractmethod
    def area(self):
        pass

class Circle(IShape):
    def __init__(self, radius):
        self.radius = radius

    def area(self):
        return math.pi * self.radius ** 2
    
class Rectangle(IShape):
    def __init__(self, width, height):
        self.width = width
        self.height = height

    def area(self):
        return self.width * self.height