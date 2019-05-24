console.log("ciao mondo");

var aVariable = "a string value";
console.log(aVariable);
aVariable = 123;
console.log(aVariable);

if(aVariable){
    console.log("this is the double: " +(aVariable*2));
}
aVariable=0
if(aVariable){
    console.log("this is the double: " +(aVariable*2));
}

var a  = "123";
var b = 56;

var sum = a+b;
var diff = a-b;
var prod = a*b;
var div = a/b;
console.log("sum: "+ sum);
console.log("diff: "+ diff);
console.log("prod: "+ prod);
console.log("div: "+ div);

var aa ="pippo";
sum= aa -b;
console.log("sum: "+ sum);

var isPrime = true;
console.log("is 101 prime?")
for(var i=2;i< 101;i++)
{
    if(101 % i ==0)
    {
        isPrime = false;
        break;
    }
}

isPrime ? console.log("YES") : console.log("NO")

console.log("print all the squares minor than 100")
var i = 1;
var square;
while (square = i*i<100) {
    console.log(i*i)
    i++
}

console.log("'0' == 0?","0" == 0);
console.log("[] == 0?",[] == 0);
console.log("0 == []?",[] == "0");

console.log("'0' == 0?","0" == 0);
console.log("0 == []?",0 == false);
console.log("'0' == false?","0" == false);
console.log("'' == false?",'' == false);
console.log("'null' == false?",null == false);


var s ="ciao";
s='ciao';
console.log(s);
var name = "Mario";
var message = `Hello ${name}`;
console.log(message);

var notDefinedVariable;
console.log("not defined/assigned variable:",notDefinedVariable)

function compare(n1,n2) {
    if(isNaN(n1)){
        return;
    }
    if(isNaN(n2)){
        throw new Error;
        
    }
    if(n1 < n2) {
        return -1;
    } else if (n1 > n2) {
        return 1;
    } else {
        return 0;
    }
}

console.log(parseInt("1000",2));

console.log(parseInt("pippo",10));

var array = [];
array = [1,2,3];
console.log("First element of the array: "+ array[0]);
console.log("Element out of range: "+ array[10]);
array.push(4);
console.log("pushed element: "+ array[3]);
console.log("array lenght: "+ array.length);
console.log(array.pop());
array.splice(1,2);

array = [1,2,3,4]
var double = array.map(x=> x*2);
console.log(array.map(x=>x*2 ));