using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpaceManagementSystem
{
    public static void RoughCutSpace(this SpaceManagmentComponent self)
    {
        Vector3 spaceSize = self.space.bounds.size;  //width = x, height = y, depth = z
        ICutStrategy strategy = null;

        switch(self.gameModel)
        {
            case GameModel.TwoD:
                strategy = new CutStrategyBy2D(self.gameModel);
                break;
            case GameModel.ThreeD:
                strategy = new CutStrategyBy3D(self.gameModel);
                break;
        }
    }
}
