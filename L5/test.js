// let text = "Hello my friends";

// let arr = new Array(4).fill(0).map(() => new Array(4).fill(0));
// let arr2 = new Array(4).fill(0).map(() => new Array(4).fill(0));

// let count = 0;

// for(i = 0; i<4; i++){
//     if(i % 2 == 0){ //для чётных
//         for(j = 3; j>=0; j--){
//             arr[j][i] = text[count];
//             count++;
//         }
//     }
//     if(i % 2 != 0){ //для нечётных
//         for(j = 0; j<4; j++){
//             arr[j][i] = text[count];
//             count++;
//         }
//     }
// }

// let encrypted = "";

// for(i = 0; i<4; i++){
//     if(i % 2 == 0){
//         for(j = 0; j<4; j++){
//             encrypted += arr[i][j];
//         }
//     }
//     if(i % 2 != 0){
//         for(j = 3; j>=0; j--){
//             encrypted += arr[i][j];
//         }
//     }
// }

// console.log('\n\n--------- Encrypt table ---------')
// console.log(arr);
// console.log('---------------------------------');
// console.log('Encrypted message: ' + encrypted, '\n\n');

// let decrypted = "";

// let encrypted_count = 0;

// for(i = 3; i>=0; i--){
//     if(i % 2 == 0){ //для чётных
//         for(j = 3; j>=0; j--){
//             arr2[i][j] = encrypted[encrypted_count];
//             encrypted_count++;
//         }
//     }
//     if(i % 2 != 0){ //для нечётных
//         for(j = 0; j<4; j++){
//             arr2[i][j] = encrypted[encrypted_count];
//             encrypted_count++;
//         }
//     }
// }

// for(i = 0; i<4; i++){
//     if(i % 2 == 0){
//         for(j = 0; j<4; j++){
//             decrypted += arr2[j][i];
//         }
//     }
//     if(i % 2 != 0){
//         for(j = 3; j>=0; j--){
//             decrypted += arr2[j][i];
//         }
//     }
// }

// console.log('--------- Decrypt table ---------')
// console.log(arr2);
// console.log('---------------------------------');
// console.log('Decrypted message: ' + decrypted, '\n\n');


/////////////    Test 2    /////////////

let text = "Hello my friendsHello my ";

function isInteger(num) {   //проверка на целое число
    return (num ^ 0) === num;
}

function NOD () {       //поиск НОД чисел
    for (var x = arguments[0], i = 1; i < arguments.length; i++) {
      var y = arguments[i];
      while (x && y) {
        x > y ? x %= y : y %= x;
      }
      x += y;
    }
    return x;
}

if(isInteger(Math.sqrt(text.length))){
    let sq = Math.sqrt(text.length);
let arr = new Array(sq).fill(0).map(() => new Array(sq).fill(0));
let arr2 = new Array(sq).fill(0).map(() => new Array(sq).fill(0));

let count = 0;

for(i = 0; i<sq; i++){
    if(i % 2 == 0){ //для чётных
        for(j = sq-1; j>=0; j--){
            arr[j][i] = text[count];
            count++;
        }
    }
    if(i % 2 != 0){ //для нечётных
        for(j = 0; j<sq; j++){
            arr[j][i] = text[count];
            count++;
        }
    }
}

let encrypted = "";

for(i = 0; i<sq; i++){
    if(i % 2 == 0){
        for(j = 0; j<sq; j++){
            encrypted += arr[i][j];
        }
    }
    if(i % 2 != 0){
        for(j = sq-1; j>=0; j--){
            encrypted += arr[i][j];
        }
    }
}

console.log('\n\n--------- Encrypt table ---------')
console.log(arr);
console.log('---------------------------------');
console.log('Encrypted message: ' + encrypted, '\n\n');

let decrypted = "";

let encrypted_count = 0;

for(i = sq-1; i>=0; i--){
    if(i % 2 == 0){ //для чётных
        for(j = sq-1; j>=0; j--){
            arr2[i][j] = encrypted[encrypted_count];
            encrypted_count++;
        }
    }
    if(i % 2 != 0){ //для нечётных
        for(j = 0; j<sq; j++){
            arr2[i][j] = encrypted[encrypted_count];
            encrypted_count++;
        }
    }
}

for(i = 0; i<sq; i++){
    if(i % 2 == 0){
        for(j = 0; j<sq; j++){
            decrypted += arr2[j][i];
        }
    }
    if(i % 2 != 0){
        for(j = sq-1; j>=0; j--){
            decrypted += arr2[j][i];
        }
    }
}

console.log('--------- Decrypt table ---------')
console.log(arr2);
console.log('---------------------------------');
console.log('Decrypted message: ' + decrypted, '\n\n');
}
else{
    console.log(`в текст добавили символ "$" для чётности`);
    text += '$';
    console.log("New message: ", text);
    console.log("LENGTH: " + text.length);

    let nods = [];
    for(i = 1; i<text.length; i++){
        nods.push(NOD(i, text.length));
    }

    console.log("Nods array: " + nods);
    console.log("MAX NOD: ", Math.max.apply(null, nods));
    let cols = Math.max.apply(null, nods);
    let rows = text.length/Math.max.apply(null, nods);

    console.log("COLS: " + cols);
    console.log("ROWS: " + rows);

let arr = new Array(rows).fill(0).map(() => new Array(cols).fill(0));
let arr2 = new Array(rows).fill(0).map(() => new Array(cols).fill(0));

let count = 0;

for(i = 0; i<cols; i++){
    if(i % 2 == 0){ //для чётных
        for(j = cols-1; j>=0; j--){
            arr[j][i] = text[count];
            count++;
        }
    }
    if(i % 2 != 0){ //для нечётных
        for(j = 0; j<cols; j++){
            arr[j][i] = text[count];
            count++;
        }
    }
}

let encrypted = "";

for(i = 0; i<rows; i++){
    if(i % 2 == 0){
        for(j = 0; j<cols; j++){
            encrypted += arr[i][j];
        }
    }
    if(i % 2 != 0){
        for(j = cols-1; j>=0; j--){
            encrypted += arr[i][j];
        }
    }
}

console.log('\n\n--------- Encrypt table ---------')
console.log(arr);
console.log('---------------------------------');
console.log('Encrypted message: ' + encrypted, '\n\n');

let decrypted = "";

let encrypted_count = 0;

for(i = rows-1; i>=0; i--){
    if(i % 2 == 0){ //для чётных
        for(j = cols-1; j>=0; j--){
            arr2[i][j] = encrypted[encrypted_count];
            encrypted_count++;
        }
    }
    if(i % 2 != 0){ //для нечётных
        for(j = 0; j<cols; j++){
            arr2[i][j] = encrypted[encrypted_count];
            encrypted_count++;
        }
    }
}

for(i = 0; i<cols; i++){
    if(i % 2 == 0){
        for(j = 0; j<rows; j++){
            decrypted += arr2[j][i];
        }
    }
    if(i % 2 != 0){
        for(j = rows-1; j>=0; j--){
            decrypted += arr2[j][i];
        }
    }
}

console.log('--------- Decrypt table ---------')
console.log(arr2);
console.log('---------------------------------');
console.log('Decrypted message: ' + decrypted, '\n\n');

} 


///////////////////////////////////////