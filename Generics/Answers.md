# Step 2
what is the same between the two stores, and what is different?
every thing is the same except the type


# Step 3 
copile error on GetById & Remove:
the compiler does not know type of T and whether it has Id or can be null 


# Step 7
new Store<string>() doesn't compile because string doesn't implement IHasId 
so it cann't be a <T> 


# what is the common name for the kind of class you built in Steps 4 and 5 ?
Generic Repository
