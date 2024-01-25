//===============task1================
//Вариант1;
// function makeCounter() {
//     let currentCount = 1;

//     return function () {
//         return currentCount++;
//     }
// }

// let counter = makeCounter();
// alert(counter());//1
// alert(counter());//2
// alert(counter());//3

// let counter2 = makeCounter();
// alert(counter2());//1

// //Вариант2;
// let currentCount = 1; 

// function makeCounter() {
    
//     return function () {
//         return currentCount++;   
//     }
// }

// let counter = makeCounter();
// let counter2 = makeCounter();
// alert(counter());//1
// alert(counter());//2

// alert(counter2());//3
// alert(counter2());//4

function task1() {}

function calcParallelepipedVolume(h) {
    return function(a) {
        return function(b) {
            return (a*b)*h;
        }
    }
    
}

let curriedVolume = calcParallelepipedVolume(6);

function task2() {
    alert(curriedVolume(2)(3));
}

let x = 0, y = 0;

function* generatorDirection(direction) {
    switch (direction) {
        case "left":
            yield `x: ${x -= 10} y: ${y}`
            break;
        case "right":
            yield `x: ${x += 10} y: ${y}`
            break;
        case "up":
            yield `x: ${x} y: ${y += 10}`
            break;
        case "down":
            yield `x: ${x} y: ${y -= 10}`
            break;
        default:
            break;
    }
}

function task3() {
    let direction = " ";
    do {
        direction = prompt("Укажите направление (left, right, up, down) или остановитесь (Enter): ");

        console.log(generatorDirection(direction).next().value)
    
    } while (direction != "");
}

var glob = 10;

function sum(a, b) {
    return a+b;
}

function task4() {
    // window.task2();
    // window.task3();
    window.glob = 12;
    window.sum(1, 2);
    // console.log(curriedVolume);
}

function callJobs() {
    const buttons = document.querySelectorAll('button');
    const functions = [task1, task2, task3, task4];

    buttons.forEach((elem, index) => {
        elem.addEventListener('click', functions[index]);
    })
}

callJobs();