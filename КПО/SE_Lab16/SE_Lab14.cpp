#include "stdafx.h"
#include "Error.h"
#include "Parm.h"
#include "In.h"
#include "Log.h"
#include "Out.h"
#include "FST.h"


int _tmain(int argc, _TCHAR* argv[])
{
    setlocale(LC_ALL, "Rus");

    FST::FST fst1(
        "BxRxE",
        6,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE(1, FST::RELATION('R', 3)),
        FST::NODE(1, FST::RELATION('x', 4)),
        FST::NODE(1, FST::RELATION('E', 5)),
        FST::NODE()
    );

    if (FST::execute(fst1))
        std::cout << "Цепочка " << fst1.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst1.string << " не распознана" << std::endl;

    FST::FST fst2(
        "BxRxME",
        7,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE(1, FST::RELATION('R', 3)),
        FST::NODE(1, FST::RELATION('x', 4)),
        FST::NODE(1, FST::RELATION('M', 5)),
        FST::NODE(1, FST::RELATION('E', 6)),
        FST::NODE()
    );

    if (FST::execute(fst2))
        std::cout << "Цепочка " << fst2.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst2.string << " не распознана" << std::endl;

    FST::FST fst3(
        "BxRxMCPxE",
        6,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE(1, FST::RELATION('R', 3)),
        FST::NODE(1, FST::RELATION('x', 4)),
        FST::NODE(1, FST::RELATION('M', 5)),
        FST::NODE()
    );

    if (FST::execute(fst3))
        std::cout << "Цепочка " << fst3.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst3.string << " не распознана" << std::endl;
    FST::FST fst4(
        "Bx",
        3,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE()
    );

    if (FST::execute(fst4))
        std::cout << "Цепочка " << fst4.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst4.string << " не распознана" << std::endl;
    FST::FST fst5(
        "BxRx",
        5,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE(1, FST::RELATION('R', 3)),
        FST::NODE(1, FST::RELATION('x', 4)),
        FST::NODE()
    );

    if (FST::execute(fst5))
        std::cout << "Цепочка " << fst5.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst5.string << " не распознана" << std::endl;
    FST::FST fst6(
        "BxE",
        4,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE(1, FST::RELATION('E', 3)),
        FST::NODE()
    );

    if (FST::execute(fst6))
        std::cout << "Цепочка " << fst6.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst6.string << " не распознана" << std::endl;
    FST::FST fst7(
        "BxRxCPxE",
        9,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE(1, FST::RELATION('R', 3)),
        FST::NODE(1, FST::RELATION('x', 4)),
        FST::NODE(1, FST::RELATION('C', 5)),
        FST::NODE(1, FST::RELATION('P', 6)),
        FST::NODE(1, FST::RELATION('x', 7)),
        FST::NODE(1, FST::RELATION('E', 8)),
        FST::NODE()
    );

    if (FST::execute(fst7))
        std::cout << "Цепочка " << fst7.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst7.string << " не распознана" << std::endl;

    FST::FST fst8(
        "BxRxCPxE",
        9,
        FST::NODE(1, FST::RELATION('B', 1)),
        FST::NODE(1, FST::RELATION('x', 2)),
        FST::NODE(1, FST::RELATION('R', 3)),
        FST::NODE(1, FST::RELATION('x', 4)),
        FST::NODE(1, FST::RELATION('S', 5)),
        FST::NODE(1, FST::RELATION('P', 6)),
        FST::NODE(1, FST::RELATION('x', 7)),
        FST::NODE(1, FST::RELATION('E', 8)),
        FST::NODE()
    );

    if (FST::execute(fst8))
        std::cout << "Цепочка " << fst8.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst8.string << " не распознана" << std::endl;

    FST::FST fst9(
        "Yolki-palkipalki",//Yolki-palki
        12,
        FST::NODE(1, FST::RELATION('Y', 1)),
        FST::NODE(1, FST::RELATION('o', 2)),
        FST::NODE(1, FST::RELATION('l', 3)),
        FST::NODE(1, FST::RELATION('k', 4)),
        FST::NODE(1, FST::RELATION('i', 5)),
        FST::NODE(1, FST::RELATION('-', 6)),
        FST::NODE(1, FST::RELATION('p', 7)),
        FST::NODE(1, FST::RELATION('a', 8)),
        FST::NODE(1, FST::RELATION('l', 9)),
        FST::NODE(1, FST::RELATION('k', 10)),
        FST::NODE(2, FST::RELATION('i', 11), FST::RELATION('i',6)),
        FST::NODE()
    );

    if (FST::execute(fst9))
        std::cout << "Цепочка " << fst9.string << " распознана" << std::endl;
    else
        std::cout << "Цепочка " << fst9.string << " не распознана" << std::endl;


   /* Log::LOG log = Log::INITLOG;
    Out::OUT out = Out::INITOUT;
    try
    {
        Parm::PARM parm = Parm::getparm(argc, argv);
        log = Log::getlog(parm.log);
        out = Out::getout(parm.out);
        Log::WriteLine(log, "Тест: ", "без ошибок ", "");
        Log::WriteLine(log, L"Тест: ", L"без ошибок\n ", L"");
        Log::WriteLog(log);
        Log::WriteParm(log, parm);
        In::IN in = In::getin(parm.in);
    Log:WriteIn(log, in);
        Out::WriteIn(out, in);
        Log::Close(log);
        Out::Close(out);
    }
    catch (Error::ERROR e)
    {
        Log::WriteError(log, e);
        Out::WriteError(out, e);
    }*/
    system("pause");
    return 0;
}
