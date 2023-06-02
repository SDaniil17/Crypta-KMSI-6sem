const encrypt = (originalText, cols) => {
    const n = originalText.length
    const rows = Math.floor((n - 1) / cols) + 1 // k = [(n − 1)/s] + 1
    const arr = originalText.split('')

    let encryptedText = ''

    for (let j = 0; j < cols; j++) {
        for (let i = 0; i < rows; i++) {
            let el = arr[i * cols + j]
            encryptedText += (el !== undefined ? el : '~')
        }
    }
    return encryptedText;
}

const decrypt = (encryptedText, cols) => {
    let decryptedText = ''

    const n = encryptedText.length
    const rows = Math.floor((n - 1) / cols) + 1 // k = [(n − 1)/s] + 1
    const arr = encryptedText.split('')


    for (let i = 0; i < rows; i++) {
        for (let j = 0; j < cols; j++) {
            let el = arr[j * rows + i]
            decryptedText += (el !== '~' ? el : '')
        }
    }
    return decryptedText;

}

const encryptMulti = (originalText, key1, key2) => {
    let encryptedText = ''

    const rows = key1.length;
    const cols = key2.length;

    // sort key1 symbols
    let orderRows = key1
        .split('')
        .map((symbol, i) => ({symbol, i}))
        .sort((a, b) => a.symbol.localeCompare(b.symbol))
        .map(el => el.i)
    // console.log(orderRows)

    let orderCols = key2
        .split('')
        .map((symbol, i) => ({symbol, i}))
        .sort((a, b) => a.symbol.localeCompare(b.symbol))
        .map(el => el.i)
    // console.log(orderCols)

    for (let i = 0; i < rows; i++) {
        for (let j = 0; j < cols; j++) {
            const encryptedSymbol = originalText[orderRows[i] * cols + orderCols[j]];
            encryptedText += encryptedSymbol !== undefined ? encryptedSymbol : '~'
        }
    }

    return encryptedText;
}

const decryptMulti = (encryptedText, key1, key2) => {
    let decryptedText = ''
    const rows = key1.length;
    const cols = key2.length;

    // sort key1 symbols
    let orderRows = key1
        .split('')
        .map((symbol, i) => ({symbol, i}))
        .sort((a, b) => a.symbol.localeCompare(b.symbol))
        .map(el => el.i) // console.log(orderRows)

    let orderCols = key2
        .split('')
        .map((symbol, i) => ({symbol, i}))
        .sort((a, b) => a.symbol.localeCompare(b.symbol))
        .map(el => el.i) // console.log(orderCols)

    for (let i = 0; i < rows; i++) {
        let newi = orderRows.indexOf(i)
        for (let j = 0; j < cols; j++) {
            let newj = orderCols.indexOf(j)
            let decryptedSymbol = encryptedText[newi * cols + newj]
            decryptedText += decryptedSymbol !== '~' ? decryptedSymbol : ''
        }
    }
    return decryptedText;
}

const printHistogram = (text) => {
    let symbolCountMap = new Map();

    text.split('').forEach(symbol => {
        if (symbolCountMap.has(symbol)) {
            let oldValue = symbolCountMap.get(symbol)
            symbolCountMap.set(symbol, ++oldValue)
        } else {
            symbolCountMap.set(symbol, 1)
        }
    })

    console.log(symbolCountMap);

    let length = text.length;
    symbolCountMap.forEach((value, key) => {
        const sharpAmount = Math.floor(value / length * 400)
        if (sharpAmount > 0) {
            let tmp = `${key}: `
            for (let i = 0; i < sharpAmount; i++) {
                tmp += '▉'
            }
            console.log(tmp)
        }
    })

}

module.exports.encrypt = encrypt
module.exports.decrypt = decrypt
module.exports.encryptMulti = encryptMulti
module.exports.decryptMulti = decryptMulti

module.exports.printHistogram = printHistogram