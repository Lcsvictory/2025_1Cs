2025_1 C# Programing 

### 사용 버전
    - visual studio 2022 17.13.1
    - .NET Framework 4.7.2

### 실행 방법 
- F6 빌드(컴파일) -> F5 디버깅 (ctrl + F5 : 디버깅 없이 실행)

### 작업흐름
- Sln(솔루션)이 전체 프로젝트를 총괄한다.
- Project(프로젝트)가 하나하나의 프로젝트다.
- Solution -> Project -> .cs files

### 단축키
- alt + 방향키 : 라인이동
- ctrl + L : 한줄삭제
- ctrl + K + F : 라인 서식 맞추기
- F11 : 디버깅시 다음 라인실행
- ctrl + alt + click : 다중선택
- F12 : 참조 찾아보기
- ctrl + - : 이전 작업공간으로 점프
- ctrl + shift + - : 앞으로 점프
- alt + shift + . : 같은 단어 선택
- ctrl + M + O

week02
---
class명과 파일명을 똑같이 하는게 관례. (자바는 강제)

week03
---
지역변수와 instance 변수가 있다.

int : byte 1 > short 2 > int 4 > long 8

sbyte byte int uint 

기본 정수형 = int
기본 실수형 = double

자료형 int, float long double char => value (값) **그러나** string => reference (참조타입)
struct 로 구현되었다 => 값
class 로 구현되었다 => 참조

string자료형은 sizeof() 사용안됨.

고정소수점 자료형 : decimal 16byte
부동소수점 자료형 : flaot, ddouble

객체지향 특징 : 상속 다형성 은닉성 추상화

소수 표현 포맷팅 방법 : string a = (57.31232).ToString("0.00") => 57.00


C#은 구역별로 묶는다.
panel컴포넌트가 그룹을 만드는 컴포넌트

week04
---
swich case 문에서 string타입을 case로 사용할 수 있다.

string타입은 class이기 때문에 초기값은 null.

week05
---
var 변수는 컴파일러가 자동으로 타입을 지정한다.
컴파일시 대입되는 값을 통해 타입을 유추한다.

var 타입은 변수 선언과 동시에 초기화 해야한다.
선언만 하는건 불가능.
지역변수로만 사용가능.

week06
---


### List자료형
- arraylist가 원형
- .Add(object), .insert()
- .Remove(object)특정 객체 삭제, .RemoveAt(index)특정 인덱스 삭제
- .Clear()
- .Length()

### Class
- 값(변수) + 기능(메소드)
- class변수 = 정적변수 (static)

week07
---


### DataTime자료형
- 

### Random자료형
-

### string 
-

wee09
---

### Property (속성)

필드가 존재하고 해당 필드에 getter, setter를 해주는 놈

- getter, setter를 한번에 처리 가능함.
- 변수처럼 사용


기본형태

``get``,``set``,``value`` 키워드
```
private string _code;
    public string Code
{
    get { return this._code; }
    set { this._code = value;  } 
}
```

자동구현 Property
```
public string Address { get; set; }

//자동생성 내용
public string Address { get => address; set => address = value; }
private string address;
```


### Enumerate (열거형)

정수에 이름을 붙이는것

```

```

week10
---

## 객체 지향 프로그래밍의 4가지 특징
- ``추상화``

클래스는 추상화와 연관되어있음
- ``캡슐화``
- ``상속``
- ``다형성``


## Method
- 인스턴스 메소드 

- 정적 메소드

- 오버로딩

리턴타입은 중요하지 않다. 매개변수가 중요함.

## 접근제한자
- private
    - 클래스를 제외한 나머지는 기본으로 private
- public
- protected
- internal
    - 클래스의 기본 접근제한자.

## 생성자 Constructor

public이 기본
private생성자도 가능
static생성자는 매개변수, 접근제한자 없음.



## 종료자 Finalizer
``소멸자``, 
가비지 컬렉터가 자동으로 호출함.

## 상수 Const
- method내 지역변수에 사용 가능
- class 내에서 사용 가능 (static의 성격)
- 선언과 동시에 생성 해야 함. 상수니까 당연하다.

**readonly키워드**
- 선언만 하고 생성은 생성자에서 가능함.
- 그 이후엔 변경 불가.

## C#의 class구성요소
- **필드**
- **프로퍼티(함수+변수)**
- **메소드**

## 상속

부모클래스 : base 클래스

(parent, super와 같은의미)

파생클래스 : derived 클래스

(child, sub와 같은의미)

week11
---
## 하이딩
- 상속받은 변수, 프로퍼티, 메소드를 숨김.

- 부모의 것도 인정하고 내것도 인정함. 

## override 
- 상속받은 변수, 프로퍼티, 메소드를 재정의함.

- 부모의 것을 내것이 대체함.

## abstract class
- 추상클래스를 가지는 클래스.
- 인터페이스와 클래스의 중간

## interface
- 추상메소드만 가짐.

- 자동구현 Property 적용 안됨. 프로퍼티의 정의는 그저 정의일 뿐임.

week12
---
## 형변환 방법
``1``. if (item is Dog) { Dog dog = (Dog)item} 

``2``. var dog = item as Dog; //Dog가 아니면 dog == NULL

``3``. bool isDog = item is Dog dog; 

    Dog타입이면 isDog == true, dog == Dog instance
    Dog타입이 아니면 isDog == false, dog == NULL


