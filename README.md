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
