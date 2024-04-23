using BB207HomeWork.lesson12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BB207HomeWork.lesson13.SerializeAndDeserialize.XmlSerializeAndDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student()
            //{
            //    Id = 1,
            //    Name = "Gulchohra",
            //    Surname = "Sultanova",
            //    Age = 20,
            //    Point = 90
            //};
            //XmlSerializer serializer = new XmlSerializer(typeof(Student));
            //using (StringWriter sw = new StringWriter())
            //{
            //    serializer.Serialize(sw, student);
            //    Console.WriteLine(sw);
            //}
            string xmlString = @"<?xml version=""1.0"" encoding=""utf-16""?>
        <Student>
            <Id>1</Id>
            <Name>Gulchohra</Name>
            <Surname>Sultanova</Surname>
            <Age>30</Age>
            <Point>90</Point>
        </Student>";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (StringReader sr = new StringReader(xmlString))
            {
                Student student = (Student)xmlSerializer.Deserialize(sr);
                Console.WriteLine(student);
            }
        }
    }
}
