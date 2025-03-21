using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//메소드의 예
public class Calculator
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }
    
}


/*메소드의 장점
 *동일한 코드 반복 작성 필요 x 

private void Awake()
{
    //메소드의 이름을 불러 사용
    Multiple(3, 4);
    Multiple(5, 6);
    Multiple(7, 8);
}

//num1과 num2의 곱을 정의하는 메소드 정의
public void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
*/




/*메소드의 반환
 * return을 호출해 메소드를 종료하고 내부에서 변환된 데이터를 반환 
private void Awake()
{
    int a = Max(10, 20);   //반환된 데이터를 변수에 저장
    Debug.Log(Max(100, 200));  //별도의 변수 없이 반환된 데이터를 바로 사용 가능
    Max(50, 100);    //반환된 데이터를 꼭 받지 않아도 됨
}

public int Max(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

public void Divide(int num1, int num2)
{
    if (num2 == 0)
    {
        Debug.Log("나누려는 값이 0이기 때문에 프로그램 종료");
        return;   //메소드 종료
    }
    float result = num1 / num2;
    Debug.Log($"{num1} / {num2} = {result}");
}
*/




/*매개변수
 *메소드 내부에서 사용되는 지역변수
 *메소드 외부에서 내부로 데이터 전달 
 *메소드의 활용성 증가

public void Awake()
{
    int a = 3 ,b = 4;
    Add(a, b);   //메소드 호출 시 매개변수로 a, b 전달
}

public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}
*/




/*참조 예
private void Awake()
{
    int a = 3, b = 4;
    Debug.Log($"a={a}, b = {b}");
    Swap(ref a, ref b);
    Debug.Log($"a={a}, b = {b}");
}

pubilc void Swap(ref int num1, ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
Debug.Log($"num1={num1}, num2 = {num2}");
}
*/



/* //출력 전용 매개 변수 ref
 * 2개 이상의 결과를 반환  
private void Awake()
{
    int a = 5, b = 4, result1 = 0, result2 = 0;
    Divide(a, b, ref result1, ref result2);
    Debug.Log($"몫 = {result}, 나머지 = {result2}")
}

public void Divide(int num1, int num2, ref int result1, ref int result2)
{
    result1 = num1 / num2;
    result2 = num1 % num2;
}
*/

/* //출력 전용 매개 변수 out(권장)  
private void Awake()
{
    int a = 5, b = 4, result1 = 0, result2 = 0;
    Divide(a, b, out result1, out result2);
    Debug.Log($"몫 = {result}, 나머지 = {result2}")
}

public void Divide(int num1, int num2, out int result1, out int result2)
{
    result1 = num1 / num2;
    result2 = num1 % num2;
}
*/



/* //메소드 오버로딩 
 * 동일한 메소드 이름으로 여러 메소드 구현 
public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}

public void Add(float num1, float num2)
{
    float result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}
*/




/* //가변길이 매개변수 params
 * 변수의 길이가 다른 메소드가 많이 필요한 경우(형식은 같아야 함) 

public class week2_study_method : MonoBehaviour
{
    public void Sum(params int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        Debug.Log($"합계 = {sum}");
    }
    void Start()
    {
        Sum(1, 2, 3, 4, 5);
        Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
    }
}
*/


/* //명명된 매개변수 
 * 순서 상관 없이 변수 이름에 근거해 데이터 할당 */
public class week2_study : MonoBehaviour
{
    public void Player(string ID, int health)
    {
        Debug.Log($"ID = {ID}, HP = {health}");
    }
    void Start()
    {
        Player("이름", 100);  //일반적인 매개 변수
        Player(ID: "이름", health: 100);  //명명된 매개 변수
        Player(health: 100, ID: "이름");  //순서 바뀌어도 작동
    }
}


