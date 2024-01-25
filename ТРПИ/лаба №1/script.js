function task1() {
    console.log("task 1")
    let a = 5;//number
    let name = "Name";//string
    let i = 0;//number
    let double = 0.23;//number
    let result = 1 / 0;//number
    let answer = true;//boolean
    let no = null;//null
    console.log(typeof no);
}

function task2() {
    console.log("task 2");
    let amountSquereX = 45 / 5;
    let amountSquereY = Math.floor(21/5);
    let amountSquereAll = amountSquereX * amountSquereY;
    console.log("Amount:" + amountSquereAll);
}

function task3() {
    console.log("task 3");
    let i = 2;
    let a = ++i;//3
    let b = i++;//3
}

function comprasion(operand_1, operand_2) {
    (operand_1 == operand_2) ? console.log(true) : console.log(false);
}

function task4() {
    console.log("task 4");
    const values = [
        ["Котик", "котик"],
        ["Котик", "китик"],
        [73, "53"],
        [false, 0],
        [54, true],
        [123, true],
        [true, "3"],
        [3, "5мм"],
        [8, "-2"],
        [34, "34"],
        [null, undefined]
    ]
    
    values.forEach(elem => {
        comprasion(elem[0], elem[1]);
    })
}

function task5() {
    let nameTeacher = "Иванов Иван Иванович";
    let nameUserLogIn = prompt("Введите свое ФИО: ").toLowerCase();

    if (nameTeacher.toLowerCase().includes(nameUserLogIn)) {
        alert("Вы успешно авторизировались!");
    } else {
        alert("Такого имени нет в системе!");
    }

}
function task6() {
    let russian = prompt("Вы сдали русский язык?(Да или Нет)");
    let math = prompt("Вы сдали математику?(Да или Нет)");
    let english = prompt("Вы сдали английский язык?(Да или Нет)");
    let counter = 0;

    let exams = [russian, math, english];

    exams.forEach(exam => {
        if (exam === "Нет") {
            counter++;
        }
    })

    switch (counter) {
        case 0:
            alert("Вас перевели на следующий курс");
            break;
        case 3:
            alert("Вас отчислили");
            break;
        case 1 || 2:
            alert(`Вам нужно пересдать ${counter} экзамен(-ов)`);
            break;
    }
}

function task7() {
    console.log(true + true);//2
    console.log(0 + "5");//05
    console.log(5 + "мм");//5мм
    console.log(8/Infinity);//0
    console.log(9 * "\n9");//81
    console.log(null - 1);//-1
    console.log("5" - 2);//3
    console.log("5px" - 3);//NaN
    console.log(true - 3);//-2
    console.log(7 || 0);//7
}

function task8() {
    console.log("task 10");
    for (let i = 1; i < 11; i++) {
        !(i % 2) ? console.log(i + 2) : console.log(i + "мм");

    }
}

function task9Arr() {
    const days = [
       "Понедельник",
       "Вторник",
       "Среда",
       "Четверг",
       "Пятница",
       "Суббота",
       "Воскресенье"
    ]

    let numDayUser = Number(prompt("Введите номер дня: "));

    alert(`Вы выбрали ${days[numDayUser-1]}`)

}

function task9Obj() {
    const days = {
        1: "Понедельник",
        2: "Вторник",
        3: "Среда",
        4: "Четверг",
        5: "Пятница",
        6: "Суббота",
        7: "Воскресенье"
    }

    let numDayUser = Number(prompt("Введите номер дня: "));
    
    alert(`Вы выбрали ${days[numDayUser]}`);
}

function conStr(param1, param2, param3 = "Параметр по умолчанию") {
    return `${param3} ${param2} ${param1}`;
}

function task10() {
    let message = prompt("Введите любое сообщение: ");

    alert(conStr(message, "Второй параметр"));


}

function task11(a, b) {
    return (a === b) ? a * 4 : a * b;
}



function callJobs() {
    const buttons = document.querySelectorAll('button');
    const functions = [task1, task2, task3, task4, task5, task6, task7, task8, task9Arr, task10, task11];

    buttons.forEach((elem, index) => {
        elem.addEventListener('click', functions[index]);
    })
}

callJobs();