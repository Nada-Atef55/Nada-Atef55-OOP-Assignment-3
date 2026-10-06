# Part 03 — answers

---

## BlockedUsers

- Time complexity before: n*m
  where n : number of request IDs,   m : number of blocked IDs     
- Time (ms) before: 18 ms


- What did you change?
  i used HashSet<T> instead of List<T>, because searching in HashSet is O(1) amortized 
  
- Time complexity after: n*1 = n      where n : number of request IDs
- Time (ms) after: 0 ms

---

## Students

- What was the problem?
  program.cs needs only 3 students but GetAllStudents() in foreach generates all 1_000_000 students first then print only 3

- What did you change?
  i used yield return so GetAllStudents() pauses after each return until someone asks 
