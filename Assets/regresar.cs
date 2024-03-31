using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class regresar : MonoBehaviour
{
    public void Onclicbotonregresar()
    {
        MMSceneLoadingManager.LoadScene("MenuPrincipal");
    }
}
