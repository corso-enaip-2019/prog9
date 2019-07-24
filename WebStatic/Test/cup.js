class Cup{
    constructor(){
        this.level = 0
        this.person = null
    }

    fill(){
        this.level = 10;
    }

    drink(sips , person){
        this.level -= sips
        if(this.level < 0){
            throw new Error('The sips is to much of cup level')
            this.level += sips 
        }
        if(this.person == null){
        this.person = person
        }
        if(this.person != person){
        throw new Error('The person is different')
        }
    }

    wash(){
        this.level = 0
        this.person = null
    }
}

module.exports.Cup = Cup