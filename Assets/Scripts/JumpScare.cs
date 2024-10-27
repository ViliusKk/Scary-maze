using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScare : MonoBehaviour
{
    public GameObject currentLevel;
    public GameObject picture;

    void OnMouseOver()
    {
        picture.SetActive(true);
        currentLevel.SetActive(false);
    }
}
