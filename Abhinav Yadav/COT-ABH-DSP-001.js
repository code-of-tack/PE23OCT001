/* Exercise 1 for Debug Project Early Bird
Task -> Given an JavaScript code snippet containing a hidden error, your task is to debug and fix the error
@Author - Abhinav Yadav
*/

function calculateSum(array) {
    let sum = 0;
    for (let i = 0; i < array.length; i++) { //there's a missing closing parenthesis in the for loop
        sum += array[i];
    }
    return sum;
}

const numbers = [1, 2, 3, 4, 5];
const result = calculateSum(numbers);
console.log(`The sum of the array is: ${result}`);