/* //선택적 매개변수
 * 매개변수에 기본값 설정 가능
 * 항상 필수 매개변수 뒤에 와야 함 
public class week2_study : MonoBehaviour
{
    public void Player(string ID, int health = 1000)
    {
        Debug.Log($"ID = {ID}, HP = {health}");
    }
    void Start()
    {
        Player("이름");  //기본값 사용
        Player("이름", 3000);  //기본값 
    }
}
*/





/* //클래스의 예
public class Player : MonoBehaviour
{
    private string ID = "이름";
    private int currentHP = 1000;//멤버 변수

    public void TakeDamage(int damage) //멤버 함수(메소드)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
*/


/* //접근 지정자의 예 
public class Player : MonoBehaviour
{
    public string ID = "이름";  //외부에서도 접근 가능
    private int currentHP = 1000;  //클래스 내부에서만 접근 가능


    void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
*/


/* //클래스의 이용 
public class Player
{
    public string ID = "이름";
    private int currentHP = 1000;

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
public class Enemy
{ 
    private Player = player;

    private void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}
*/


/* //클래스 객체 생성 
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player01.TakeDamage(100);
        player02.TakeDamage(200); //에러 발생
    }
}
*/
/* //생성자 
public class Player
{
    public string ID;
    public int currentHP;

    public Player()
    {
        ID = "이름";
        currentHP = 1000;
    }
}
public class GameController : MonoBehaviour
{
    public Player player01;

    private void Awake()
    {
        player01 = new Player();//new로 생성자 호출
    }
}
*/
/* //생성자 오버로딩
public class Player
{
  public string ID;
    public int currentHP;

    public Player()
    {
        ID = "이름";
        currentHP = 1000;
    }
    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("유니티", 10);
    }
}
*/
/* //소멸자
public class Player
{
    public string ID;
    public int health;

    ~Player()
    {
        //c#에서는 소멸자를 사용 x
    }
}
*/



/* //얕은 복사
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("이름", 1000);
        player02 = player01; //얕은 복사
        player02.ID = "유니티";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");//둘 다 유니티 출력
    }
}
*/
/* //깊은 복사
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("이름", 1000);

        player02 = player01.DeepCopy;
        player02.ID = "유니티";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");//이름, 유니티 출력
    }
}

public class Player
{
    public string ID;
    public int currentHP;


    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
}
*/

/* //this 키워드
 * 클래스 내부에서 자기 자신의 변수나 메소드에 접근할 때 사용
public class Player
{
    public string ID = "이름"; //클래스 멤버 변수

    public SetID(string ID) //지역변수
    {
        Debug.Log($"ID : {ID}"); //지역변수를 지칭
        Debug.Log($"ID : {this.ID}"); //클래스 멤버 변수를 지칭
    }
}
public class Player
{
    private string ID;
    private int currentHP;
    private int currentMP;

    public Player() // 1) 생성자
    {
        ID = "이름";
    }
    public Player(int hp): this() // 1) this()로 다른 생성자 호출, 2) 생성자
    {
        currentHP = hp;
    }
    public Player(int hp, int mp): this(hp) // 2) this(hp)로 다른 생성자 호출
    {
        currentMP = mp;
    }
}
*/






/* //정보 은닉과 캡슐화 예
 * 일반적으로 변수명 앞 Set, Get붙여 메소드 명으로
public class Player
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        player.CurrentHP = 100; // private 멤버 변수 접근 불가
        Debug.Log($"HP : Player.currentHP");

        player.SetCurrentHP(100);
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
}
*/

/* //상속의 예
public class Entity //기반 클래스
{
    public string ID;
    public int currentHP;

    public void Initialize();
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}
public class Player : Entity //파생 클래스
{
    public Player(string id, int hp)
    {
        ID - id;
        currentHP = hp;
        RecoveryHP(100);


        Initialize(); //private이므로 접근 불가
    }
}
*/

