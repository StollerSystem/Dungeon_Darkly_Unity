using System;
using System.Collections;
using System.Collections.Generic;

namespace Dungeon_Darkly
{
  public class Container : Item
  {
    public string Type { get; set; }
    public List<Item> Contents { get; set; }
    public int Capacity { get; set; }  

    public Container (string type, int capacity, string name,int id,int worth,int hp,int level,List<string> properties,List<string> flags,string rarity) : base(name,id,worth,hp,level,properties,flags,rarity)
    {
      this.Type = type;
      this.Contents = new List<Item>();
      this.Capacity = capacity;
    }
  }
}