using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutStrategyBy3D : CutStrategyBase, ICutStrategy
{
    public CutStrategyBy3D(GameModel gameModel) : base(gameModel)
    {
    }

    public void StrategyExecution(Vector3 space, int particleSize)
    {

    }

    public void CuttingSpaceVisualization()
    {
#if DEBUG
#endif
    }
}
