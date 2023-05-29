
    int intfive = 5;//Число 5 хранится в stack
    object objFive = intfive;//Число 5 хранится в heap

int intFive2 = 5;//Число 5 хранится в stack
object objFive2 = objFive;//Число 5 хранится в heap

bool isIntEqual = intfive == intFive2;
    Console.WriteLine(isIntEqual);//Здесь будет True, потому что 5 ровно 5 

    bool isObjEqual = objFive == objFive2;
    Console.WriteLine(isObjEqual);//Здесь будет False, потому что 