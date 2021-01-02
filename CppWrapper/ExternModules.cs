using System;

namespace CppWrapper
{
    public static class ExternModules
    {
        // 구조체를 전달할 때, 값 복사가 2번 발생하는 것은 비효율적이므로 in으로 지정한다.
        // (in 한정자는 C# 7.2(.NET Framework 4.7.2가 아니다) 이상에서만 사용할 수 있다. 버전이 낮으면 ref를 사용해야 한다.)
        // 아웃풋 인자는 out으로 지정한다.
        public static void UseStruct(int normalInput, in RecordA structInput, out int normalOutput, out RecordA structOutput)
        {
            int errorCode = NativeMethods.CUseStruct(normalInput, in structInput, out normalOutput, out structOutput);
            if (-1 == errorCode)
            {
                throw new Exception("네이티브 함수에서 에러가 발생했습니다.");
            }
        }
    }
}