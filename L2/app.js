const fs = require('fs');

let text = fs.readFileSync('latin.txt', 'utf-8');
// let binaryText = fs.readFileSync('binary.txt', 'utf-8');
let binaryText = '01001000011001010110110001101100011011110010110000100000010101110110111101110010011011000110010000100001';
text = text.toLowerCase();

console.log("BINARY TEXT: ", binaryText);

const alphabetLatin = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
const alphabetCyrilice = ['а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'];
const alphabetBinary = ['1', '0'];

let letters = {};            //empty array for amount of every letter
let lengthOfMessage = 0;    //length of only text without others symbols
let symbols = 0;            //amount of unique symbols
let Hs = 0;                 //Shennon entropy
let Hh;                     //Hartly entropy
let p;
let sumP = 0;

let digits = {};
let binLengthMessage = 0;

console.log('==========================================');
console.log('************* Latin alphabet *************')
console.log('==========================================\n');
console.log("Alphabet length: " + alphabetLatin.length);
console.log('Text length with others symbols: ' + text.length);

for (i = 0; i < text.length; i++) {
    if (alphabetLatin.includes(text[i])) {
        lengthOfMessage++;
        if (letters[text[i]] == undefined) {
            letters[text[i]] = 0;
            symbols++;
        }
        else {
            letters[text[i]]++;
        }
    }
}

console.log("Text length without others symbols: " + lengthOfMessage);
console.log("Amount of unique symbols in text: " + symbols + '\n');

function entropyShennon(letters, length) {
    Hs = 0;
    sumP = 0;
    for (let letter in letters) {
        p = letters[letter] / length;
        console.log(`Amount of (${letter}): ${letters[letter]} | P(${letter}) -> ${p}`);
        Hs += -1 * p * Math.log2(p);
        sumP += p;
    }
    console.log("\nSum of p: " + sumP + '\n');
    return Hs;
    // console.log("Entropy Shennon: " + Hs);
}

function entropyHartly(length) {
    Hh = Math.log2(length);
    return Hh;
}

//Task а)
let eS = entropyShennon(letters, lengthOfMessage);
let eH = entropyHartly(symbols);

console.log("Shennon Entropy (Latin): ", eS);
console.log("Hartly Entropy (Latin): ", eH);
console.log('\n==========================================\n\n\n');

console.log('=============================================');
console.log('************* Cyrilice alphabet *************')
console.log('=============================================\n');

let cyriliceText = fs.readFileSync('cirylice.txt', 'utf-8');
cyriliceText = cyriliceText.toLowerCase();

let lettersC = {};            //empty array for amount of every letter
let lengthOfMessageC = 0;    //length of only text without others symbols
let symbolsC = 0;            //amount of unique symbols
let HsC = 0;                 //Shennon entropy
let HhC;                     //Hartly entropy

for (i = 0; i < cyriliceText.length; i++) {
    if (alphabetCyrilice.includes(cyriliceText[i])) {
        lengthOfMessageC++;
        if (lettersC[cyriliceText[i]] == undefined) {
            lettersC[cyriliceText[i]] = 0;
            symbolsC++;
        }
        else {
            lettersC[cyriliceText[i]]++;
        }
    }
}

console.log("Text length without others symbols: " + lengthOfMessageC);
console.log("Amount of unique symbols in text: " + symbolsC + '\n');

HsC = entropyShennon(lettersC, lengthOfMessageC);
HhC = entropyHartly(symbolsC);

console.log("Shennon Entropy (Cyrilice): " + HsC);
console.log("Hartly Entropy (Cyrilice): " + HhC);

console.log('=============================================\n');

//Task б)
console.log('===========================================');
console.log('************* Binary alphabet *************')
console.log('===========================================\n');
symbols = 0;
for (i = 0; i < binaryText.length; i++) {
    if (alphabetBinary.includes(binaryText[i])) {
        binLengthMessage++;
        if (digits[binaryText[i]] == undefined) {
            digits[binaryText[i]] = 0;
            symbols++;
        }
        else {
            digits[binaryText[i]]++;
        }
    }
}

let bin_eS = entropyShennon(digits, binLengthMessage);
console.log('Binary alphabet entropy: ', bin_eS);

console.log('\n===========================================\n\n');

//Task в)
console.log('=================================================');
console.log('************* Amount of Information *************')
console.log('=================================================\n');

let FIO = "Sokolovskiy Daniil Viktorovich";
let ascii = "";

for (let i in FIO) {
    ascii += FIO[i].charCodeAt(0);
}
console.log("FIO: " + FIO);
console.log("ASCII FIO: " + ascii + '\n');

//calculate an amount of information by Shennon -> message: FIO/ASCII FIO
let amountFioInfo = eS * FIO.length;
let amountAsciiFioInfo = bin_eS * ascii.length;

console.log(`Amount of information -> message: "${FIO}" = ${amountFioInfo} bit`);
console.log(`Amount of information -> message: "${ascii}" = ${amountAsciiFioInfo} bit`);

console.log('\n=================================================\n\n');

//Task г)
console.log('===============================================================');
console.log('************* Amount of Information with mistakes *************')
console.log('===============================================================\n');

let mistake1 = 0.1;
let mistake2 = 0.5;
let mistake3 = 1.0;

function amountFioInfoWithMistake(message, entropy, p) {
    return message.length * (entropy - (-p * Math.log2(p) - (1.0 - p) * Math.log2(1.0 - p)));
}

console.log(`Amount of information (p=${mistake1}): ${amountFioInfoWithMistake(ascii, bin_eS, mistake1)} bit`);
console.log(`Amount of information (p=${mistake2}): ${amountFioInfoWithMistake(ascii, bin_eS, mistake2)} bit`);
console.log(`Amount of information (p=${mistake3}): ${amountFioInfoWithMistake(ascii, bin_eS, mistake3)}`);

console.log('\n===============================================================\n\n');

let english = "Sokolovskiy Daniil Viktorovich";
let russian = "Соколовский Даниил Викторович";

let asciiEng = "";
let asciiRus = "";

for (let i in english) {
    asciiEng += english[i].charCodeAt(0);
}

for (let i in russian) {
    asciiRus += russian[i].charCodeAt(0);
}

console.log("ENGLISH ASCII: ", asciiEng);
console.log("RUSSIAN ASCII: ", asciiRus);