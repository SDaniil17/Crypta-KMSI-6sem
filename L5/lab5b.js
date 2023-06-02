// 2. Множественная перестановка, ключевые
// слова – собственные имя и фамилия

const util = require('./lab5util')
const fs = require('fs')

const originalText = fs.readFileSync('./original.txt', 'utf-8')

console.log('originalText:', originalText)

const key1 = 'daniil'
const key2 = 'sokolovskiy'

let time = Date.now()
const encryptedText = util.encryptMulti(originalText, key1, key2)
console.log('Encryption Time', Date.now() - time)
console.log('encryptedText:', encryptedText)

time = Date.now()
const decryptedText = util.decryptMulti(encryptedText, key1, key2)
console.log('Decryption Time', Date.now() - time)
console.log('decryptedText:', decryptedText)


console.log('Histogram of Original Text')
util.printHistogram(originalText.substr(0, encryptedText.length))

console.log('----------------------')
console.log('Histogram of Encrypted Text')
util.printHistogram(encryptedText)