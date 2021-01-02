#pragma once
#include "framework.h"
// C 스타일로 작성한다.
#include "records.h"

#define ERROR_CODE int
#define OK 0
#define FAIL -1

EXTERN_C_START

// 네이티브 함수에서는 const pointer로 설정하여 인풋의 오염을 방지한다.
ERROR_CODE CPPLIBEXPORTTEST_API useStruct(int normalInput, const RecordA* structInput, int* normalOutput, RecordA* structOutput);

EXTERN_C_END
