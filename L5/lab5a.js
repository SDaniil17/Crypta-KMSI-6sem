// 1. Маршрутная перестановка (маршрут запись –
// по столбцам, считывание – по строкам таблицы;

const util = require('./lab5util')
const fs = require('fs')

const originalText = fs.readFileSync('./original.txt', 'utf-8')

console.log('originalText:', originalText)

const cols = 10  // 10 cols

let time = Date.now()
const encryptedText = util.encrypt(originalText, cols)
console.log('Encryption Time', Date.now() - time)
console.log('encryptedText:', encryptedText)

time = Date.now()
const decryptedText = util.decrypt(encryptedText, cols)
console.log('Decryption Time', Date.now() - time)
console.log('decryptedText:', decryptedText)


console.log('Histogram of Original Text')
util.printHistogram(originalText)

console.log('----------------------')
console.log('Histogram of Encrypted Text')
util.printHistogram(encryptedText)