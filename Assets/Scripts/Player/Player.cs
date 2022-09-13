using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField] private float _hp;
    [SerializeField] private float _maxHP;
    [SerializeField] private float _pointForShipUpgrade;
    [SerializeField] private float _speed;
    [SerializeField] private float _acceleration;
    [SerializeField] private float offset = -90;
    [SerializeField] private float _currentPoint;
    private Vector3 _move;
    private Camera _camera;
    private Rigidbody2D _rb;
    
    public float PointForShipUpgrade 
    { 
        get => _pointForShipUpgrade; 
        set => _pointForShipUpgrade = value; 
    }
    public float CurrentPoint 
    { 
        get => _currentPoint; 
        set => _currentPoint = value; 
    }

    void Start()
    {        
        _camera = Camera.main;
        _rb = GetComponent<Rigidbody2D>();      
        
    }

    
    void Update()
    {
        var direction = _camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
        Rotation(direction);
        Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);
        AccelerationControl();       
    }
    //private void FixedUpdate()
    //{
    //    _rb.MovePosition(_rb.position + _move * Time.fixedDeltaTime);
    //}
    

    private void Move(float horizontal, float vertical, float deltaTime)
    {
        var speed = deltaTime * _speed;
        //Vector2 moveInput = new Vector2(horizontal, vertical);
        //_move = moveInput.normalized * _speed;
        _move.Set(horizontal * speed, vertical * speed, 0.0f);
        transform.position += _move;
        //transform.position = transform.position + transform.forward + _move;
    }

    public void Rotation(Vector3 direction)
    {
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Euler(0f, 0f, angle + offset);
    }

    public void AccelerationControl()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            AddAcceleration();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            RemoveAcceleration();
        }
    }

    public void AddParametrs(float hp, float maxHP, float pointForShipUpgrade, float speed, float acceleration)
    {
        _hp = hp;
        _maxHP = maxHP;
        _pointForShipUpgrade = pointForShipUpgrade;
        _speed = speed;
        _acceleration = acceleration;

    }
    public void AddAcceleration()
    {
        _speed += _acceleration;
    }

    public void RemoveAcceleration()
    {
        _speed -= _acceleration;
    }
}
