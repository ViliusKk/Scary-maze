using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public List<GameObject> levels;
    public GameObject player;

    void Start()
    {
        for (int i = 0; i < levels.Count; i++)
        {
            levels[i].SetActive(false);
        }
        player.SetActive(false);
    }

    void OnMouseDown()
    {
        print("ok");
        transform.gameObject.SetActive(false);
        levels[0].SetActive(true);
        player.SetActive(true);
    }
}
