#Animal Shelter

Initially we thought about using 2 separate queues for cats and dogs. We found a resource for reference, but ended up not using it. In our solution, first we make a queue named Animals and enqueue cats and dogs into it. If the user has no animal preference, we dequeue from animals and write that one to the console.
If the user has a preference, we ask what type they want, cat or dog. We then peek the object and check if it contains the same type. If it does, dequeue from animals and write to console.
If types don't match, we create a new queue called Rejects. We dequeue from Animals and enqueue into Rejects until we get matching types. Then we return that one to the user.


Resources used: 
https://github.com/wzhishen/cracking-the-coding-interview/blob/master/src/chap03/Q7.java