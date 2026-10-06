**Task 2.1** 

# what is each one?
IReadOnlyDictionary : is an interface that makes the content of a dictionary only available for reading

SortedDictionary : is dictionary that keeps its key-value pairs sorted by key



# how is IReadOnlyDictionary different from Dictionary?
Dictionary => is a collection that allows the user to read and modify data

IReadOnlyDictionary => is an interface that depends on IEnumerable so it only enables the user to enumerate through pairs and read them



# why would a public method return IReadOnlyDictionary instead of a Dictionary?
to save object data and prevent illegal modifications from outside


# how is SortedDictionary different from Dictionary in ordering and in lookup speed and when would you choose it?
SortedDictionary => uses binary search tree which enables it to be sorted by key,
slower lookup because it must walk through the tree to find a key 

Dictionary => uses hash table and store keys in buckets deoending on their hash code, faster lookup because it jumps directly to the key by hash code 

I would like to choose it if i need sorting like scores 


**Task 2.2**
 S1 => Dictionary 

 S2 => HashSet

 S3 => List

 S4 => IReadOnlyDictionary

 S5 => SortedDictionary

 S6 => IEnumerable



 