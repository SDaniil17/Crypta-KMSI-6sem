const { encrypt, decrypt } = require('./util')
const fs = require('fs')
const crypto = require('crypto')
const algorithm = 'aes-192-cbc'
const password = 'Password used to generate key' 
const iv = Buffer.alloc(16, 0) 
const key = crypto.scryptSync(password, 'salt', 24)
const originalText = fs.readFileSync('./original-text.txt')
const encryptedText = encrypt(originalText, algorithm, key, iv)
console.log('Encrypted: ', encryptedText)
const decryptText = decrypt(encryptedText, algorithm, key, iv)
console.log('Decrypted: ', decryptText)

fs.writeFileSync('./encrypted-data.txt', encryptedText)



