const { Cup } = require('../cup')

describe('CUP TEST', () => {
    let cup

    beforeEach(() => {
        cup = new Cup()
        cup.fill()
    })

    test('number of level equals 10 ', () => {
        expect( cup.level ).toBe(10)
    })

    describe('when a person drink', () => {
        beforeEach(() => {
            cup = new Cup()
            cup.fill()
            cup.drink(6,'Mario')
        })
        test('number of level is 4', () => {
            expect( cup.level).toBe(4)
        })
    })

    describe('when a person drinks over the level', () => {
        beforeEach(() => {
            cup = new Cup()
            cup.fill()
            cup.drink(6,'Mario')
        })
        test('throws Error because the level is over', () => {
            expect(() => cup.drink(6,'Mario')).toThrow(Error)
        })
        test('throws Error because the person is different', () => {
            expect(() => cup.drink(1,'Francesco')).toThrow(Error)
        })
        test('number of level is 5', () => {
            expect( cup.level ).toBe(4)
        })
    })

    describe('A washed cup can be drunk by a different person', () => {
        beforeEach(() => {
            cup = new Cup()
            cup.fill()
            cup.drink(9,'Mario')
            cup.wash()
            cup.fill()
            cup.drink(9,'Francesco')
        })
        test('person equal Francesco', () => {
            expect( cup.level).toBe(1)
            expect( cup.person).toBe('Francesco')
        })
    })
    describe('A empty cup ', () => {
        beforeEach(() => {
            cup = new Cup()
        })
        test(('level cup is 0 and person null'), () => {
            expect( cup.level).toBe(0)
            expect( cup.person).toBe(null)
        })
    })
    describe('A drinks cup more time', () => {
        beforeEach(() => {
            cup = new Cup()
            cup.fill()
            cup.drink(2,'Mario')
            cup.drink(5,'Mario')
        })
        test(('person equal Mario'), () => {
            expect( cup.person).toBe('Mario')
        })
    })

})