using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    [SerializeField] Transform Hand;

    private void Awake()
    {
        transform.SetParent(Hand);
    }
}
