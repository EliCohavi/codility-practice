1. Count Character Frequency

Difficulty: Easy

Write a function that takes a string and returns the number of times each character appears.

Example:
input: "banana"
output:

b:1
a:3
n:2

Practice:

dictionary usage
iteration
edge cases

This is extremely common.


2. First Non-Repeating Character

Difficulty: Easy+

Return the first character in a string that appears only once.

Example:
input: "swiss"
output: 'w'

Practice:

frequency maps
second-pass lookup


3. Reverse Words in a Sentence

Difficulty: Easy+

Input:
"hello world there"

Output:
"there world hello"

Practice:

split/join
arrays
indexing


4. Validate Balanced Parentheses

Difficulty: Medium

Input:
"(())()"

Return:
true

Input:
"(()"

Return:
false

Practice:

stack
control flow
edge cases

This is harder than likely interview but very good practice.


5. Find Duplicate Numbers

Difficulty: Medium

Given an array, return all duplicates.

Example:
[1,2,3,2,4,1]
Return:
[1,2]

Practice:

HashSet
duplicate tracking


6. Group Words by Length

Difficulty: Medium

Input:
["cat", "tree", "dog", "house"]

Output:

3: ["cat","dog"]
4: ["tree"]
5: ["house"]

Practice:

Dictionary<int, List<string>>
grouping logic

Excellent for decomposition.


7. Merge Overlapping Time Ranges

Difficulty: Medium+

Input:
[(1,3), (2,4), (6,8)]

Output:
[(1,4), (6,8)]

Practice:

sorting
interval logic
iterative comparison

Harder than likely interview.


8. Shopping Cart Total with Discounts

Difficulty: Medium+

Given cart items:

apples: $2 each
buy 3 apples, get 1 free

Return total cost.

Practice:

business rules
decomposition
clarity

This is VERY interview-relevant because it tests practical coding.