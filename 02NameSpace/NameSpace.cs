﻿// 문법을 공부할 때 
// 응용법까지 욕심내는 경우가 있다.
// 게임 프로그래밍에서는
// 실제 코드를 짜면서 보기 전까지는
// 응용에 대해서 느낄 수가 없어요.
// 프로그래밍에서는 경우가 무한대이다.
/*배열이라는 것을 배웠다.
인벤토리 만들 때 쓸 수 있다.
오브젝트를 관리할 때 쓸 수 있다. 
너무 단편적이라는 것*/

// 프로그래머가 2명이다.
// RPG를 만들기로 했다.
// 몬스터
// 무기
// 아이템

// A프로그래머 
// HP포션
// B프로그래머
// MP포션

// 클래스의 이름들은
// 전문적인 용어로 식별자
// 어떠한 코드적 내용을
// 묶는 하나의 명칭이다.

// 식별자가 겹칠 때의 문제는
// 사용할 때이다.
// Potion 쓸게.

// A프로그래머 
// 네임스페이스는 개념의 표현이라기보다는
// 개념의 분류
namespace APRO
{
    class /*APRO.*/Potion
    {

    }
}

namespace JHS
{
    // B프로그래머
    class /*BPRO.*/Potion
    {

    }
}
