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

9. Word Frequency Ranking

Difficulty: Medium+

Input:
"cat dog cat bird dog cat"

Output:
["cat", "dog", "bird"]

Ordered by frequency.

Practice:

dictionary
sorting
transformation

10. Basic Rate Limiter

Difficulty: Hard-ish

Allow max 3 requests per user.

Input:
user requests:
A, A, B, A, A

Output:
allow / deny

Practice:

dictionaries
state tracking
logic design

This is harder than they’ll likely ask but excellent for reasoning.

11. Inventory Reservation

Difficulty: Hard-ish

Given stock:
itemA = 5

Reserve quantities:

- reserve 3 → success
- reserve 4 → fail

Practice:

- object state
- validation
- business logic

Very realistic backend logic.

12. Build a Simple Todo System

Operations:

AddTodo
CompleteTodo
GetPending

Pattern:

object modeling
list state
CRUD-style logic

13. Two Sum
    Easy
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

9. Palindrome Number
   Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

Constraints:

-231 <= x <= 231 - 1

Follow up: Could you solve it without converting the integer to a string?

13. Roman to Integer
    Easy
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol Value
I 1
V 5
X 10
L 50
C 100
D 500
M 1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9.
X can be placed before L (50) and C (100) to make 40 and 90.
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

Constraints:

1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999].
