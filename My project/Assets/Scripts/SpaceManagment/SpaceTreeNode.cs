using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTreeNode
{
    public int depth = 1;
    public SpaceTreeNode[] children = null;

    public SpaceTreeNode(SpaceTreeNode parent,int forks)
    {
        children = new SpaceTreeNode[forks];
    }
}
