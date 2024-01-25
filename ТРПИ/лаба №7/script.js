const products = {
    shoes: {
        boots: [
            {
                id: 1,
                size: 42,
                color: "black",
                price: 120
            },
            {
                id: 2,
                size: 37,
                color: "pink",
                price: 70
            },
            {
                id: 3,
                size: 40,
                color: "blue",
                price: 100
            }
            
        ],
        sneakers: [
            {
                id: 1,
                size: 41,
                color: "red",
                price: 80
            },
            {
                id: 2,
                size: 44,
                color: "black",
                price: 140
            }
            
        ],
        sandals: [
            {
                id: 1,
                size: 37,
                color: "white",
                price: 90
            },
            {
                id: 2,
                size: 40,
                color: "blue",
                price: 120
            }
        ]
    }
}

function filter(products, priceStart, priceEnd, size, color) {
   for (const product in products) {
        
            for (let i = 0; i < products[product].length; i++) {
                if(priceStart < products[product][i].price 
                    && priceEnd > products[product][i].price
                    && size === products[product][i].size
                    && color === products[product][i].color) {
                        console.log(`${product}: ${products[product][i].id}`);
                }
                
            }
        
   }
}

filter(products.shoes, 90, 140, 40, "blue");

let newProducts = {
    shoes: {
        boots: [
            {
                id: 1,
                size: 42,
                color: "black",
                cost: 120,
                discount: 0.2,
                get getPrice () {
                    return this.cost - (this.cost * this.discount);
                } 
            },
            {
                id: 2,
                size: 37,
                color: "pink",
                cost: 90,
                discount: 0.0,
                get getPrice () {
                    return this.cost - (this.cost * this.discount);
                } 
            }
        ],
        sneakers: [
            {
                id: 1,
                size: 41,
                color: "red",
                cost: 80,
                discount: 0.15,
                get getPrice () {
                    return this.cost - (this.cost * this.discount);
                } 
            },
            {
                id: 2,
                size: 44,
                color: "black",
                cost: 130,
                discount: 0.25,
                get getPrice () {
                    return this.cost - (this.cost * this.discount);
                } 
            }
        ],
        sandals: [
            {
                id: 1,
                size: 37,
                color: "white",
                cost: 120,
                discount: 0.2,
                get getPrice () {
                    return this.cost - (this.cost * this.discount);
                } 
            },
            {
                id: 2,
                size: 40,
                color: "blue",
                cost: 110,
                discount: 0.2,
                get getPrice () {
                    return this.cost - (this.cost * this.discount);
                } 

            }
        ]
    }
}

function defineProperty(property) {
    for (const key in newProducts.shoes) {
        for (let i = 0; i < newProducts.shoes[key].length; i++) {
            Object.defineProperty(newProducts.shoes[key][i], property, {
                configurable: false, 
                enumerable: true,
                writable: false,
                value: newProducts.shoes[key][i][property]
            });
        }
    }
}

defineProperty("getPrice");
defineProperty("id");

console.log(newProducts);


newProducts.shoes.boots[0].getPrice = 20;
console.log(newProducts.shoes.boots[0].id)

function Boots(size, color, cost, discount) {
    this.id = allProducts.shoes.boots.length;
    this.size = size;
    this.color = color;
    this.cost = cost;
    this.discount = discount;
}

function Sneakers(size, color, cost, discount) {
    this.id = allProducts.shoes.sneakers.length;
    this.size = size;
    this.color = color;
    this.cost = cost;
    this.discount = discount;
}

function Sandals(size, color, cost, discount) {
    this.id = allProducts.shoes.sandals.length;
    this.size = size;
    this.color = color;
    this.cost = cost;
    this.discount = discount;
}

let allProducts = {
    shoes: {
        boots: [],
        sneakers: [],
        sandals: []
    }
}

function AddShoes(type, shoes) {
    allProducts.shoes[type].push(shoes);
}

let boots = new Boots(40, "blue", 100, 0.1);
let sneakers = new Sneakers(39, "pink", 70, 0.0);
let sandals = new Sandals(42, "white", 130, 0.05);

AddShoes("boots", boots);
AddShoes("sneakers", sneakers);
AddShoes("sandals", sandals);

console.log(allProducts);
