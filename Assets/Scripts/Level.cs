using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] private int breakableBlocks; //Serialized for debugging purposes

    //cached reference
    private SceneLoader sceneLoader;

    public void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 4)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
