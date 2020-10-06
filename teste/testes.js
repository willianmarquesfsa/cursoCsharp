
const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the 'diagonalDifference' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
 */

function diagonalDifference(arr) {
    // Write your code here
    
    let i = 0
    let ii = 0
    let iii = 0
    let iiii = 0
    var arrnova1 = []
    var arrnova2 = []
    
    let resD1 = 0
    let resD2 = 0
    let resultado = 0


    for(i=0; i < arr.length ;i++){
        arrnova1.push(arr[i])

        for(ii=0;ii<arr.length;ii++){

            arrnova2.push(arr[i][ii])         
       
        }       
           } 
          
    for(iii = 0; iii< arrnova2.length; iii = iii + arrnova1.length+1){
                resD1 = resD1 + arrnova2[iii]                         

          }

    for(iiii = arrnova1.length-1; iiii<(arrnova2.length-(arrnova1.length-1)); iiii = iiii + (arrnova1.length-1))   {
        resD2 = resD2 + arrnova2[iiii]
    }      
   
    if(resD1<0){

        resD1 = resD1*(-1)
    }
    if(resD2<0){
        resD2=resD2*(-1)
    }        
      
    resultado = (resD1-resD2)
    if(resultado<0){
        resultado=resultado*(-1)
    } 
    return resultado+1
}








function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    let arr = Array(n);

    for (let i = 0; i < n; i++) {
        arr[i] = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));
    }

    const result = diagonalDifference(arr);

    ws.write(result + '\n');

    ws.end();
}
