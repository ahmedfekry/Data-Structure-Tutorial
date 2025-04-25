# Welcome Data Structure Tutorial

Hi, My Name is Ahmed Fekry, i am software engineer who is always struggle with data structures and algorithms and trying to practice more about problem solving and this repository is intended to summarize what i have learned the problems i solved on each topic i learned  


# Data Structures

This section will mainly focus on data structures and some of the problems i could solve on LeetCode or hackerrank and hope you can enjoy it.


## HashMap 

First lets focus learn about HashMap. 

-   Arrays have the feature of random access, but its problem is that it is fixed in length.
-   Linked List is flexible in length but it doesn't have random access.
-   Hash map/table solved both of them by being variable in length and also support random access.

**How Hashtable works**

Hash table is array with a hash function.
-   A hash function determines where in the hash table we can store a value in the table.
 -   Hash function must output the same value for the same key every time.    
-   A collision may happen if the result of two keys = result of the same hash value.

      key  →  hash function  →  index in the table
												                                 
|Key|Value|
|--|--|
| 0 | someValue |
| 1 | someValue |
| 2 | someValue |
| 3 | someValue |



**How to solve collisions?**

1.  **Linear Probing**
    
    -   When a collision occurs, find the nearest available next slot.
        
    -   The problem is that if collisions occur often, there’s a higher chance it happens again in the next slot.
        
    -   Essentially, we look at `index + 1` to find the nearest available slot in case of collision.
        
2.  **Separate Chaining**
    
    -   When a collision occurs, create a pointer to another item—essentially making a linked list at that slot.
        

-   The worst-case cost is O(n/k), where:
    
    -   n = number of items
        
    -   k = number of slots in the hash table
        
-   If k is constant (the table size doesn’t grow), then O(n/k) becomes O(n). However, in practice, O(n/k) is typically better than O(n).
-   To avoid these issues, choose a hash function that minimizes the chances of collisions in the first place.

**Sources**
1.  [Hash Tables CS50](https://www.youtube.com/watch?v=h2d9b_nEzoA)
2. [LeetCode](https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1109/)

**Problems**

 1. [Custom HashSet LeetCode](https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1139/)
 2. [Design HashMap LeetCode](https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1140/)
 3. [Contains Duplicate](https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1112/)
 4. [Single Number](https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1176/)
 5. [Intersection of Two Arrays](https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1105/)
 6. [Happy Number](https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1131/)
 7. [2 SUM](https://leetcode.com/problems/two-sum/description/)

 
## Linked List

- Linked List is similar to arrays but every object in a Linked List is separate.
- It is linked to another object by a reference field that points to that another object.

```
[5] -> [3] -> [2] -> [1] -> ⊗
```

- This is a single Linked List.
- The first Node is called the **head node**, and it represents the whole list.

## Code Example

```csharp
public class SingleListNode {
    int val;
    SingleListNode(int x) {
        val = x;
    }
}
```

- You can't access a random element in a single linked list in constant time.  
  If we want to get to the `i-th` element, we have to traverse from the head node one by one.

- Linked List has bad performance in accessing elements compared to arrays.

---

## Adding After Specific Node to Linked List

1. Initialize new node `cur` with the given value.
2. Link the `next` field of the `cur` to that specific's `next` node.
3. Link the `next` field of the `prev` to `cur`.

### To add a node to the beginning of the list:
- Just point the `next` of the new node to the current head.

---

## Delete Operation

1. Find the node you want to delete.
2. Keep the previous node.
3. Just point `previous.next` to the desired node's `next`.


**Sources**

1-  [LeetCode](https://leetcode.com/explore/learn/card/linked-list/)


**Problems**

1. [Design Linked List](https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1290/)
2. [Linked List Cycle](https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1212/)
3. [Linked List Cycle ||](https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1214/)

tree videos

1- https://www.youtube.com/watch?v=oSWTXtMglKE
2- 