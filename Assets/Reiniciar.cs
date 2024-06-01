using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;


public class Reiniciar : MonoBehaviour
{
    public void Onclicbotonreiniciar()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1");
    }
}
