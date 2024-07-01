using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    //даная функция открывает сцену по введеному индексу
    public void OpenNewScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
