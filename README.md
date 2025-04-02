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


