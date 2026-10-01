using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    private Player _selectedPlayer;

    public Player SelectedPlayer
    {
        get { return _selectedPlayer; }
        private set { _selectedPlayer = value; }
    }

    public void SetPlayer(Player player)
    {
          
        if (SelectedPlayer != null && object.ReferenceEquals(SelectedPlayer, player))
        {
            SelectedPlayer.HideBorder();
            SelectedPlayer = null;
        }
        else if (SelectedPlayer == null)
        {
            player.ShowBorder();
            SelectedPlayer = player;
        }
        else
        {
            SelectedPlayer.HideBorder();
            player.ShowBorder();
            SelectedPlayer = player;
        }

    }

}
