using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    // Start is called before the first frame update
    public void countBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void deleteBlocks()
    {
        breakableBlocks--;
    }
}
