

public interface IEnemy 
{
    public float HP { get; set; }
    public float Damage { get; set; }

    public void Move();
    public void DestroyAsteroid();
    public void GetDamage();
    public void TakeDamage(float damage);


}
