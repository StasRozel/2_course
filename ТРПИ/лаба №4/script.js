function task1() {

    let productList = new Set(["Телефон", "Ноутбук", "Камера", "Игровая приставка"]);

    console.log(addProductSet(productList, "Телевизор"));
    console.log(deleteProduct(productList, "Камера"));
    console.log(size(productList));
    console.log(findProduct(productList, "Телефон"));
    console.log(productList);

}

function addProductSet(set, product) {
    return set.add(product);
}

function deleteProduct(set, product) {
    return set.delete(product) ? "Продукт удален" : "Продукт не найден";
}

function size(set) {
    return set.size > 0 ? `Продуктов ${set.size}` : "Продуктов нет";
}

function findProduct(set, product) {
    return set.has(product) ? "Продукт найден" : "Продукт не найден";
}

function task2() {

    const studentsArr = [
        {
            id: 341,
            groupNum: 6,
            fullName: "Rozel Stanislav Alexandrovich"
        },
        {
            id: 424,
            groupNum: 6,
            fullName: "Ljashonok Matvei Mihailovich"
        },
        {
            id: 643,
            groupNum: 6,
            fullName: "Bykov Pavel Alexeevich"
        },
        {
            id: 123,
            groupNum: 2,
            fullName: "Ivanov Ivan Ivanovich"
        },
        {
            id: 221,
            groupNum: 1,
            fullName: "Sidorov Alex Ivanovich"
        },
        {
            id: 523,
            groupNum: 7,
            fullName: "Petrov Petr Petrovich"
        },

    ]

    let studentsList = new Set(studentsArr);

    const newStudent = {
        id: 120,
        groupNum: 9,
        fullName: "Volski Nikolai Petrovich"
    }


    console.log(addStudent(studentsList, newStudent));
    console.log(deleteStudent(studentsList, 120));
    console.log(filterStudentGroup(studentsList, 6));
    console.log(sortStudentById(studentsList));
}

function addStudent(set, student) {
    return set.add(student);
}

function deleteStudent(set, studentId) {
    if (Number.isInteger(studentId)) {
        for (const student of set) {
            if (student.id == studentId) {
                set.delete(student);
                return "Студент найден и удален";
            }
        }
    } else {
        return "Введенны не корректные данные";
    }
}

function filterStudentGroup(set, numberGroup) {
    let studentsArr = [...set];

    let i = 0;
    while (i < studentsArr.length) {
        if (studentsArr[i].groupNum !== numberGroup) {
            studentsArr.splice(i, 1);
        } else {
            i++;
        }
    }

    return new Set(studentsArr);
}

function QuickSort(List) {
   if (List.length <= 1) {
       return List;
   }

   const pivot = List[List.length - 1];
   const leftList = [];
   const rightList = [];

   for (let i = 0; i < List.length - 1; i++) {
       if (List[i].id < pivot.id) {
           leftList.push(List[i]);
       }
       else {
           rightList.push(List[i])
       }
   }

   return [...QuickSort(leftList), pivot, ...QuickSort(rightList)];
}

function sortStudentById(set) {
    let studentsArr = [...set];

    let newStudentArr = QuickSort(studentsArr);

    return new Set(newStudentArr);
}

function task3() {

    const basket = new Map();

    basket.set(1, {
        title: "Ноутбук",
        amount: 190,
        price: 1700
    })
    basket.set(2, {
        title: "Смартфон",
        amount: 200,
        price: 1400
    })
    basket.set(3, {
        title: "Системный блок",
        amount: 100,
        price: 3400
    })
    basket.set(4, {
        title: "Ноутбук",
        amount: 320,
        price: 1200
    })

    addProductMap(basket, {
        title: "Смартфон",
        amount: 120,
        price: 2400
    })

    addProductMap(basket, {
        title: "Монитор",
        amount: 60,
        price: 1400
    })

    changeAmountProduct(basket, 3, 120);

    deleteProductById(basket, 3);

    deleteAllProductByName(basket, "Смартфон");

    console.log(basket);

    console.log(changePositionsAndSum(basket));
}

function addProductMap(elem, product) {
    let size = elem.size++;
    elem.set(size, product);
}

function deleteProductById(map, id) {
    map.delete(id);
}

function deleteAllProductByName(map, name) {
    let i = 1;
    for (let item of map.values()) {
        if (map.get(i) === undefined) {
            i++;
        }
        if (item.title === name) {
            map.delete(i);
        }
        i++;
    }
}

function deleteFirstProductByName(map, name) {
    let i = 1;
    for (let item of map.values()) {
        if (map.get(i) === undefined) {
            i++;
        }
        if (item.title === name) {
            map.delete(i);
            return;
        }
        i++;
    }
}

function changeAmountProduct(map, id, amount) {
    map.get(id).amount = amount;
}

function changePriceProduct(map, id, price) {
    map.get(id).price = price;
}

function changePositionsAndSum(map) {
    let sum = 0;
    for (const item of map.values()) {
        sum += item.price * item.amount;
    }

    return `Количество товаров: ${map.size}, общая сумма: ${sum}`;
}

function task4() {
    let cache = new WeakMap();

    let set = new Set([1, 2, 3, 4, 5])
    let A = {0: set, 1: 3};
    console.log(caching(cache, A));
  
    console.log(caching(cache, A));
}

function caching(cache, args) {
    if(!cache.has(args)) {
        console.log("добавить новый кэш");
        let result = isFindFirst(args[0], args[1]);

        cache.set(args, result);
    } 
    console.log("такой кэш уже есть, выводим")
    return cache.get(args);
}

function isFindFirst(set, item) {

    let arr = [...set];
    let flag = false;

    arr.forEach(element => {
        if (element == item) {
            flag = true;
        }
    });

    return flag;
}



function callJobs() {
    const buttons = document.querySelectorAll('button');
    const functions = [task1, task2, task3, task4];

    buttons.forEach((elem, index) => {
        elem.addEventListener('click', functions[index]);
    })
}

callJobs();