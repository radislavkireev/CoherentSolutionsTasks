# CoherentSolutionsTasks
Homeworks

Task 1. Create a console application, whichasks the user for two integers a and b (assume
that the user enters integers without errors). The application then prints out all integers
in the range from a (inclusive) to b (inclusive) that have exactly two 2's in their ternary
number system (0, 1, 2) representation. Develop a console application that implements
the specified functionality.
Note: to convert a string s to an int value, use the int.Parse(s) method.

Task 2. The 10-digit ISBN is a numeric code that uniquely identifies a book. It has the
following form: d1d2d3d4d5d6d7d8d9d10.. Digit d10 is a control one. It is calculated
according to the condition that the expression

10d1 + 9d2 + 8d3+.. .+ 1d10

(the sum of the products of code elements by the weight of their positions) must be a
multiple of 11. Create a program that prompts the user for a 9 character-digit string (the
first nine digits of the ISBN), calculates the check digit, and prints the resulting ISBN. Do
not check the correctness of the user's input - assume that the user does not make
mistakes when entering.
Note 1: the check "digit" can be equal to 10. In this case, the symbol X is used to denote it.

Task 3. The application asks the user for the number of elements in a numeric array (at
least two), and then in a loop -the elements themselves (of int type). After entering the
elements, the application prints out the original array and outputs the sum of the array
elements located between the smallest element in the array (the leftmost element if there
are several) and the largest element (the rightmost element if there are several). Develop
a console application that implements the specified functionality.
Example: array [1, 3, 5, 1, 0, 3, 0, 1]. The sum of the required elements = 5 + 1 + 0 = 6.
Note 1: the correctness of the length of the array can be left unchecked.

Note 2: The smallest and largest items are to be included in the amount.
