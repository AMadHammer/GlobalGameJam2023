using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class videoNavigateToNext : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneName);
    }
}
