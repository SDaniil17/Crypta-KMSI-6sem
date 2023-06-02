const crypto = require('crypto')

const hash = (text, secret = 'abcdefg') => {
    return crypto.createHmac('sha256', secret)
        .update(text)
        .digest('hex')
}

module.exports.hash = hash