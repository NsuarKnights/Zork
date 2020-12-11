using UnityEngine;
using Zork;

public class GameManager : MonoBehaviour
{

    public string ZorkFilename = @"Assets\Zork.json";
    public UnityOutputService OutputService;

    // Start is called before the first frame update
    void Start()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);

        Game.Start(gameJsonAsset.text, OutputService);
    }

    // Update is called once per frame
    void Update()
    {

    }

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    //[SerializeField]
    //private UnityOutputService Output;

}