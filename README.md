# Atents_231226
아텐츠 23/12/26 수업

https://github.com/go2665/Atents231226.git
------------------------------------
[h2] 내용 정리 [/h2]

깃에서 포크 - 쓰기권한 없는거에 푸시할려할때 뜬거
	브랜치 생성이랑 같다.

컴퓨터는 0과 1로만 대화한다.
	이걸 번역하는 언어가 어셈블리

c 가 로우와 하이 사이다

c#은 마소가 만듦

  자바에 가비지 컬렉팅이 있다. 
  c언어에선 일이 끝나면 메모리영역에서 다 시 돌려줘야됨 (메모리 해제 해야됨)
  일을 할 때 메모리를 할당을 해야된다.
  이걸 안돌려주면 컴퓨터를 껏다 키기 전까진 램에 계속 쌓인다. =  메모리 누수

  가비지 컬렉팅은 위를 자동으로 해준다. 대신 메모리를 full로 못 씀 (정확하게 원하는 만큼 원하는 시간에 못 써서 뭉탱이로 씀)

  
--------------------

비주얼 스튜디오에 프로젝트와 솔루션이 있다.
	솔루션은 무조건 하나 있다고 보면됨
 	실행파일은 있어야되니까

  
  c#콘솔앱으로 만든다.
  cmd 같은거

cpu가 다르면 다르게 만들어야되는건 말이안된다. 가상머신이 필요함
C#에선 .NET 이 자바의 가상머신이라고 보면 됨

실행파일은 bin 폴더에 있다 (바이너리의 약자)

컨트롤 + D를 이용하자

쉬프트 + delete 하면 한 줄 삭제

게임은 입력과 출력이 되야 한다.
Console.ReadLine(); 으로 입력이 가능



C#은 에러가 생기면 더더욱 반드시 수정
중간에 끊기면 그냥 스킵하고 다른걸로널어갈수 잇음( 당연한얘기)



----------------------------
~!@
----------------------------------
23-12-28 일자

홀짝 게임, 주사위 굴리기 만들기 --후반엔 콘솔 앱 텍스트 게임 제작

Random r = new Random(); 으로 랜덤 클래스 사용해서
int dice = r.Next(6) + 1 ; 로 1~6 까지의 값이 랜덤으로 나옴

switch문에서 default는 예외사항 처리할 때 쓴다.

---------------------
객체 지향 

클래스-
멤버 함수 - 메소드
멤버 변수 

객체지향의 원칙

        private float hp;
        public float HP
        {
            get => hp;
            private set
            {
                hp = value; 
                hp = Math.Clamp(value, 0, maxHp);

                //if(hp < 0 ) hp = 0;
                //if (hp > 0) hp = maxHp;

            }
        }
읽기는 되지만 쓰기는 외부에서 안되게 get, set 사용

const는 변경불가
        float exp;
        const float maxExp = 100; // 상수, 절대 변경불가

visual studio에서 f9 아니면 찍어서 멈추는 지점 정하고
f5 (실행) 하면 지정한 중단점에서 멈춘다. 그리고 자동 탭에서 현재 인스턴스화된 클래스 내 변수 확인가능하다.
여기서 f10누르면 다음 중단점으로 넘어갈 수 있다.

C#은 클래스를 하나만 상속받는다.
 C++은 여러개 가능한데 하나만 받는 것과의 차이가 있다면..


override = 덮어쓰기
--------------
Character 클래스
        public void Attack()
        {
            Console.WriteLine("캐릭터가 공격한다");
        }
        public virtual void Skill()
	// Skill 함수는 virtual 함수다 = > Skill 함수는 상속받은 클래스에서 덮어쓸 수 있다. (override)
        {
            Console.WriteLine("캐릭터가 스킬을 사용한다");
        }

Player 클래스
    internal class Player : Character // Player 클래스가 Character 클래스를 상속 받음
    {
        public void Attack()
        {
            Console.WriteLine("플레이어가 공격한다");
        }
        public override void Skill()
        {
            //base.Skill(); // Player의 부모클래스의 skill을 사용하고
            Console.WriteLine("플레이어가 파이어볼을 사용한다."); //자신의 코드 실행
        }
    }
    -------------

    메인함수 (실행하는 곳) 
	    Character test = new Player(); 
     //자식 클래스의 인스턴스는 부모타입의 변수에 저장할 수 있다.
            test.Skill();
            Character test2 = new Player(); 
            test2.Attack();

     위 함수 실행의 결과는 
     	플레이어가 파이어볼을 사용한다.
	캐릭터가 공격한다
     이다.

virtual로 지정된 함수는 가상 테이블에 저장되어서 그거 실행되는데
그냥 인 Attack은 Character꺼 사용되ㅏㅁ

Player 클래스에서 
hp = 100; 처럼 수정할 수 없다.
priate변수여서 부모의 변수라도 접글 불가능
protected는 가능하다.

------------------------------
Stack메모리와  Heap 메모리

스택 메모리
-함수가 실행될 때 잡히는 게 스택메모리
-크기가 상대적으로 작다.
-함수 실행코드, 함수 파라메터, 지역변수 
-사용하는데 속도가 빠르다. (위치가 정해져있기떄문)

	컴퓨터에서 모든 실행파일은 메모리로 올라가야 처리 할 수 있다.
	실행파일들은 딱 봐도 몇십메가가 넘는데 스택은 아니다 (크기가 크니까)

힙 메모리
-컴퓨터에 남아있는 램
-크기는 보통 무한으로 처리 (크기가 크다)
-동적 할당 용도로 사용 (new)
		동적 (프로그램 실행 중)
  		정적 (프로그램 실행 전)
-속도가 느리다. 

	=> 보안에 대한 요구사항이 크다. 메모리에 대한 직접참조를 막는다
 	운영체제한테 요구해서 허용되면 메모리를 사용 가능하다.
  	운영체제는 바쁘다보니(우선순위에 따라) 처리가 느려진다. 
   	따라서 new는 최소화해야한다.

    
-------------------------
C#의 데이터 타입

값타입
- 스택 메모리에 저장
- unmanaged type
- 깊은 복사 (깡으로 복사 = 완전한 사본을 가지게 된다.)

참조타입
- 힙 메모리에 저장
- managed type (가비지 콜랙팅이 된다)
- 얕은 복사 (참조로 가져옴) = 복사 속도가 빠르다









