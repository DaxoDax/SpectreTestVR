using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    public OVROverlay overlayBackground;
    public OVROverlay overlayLoadingText;

    [SerializeField] private float numberOfSeconds = 3f;
    [SerializeField] private float distanceFromThePlayer = 3f; 


    
    public void LoadScene(string sceneName)
    {
        StartCoroutine(ShowOverlayAndLoad(sceneName));
    }


    IEnumerator ShowOverlayAndLoad(string sceneName)
    {
        overlayBackground.enabled = true;
        overlayLoadingText.enabled = true;

        //Putting overlay loading text 3 meters forward when it's loading
        GameObject centerEyeAnchor = GameObject.Find("CenterEyeAnchor");
        overlayLoadingText.gameObject.transform.position = centerEyeAnchor.transform.position + new Vector3(0f, 0f, distanceFromThePlayer);

        //Waiting specified number of seconds to prevent "pop" to new scene
        yield return new WaitForSeconds(numberOfSeconds);

        //Loading scene and waiting until it's complete
        AsyncOperation asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);

        while(!asyncLoad.isDone)
        {
            yield return null;
        }

        //Disable the overlays because loading is over

        overlayBackground.enabled = false;
        overlayLoadingText.enabled = false;

        yield return null;
    }
}
