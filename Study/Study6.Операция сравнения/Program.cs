////Операция сравнения
// "==" - Равенства двух операндов, eсли они равны, то операция возвращает true, если не равны, то возвращается false
int a = 10;
int b = 5;
bool c = a == b;// false

// "!=" - Cравнение двух операндов,  true если операнды не равны, и false если они равны.
int a1 = 10;
int b1 = 5;
bool c1 = a1 != b1;// true
bool d1 = a1 != 10;// false

// "<" - Операция "меньше чем", true, если первый операнд меньше второго, и false, если первый операнд больше второго
int a2 = 10;
int b2 = 5;
bool c2 = a2 < b2;// false

// ">" - Операция "больше чем". Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false
int a3 = 10;
int b3 = 5;
bool c3 = a3 > b3;// true
bool d3 = a3 > 25;// false

// "<=" - Операция "меньше или равно". Сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. Иначе возвращает false.
int a4 = 10;
int b4 = 5;
bool c4 = a4 <= b4;// false
bool d4 = a4 <= 25;// true

// ">=" - Операция "больше или равно". Сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false
int a5 = 10;
int b5 = 5;
bool c5 = a5 >= b5;//true
bool d5 = a5 >= 25;// false


////Логические  операции
// "||" Операция логического сложения. возврвщает true, если хотя бы один из оперантов возвращает true.
bool x = ( 5 > 6 ) || ( 4 < 6 );// 5 > 6 - false, 4 < 6 - true, поэтому возвращается true

// "&&" Операция логического умножения. Возвращает true, если оба операнта одновременно равны.
bool x1 = ( 5 > 6 ) && ( 4 < 6 );// 5>6 - false, 4<6 - true, поэтому возвращается false

//test
bool isOne = true;
bool isTwo = false;
bool isResaute = isOne || isTwo;//true
bool isResult = !isOne || isTwo;//false
bool isResult2 = ( !isOne || isTwo ) && ( !isResaute );//false
bool isResult3 = ( isOne || !isTwo ) && ( isResaute );//true
bool isResult4 = !( !isTwo && isOne ) || ( isResaute );// !(true) || (true) / false || true, будет true
bool isResult5 = !( !isTwo && isOne ) && ( isResaute );// false && true, будет false