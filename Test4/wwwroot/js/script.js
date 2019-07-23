function createMainGrid(){
    let table = document.getElementById("table");
    let cells = [];
    for(let i = 0;i<6; i++){
        let row = document.createElement("tr")
        for(let j = 0;j<6; j++){
            let cell = document.createElement("td")
            cell.id = i * 6 + j ;
           /*  cell.setStateOccupied();
            cell.setStateFree();
            cell.isOccupied() */
            row.appendChild(cell)
            cells.push(cell)
        }
        table.appendChild(row)
    }
    return cells
}

function createSecondGrid(){
    let piece = document.getElementById("piece");
    let cells = [];
    for(let i = 0;i<2; i++){
        let row = document.createElement("tr")
        for(let j = 0;j<2; j++){
            let cell = document.createElement("td")
            cell.id = i * 2 + j ;
            row.appendChild(cell)
            cells.push(cell)
        }
        piece.appendChild(row)
    }
    return cells
}

function pieceN1(){
    let piece = document.getElementById("piece")
    let td = piece.getElementsByTagName("td")
    var cell1 = td.document.getElementById("1")
    var cell2 = td.document.getElementById("2")
    var cell3 = td.document.getElementById("3")

    cell1.style.backgroundColor = "#f00"
    cell2.style.backgroundColor = "#f00"
    cell3.style.backgroundColor = "#f00"

}

function play(){
    createMainGrid();
    createSecondGrid();
    pieceN1();
}