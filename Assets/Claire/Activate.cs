using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Activate : MonoBehaviour
{
    private Vector2 button = new Vector2(175, 50);
    public GameObject disolve, hologram, forceField;
    public GameObject orb, rainbow;
    public GameObject portal, sword;
    private void Start()
    {
        disolve.SetActive(false);
        hologram.SetActive(false);
        forceField.SetActive(false);

        orb.SetActive(false);
        rainbow.SetActive(false);
        
        portal.SetActive(false);
        sword.SetActive(false);
    }
    private void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 50, 50), "X")) Application.Quit();
        if (GUI.Button(new Rect(50, 125, button.x, button.y), "Disolve"))
        {
            disolve.SetActive(true);
            hologram.SetActive(false);
            forceField.SetActive(false);
            
            orb.SetActive(false);
            rainbow.SetActive(false);

            portal.SetActive(false);
            sword.SetActive(false);
        }
        if (GUI.Button(new Rect(50, 200, button.x, button.y), "Hologram"))
        {
            disolve.SetActive(false);
            hologram.SetActive(true);
            forceField.SetActive(false);

            orb.SetActive(false);
            rainbow.SetActive(false);

            portal.SetActive(false);
            sword.SetActive(false);
        }
        if (GUI.Button(new Rect(50, 275, button.x, button.y), "Force Field"))
        {
            disolve.SetActive(false);
            hologram.SetActive(false);
            forceField.SetActive(true);

            orb.SetActive(false);
            rainbow.SetActive(false);

            portal.SetActive(false);
            sword.SetActive(false);
        }
        if (GUI.Button(new Rect(50, 350, button.x, button.y), "Orb"))
        {
            disolve.SetActive(false);
            hologram.SetActive(false);
            forceField.SetActive(false);

            orb.SetActive(true);
            rainbow.SetActive(false);

            portal.SetActive(false);
            sword.SetActive(false);
        }
        if (GUI.Button(new Rect(50, 425, button.x, button.y), "Rainbow"))
        {
            disolve.SetActive(false);
            hologram.SetActive(false);
            forceField.SetActive(false);

            orb.SetActive(false);
            rainbow.SetActive(true);

            portal.SetActive(false);
            sword.SetActive(false);
        }
        if (GUI.Button(new Rect(50, 500, button.x, button.y), "Portal"))
        {
            disolve.SetActive(false);
            hologram.SetActive(false);
            forceField.SetActive(false);

            orb.SetActive(false);
            rainbow.SetActive(false);

            portal.SetActive(true);
            sword.SetActive(false);
        }
        if (GUI.Button(new Rect(50, 575, button.x, button.y), "Sword"))
        {
            disolve.SetActive(false);
            hologram.SetActive(false);
            forceField.SetActive(false);

            orb.SetActive(false);
            rainbow.SetActive(false);

            portal.SetActive(false);
            sword.SetActive(true);
        }
    }
}