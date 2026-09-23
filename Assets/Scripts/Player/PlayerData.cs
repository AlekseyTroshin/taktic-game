using UnityEngine;

public class PlayerData
{

    public ColorPlayer _color;
    public Vector2 _cellPosition;  

    public PlayerData(Vector2 cellPosition, ColorPlayer color)
    {
        _cellPosition = cellPosition;
        _color = color;
    }

}

public enum ColorPlayer
{
    Red,
    Blue,
    Green
}