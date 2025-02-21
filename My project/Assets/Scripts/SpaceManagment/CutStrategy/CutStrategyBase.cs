using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutStrategyBase
{
    protected SpaceTree _spaceTree = null;

    public CutStrategyBase(GameModel gameModel)
    {
        switch(gameModel)
        {
            case GameModel.TwoD:
                _spaceTree = new SpaceTree(4);
                break;
            case GameModel.ThreeD:
                _spaceTree = new SpaceTree(8);
                break;
        }
    }
}
