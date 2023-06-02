const crypto = require('crypto')

// x[t + 1] = (a * x[t] + c) mod n
const generator  = (a, c, n, count) => {
    let next = 1
    const result = []

    for (let i = 0; i < count; i++) {
        next = (a * next + c) % n
        result.push(next)
    }
    return result
}

const rc4encrypt = (text, key) => {
    const algorithm = 'rc4'

    const cipher = crypto.createCipher(algorithm, key)
    let encrypted = cipher.update(text, 'utf8', 'hex')
    encrypted += cipher.final('hex')

    return encrypted
}

const rc4decrypt = (encrypted, key) => {
    const algorithm = 'rc4'
    const decipher = crypto.createDecipher(algorithm, key)

    let decrypted = decipher.update(encrypted, 'hex', 'utf8')
    decrypted += decipher.final('utf8')

    return decrypted
}

module.exports.generator = generator
module.exports.rc4encrypt = rc4encrypt
module.exports.rc4decrypt = rc4decrypt