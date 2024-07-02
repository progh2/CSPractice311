using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{

    class MyMath
    {
        public static int classVar = 1;
        public int instanceVar = 2;

        public static int Abs(int input)
        {
            Console.WriteLine(classVar);
            // 클래스 메서드에서 인스턴스 변수 접근 불가
            //Console.WriteLine(instanceVar);
            return (input >= 0) ? input : -input;
        }
    }

    class FirstClass
    {

    }

    internal class Program
    {
        class ThirdClass
        {

        }

        static void Main(string[] args)
        {
            // #1 12-1. 기본용어
            //int base = 0;
            var abc = 3;
            //var var = 3;
            
            // 한줄주석
            /*
             * 여러줄 주석
             */
            /*** XML 주석 ***/


            // #1 12-2. 출력 
            Console.WriteLine("Hello World");
            Console.Write("줄바꿈 싫어");

            // #1 12-3. 기본 자료형
            // 정수 
            Console.WriteLine(52 + 4 - 1);
            // 사칙연산자 = 산술 연산 = Arithmetic Operator
            // + - * / % 

            // 실수(Real Number)
            Console.WriteLine(52.0);

            // 문자(Character)
            Console.WriteLine('A');
            Console.WriteLine('가');

            // 문자열(string)  
            Console.WriteLine("Hello World");
            // Escape Character 탈출 문자
            Console.WriteLine("미\n\\림\t마\"고");

            // 문자열 연결 연산자(Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World");

            // 문자열 인덱스 접근 [ ]
            Console.WriteLine("Hello World"[4]); // "o" 출력
            //Console.WriteLine("Hello World"[100]); // 예외 발생
            //Console.WriteLine("Hello World"[-3]);  // 예외 발생

            // 주의 
            Console.WriteLine('가' + '힣');
            // 문자열연결연산자X. 덧셈 연산자임

            // 논리 (Boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);

            // 비교 연산자(Comparison operator)
            // == != > < >= <=

            // 논리 연산자(Logical Operator)
            // && || !    and or not 
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            // #1 12-4. 변수
            string s = "문자열 자료형";

            // #1 12-5. 복합대입연산자
            // += -= *= /= 
            string output = "Hello";
            output += " World";
            Console.WriteLine(output);

            // #1 12-6. 증감 연산자
            int number = 10;
            Console.WriteLine(number++); // 10
            Console.WriteLine(++number); // 12
            Console.WriteLine(number--); // 12
            Console.WriteLine(--number); // 10

            // #1 12-8 var 키워드
            var varnumber = 20;
            //var abc;  // X반드시 초기화 해줘야 함

            // #1 12-9. 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // #1 12-10. 자료형 변환
            // 굉장히 중요

            // #2 13-1. if 조건문
            bool condition = true;
            if (condition)
            {
                // some 
            }else if(condition){
                // some2
            }
            else
            {
                // other
            }
            int v = 0;
            // #2 13-5. switch 조건문
            switch (v)
            {
                case 0:
                    //
                    break;
                default:
                    //
                    break;
            }

            // #2 13-6. 삼항 연산자
            Console.WriteLine(number % 2 != 1 ? true : false);

            // #3 14-1. 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray[99]);

            // #3 14-2. while 반복문
            int i = 0;
            int[] intArray2 = { 52, 273, 32 };
            while(i < intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++; // 탈출을 위한 변수
            }

            // #3 14-6 foreach 반복문
            string[] foreachArray = { "사과", "배", "포도" };
            foreach (var item in foreachArray)
            {
                Console.WriteLine(item);
            }

            // #4 21-2 클래스 사용
            Random random = new Random();
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));

            Console.WriteLine(Math.Abs(-9));// 9
            Console.WriteLine(Math.Ceiling(42.3)); // 43
            Console.WriteLine(Math.Floor(42.9)); // 42
            Console.WriteLine(Math.Round(42.6)); // 43
            Console.WriteLine(Math.Min(42, 1));  // 1
            Console.WriteLine(Math.Max(42, 1));  // 42
            Console.WriteLine(Math.PI); // 3.141592~~

            // #4 21-3. 클래스 생성

            // #4 21-4. 인스턴스 변수
            User user1 = new User();
            user1.name = "이미림";
            user1.phoneNumber = "010-1234-5678";

            Product p1 = new Product();
            p1.name = "어른폰";
            p1.price = 99999999;

            Product p2 = new Product() {
               price = 3000, name = "감자폰"
            };
            Product p3 = new Product()
            {
                name = "공짜폰"
            };

            // #4 21-4. 클래스 변수
            Console.WriteLine(Product.TAX_RATIO);
           // Console.WriteLine(p1.TAX_RATIO);  // JAVA는 가능하나 C#은 X

            // #5 22-3. 클래스 메서드

        }
    }
}
