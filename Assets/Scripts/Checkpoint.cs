using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Checkpoint : MonoBehaviour
{
    public GameObject currentLevel;
    public GameObject nextLevel;

    void OnMouseOver()
    {
        currentLevel.SetActive(false);
        nextLevel.SetActive(true);
    }
}
