using System;

namespace CSharp
{
    public class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를 참조 (null)
                // 3. 오버플로우
                int a = 10;
                int b = 0;
                int result = a / b;

                int c = 0; // 16라인에서 예외가 발생하므로 해당 코드를 실행될 여지가 없다.
            }
            catch (DivideByZeroException e)
            {

            }
            catch (Exception e)
            {

            }
            finally
            {
                // 반드시 실행되어야 하는 코드 작성
                // ex) DB, 파일 정리 등
            }
        }
    }
}