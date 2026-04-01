using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
public class NodeOfHorde
{
    [Range(10, 30)]
    public int life;
    public int Str;
    public List<Color> Colors = new List<Color>() { Color.black, Color.red, Color.blue };
    public List<string> EnemyNames = new List<string>() { "Bica", "Trica", "Func" , "Vectores" , "Lambda" };
    public int Quantity =5;
}
