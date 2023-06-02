const { hash } = require("./util")
const fs = require('fs')

const secret = 'abcdefg'

const originalText = fs.readFileSync('./originalText.txt', 'utf8')

let timer = Date.now()
const hashedText = hash(originalText, secret)
timer = Date.now() - timer

console.log('Original Text: ', originalText)
console.log('Hashed Text: ', hashedText)
console.log('Timer:', timer)
