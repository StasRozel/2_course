function basicOperation(operation, value1, value2) {
    switch (operation) {
        case "+":
            return value1 + value2;
        case "-":
            return value1 - value2;
        case "*":
            return value1 * value2;
        case "/":
            return value1 / value2;
        case "%":
            return value1 % value2;
        default:
            return "Данный операнд не поддерживается";
    }

   
}

function task1() {
    console.log(basicOperation('+', 2, 5));
}

function sumCubes(n) {
    let sum = 0;
    for (let i = 0; i <= n; i++) {
        sum += Math.pow(i, 3);
    }

    return sum;
}

function task2() {
    console.log(sumCubes(3));
}

function averageNumbers(array) {
    let sum = 0;

    for (let i = 0; i < array.length; i++) {
        sum += array[i];
    }

    return sum / array.length;
}

function task3() {
    console.log(averageNumbers([1, 2, 3]));
}

function reversString(string) {
    let newString = '';
    for (let i = 0; i < string.length; i++) {
        let symbol = string[i].charCodeAt(0);
        if((symbol >= 65 && symbol <=90) || (symbol >= 97 && symbol <=122)) {
            newString += string[i];
        }
        
    }

    let stringToArray = newString.split("");
    let reversString = stringToArray.reverse().join("");

    return reversString
}

function task4() {
    console.log(reversString("111JavaScriptПривет"));
}

function increaseString(number, string) {
    let resultString = "";

    for (let i = 0; i < number; i++) {
        resultString += ` ${string}`;
    }

    return resultString;
}

function task5() {
    console.log(increaseString(2, "hello world"));
}

function createArr3(arr1, arr2) {
    
    let arr3 = [];

    for (let i = 0; i < arr1.length; i++) {
        let flag = false;
        for (let j = 0; j < arr2.length; j++) {
            if(arr1[i] === arr2[j]) {
                flag = true;
            }
        }
        
        if (!flag) {
            arr3.push(arr1[i]);
        }
    }

    return arr3;
}

function task6() {
    console.log(createArr3(["Hello", "world", "Stas", "JavaScript"], ["Ivan", "Hello", "Stas"]));
}



function callJobs() {
    const buttons = document.querySelectorAll('button');
    const functions = [task1, task2, task3, task4, task5, task6];

    buttons.forEach((elem, index) => {
        elem.addEventListener('click', functions[index]);
    })
}

callJobs();