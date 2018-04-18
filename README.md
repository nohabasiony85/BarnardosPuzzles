# BarnardosPuzzles

Code Competency Puzzles
Introduction
Your first step in the Barnardos recruitment process is to demonstrate your understanding of writing code in C#.
You are given the choice of solving either a set of three small puzzles ("Choice A") or solving one larger puzzle
("Choice B").
When writing your code, please be mindful of the following:
• Your code should be production ready.
• Your code should be understandable and maintainable by other developers.
• Your code should be robust and handle error situations.
• Your code should be bug free, compile and work.
• Your code should include unit tests, you may use a unit test framework of your choice (MSTest, NUnit,
XUnit, MbUnit, etc)
Code must be submitted in ZIP format and should contain the source code for one choice only (i.e. no binaries,
packages, test artifacts, etc). When you have completed your choice of puzzle(s), forward the ZIP file along to
Barnardos.
Good luck! And thank you for your interest in a position with Barnardos.
Choice A - Puzzle One – Reverse Words
Write a function to reverse the words in a string, for example “cat and dog” becomes “tac dna god”.
t a C d n a g o d
C a t a n d d o g
Please do not use any string manipulation functions that you do not implement yourself.
Your code
• Should reverse each word within the string without altering whitespace characters
• Should treat punctuation characters as part of the word
• Is only required to deal with standard English characters. Unicode support is not required.
• Should be your own code and should not use any built-in .NET string manipulation calls.
Choice A - Puzzle Two – Linked list
Write a function that would return the 5th element from the tail (or end) of a singly linked list of integers.
For example, given the list 2 -> 3 -> 4 ->5 -> 6 -> 7 -> 8 -> 9 -> 10 -> 11 your function would return 7.
Your code
• Should return the 5th element from the tail in a single pass.
• Should be your own code and should not use any built-in .NET collection components.
Choice A - Puzzle Three - Triangles
Write a function that receives three integer inputs for the lengths of the sides of a triangle and returns one of four
values to determine the triangle type: scalene, isosceles, equilateral or error.
Equilateral
Three equal sides
Isosceles
Two equal sides
Scalene
No equal sides
Choice B - Glossary
In this puzzle, you are required to store and display a list of words and descriptions to build a glossary of terms
into a persistent data store. Whilst this puzzle is expected to take longer to complete than the Choice A puzzles it
should give you the opportunity to demonstrate your flair for technology and your programming style. The
choice of technology used to solve this puzzle is entirely at your discretion.
Glossary Term Model
Glossary
Term The term of reference
Definition A paragraph of text describing the meaning of the term.
Sample Glossary
Term Definition
abyssal plain The ocean floor offshore from the continental margin, usually very flat with a slight
slope.
accrete v. To add terranes (small land masses or pieces of crust) to another, usually larger, land
mass.
alkaline Term pertaining to a highly basic, as opposed to acidic, subtance. For example,
hydroxide or carbonate of sodium or potassium.
Stories
1. As a glossary author, I would like to add a term and definition to the system so I can continually grow our
knowledge base of terms.
2. As a glossary author, I would like to edit a term so I can fix mistakes and update definitions.
3. As a glossary author, I would like to remove terms that I no longer feel are necessary or valid.
4. As a glossary author, I would like to view the alphabetically sorted list of terms and definitions so I can find a
particular term quickly.
Acceptance Criteria
• Should have full CRUD operations
• Should show terms sorted alphabetically
• Existing terms should be visible when the application starts
