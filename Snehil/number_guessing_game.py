print("hello , let's start the game ")
from random import randint
choice = randint(1, 100)
print(choice)
count = 5


while(True and count):
    print("enter the number :")
    input_a = int(input())
    if input_a<choice:
        print("try a greater number")
        count-=1
        print("Number of turns you are left with :",count)
    elif input_a>choice:
        print("try a smaller number")
        count-=1
        print("Number of turns you are left with :",count)
    else:
        print("wohooo ... you got the right answer !!! ")
        break
    
