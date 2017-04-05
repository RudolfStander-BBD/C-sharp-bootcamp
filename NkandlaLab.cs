using System;

class HomeStead {
    string name;
    string district;
    string province;
    string country;

    public HomeStead(string name, string district, string province, string country) {
        this.name = name;
        this.district = district;
        this.province = province;
        this.country = country;
    }

    public void accept(Visitor visitor) {
        visitor?.visit(this);
    }

    public string Name {
        get { 
            return this.name;
        }

        set { 
            this.name = value;
        }
    }

    public string District {
        get {
            return this.district;
        }

        set {
            this.district = value;
        }
    }

    public string Province {
        get {
            return this.province;
        }

        set {
            this.province = value;
        }
    }

    public string Country {
        get {
            return this.country;
        }

        set {
            this.country = value;
        }
    }
}

class Nkandla : HomeStead {
    string name;
    string district;
    string province;
    string country;
    string swimmingPool; // irrelevant
    string chickenRun; // irrelevant
    string amphitheatre; // irrelevant

    public Nkandla(string name, string district, string province, string country) : base(name, district, province, country) {
    }

    public string SwimmingPool {
        get {
            return this.swimmingPool;
        }

        set {
            this.swimmingPool = value;
        }
    }

    public string ChickenRun {
        get {
            return this.chickenRun;
        }

        set {
            this.chickenRun = value;
        }
    }

    public string Amphitheatre {
        get {
            return this.amphitheatre;
        }

        set {
            this.amphitheatre = value;
        }
    }
}

class Person {
    string name;
    int age;
    string gender;
    string type;

    public Person(string name, int age, string gender, string type) {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.type = type;
    }

    public string Name {
        get { 
            return this.name;
        }

        set { 
            this.name = value;
        }
    }

    public int Age {
        get { 
            return this.age;
        }

        set { 
            this.age = value;
        }
    }

    public string Gender {
        get { 
            return this.gender;
        }

        set { 
            this.gender = value;
        }
    }

    public string Type {
        get { 
            return this.type;
        }

        set { 
            this.type = value;
        }
    }
}

interface Visitor {
    void visit(HomeStead homeStead);
}

class Politician : Person, Visitor {
    string party;

    public Politician(string name, int age, string gender, string type, string party) : base(name, age, gender, type) {
        this.party = party;
    }

    public void visit(HomeStead homeStead) {
        if (this.Type == "politician" && party != "ANC") {
            Console.WriteLine($"{this.Name} is not welcome");
        } else {
            Console.WriteLine($"{this.Name} is welcome");
        }
    }
}

class JZ : Politician {
    Person lawyer; // irrelevant
    Person architect; // irrelevant

    public JZ(string name, int age, string gender, string type, string party) : base(name, age, gender, type, party) {
    }

    public Person Lawyer {
        get {
            return this.lawyer;
        }

        set {
            this.lawyer = value;
        }
    }

    public Person Architect {
        get {
            return this.architect;
        }

        set {
            this.architect = value;
        }
    }
}

class Program {
    static void Main() {
        JZ jz = new JZ("JZ", 100, "Male", "politician", "ANC");
        Politician helen = new Politician("Helen Zille", 60, "Female", "politician", "DA"); 
        Politician juju = new Politician("Juju", 40, "Male", "politician", "EFF");

        Nkandla nkandla = new Nkandla("Nkandla", "Zumaville", "State of Zuma", "SA");
        nkandla.accept(jz);
        nkandla.accept(helen);
        nkandla.accept(juju); 
    }
}