using UnityEngine;

public class MovementManager : MonoBehaviour
{

    public bool CanMove(Vector2 currentPosition, Vector2 targetPosition)
    {
        Vector2 result = targetPosition - currentPosition;
        float deltaX = Mathf.Abs(result.x);
        float deltaY = Mathf.Abs(result.y);

        if ((deltaX <= 1 && deltaY <= 1) && !(deltaX == 0 && deltaY == 0))
        {
            return true;
        }

        return false;
    }

    public void Move(Player player, Vector2 targetPosition)
    {
        float z = player.transform.position.z;
        player.transform.position = new Vector3(targetPosition.x, targetPosition.y, z);
        player.CellPosition = targetPosition;
    }

}