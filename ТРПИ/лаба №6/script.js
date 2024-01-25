function task1() {
    let numbers = [1, 2, 3, 4, 5];

    let [firstNumber] = numbers;

    console.log(firstNumber);
}

function task2() {
    let user = {
        name: "Stas",
        age: "18",
        arr: [1, 2, 3],
    }

    let admin = {
        admin: true,
        ...user
    }

    let {
        name, 
        age,
        arr: [first, second, three]

    } = user;

    console.log(user);
    console.log(name);
    console.log(age);
    console.log(first);
    console.log(second);
}

function task3() {
    let store = {
        state: {
            profilePage: {
                posts: [
                    { id: 1, message: 'Hi', likesCount: 12 },
                    { id: 2, message: 'By', likesCount: 1 },
                ],
                newPostText: "About me",
            },
            dialogsPage: {
                dialogs: [
                    { id: 1, name: 'Valera' },
                    { id: 2, name: 'Andrey' },
                    { id: 3, name: 'Sasha' },
                    { id: 4, name: 'Viktor' },
                ],
                messages: [
                    { id: 1, message: 'hi' },
                    { id: 2, message: 'hi hi' },
                    { id: 3, message: 'hi hi hi' },
                ]
            },
            sidebar: []
        }
    }

    let { state: {
        profilePage: {
            posts,
            newPostText
        },
        dialogsPage: {
            dialogs,
            messages
        },
        sidebar
    } } = store;

    console.log(`Amount likes: ${posts[0].likesCount}`);

    filterDialogs(dialogs);

    changeMessage(messages);

    console.log(messages);
}

function filterDialogs(dialogs) {
    for (let i = 0; i < dialogs.length; i++) {
        if (!(dialogs[i].id % 2)) {
            console.log(dialogs[i]);
        }
    }
}

function changeMessage(messages) {
    for (let i = 0; i < messages.length; i++) {

        messages[i].message = "Hello user";

    }
}

function task4() {

    let tasks =
        [
            { id: 1, title: "HTML&CSS", isDone: true },
            { id: 2, title: "JS", isDone: true },
            { id: 3, title: "ReactJS", isDone: false },
            { id: 4, title: "Rest API", isDone: false },
            { id: 5, title: "Graphol", isDone: false },

        ];

    let newTaskTitle = prompt('Введите задачу: ');
    let size = tasks.length;
    let newTask = { id: size++, title: newTaskTitle, isDone: false };

    tasks[tasks.length++] = { ...newTask };

    console.log(tasks);
}

function task5() {
    console.log(sumValues(...[1, 2, 3]))
}

function sumValues(x, y, z) {
    return x + y + z;
}

function callJobs() {
    const buttons = document.querySelectorAll('button');
    const functions = [task1, task2, task3, task4, task5];

    buttons.forEach((elem, index) => {
        elem.addEventListener('click', functions[index]);
    })
}

callJobs();