//Условие
//#region 
let user = {
    name: 'Masha',
    age: 21
};

let numbers = [1, 2, 3];

let user1 = {
    name: 'Masha',
    age: 23,
    location: {
        city: 'Minsk',
        country: 'Belarus'
    }
};

let user2 = {
    name: 'Masha',
    age: 28,
    skills: ["HTML", "CSS", "JavaScript", "React"]
};

const array = [
    { id: 1, name: 'Vasya', group: 10 },
    { id: 2, name: 'Ivan', group: 11 },
    { id: 3, name: 'Masha', group: 12 },
    { id: 4, name: 'Petya', group: 10 },
    { id: 5, name: 'Kira', group: 11 },
]

let user4 = {
    name: 'Masha',
    age: 19,
    studies: {
        university: 'BSTU',
        speciality: 'designer',
        year: 2020,
        exams: {
            maths: true,
            programming: false
        }
    }
};

let user5 = {
    name: 'Masha',
    age: 22,
    studies: {
        university: 'BSTU',
        speciality: 'designer',
        year: 2020,
        department: {
            faculty: 'FIT',
            group: 10,
        },
        exams: [
            { maths: true, mark: 8 },
            { programming: true, mark: 4 },
        ]
    }
};

let user6 = {
    name: 'Masha',
    age: 21,
    studies: {
        university: 'BSTU',
        speciality: 'designer',
        year: 2020,
        department: {
            faculty: 'FIT',
            group: 10,
        },
        exams: [
            {
                maths: true,
                mark: 8,
                professor: {
                    name: 'Ivan Ivanov ',
                    degree: 'PhD'
                }
            },
            {
                programming: true,
                mark: 10,
                professor: {
                    name: 'Petr Petrov',
                    degree: 'PhD'
                }
            },
        ]
    }
};

let user7 = {
    name: 'Masha',
    age: 20,
    studies: {
        university: 'BSTU',
        speciality: 'designer',
        year: 2020,
        department: {
            faculty: 'FIT',
            group: 10,
        },
        exams: [
            {
                maths: true,
                mark: 8,
                professor: {
                    name: 'Ivan Petrov',
                    degree: 'PhD',
                    articles: [
                        { title: "About HTML", pagesNumber: 3 },
                        { title: "About CSS", pagesNumber: 5 },
                        { title: "About JavaScript", pagesNumber: 1 },
                    ]
                }
            },
            {
                programming: true,
                mark: 10,
                professor: {
                    name: 'Petr Ivanov',
                    degree: 'PhD',
                    articles: [
                        { title: "About HTML", pagesNumber: 3 },
                        { title: "About CSS", pagesNumber: 5 },
                        { title: "About JavaScript", pagesNumber: 1 },
                    ]
                }
            },
        ]
    }
};

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
        }
    }
}
//#endregion
function task1() {
    let cloneUser = {...user};

    let cloneNumbers = [...numbers];

    let cloneUser1 = {
        ...user1,
        location: {...user1.location}
    };

    let cloneUser2 = {
        ...user2, 
        skills: [...user2.skills]
    }

    let cloneArray = [
      
    ]
    array.forEach(el => {
        cloneArray.push({...el});
    })
    cloneArray[1].name = "Stas";
    console.log(cloneArray);

    
    let cloneUser4 = {
        ...user4, 
        studies: {
            ...user4.studies,
            exams: {
                ...user4.studies.exams
            }
        }
    }

    let cloneUser5 = {
        ...user5,
        studies: {
            ...user5.studies,
            department: {
                ...user5.studies.department
            },
            examp: [
                {...user5.studies.exams[0]},
                {...user5.studies.exams[1]}
            ]
        }
    }
    let cloneUser6 = {
        ...user6,
        studies: {
            ...user6.studies,
            department: {
                ...user6.studies.department
            },
            exams: [
                {
                    ...user6.studies.exams[0],
                    professor: {
                        ...user6.studies.exams[0],
                    }
                },                 
                {
                    ...user6.studies.exams[1],
                    professor: {
                        ...user6.studies.exams[1],
                    }
                },                 
                
            ]
        }
    }

    let cloneUser7 = {
        ...user7,
        studies: {
            ...user7.studies,
            department: {
                ...user7.studies.department
            },
            exams: [
                {
                    ...user7.studies.exams[0],
                    professor: {
                        ...user7.studies.exams[0].professor,
                        articles: [
                            {...user7.studies.exams[0].professor.articles[0]},
                            {...user7.studies.exams[0].professor.articles[1]},
                            {...user7.studies.exams[0].professor.articles[2]},
                        ]
                    } 
                },                
                {
                    ...user7.studies.exams[1],
                    professor: {
                        ...user7.studies.exams[1].professor,
                        articles: [
                            {...user7.studies.exams[1].professor.articles[0]},
                            {...user7.studies.exams[1].professor.articles[1]},
                            {...user7.studies.exams[1].professor.articles[2]},
                        ]
                    } 
                },                
                
            ]
        }
    }

    let cloneStore = {
        ...store,
        state: {
            profilePage: {
                ...store.state.profilePage,
                posts: [
                    {...store.state.profilePage.posts[0]},
                    {...store.state.profilePage.posts[1]}
                ]
            },
            dialogsPage: {
                dialogs: [
                    {...store.state.dialogsPage.dialogs[0]},
                    {...store.state.dialogsPage.dialogs[1]},
                    {...store.state.dialogsPage.dialogs[2]},
                    {...store.state.dialogsPage.dialogs[3]}
                ],
                messages: [
                    {...store.state.dialogsPage.messages[0]},
                    {...store.state.dialogsPage.messages[1]},
                    {...store.state.dialogsPage.messages[2]}
                ]
            }
        }
    }

    console.log(cloneNumbers);
    console.log(cloneArray);
    console.log(cloneUser);
    console.log(cloneUser1);
    console.log(cloneUser2);
    console.log(cloneUser4);
    console.log(cloneUser5);
    console.log(cloneUser6);
    console.log(cloneUser7);
    console.log(cloneStore);

    cloneUser5.studies.department.group = 12;
    cloneUser5.studies.examp[1].mark = 10;

    cloneUser6.studies.exams[0].professor.name = "Кудлацкая Марина Федоровна";
    cloneUser6.studies.exams[1].professor.name = "Шиман Дмитрий Васильевич";

    cloneUser7.studies.exams[0].professor.articles[1].pagesNumber = 3;
    
    cloneStore.state.dialogsPage.messages[0].message = "Hello"; 
    cloneStore.state.dialogsPage.messages[1].message = "Hello"; 
    cloneStore.state.dialogsPage.messages[2].message = "Hello"; 
}

task1();
