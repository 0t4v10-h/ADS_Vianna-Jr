class Person{

    _name = '';
    age = 0;
    gender = '';
    interests = [];

    constructor(first, last, age, gender, interests) {
        this._name = {
            'first': first,
            'last': last
        };
        this.age = age;
        this.gender = gender;
        this.interests = interests;
    }

    bio() {
        // First define a string, and make it equal to the part of
        // the bio that we know will always be the same.
        let string = this.name.first + ' ' + this.name.last + ' is ' + this.age + ' years old. ';
        // define a variable that will contain the pronoun part of
        // the second sentence
        let pronoun;
    
        // check what the value of gender is, and set pronoun
        // to an appropriate value in each case
        if (this.gender === 'male' || this.gender === 'Male' || this.gender === 'm' || this.gender === 'M') {
            pronoun = 'He likes ';
        } else if (this.gender === 'female' || this.gender === 'Female' || this.gender === 'f' || this.gender === 'F') {
            pronoun = 'She likes ';
        } else {
            pronoun = 'They like ';
        }
    
        // add the pronoun string on to the end of the main string
        string += pronoun;
    
        // use another conditional to structure the last part of the
        // second sentence depending on whether the number of interests
        // is 1, 2, or 3
        if (this.interests.length === 1) {
            string += this.interests[0] + '.';
        } else if (this.interests.length === 2) {
            string += this.interests[0] + ' and ' + this.interests[1] + '.';
        } else {
            // if there are more than 2 interests, we loop through them
            // all, adding each one to the main string followed by a comma,
            // except for the last one, which needs an and & a full stop
            for (let i = 0; i < this.interests.length; i++) {
                if (i === this.interests.length - 1) {
                    string += 'and ' + this.interests[i] + '.';
                } else {
                    string += this.interests[i] + ', ';
                }
            }
        }
    
        // finally, with the string built, we alert() it
        alert(string);
    };

    greeting() {
        alert('Hi! I\'m ' + this.name.first + '.');
    };

    farewell() {
        alert(this.name.first + ' has left the building. Bye for now!');
    }

    goodbye() {
        alert('Goodbye!');
    };

    get name(){
        return `${this._name.first} ${this._name.last}`;
    }
    set name(fullName){
        let words = fullName.split(' ');
        this._name.first = words[0];
        this._name.last = words[1];
    }
    
}



class Teacher extends Person{

    #subject;

    constructor(first, last, age, gender, interests,subject) {
        super(first, last, age, gender, interests)
        this.#subject = subject;
    }

    lesson(){
        alert('Start lesson!');
    }

    get subject(){
        return this.#subject;
    }
    set subject(newSubject){
        this.#subject = newSubject;
    }
}



let professor = new Teacher('Gildo', 'Leonel', 38, 'male',['CSS','JS','Jogos'],['JS','CSS','PHP','IA']);

console.log(professor.name);



class Usuario{

    #email = '';
    #senha = '';

    constructor(email, senha){
        this.#email = email;
        this.#senha = senha;
    }

    get email(){
        return this.#email;
    }
    set email(email){
        this.#email = email;
    }

    get senha(){
        return this.#senha;
    }
    set senha(senha){
        this.#senha = senha;
    }

    isAdmin = function() {
        return this.admin ? true : false;
    }
}

class Admin extends Usuario{
    
    admin = false;

    constructor(email, senha){
        super(email, senha);
        this.admin = true;
    }

    get admin(){
        return this.admin;
    }
}

let user = new Usuario('zeCu@email.com', '12345');
let administrador = new admin('zeRuela@email.com','67890');

console.log(administrador.email);