using System;

namespace CppWrapper
{
    public static class ExternModules
    {
        // 인터페이스에서 아웃풋이 2개 이상이라면 out으로 한정된 인자를 사용할 수 있다.
        // 하지만 그것보다는 1개의 반환값으로 정의하는 것이 더 적절하다.
        // 가능하면 1개의 값 또는 구조체만 반환하도록 메서드를 설계하도록 한다.
        public static void UseStruct(int normalInput, RecordA structInput, out int normalOutput, out RecordA structOutput)
        {
            int errorCode = NativeMethods.CUseStruct(normalInput, structInput, out normalOutput, out structOutput);
            // 에러 코드를 직접 반환하면 안 된다. 적절한 예외로 변형하여 throw한다.
            if (-1 == errorCode)
            {
                // 실제로는 올바르게 Exception을 상속한 새로운 예외를 정의해서 사용해야 한다.
                throw new Exception("네이티브 함수에서 에러가 발생했습니다.");
            }
        }
    }
}