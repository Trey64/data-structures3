#Towers Of Hanoi

Our MoveTower method takes in the number of discs, start pole, aux pole, and end pole as arguments. If the number of discs is 1, we move a disc from the start pole to the end pole.
If the number of discs is greater than 1, we make two recursive calls of MoveTower. 
Our first recursive call is when we need to move (n-1) discs from start to aux, the aux becomes the end and the end becomes the aux.
Then we write "start -> end" which is the movement of the largest disc from the bottom of the start pole to the end.
In our second recursive call, the aux becomes the start, and the start becomes the aux.
Our implementation uses 4 discs, but the number can be changed.


Resources used: 
http://www.javawithus.com/programs/towers-of-hanoi