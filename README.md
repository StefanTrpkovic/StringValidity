# Valid String 
You are given a string and your job is to write a function that determines if that string is valid by following these rules:
- The number of times that the letters appear in the string should
be the same 
- The string is also correct if by removing only 1 character, the
remaining appear the same number of times 
- If a string is valid return "Correct String", if it is not valid return
"Not Correct String"
### Examples:
- IsString Correct(xyz) — "Correct String"<br />
The string is valid because all characters in the string appear the same number of times. 
- IsString Correct(xyzz) — "Correct String" <br />
The string is valid because by removing 1 "z", the remaining string
is contains characters that appear the same number of times. 
- IsString Correct(xxyyzj) — "Not Correct String"<br />
The string is NOT valid because we would need to remove two characters, both z and j -> xxyy or x and y -> xyzj, to make it valid. We are limited to removing only one character, so it is invalid.