/* //base 키워드
 * 기반 클래스의 변수, 메소드 접근
public class Entity
{
    public sring ID;        //기반 클래스의 ID
    protected int currentHP;
}
public class Player : Entity
{
    private string ID;      //파생 클래스의 ID

    public Player(string id, int hp)
    {
        base.ID = "Noname"; //기반 클래스의 ID에 접근
        ID = id;            //파생 클래스의 ID에 접근
        currentHP = hp;
    }

/* // 참조 변수 형식과 메모리 할당 형식에 따른 사용 가능 멤버
public class Entity
{
    public void Attack;
    {
        Debug.Log("적을 공격한다.");
    }
    public void Heal()
    {
        Debug.Log("체력을 회복한다.");
    }
}
public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("도망가자!!");
    }
    public void Heal();
    {
        Debug.Log("고블린의 체력 회복!");
    }
}
//사용 가능 멤버
private Entitiy entity = new Entity();
{
    Attack();
    Heal();
}
private Goblin goblin = new Goblin();
{
    Attack();
    Avoid();
    Heal(); //Goblin의 Heal() 호출
}
private Entity entity = new Goblin();
{
    Attack();
    Heal(); //Entity의 Heal() 호출
}
*/



/* //다형성2(메소드 오버라이딩)
public class Entity
{
    public virtual void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
}
public class GameController
{
    private Slime slime;
    private Goblin goblin;

    private void Awake()
    {
        slime.Attack();
        goblin.Attack();
    }
}
public class Slime : Entity
{
    public override void Attack()
    {
        Debug.Log("슬라임의 공격"); //출력
    }
}
public class Goblin : Entity
{
    public override void Attack()
    {
        Debug.Log("고블린의 공격"); //출력
    }
}
*/

/* //is as 연산자 예
public class Entity
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
}
public class Slime : Entity
{
}
public class Goblin : Entity
{
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Entity entity = new Slime();
        if (entity is Slime)
        {
            Debug.Log("Entity type is Slime");
        }

        Goblin goblin = entity as Goblin;
        if (goblin == null)
        {
            Debug.Log("goblin is null");
        }
    }
}
*/


/* //추상 클래스 예
public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target); //추상 메소드
    public void TakeDamage(int damage)
    {
        if currentHP > damage
        {
            currentHP -= damage;
            Debug.Log($"체력이 {damage}감소");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}
public class Goblin : Entity
{
    public Goblin(int damage, int hp)
    {
        base.damage = damage;//변수명 같으므로 base 필요
        currentHP = hp;
    }

    public override void Attack(Entity target)
    {
        Debug.Log("고블린의 공격!");
        target.TakeDamage(damage);
    }
}
public class Slime : Entity
{
    public Slime(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }
    public override void Attack(Entity target)
    {
        Debug.Log("슬라임의 공격!");
        target.TakeDamage(damage);
    }
}
*/

/* //인터페이스 예
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}
public class Slime : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 기어서 이동");
    }
}
public class Butterfly : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 날아서 이동");
    }
}
public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IMovingEntity slime;
    private IMovingEntity butterfly;

    private void Awake()
    {
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();

        goblin.MoveTo(new Vector3(1, 2, 3));
        slime.MoveTo(new Vector3(4, 5, 6));
        butterfly.MoveTo(new Vector3(7, 8, 9));
    }
}
*/

/* //매개변수가 인터페이스 타입
 * 메소드 호출 시 인터페이스를 구현한 클래스의 인스턴스를 매개변수로 제공
public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private void Awake()
    {
        goblin = new Goblin();
        Method(goblin);
    }

    public void Method(IMovingEntity entity)
    {
    }
}
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}
*/
/* //반환타입이 인터페이스 타입
 * 메소드가 해당 인터페이스를 구현한 클래스의 인스턴스를 반환
public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;

    private void Awake()
    {
        goblin = Method();
    }

    public IMovingEntity Method()
    {
        Goblin goblin = new Goblin();

        return Goblin();
    }
}
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}
*/

