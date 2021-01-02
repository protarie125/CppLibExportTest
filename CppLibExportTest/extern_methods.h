#pragma once
#include "framework.h"
// C 스타일로 작성한다.
#include "records.h"

#define ERROR_CODE int
#define OK 0
#define FAIL -1

EXTERN_C_START

ERROR_CODE CPPLIBEXPORTTEST_API useStruct(int normalInput, RecordA structInput, int* normalOutput, RecordA* structOutput);

EXTERN_C_END
