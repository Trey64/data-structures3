At first glance this seemed like a difficult challenge, but we found a great resource that broke it down well. For our implementation, we chose to rotate our matrix counter-clockwise and in-place.
Our matrix can be broken down into 4 smaller squares. This helped us to visualize things better during whiteboarding. For each square, we move elements in the same cells counter-clockwise. We do this one at a time, storing cells in a temporary variable and repeating until every element is rotated.

Resources used: 
http://www.geeksforgeeks.org/inplace-rotate-square-matrix-by-90-degrees/