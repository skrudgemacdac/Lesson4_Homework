using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;
    private GameObject playerCharacter;
    private SpawnPoint spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCharacter();
    }

    public void SpawnCharacter()
    {
        if (!isServer)
        {
            return;
        }
        playerCharacter = Instantiate(playerPrefab);
        NetworkServer.SpawnWithClientAuthority(playerCharacter,
        connectionToClient);
        spawnPoint.GetRandomSpawnPoint();
    }
}
