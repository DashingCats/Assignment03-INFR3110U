using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceStoneCommand : ICommand
{
    Vector3 position;
    Transform stone;

    public PlaceStoneCommand(Vector3 position, Transform stone)
    {
        this.position = position;
        this.stone = stone;
    }

    public void Execute()
    {
        StonePlacer.PlaceStone(position, stone);
    }

    public void Undo()
    {
        StonePlacer.RemoveStone(position);
    }

    public override string ToString()
    {
        return "PlaceStone:\t" + position.x + " , " + position.y + " , " + position.z;
    }
}
