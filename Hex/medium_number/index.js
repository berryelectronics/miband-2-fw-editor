const fs = require('fs');

for(var i = 0; i <= 9; i++) {
    var filename = i.toString() + '.txt';
    fs.writeFileSync(filename, '');
}