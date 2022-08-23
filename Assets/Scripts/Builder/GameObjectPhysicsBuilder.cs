using UnityEngine;

public sealed class GameObjectPhysicsBuilder : GameObjectBuilder
{
    public GameObjectPhysicsBuilder(GameObject gameObject) : base(gameObject) { }

    public GameObjectPhysicsBuilder BoxCollider2D()
    {
        GetOrAddComponent<BoxCollider2D>();
        return this;
    }

    public GameObjectPhysicsBuilder Rigidbody2D(float mass, bool simulated)
    {
        var component = GetOrAddComponent<Rigidbody2D>();
        component.mass = mass;
        component.simulated = true;
        component.bodyType = RigidbodyType2D.Kinematic;
        return this;
    }
    private T GetOrAddComponent<T>() where T : Component
    {
        var result = _gameObject.GetComponent<T>();
        if (!result)
        {
            result = _gameObject.AddComponent<T>();
        }
        return result;
    }
}
