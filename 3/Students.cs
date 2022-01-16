using System;
using System.Collections.Generic;
using System.IO;
class Student
{
    private string surName;
    private string Name;
    private string university;
    private string faculty;
    private string department;
    int age;
    private int course;
    private int group;
    private string city;
    public Student(string surName, string Name, string university, string faculty, string department, int age, int course, int group, string city)
    {
        this.surName = surName;
        this.Name = Name;
        this.university = university;
        this.faculty = faculty;
        this.department = department;
        this.age = age;
        this.course = course;
        this.group = group;
        this.city = city;
    }

    
}