/* //인터페이스를 상속하는 인터페이스 예
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}
interface IPerson : IMovingEntity
{
    void Talk(string word);
}

public class Goblin : IMovingEntity //IMocingEntity 상속, MoveTo 구현
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}

public class Player : IPerson //IPerson 상속, MoveTo, Talk 구현
{
    private string ID = "이름";

    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{ID}님이 {destination}으로 이동");
    }

    public void Talk(string word)
    {
        Debug.Log($"{ID} : {word}");
    }
}

public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IPerson player;

    private void Awake()
    {
        goblin = new Goblin();
        player = new Player();

        goblin.MoveTo(new Vector3(1, 2, 3));
        player.MoveTo(new Vector3(4, 5, 6));
        player.Talk("안녕하세요");
    }
}
*/


/* //인터페이스의 다중 상속
interface IMovingEntity
{
    void Move(Vector3 destination);
}

interface ICombatEntity
{
    void Attack(Entity target);
}

public class Player : IMovingEntity, ICombatEntity
{
    public void Move(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }

    public void Attack(Entity target)
    {
        Debug.Log($"{target}을 공격합니다.");
    }
}
*/

/* //상속이 아닌 방법으로 다른 클래스의 기능 사용
 * 클래스는 다중 상속 불가능
public class Player
{
    private Berserker berserker;
    private Archer archer;

    private void Awake()
    {
        berserker = new Berserker();
        archer = new Archer();
    }

    public void SwordAttack() {berserker.Sword(); }
    public void ArrowAttack() { archer.Arrow(); }
}
*/








/* //메소드 숨기기 예
public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}
public class Child : Parent
{
    public new void Method01()
    {
        Debug.Log("Child");
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Child c = new Child(); //자식 메소드
        c.Method01();

        Parent pc = new Child(); //부모 메소드
        pc.Method01();
    }
}
*/

/* //오버라이딩 봉인하기
 * 메소드를 오버라이딩   
public class Entity
{
    public virtual void AttackDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}
public class MovingEntity : Entity
{
    public override void AttackDamage(int damage) //sealed 키워드 추가시 오류 발생
    {
        Debug.Log($"gEntity : {damage}만큼 체력 감소");
    }
}
public class Player : MovingEntity
{
    public override void AttackDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}
*/


/* //중첩 클래스
public class OuterClass
{
    public class InnerClass
    {
    }
}
*/
/* //분할 클래스
//파일1
public partial class Player
{
    public void CounterAttack()
}
//파일2
public partial class Player
{
    public void TakeDamage(int damage)
    {
        //체력 감소
        CounterAttack(); //같은 클래스이므로 호출 가능
}
*/

/* //구조체 예
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Stats player01 = new Stats();
        Stats player02; //구조체 변수에 new를 붙이지 않으면 직접 초기화 필요

        player02.ID = "이름";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"ID : {player01.ID}, 체력 : {player01.currentHP}, 공격력 : {player01.damage}");
        Debug.Log($"ID : {player02.ID}, 체력 : {player02.currentHP}, 공격력 : {player02.damage}");
    }
}
public struct Stats
{
    public string ID;
    public int currentHP;
    public int damage;
}
*/

/* //튜플 예
var a = ("이름", 20);
Debug.Log($"{a.Item1}, {a.Item2}");
 */



/* //정적 메소드 예
public class Enemy
{
    public int InstanceRun() {return 1;} //인스턴스 메소드

    public static int StaticRun() //정적 메소드
    {
        InstanceRun(); //정적 메소드에서 인스턴스 메소드 호출 불가능
        return 1;
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        int j = Enemy.StaticRun();//정적 메소드 호출

        Enemy enemy01 = new Enemy();
        int i = enemy01.InstanceRun();//인스턴스 메소드 호출

        enemy01.StaticRun(); //인스턴스로 정적 메소드 호출 불가능
    }
}
*/

/* //정적 변수 예
public class Enemy
{
    public int numeric; //인스턴스 변수
    public static string species; //정적 변수
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Enemy enemy01 = new Enemy(); //인스턴스 변수 사용
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        Enemy.species = "고블린"; //정적 변수 사용
        Debug.Log(Enemy.species);
    }
}
*/

