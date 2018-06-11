const fs = require('fs');

var charArray = ['_A', '_D', '_F', '_J', '_M', '_N', '_O', '_S', '_T', '_W']

for(var i = 0; i < charArray.length; i++) {
    var filename = charArray[i] + '.txt';
    fs.writeFileSync(filename, '');
}