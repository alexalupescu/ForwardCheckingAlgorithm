**Forward Checking Algorithm**

**Desciption**
In this project, the goal is to color a map, with a main condition: that two adjacent regions don't have the same color. This is a classic constraint satisfaction problem (CSP).
The basic idea to solve this problem is to form a graph, then traverse it in order to achieve the goal. The Forward Checking algorithm performs consistency tests with future variables, not with those from the previous step. Thus, at the moment when a variable is instantiated, the domains of the possible variables assignables are filtered to remove all values that may generate inconsistencies with the current instance.

The main benefit of the Forward Checking algorithm is to reduce the number of colors used when we're using backtracking method. The algorithm prevents an addition verification of conflicts. The available colors for each region are kept in a list, and after coloring a region, that color is removed, being inaccessible to the adjacent regions.

**Conclusions**
The Forward Checking algorithm performs consistency tests with future variables, not with those from the past. 
The application was successfully finalized in C# with the expected results. By implementing the algorithm, it was possible to color a map, using three colors (ex. Australia map) and for the other maps using four color (Europe, SUA, Africa maps).

**Screenshots**
**Application Menu**

![image](https://github.com/alexalupescu/ForwardCheckingAlgorithm/assets/134335603/099fa370-afa6-44df-922c-f841c6734dcd)

**USA Map**

![image](https://github.com/alexalupescu/ForwardCheckingAlgorithm/assets/134335603/80c8d1c5-5b20-4b83-8830-172275bfc044)

**Bibliography**
2. https://www.csie.ntu.edu.tw/~d91003/ai/project2/
3. https://www.geeksforgeeks.org/m-coloring-problem-backtracking-5/
