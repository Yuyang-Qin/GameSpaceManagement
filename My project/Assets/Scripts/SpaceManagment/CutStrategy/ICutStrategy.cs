using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 切割策略接口
/// </summary>
public interface ICutStrategy
{
    /// <summary>
    /// 策略执行
    /// </summary>
    /// <param name="particleSize"></param>
    public void StrategyExecution(Vector3 spaceSize,int particleSize);
    /// <summary>
    /// 切割空间可视化
    /// </summary>
    public void CuttingSpaceVisualization();
}
