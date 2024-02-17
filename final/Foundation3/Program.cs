using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Lecture lecture = new Lecture("The History of Pants", "The esteemed doctor will lay out the entire history of pants; from their inception to the end", "April 29, 2024", "3:00 pm", "1234 Grace St, Logan, UT, 84321", "Dr. John Johnson", "500");
        Reception reception = new Reception("Humes Wedding Reception", "Christie and Neil Humes with Sam Chan and Seang Bunly are please to announce the marriage of Adam Neil Humes and Seang Sokunrath", "March 16, 2024", "5 in the evening", "1234 Nowhere St, Logan, UT, 84321", "humeswed@fakemail.com");
        Outdoor outdoor = new Outdoor("Concert in the Alley", "Playing are: Greg's Band and Steve who gave me $20", "July 24, 2024", "11:00 pm", "1234 Nowhere St, Logan, UT, 84321", "Sunny");

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);

        foreach(Event evento in events){
            Console.WriteLine(evento.ShortDescription());
            Console.WriteLine(evento.StandardDetails());
            Console.WriteLine($"{evento.FullDetails()}\n");
        }
    }
}