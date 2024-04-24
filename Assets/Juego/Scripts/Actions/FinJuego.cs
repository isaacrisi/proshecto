using JetBrains.Annotations;
using MoreMountains.Tools;
using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJuego : MonoBehaviour
{
    //GameManager gameManager = new GameManager();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.CurrentLives <=0)
        {
            MMSceneLoadingManager.LoadScene("GameOver");
        }
    }
}
