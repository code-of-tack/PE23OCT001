/* Exercise 1 Project Early Bird
Task -> Write a clean JavaScript function that can count the number of vowels in a given string
@Author - Abhinav Yadav
*/


const prompt = require ("prompt-sync")({sigint: true}) //to avoid reference error 

function countVowel(str) { 

    
    const count = str.match(/[aeiou]/gi).length;  // finding the count of vowels

    return count;  // returning the number of vowels
}

const string = prompt('Enter a string: ');  // take the input

const result = countVowel(string);

console.log(result);