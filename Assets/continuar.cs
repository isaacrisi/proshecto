using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;


public class continuar : MonoBehaviour
{
    public void Onclicbotoncontinuar()
    {
        MMSceneLoadingManager.LoadScene("MenuPrincipal");
    }
}
