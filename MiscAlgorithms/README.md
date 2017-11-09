#Alphabet Permutation

Immediately, we thought about creating a string of letters and setting int n to the length of the string. We ended up using a char array.
Our Swap method passes two values as references and swaps the values.
Our Permute method takes a char array, starting index, and end index as parameters. If a set has only 1 element, it returns it.
If the set has two characters it returns each element, with the permutation of the rest of the elements added. Then it swaps the reference values, ecursively permutates, backtracks to swap values again, and continues on until all possible permutations are done.


Resources used: 
http://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer/756083#756083