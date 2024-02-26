/** 
The Back_Forward_Checking method involves implementing the backtracking part and the check before. 
Initially, a region without an assigned color is selected from the list of regions. 
In the the next phase, the list of colors will be cycled through. It is checked if a neighbor has this assigned
color. If yes, it moves to the next color in the list. When an available color is found, the neighbors are notified 
that they can no longer use it and it's checked beforehand if this choice will not block
later the program. If yes, it will be changed to another color and the neighbors will be notified that they can use it
the previous color.
**/
public int Back_Forward_Checking(int dimension)
{
       if(dimension==Regions_List.Count())
       {
           return SUCCES;
       }
  
       //select a region
       int aux = Select_Variables();
       //we go through the whole list of colors
       for(int i=0;i<Colors.Count();i++)
       {
           //it is checked if no neighboring region is assigned the color
           if(!Has_Constraints(aux,Colors[i]))
           {
               ////set the color for the aux region
               Regions_List[aux].SetColor(Colors[i]);
               //for all aux's neighbors it is marked that they can no longer use aux's color
               Update_Neighbors(aux, false, Colors[i]);
               step += 1;
               dimension += 1;
               //it is checked if a neighbor remains without available colors
              if(Forward_Checking(aux))
              {
                 int result = Back_Forward_Checking(dimension);
                 if(result==SUCCES)
                 {
                     return result;
                 }
             }
             //if there are neighbors without colors, the color assigned to the region is deleted and the checks are resumed with the next color
             Regions_List[aux].DeleteColor();
             //all neighbors of the region can access the color again
             Update_Neighbors(aux, true, Colors[i]);
             dimension -= 1;
          }
       }
    return 0;
}
