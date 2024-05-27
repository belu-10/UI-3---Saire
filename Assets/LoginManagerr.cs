using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoginManagerr : MonoBehaviour
{
    public InputField inputNombre;
    private string contra = "hola"; 

    public void BotonAceptar()
    {
        if (inputNombre.text == contra)
        {
            Debug.Log("Access granted");
        } 

        else
        {
            Debug.Log("Access denied"); 
        }
    }
}