/* //정적 클래스
public static class Calculator
{
    public static int num;

    static Calculator()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
public class GameController
{
    private void Awake()
    {
        Debug.Log(Calculator.Sum(20, 55)); //정적 클래스의 메소드 호출  
        Debug.Log(Calculator.num); //정적 클래스의 변수 호출
    }
}
*/


/* //확장 메소드 예
public static class StringExtension //string 클래스에 확장 메소드 추가하는 예제
{
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}
public class GameController : MonoBehaviour
{
    private void Awake()
    {
        string str = "안녕하세요.";
        str.PrintData(); //확장 메소드 호출
    }
}
*/


/* //이름공간 예
namespace MySpace //이름공간 선언
{
    public class Player
    {
        //변수, 메소드
    }
}
namespace YourSpace //이름공간 선언
{
    public class Player
    {
        //변수, 메소드
    }
}
using MySpace; //이름공간의 클래스, 구조체 사용

public class GameController
{
    private void Awake()
    {
        Player player01; //MySpace의 Player 클래스 사용
        YourSpace.Player player02 //YourSpace의 Player 클래스 사용
    }
}
*/




/* //멤버 변수의 은닉성을 위해 Get, Set 멤버 함수 사용
public class Player
{
    private int currentHP;
    private int GetCurrentHP() { return currentHP; }
    private int SetCurrentHP(int hp) { currentHP = hp; }
}
public class GameControlle
{
    private void Awake()
    {
        Player player = new Player();
        player.SetCurrentHP(100);
        Debug.Log($"Player HP : {player.GetCurrentHP()});
    }
}
*/


/* //프로퍼티 선언
//get 접근자는 멤버 변수로부터 값 읽기
//set 접근자는 멤버 변수에 값 할당
//set 접근자 안의 value 키워드는 set 접근자의 암묵적 매개변수
pubic class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
        set
        {
            if (currentHP > 0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
    }
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.CurrentHP = 100;
        Debug.Log($"Player HP : {player.CurrentHP}");
        player.CurrentHP = -100;
        Debug.Log($"Player HP : {player.CurrentHP}");
    }
}
*/

/* //자동 구현 프로퍼티 예
public class Player
{
    public int CurrentHP
    {
        get; set; 
    }
    public string ID
    {
        get; set;
    }
}
public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.ID = "이름";
        player.CurrentHP = 100;
        Debug.Log($"{player.ID} : {player.CurrentHP}");
    }
}
*/

/* //읽기 전용 프로퍼티
pubilc class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
    }
}
*/
/* //쓰기 전용 프로퍼티
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        set => currentHP = value;
    }
}
*/

/* //private 접근지정자로 현재 클래스 내부에서만 get, set 프로퍼티 사용 가능하도록 설정
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        private set => currentHP = value;
       get => currentHP;
    }
}
public class Player
{
    pubilc int CurrentHP
    {
        private set; get;
    }
*/


/* //인터페이스  프로퍼티 예
interface IBaseEnity
{
    strinf ID { get; set; }
    int damage { get; set; }
    int CurrentHP { get; set; }
}
public class Player : IBaseObject
{
    private string id;
    public string ID
    {
        get => id;
        set => id = value;
    }
    public int Damage
    {
        get; set; 
    }
    public int CurrentHP
    {
        get; set;
    }
}
*/


/* //추상 클래스 프로퍼티 예
public abstract class BaseEntity
{
    abstract public int Shield
    {
        get; set;
    }
    public int Defense
    {
        get; set;
    }
}
public class Player : BaseEntity
{
    public override int Shield
    {
        get; set;
    }
    public int ID
    {
        get; set;
    }
}

pubic class GameController
{
    private void Awake()
    {
        Player player = new Player();
        {
            player.ID = "이름";
            player.Shield = 50;
            player.Defense = 10;
        };

        Debug.Log($"ID : {player.ID}");
        Debug.Log($"방어력 : {player.Defense}, 방어막 : {player.Shield}");
    }
}
*/