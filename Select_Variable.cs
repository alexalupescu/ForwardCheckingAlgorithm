//Select a region from the list of regions
 public int Select_Variable()
 {
   int aux=0;
   for(int i=0;i<Regions_List.Count();++i)
     {
       if(!Regions_List[i].HasColor())
         {
             aux=i;
         }
     }
   return aux;
}
