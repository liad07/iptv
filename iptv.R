link<-"https://liad07.github.io/crack-apps.github.io/assets/iptv/iptv%20project/";
chanel <- readline(prompt = "Enter any chanel  : ");
# result = paste(link,"/",chanel)
if (chanel == "ספורט1" | chanel == "ספורט 1" | chanel == "51")
{
   tempch="";
print("did you mean sport 1 ? yes/no");
tempch= readline();
tempch=tolower(tempch);
if (tempch=="yes")
{
chanel = "sport1";
}
}
if (chanel == "ספורט2" | chanel == "ספורט 2" | chanel == "52")
{
  tempch="";
  print("did you mean sport 2 ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "sport2";
  }
}
if (chanel == "ספורט3" | chanel == "ספורט 3" | chanel == "53")
{
  tempch="";
  print("did you mean sport 3 ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "sport3";
  }
}
if (chanel == "ספורט4" | chanel == "ספורט 4" | chanel == "54")
{
  tempch="";
  print("did you mean sport 4 ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "sport4";
  }
}
if (chanel == "ספורט5" | chanel == "ספורט 5" | chanel == "55")
{
  tempch="";
  print("did you mean sport 5 ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "sport5";
  }
}
if (chanel == "ספורט5פלוס" | chanel == "ספורט 5 פלוס" | chanel == "56")
{
  tempch="";
  print("did you mean sport5plus ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "sport5plus";
  }
}
if (chanel == "ספורט5גולד" | chanel == "ספורט 5 גולד" | chanel == "57")
{
  tempch="";
  print("did you mean sport5plusgold  ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "sport5gold";
  }
}
if (chanel == "ספורט5לייב" | chanel == "ספורט 5 לייב" | chanel == "58")
{
  tempch="";
  print("did you mean sport5live  ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "sport5live";
  }
}
if (chanel == "כאן11" | chanel == "כאן 11" | chanel == "11")
{
  tempch="";
  print("did you mean kan11  ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "kan11 ";
  }
}
if (chanel == "קשת12" | chanel == "קשת 12" | chanel == "12")
{
  tempch="";
  print("did you mean keshet12  ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "keshet12 ";
  }
}
if (chanel == "רשת13" | chanel == "רשת 13" | chanel == "13")
{
  tempch="";
  print("did you mean reshet13   ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "reshet13 ";
  }
}
if (chanel == "עכשיו14" | chanel == "עכשיו 14" | chanel == "14")
{
  tempch="";
  print("did you mean now-14  ? yes/no");
  tempch= readline();
  tempch=tolower(tempch);
  if (tempch=="yes")
  {
    chanel = "now-14";
  }
}
str3="";
result = paste(link, chanel, sep = "");
result=tolower(result)
if (chanel == "kan11" | chanel == "keshet12" | chanel == "reshet13" | chanel == "now-14")
{
  str3="news category";
 print(str3);
  print("the link is" + result);
}
if (chanel == "sport1" | chanel == "sport2" | chanel == "sport3" | chanel == "sport4"|chanel == "sport5" | chanel == "sport5gold" | chanel == "sport5live" |chanel=="sport5plus")
{
  str3="sport category";
  print(str3);
  print("the link is"  );
  print(result)
}
if (str3 == "news category" | str3 == "sport category")
{
str3="checkwork"}
if(str3!="checkwork"){
  print("wrong link")
}
# else {
#   print("wrong link");}

# print(link+"\n")
# print(chanel)