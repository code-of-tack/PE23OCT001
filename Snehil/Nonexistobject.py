# Creating a sample class with an attribute
class MyClass:
    def __init__(self, name):
        self.name = name

# Creating an object of the class and trying to access a non-existent attribute
obj = MyClass("Example")
print(obj.name)
