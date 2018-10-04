using LabsTogether2.src.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 В классах должна содержаться основная информация о паспортных данных абитуриента,
 об уровне образования, об экзаменах, о выбранных специальностях.*/

namespace LabsTogether2.src.entities
{
    public class Student: Person
    {
        /// <summary>
        /// Уровень образования
        /// </summary>
        public LevelOfEducation Education { get; set; }
        /// <summary>
        /// Экзамен и оценка за экзамен
        /// </summary>
        public Dictionary<Subject,int> ExamMarks { get; private set; }
        /// <summary>
        /// Паспортные данные
        /// </summary>
        public int PassportID { get; set; }
        
        /// <summary>
        /// Студент
        /// </summary>
        /// <param name="firstName"> Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="passportID">Номер паспорта</param>
        /// <param name="levelOfEducation">Уровень образования</param>
        public Student(string firstName, string lastName, string patronymic, int passportID, LevelOfEducation levelOfEducation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronymic = patronymic;
            this.Education = levelOfEducation;
            this.PassportID = passportID;
            ExamMarks = new Dictionary<Subject, int>();
        }
        
    }
}
