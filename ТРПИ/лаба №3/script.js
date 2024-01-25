function task1(arr) {
  if (Array.isArray(arr)) {
    return arr.reduce(function (subArr, current) {

      return subArr.concat(task1(current));

    }, []);
  } else {
    return arr;
  }
}

console.log(task1([1, [1, 2, [3, 4]], [2, 4]]))


let sum = 0;
function foo(array) {

  array.forEach(function (value, index) {
    Array.isArray(value) ? foo(value) : sum += value;
  });

  return sum;
}

function task2() {
  let arr = [1, 2, [2, 5, 3, [32, 5], 3], 7, 4];
  console.log(foo(arr));
}

function getStudents(students) {
  let userGroupID = Number(prompt("Введите номер группы:"))
  let newObject = {};
  newObject[userGroupID] = [];
  students.forEach(student => {
    if (student.age > 17 && student.groupId === userGroupID)  {
      newObject[student.groupId].push(student.name);
    }
  });

  return newObject;
}

function task3() {
  let students = [
    {
      name: "Stas",
      age: 20,
      groupId: 6
    },
    {
      name: "Vlad",
      age: 19,
      groupId: 7
    },
    {
      name: "Matvei",
      age: 17,
      groupId: 6
    },
    {
      name: "Misha",
      age: 18,
      groupId: 7
    },
    {
      name: "Lesha",
      age: 19,
      groupId: 6
    },
    {
      name: "Maksim",
      age: 17,
      groupId: 6
    }
  ]

  console.log(getStudents(students));
}

function StrToCode(string) {

  let total1 = "";
  for (let i = 0; i < string.length; i++) {
    total1 += string[i].charCodeAt(0);
  }

  let total2 = total1.replaceAll("7", "1");

  return total1 - total2;
}

function task4() {
  console.log(StrToCode('ABC'));
}

function extend(...objs) {
  let copyObjs = {};

  for (const value of objs) {
    Object.assign(copyObjs, value);
  }

  return copyObjs;
}

function task5() {
  console.log(extend({a: 1, b: 2}, {c: 3}, {d: 1, e: 2}, {f: 3}, {g: 4} ));
}

function createPyramid(numFloors) {
  for (let i = 1; i <= numFloors; i++) {
    let spaces = ' '.repeat(numFloors - i); 
    let stars = '*'.repeat(2 * i - 1); 
    console.log(spaces + stars); 
  }
}

let A = {};

let C = A;
A.name = "Stas";
console.log(C);
let B = {};
function callJobs() {
  const buttons = document.querySelectorAll('button');
  const functions = [task1, task2, task3, task4, task5, createPyramid];

  buttons.forEach((elem, index) => {
    elem.addEventListener('click', functions[index]);
  })
}

callJobs();


