using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class SceneSwitcher : MonoBehaviour ,IPointerClickHandler
{
    // Start is called before the first frame update
    [SerializeField] int sceneIndex;

    public void OnPointerClick(PointerEventData eventData)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneIndex);
    }
}
