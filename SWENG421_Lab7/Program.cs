using SWENG421_Lab7;

class Program
{
    public static void Main()
    {
        Novel novel = new Novel();
        Page page1 = new Page();
        Column column1 = new Column();
        Column column2 = new Column();
        Frame frame1 = new Frame();
        LineOfText line1 = new LineOfText();
        LineOfText line2 = new LineOfText();
        
        line1.Add(new Character('S'));
        line1.Add(new Character('W'));
        line1.Add(new Character('E'));
        line1.Add(new Character('N'));
        line1.Add(new Character('G'));
        column1.Add(line1);

        line2.Add(new Character('4'));
        line2.Add(new Character('2'));
        line2.Add(new Character('1'));
        frame1.Add(column2);
        column2.Add(line2);

        page1.Add(column1);
        page1.Add(frame1);
        novel.Add(page1);

        //uncomment when completed
        //Writer writer = new Writer();
        //writer.View(novel);
    }
}