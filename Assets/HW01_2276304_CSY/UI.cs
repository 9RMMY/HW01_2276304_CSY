using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void OnClick_LoadScene(){
      SceneManager.LoadScene(0);
    }

}


