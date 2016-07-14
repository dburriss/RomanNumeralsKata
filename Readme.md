# Roman numerals kata

The goal is to create a program that can convert Roman numerals to numeric numbers and also the other way around.
How are you going to do this? *TDD* baby!

[Dont like TDD?](https://raw.githubusercontent.com/dburriss/RomanNumeralsKata/master/DontLikeTDD.md)

## Use cases

As a game developer
I want to be able to convert a number to a numeral
So that I can label my game releases using Roman numerals
Given I have started the converter
When I enter $number
Then $numeral is returned

As a marketing manager
I want customers to be able to convert numerals to numbers
So that they can buy the latest version of the game
Given I have started the converter
When I enter $numeral
Then $number is returned

## Extra details about Roman numerals

The Romans wrote their numbers using letters; 
specifically the letters 
'I' meaning '1', 
'V' meaning '5', 
'X' meaning '10', 
'L' meaning '50', 
'C' meaning '100', 
'D' meaning '500', 
and 'M' meaning '1000'. 

There were certain rules that the numerals followed which should be observed.

The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row. 
The symbols 'V', 'L', and 'D' can never be repeated. 
The '1' symbols ('I', 'X', and 'C') can only be subtracted from the 2 next highest values ('IV' and 'IX', 'XL' and 'XC', 'CD' and 'CM'). 
Only one subtraction can be made per numeral 
('XC' is allowed, 'XXC' is not). 
The '5' symbols ('V', 'L', and 'D') can never be subtracted.
