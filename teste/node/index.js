const { request, response } = require('express');
const express = require('express');

const App = express();

const intei = 6

const arr2 = [-4, 3, -9, 0, 4, 1,]

const arr1 = [intei,arr2]

function plusMinus(arr) {
    
    var i=0;
    var negativos=0;
    var positivos=0
    var zeros=0

    for(i=0;i<arr.length;i++){

        if(arr[i]<0){
            negativos++
        }
        if(arr[i]==0){
            zeros++
        }
        if(arr[i]>0){
            positivos++
        }
    }

    var proN = 0;
    var proZ = 0;
    var proP = 0;
    var resu = ""

    proN = negativos/arr.length
    proZ = zeros/arr.length
    proP = positivos/arr.length

    
     resu = `${proP} \n ${proN} \n ${proZ}`

   
    
    return  resu
    
  
  
  }

App.get('/', (request, response)=> {
   response.json(plusMinus(arr2))
   
   plusMinus(arr2);
})




App.listen(3333);



