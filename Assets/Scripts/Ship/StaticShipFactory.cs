using UnityEngine;

public class StaticShipFactory : MonoBehaviour
{

    public static SpaceShip CreateShip(int shipNumber)
    {
        switch (shipNumber)
        {
            case 1:
                return new SpaceShipOne();
            case 2:
                return new SpaceShipTwo();
            case 3:
                return new SpaceShipThree();
            case 4:
                return new SpaceShipFour();
            default:
                Debug.Log("Max ship Level");
                return null;
        }
    }
}
