using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//格子信息
public class Tile{

    public int X;
    public int Y;
    public bool CanHold;   //这个格子是否可以放塔
    public object Data;

    public Tile(int x,int y) 
    {
        this.X = x;
        this.Y = y;
    }
}
