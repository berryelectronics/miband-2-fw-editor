const fs = require('fs');

for(var i = 21; i <= 38; i++) {
    var filename = i.toString() + '.txt';
    fs.writeFileSync(filename, '');
}