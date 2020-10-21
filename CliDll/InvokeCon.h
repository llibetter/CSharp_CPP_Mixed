#pragma once

#include <iostream>
#include "..\CPPAlg\\CalculateData.h"
public ref class InvokeCon
{
public:
    InvokeCon();

    int AddCli(int numberA, int numberB);
    int SubtractCli(int numberA, int numberB);
    int MultiplicationCli(int numberA, int numberB);
    int DividedCli(int numberA, int numberB);
};