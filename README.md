# ass3

Two games:
1 prefarb triggers - improve of the prefarb triggers of the class when there no side,so when a spaceship reaches some boundary so it appears on the other side.
2 Laser battle - A game where two objects represent two players, the objects are able to move left and right and shoot directly.
All game creations are detailed in the game itself.

code:
prefarb triggers:
Every time the spaceship collides with one of the sides using the collider then it is transferred to the other side -
public class SideCollision : MonoBehaviour {
    private void Start() {
        Debug.Log("Start SideCollision on "+this.name);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Collider2D other = collision.collider;
        Debug.Log(this.name + " Collision 2D with " + other.name + " tag=" + other.tag);

        if(collision.gameObject.name == "LeftWall"){
            Debug.Log("Leftwalll");
            transform.position = new Vector3(9.216325f, transform.position.y, 0);
        }

        if(collision.gameObject.name == "RightWall"){
            Debug.Log("Rightwalll");
            transform.position = new Vector3(-8.894714f, transform.position.y, 0);
        }
    }
}
Lasser battle:
Spawning a new object
public class ClickSpawner: MonoBehaviour {
    [SerializeField] protected InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject = new Vector3(0,15f,0);

    void OnEnable()  {
        spawnAction.Enable();
    }

    void OnDisable()  {
        spawnAction.Disable();
    }

    protected virtual GameObject spawnObject() {
        Debug.Log("Spawning a new object");

        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover) {
            if(gameObject.name == "Gunu"){
                newObjectMover.SetVelocity(new Vector3(0,-10f,0));
            }
            else
            {newObjectMover.SetVelocity(new Vector3(0,10f,0));}
        }

        return newObject;
    }
    
    private void Update() {
        if (spawnAction.WasPressedThisFrame()) {
            spawnObject();
        }
    }
}
collision

public class CollisionTest : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        Body b = other.GetComponent<Body>();
        b.AddDamage();
    
    }
}





links to itch game:
Laser battle - https://yoyo1516.itch.io/laser-bat

prefab triggers - https://yoyo1516.itch.io/p

enjoy:)
