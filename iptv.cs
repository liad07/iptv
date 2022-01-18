// See https://aka.ms/new-console-template for more information
string link;
string chanel;
link="https://liad07.github.io/crack-apps.github.io/assets/iptv/iptv%20project/";

Console.WriteLine("please enter the chanel");
chanel = Console.ReadLine();
if (chanel == "ספורט1" || chanel == "ספורט 1" || chanel == "51")
{
    string tempch;
    Console.WriteLine("did you mean sport 1 ? yes/no");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport1";
    }
}
if (chanel == "ספורט2" || chanel == "ספורט 2" || chanel == "52")
{
    string tempch;
    Console.WriteLine("did you mean sport 2 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport2";
    }
}
if (chanel == "ספורט3" || chanel == "ספורט 3" || chanel == "53")
{
    string tempch;
    Console.WriteLine("did you mean sport 3 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport3";
    }
}
if (chanel == "ספורט4" || chanel == "ספורט 4" || chanel == "54")
{
    string tempch;
    Console.WriteLine("did you mean sport 4 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport4";
    }
}
if (chanel == "ספורט5" || chanel == "ספורט 5" || chanel == "55")
{
    string tempch;
    Console.WriteLine("did you mean sport 5 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport5";
    }
}
if (chanel == "ספורט5פלוס" || chanel == "ספורט 5 פלוס" || chanel == "56")
{
    string tempch;
    Console.WriteLine("did you mean sport5plus ? yes/no");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport5plus";
    }
}
if (chanel == "ספורט5גולד" || chanel == "ספורט 5 גולד" || chanel == "57")
{
    string tempch;
    Console.WriteLine("did you mean sport5plus ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport5gold";
    }
}
if (chanel == "ספורט5לייב" || chanel == "ספורט 5 לייב" || chanel == "58")
{
    string tempch;
    Console.WriteLine("did you mean sport5plus ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "sport5live";
    }
}
if (chanel == "כאן11" || chanel == "כאן 11" || chanel == "11")
{
    string tempch;
    Console.WriteLine("did you mean kan11 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "kan11";
    }
}
if (chanel == "קשת12" || chanel == "קשת 12" || chanel == "12")
{
    string tempch;
    Console.WriteLine("did you mean keshet12 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "keshet12";
    }
}
if (chanel == "רשת13" || chanel == "רשת 13" || chanel == "13")
{
    string tempch;
    Console.WriteLine("did you mean reshet13 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "reshet13";
    }
}
if (chanel == "עכשיו14" || chanel == "עכשיו 14" || chanel == "14")
{
    string tempch;
    Console.WriteLine("did you mean now-14 ? yes/no ");
    tempch= Console.ReadLine();
    tempch=tempch.ToLower();
    if (tempch=="yes"||tempch=="כן")
    {
        chanel = "now-14";
    }
}
string all;
all = link + chanel;
string str3 = "";
if (chanel == "kan11" || chanel == "keshet12" || chanel == "reshet13" || chanel == "now-14")
{
      str3="news category";
     Console.WriteLine(str3);
     Console.WriteLine("the link is" + all.ToLower());
}
if (chanel == "sport1" || chanel == "sport2" || chanel == "sport3" || chanel == "sport4"||chanel == "sport5" || chanel == "sport5gold" || chanel == "sport5live" ||chanel=="sport5plus")
{
     str3="sport category";
    Console.WriteLine(str3);
    Console.WriteLine("the link is\n" +all.ToLower());
}

if (str3 == "news category" || str3 == "sport category")
{
    
}
else
{
    Console.WriteLine("Wrong link");

}
