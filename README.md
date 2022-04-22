My own Documentation of AlgoData Project "CITY MAP"

How can I get from home to the City center? There are two options, which way is the fastest?
The first option: walk to the nearest subway station and ride three subway stations, which are connected, to the city center
The second option: cycle directly from home to the city center.
Home (Player or Bike) is the START and City center is the TARGET.

![image](https://user-images.githubusercontent.com/90723803/164650003-8876e100-ee31-4c0f-8006-be4c8870b253.png)

I started my project by designing a simple scene in Unity, with buildings in different sizes, three subway stations and a few trees. The plane itself is walkable (Layer: Default) but Environment obstacles are unwalkable with Layer (Unwalkable). Then I added START, Player (I) and bike. The point is to find the fastest way to the City by bike and by player to the first subway station Globen. How algorithm works. Finding the shortest path from nod A to node B in the defined grid. Grid is occupied by walkable obstacle nodes represented by squares. To find the shortest way from point A to B we need to define the distance between two nodes to one. What means that the distance to the diagonal nodes is defined by Pythagorized and it will be the square root of two which is approximately 1,4. To easier calculate and to use integers we are going to multiply those numbers by 10. The algorithm begins by going to the start node A and by looking on all surrounding nodes and calculating some values for each of them.

* The value G cost is distance from the starting node, A.
* The value H cost is distance from the end node, B.
* And the value F cost which is the sum of the G and H cost.

The algorithm will first look at the lowest F cost value and it will then look at the all neighbouring nodes and F costs. If we have nodes with the same value F cost, the algorithm will look on the H cost value to see which node has the lowest cost value to the end node. By following the same principles and comparisons we are moving closer and closer until we reach the end value. When reaching the end value we can retrace steps and find the path we took to get there. 2.Script I created two scripts, Node class script and Grid class script. We assigned the grid class to the game object. The Node script has two states, the walkable and non-walkable. I created the public bool parameter called it "walkable" and because we need to know the place in the world those nodes represent, I created the Vector3 parameter and named it "world Position". We need to assign those parameters, by creating the constructor node taking the parameters bool_walkable and vector3_worldPos. I assigned the walkable to/= _walkable and the, world_Position to/= _worldPos. In the Grid script I created two dimensional array of nodes which will represent the grid. And I created the public vector2 with the name "gridWorldSize" which helped us to define the area of coordinates that the grid is going to cover. I defined the space that each node will occupy with bool "nodeRadius". To define the obstacles I created the public LayerMask with the name "unwalkableMask". To visualize everything we use the Unitys Gizmos drawing method, OnDrawGizmos. I drew the Wire Cube and for the center I used transform.position for sides (vector2) and created the new vector3, for x coordinate - gridWorldSize.x for y coordinate - 1 for z coordinate - gridWorldSize.Y (the y axes is representing the z axes in the 3D space)

![image](https://user-images.githubusercontent.com/90723803/164650646-c6a5e546-851c-4f62-b0b5-5d6b258ff37a.png)
 
I also created the Start method where we are going to do the basic calculations. One of the calculations is how many nodes fit in the grid. To calculate I created the float "nodeDiameter" and int gridSizeX and grdSizeY. Inside of the Start method we defined the nodeDiameter us a nodeRadius times 2, the gridSizeX us a gridWorldSize.x devided by nodeDiameter and the gridSizeY us a gridWorldSize.y devided by nodeDiameter but to be sure that those are integers we used Mathf.RoundToInt to round it to closest integer.

![image](https://user-images.githubusercontent.com/90723803/164650960-648f59a9-1215-4302-9888-89850bdad254.png)
 
Optimization
Finding the right node takes a lot of time if I have to iterate through the whole set. Because of that I am going to use heap max-min node data set. Which is a much faster way to find minimum or maximum node. In the heap data set we can use the fact that each child node has lower value of the parent node. By switching the lower value child node for higher value of the parent node I can reach the fastest way of finding the path with the lowest cost. For finding the parent node I can use the simple mathematics formula n-1/2 where n is the value of the children node. And to find the children value n2+1 for left and the 2n+2 for the right node. I created the new class called heap and we implemented it in the node class. Implementing the speed counter in the classes we could calculate that for the first algorithm time was about 25 ms and for heap algorithm about 5ms in average.

![image](https://user-images.githubusercontent.com/90723803/164651610-abf80d76-6413-4902-8c0c-69beae1293d4.png)
 
Units
For calculating the few paths at the same time I created the path request manager class. Where I am using the queue for storing all requests and spreading them to the few frames and we pass it to the pathfinding class. Then I created the unit class where I used the path request manager class. In the same class I visualized the path with the help of the Gizmo drawing.

![image](https://user-images.githubusercontent.com/90723803/164648762-34709a1f-b162-432f-9172-9b5a95b6d64e.png)
 
I created the script for the subway colour switch (from grey to blue) when you the space key and two scripts SubwayTrain and TakeTrain where the player jumps onto the train and rides three stations away towards the center. 
I have created a timer in unity, for the bike as well as walking + subway.

![image](https://user-images.githubusercontent.com/90723803/164651744-734ef7c6-2baa-43ef-8d2f-99d9fc729f51.png)
 
The And
Yours Sincerely

Cecilija Simic Rihtnesberg
