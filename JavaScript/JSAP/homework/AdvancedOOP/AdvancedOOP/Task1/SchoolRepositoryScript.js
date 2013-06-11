var dom = (function () {
    'use strict';

    if (!Object.prototype.extend) {
        Object.prototype.extend = function (properties) {
            function f() { };
            f.prototype = Object.create(this);
            for (var prop in properties) {
                f.prototype[prop] = properties[prop];
            }
            f.prototype._super = this;
            return new f();
        }
    }

    var School = {
        init: function (name, town, classes) {
            this.name = name;
            this.town = town;
            this.classes = classes;
        },

        addClass: function (Class, schoolClassesArray) {
            this.Class = Class;
            this.schoolClassesArray = schoolClassesArray;
            this.schoolClassesArray.push(Class);
            return schoolClassesArray;
        }
    };

    var Class = {
        init: function (name, studentsCapacity, setOfStudents, formTeacher) {
            this.name = name;
            this.studentsCapacity = studentsCapacity;
            this.setOfStudents = setOfStudents;
            this.formTeacher = formTeacher;
        },

        toString: function () {
            return "This is the school class: " + this.name + ", with students capacity of: " + this.studentsCapacity +
                " and form teacher: " + this.formTeacher;
        }
    };

    var Person = {
        init: function (fname, lname, age){
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        },

        introduce: function () {
            //maybe without this.constructor.name
            return " introducement - Name:" + this.fname + " " + this.lname + "," + "Age:" + this.age; 
    }
    };

    var Student = Person.extend({
        init: function (fname, lname, age, grade) {
            Person.init.apply(this, agruments);
            this.grade = grade;
        },
        introduce: function () {
            return "Student" + Person.introduce.apply(this) + ", grade: " + this.grade;
        }
    });


    var Teacher = Person.extend({
        init: function (fname, lname, age, speciality) {
            Person.init.apply(this, agruments);
            this.speciality = speciality;
        },
        introduce: function () {

            return "Teacher" + Person.introduce.apply(this) + ", speciality: " + this.speciality;
        }
    });


    //some simple tests
    //1.school test
    var joro = Object.create(Student);
    joro.init("Joro", "LName", 25, 5);
    var niki = Object.create(Student);
    niki.init("Niki", "LName", 26, 4);
    var nachko = Object.create(Teacher);
    nachko.init("Nachko", "LName", 35, 6);

    console.log(joro.introduce());

    //var students = [];
    //students.push(joro);
    //students.push(niki);
    //var DSA = Object.create(Class);
    //DSA.init("DSA", 100, students, "Nachko");
    //var JS = Object.create(Class);
    //JS.init("JS", 100, students, "Joro");
    
    //var telerikAcademy = Object.create(School);
    //var courses = [];
    //courses.push(DSA);
    //courses.push(JS);

    //telerikAcademy.init("Telerik Academy", "Sofia", courses);
    //console.log(telerikAcademy.toString());

    ////2.person test
    //console.log(joro.introduce());
}());
