using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    private Player _selectedPlayer;

    public void SetPlayer(Player player)
    {
          
        if (_selectedPlayer != null && !object.ReferenceEquals(_selectedPlayer, player))
        {
            _selectedPlayer.HideBorder();
            player.ShowBorder();
        }

        if (_selectedPlayer == null)
        {
            player.ShowBorder();
        }

        _selectedPlayer = player;
        
    }

}
