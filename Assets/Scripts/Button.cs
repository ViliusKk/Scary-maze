using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject firstLevel;
    public GameObject player;

    void Start()
    {
        firstLevel.SetActive(false);
        player.SetActive(false);
    }

    void OnMouseDown()
    {
        transform.gameObject.SetActive(false);
        firstLevel.SetActive(true);
        player.SetActive(true);
    }
}
