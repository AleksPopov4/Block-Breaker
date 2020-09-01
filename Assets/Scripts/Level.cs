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
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
