String Validity

For an inputted string, the program should check if it is valid.
A string is valid if:
- All the leeters appear the same number of times in the string.
- If by removing only 1 character, the remaining characters appear the same number of times.\
If the string is valid return "Correct String", if it is not valid return "Not Correct String"

Examples of test run times:
- IsStringCorrect(mnhmnh) — "Correct String". All characters in the string appear the same number of times.
- IsStringCorrect(mnpm) — "Correct String". By removing 1 "m", the remaining characters appear the same number of times.
- IsStringCorrect(mnppll) — "Not Correct String". We can remove only one 'l', or one 'p', but not both.
