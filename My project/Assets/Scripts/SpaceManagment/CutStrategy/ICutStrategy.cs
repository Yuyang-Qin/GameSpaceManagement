using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �и���Խӿ�
/// </summary>
public interface ICutStrategy
{
    /// <summary>
    /// ����ִ��
    /// </summary>
    /// <param name="particleSize"></param>
    public void StrategyExecution(Vector3 spaceSize,int particleSize);
    /// <summary>
    /// �и�ռ���ӻ�
    /// </summary>
    public void CuttingSpaceVisualization();
}
