using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Jugar : MonoBehaviour
{
    public void Onclicbotonjugar()
    {
        MMSceneLoadingManager.LoadScene("Nivel 1");
    }
}
