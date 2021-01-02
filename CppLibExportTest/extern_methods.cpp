#include "extern_methods.h"

#include <iostream>
#include <exception>

using std::cout;
using std::endl;
using std::exception;

ERROR_CODE useStruct(int normalInput, const RecordA* structInput, int* normalOutput, RecordA* structOutput)
{
    // out 파라미터로 지정되어 있기때문에 nullptr인 경우는 없지만, 일단 체크한다.
    // 실제로는 단순히 FAIL이 아닌 구체적인 에러코드를 반환한다.
    if (normalOutput == NULL) return FAIL;
    if (structOutput == NULL) return FAIL;

    try
    {
        // 내부에서 포인터 자체를 변경시키는 것은 아무 효과도 없지만,
        // 실수를 방지하기 위해서 상수 포인터로 지정할 수 있다.
        // (int* const normalOutput, RecordA* const structOutput 사용)
        *normalOutput = normalInput + 100;
        structOutput->intValue = structInput->intValue * 2;
        structOutput->floatValue = structInput->floatValue * 3;
        structOutput->doubleValue = structInput->doubleValue * 4;

        return OK;
    }
    catch (const exception& exc)
    {
        // std::exception을 C 함수로 전달할 방법은 없으므로 에러코드를 이용한다.
        // 실제로는 콘솔이 아닌 logger 모듈에 로깅한다.
        cout << exc.what() << endl;
        // 실제로는 일반 exception이 아닌 구체적인 예외를 캐치하고 올바른 에러코드를 반환한다.
        return FAIL;
    }
}