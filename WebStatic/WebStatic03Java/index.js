function Stack () {

    this._items = [];

}
// Stack.prototype.Push = function(item){
//     this._items.Push(item)
// }


// Stack.prototype.pop = function(){
//     if(!this._items.length){
//         throw new Error('Cannot pop from empty stack!');
        
//     }
//     return this._items.pop();
// }


// var elenco = new Stack()
// elenco.Push(8)
// console.log(elenco)
// elenco.Push(9)
// console.log(elenco)
var elenco = new Stack();
elenco._items.push(5)

console.log(elenco)


