const crypto = require('crypto')

const encrypt = (originalText, algorithm, key, iv) => {
    const cipher = crypto
        .createCipheriv(algorithm, key, iv)
    let encryptedData = cipher.update(originalText, 'utf-8', 'hex')
    encryptedData += cipher.final('hex')

    return encryptedData
}

const decrypt = (encryptedText, algorithm, key, iv) => {
    const decipher = crypto
        .createDecipheriv(algorithm, key, iv)
    let decryptedData = decipher.update(encryptedText, 'hex', 'utf8')
    decryptedData += decipher.final('utf8')


    return decryptedData
}


module.exports.encrypt = encrypt
module.exports.decrypt = decrypt


