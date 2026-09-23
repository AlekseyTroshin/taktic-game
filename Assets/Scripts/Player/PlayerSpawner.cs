using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _prefabPlayer;
    
    private List<PlayerData> _playersData;
    
    private void Start()
    {
        _playersData = new List<PlayerData>();
        _playersData.Add(new PlayerData(new Vector2(3, -1), ColorPlayer.Red));
        _playersData.Add(new PlayerData(new Vector2(2, -2), ColorPlayer.Blue));
        _playersData.Add(new PlayerData(new Vector2(0, -3), ColorPlayer.Green));


        foreach(PlayerData pd in _playersData)
        {
            Vector3 position = pd._cellPosition;

            GameObject player = Instantiate(_prefabPlayer, position, Quaternion.identity);
			player.GetComponent<Player>().Initialize(pd);
        }


    }

}
