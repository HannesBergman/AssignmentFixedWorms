using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScopeHolder : MonoBehaviour
{
    [SerializeField] Transform sniper;

    private void Awake()
    {
        transform.SetParent(sniper);
    }
}
