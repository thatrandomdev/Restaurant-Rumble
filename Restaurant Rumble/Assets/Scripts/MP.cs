using UnityEngine;
using UnityEngine.InputSystem;
public class MP : MonoBehaviour
{
    public Transform[] SpawnPoints;
    private int m_playerCount;

    public void OnPlayerJoined(PlayerInput playerInput)
    {
        playerInput.transform.position = SpawnPoints[m_playerCount].transform.position;

        m_playerCount++;
    }
}
