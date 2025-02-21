using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManagmentComponent : MonoBehaviour
{
    public GameModel gameModel;
    public Renderer space;
    public int particleSize = 1;

    private void Awake()
    {
        if(space == null)
        {
            Debug.LogError("Space Management Component don't has space");
            this.enabled = false;
        }

        this.RoughCutSpace();
    }
}
