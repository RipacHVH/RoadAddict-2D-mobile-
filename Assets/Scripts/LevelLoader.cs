using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject Case;
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public float progress = 0;
    

    private void Start()
    {
        StartCoroutine(LoadAsynchronously());
    }
    
    IEnumerator LoadAsynchronously()
    {
        

        loadingScreen.SetActive(true);

        while (progress <= 100)
        {

            progress += 2;
            yield return new WaitForSeconds(0.001f);
            slider.value = progress/100f;
            progressText.text = progress + "%";
            yield return null;
        }
        loadingScreen.SetActive(false);
        Case.SetActive(false);

    }



}
