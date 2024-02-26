/**
The Has_Constraint method checks if a neighbor of the region already has that current color. 
If yes, it will return true. The Find_Region method will return the index corresponding to a region in the list.
The Update_Neighbors method updates the available colors for neighbors.
**/
public bool Has_Constraint(int region,string _color)
{
     List<Region> neighbors = Regions_List[region].GetNieghbors();
     for(int i=0;i<neighbors.Count();i++)
     {
         if(Regions_List[Find_Region(neighbors[i].GetRegionName())].GetColor().CompareTo(_color)==0)
         {
             return true;
         }
     }
     return false;
}

public int Find_Region(string region_name)
{
     for(int i=0;i<Regions_List.Count();i++)
     {
         if(Regions_List[i].GetRegionName()==region_name)
         {
             return i;
         }
     }
     return -1;
}

public void Update_Neighbors(int variable,bool flag,string _color)
{
   List<Region> neighbors = Regions_List[variable].GetNieghbors();
   for(int i=0;i<neighbors.Count();i++)
   {
       Regions_List[Find_Region(neighbors[i].GetRegionName())].ModifyColor(flag, _color);
   }
}
 
