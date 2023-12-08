# 코드 샘플

```csharp
public class Stage3GimmickManager : MonoBehaviour
{
    public virtual void MovingParentObjectWithVelocity(GameObject obj, float x, float y, float z)
    {
        if (obj != null)
        {
            obj.transform.parent.GetComponent<Rigidbody>().isKinematic = false;
            obj.transform.parent.GetComponent<Rigidbody>().velocity = new Vector3(x, y, z);
        }
        if (obj != null && x == 0 && y == 0 && z == 0)
            obj.transform.parent.GetComponent<Rigidbody>().isKinematic = true;
    }
}
```
```csharp
public class PressBtn : MonoBehaviour
{
    public GameObject btn;
    public float xdir;
    public float ydir;
    public float zdir;

    [SerializeField] private GameObject _gimmickForObject;
    private void OnTriggerStay(Collider other)
    {
        ForceReceiver forceReceiver = other.gameObject.GetComponent<ForceReceiver>();
        
        if (forceReceiver != null && other.CompareTag("Player"))
        {
            _gimmickForObject.GetComponent<Stage3GimmickManager>().MovingParentObjectWithVelocity(btn, xdir, ydir, zdir);
            other.gameObject.transform.SetParent(btn.transform.parent);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other != null && other.CompareTag("Player"))
        {
            _gimmickForObject.GetComponent<Stage3GimmickManager>().MovingParentObjectWithVelocity(btn, 0, 0, 0);
            other.gameObject.transform.SetParent(null);
        }
    }
}
```
```csharp
public class Wind : MonoBehaviour
{
    public float xdir;
    public float ydir;
    public float zdir;
    public float windpower;

    public bool useForce;
    public bool useVelocity;
    private void OnTriggerStay(Collider other)
    {
        ForceReceiver forceReceiver = other.gameObject.GetComponent<ForceReceiver>();
        if (useForce)
        {
            if (forceReceiver != null)
                forceReceiver.StartGimmick(Gimmicks.AddForce, other.attachedRigidbody, xdir, ydir, zdir, windpower);
        }
        else if (useVelocity)
        {
            if (forceReceiver != null)
                forceReceiver.StartGimmick(Gimmicks.AddVelocity, other.attachedRigidbody, xdir, ydir, zdir, 0);
        }
        else return;
    }
}
```
