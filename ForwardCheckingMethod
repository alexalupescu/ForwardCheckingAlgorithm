//Checks if a neighbor has no colors available
 public bool Forward_Checking(int region)
{
      List<Regions> neighbors = Regions_List[regions].GetNeighbors();
      for(int i=0;i<neighbors.Count();i++)
      {
           if(Regions_List[Find_Region(neighbors[i].GetRegionName())].PossibleColors()==0)
           {
                 return false;
           }
      }
      return true;
}
