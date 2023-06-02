const { generator, rc4encrypt, rc4decrypt } = require('./util')

const a = 430
const c = 2531
const n = 11979

const count = 10
const result = generator(a, c, n, count)

console.log('Generated: ', result)

const text = 'Sokkolovskiy Daniil hello world!'

const key = Buffer.from([61, 60, 23, 22, 21, 20])


const encryptedText = rc4encrypt(text, key)
console.log('Encrypted text: ', encryptedText)

const decryptedText = rc4decrypt(encryptedText, key)
console.log('Decrypted text: ', decryptedText)  