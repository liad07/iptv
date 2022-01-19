#include <iostream>
using namespace std;
string chanel;
string link="https://liad07.github.io/crack-apps.github.io/assets/iptv/iptv%20project/";

int main() {
    cout<<"please enter the chanel\n";
    cin >> chanel;
    if (chanel=="ספורט1" || chanel=="ספורט 1"||chanel=="51"){
        string tempch;
        cout<<"did you mean sport 1 ? yes/no\n ";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport1";
        }
    }
    if (chanel=="ספורט2" || chanel=="ספורט 2"||chanel=="52"){
        string tempch;
        cout<<"did you mean sport 2 ? yes/no\n ";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport2";
        }
    }
    if (chanel=="ספורט3" || chanel=="ספורט 3"||chanel=="53"){
        string tempch;
        cout<<"did you mean sport 3 ? yes/no\n ";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport3";
        }
    }
    if (chanel=="ספורט4" || chanel=="ספורט 4"||chanel=="54"){
        string tempch;
        cout<<"did you mean sport 4 ? yes/no \n";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport4";
        }
    }
    if (chanel=="ספורט5" || chanel=="ספורט 5"||chanel=="55"){
        string tempch;
        cout<<"did you mean sport 5 ? yes/no\n ";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport5";
        }
    }
    if (chanel=="ספורט5פלוס" || chanel=="ספורט 5 פלוס"||chanel=="56"){
        string tempch;
        cout<<"did you mean sport 5 plus ? yes/no\n ";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport5plus";
        }
    }
    if (chanel=="ספורט5גולד" || chanel=="ספורט 5 גולד"||chanel=="57"){
        string tempch;
        cout<<"did you mean sport 5 gold ? yes/no\n ";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport5gold";
        }
    }
    if (chanel=="ספורט5לייב" || chanel=="ספורט 5 לייב"||chanel=="58"){
        string tempch;
        cout<<"did you mean sport 5 live ? yes/no\n ";
        cin >>tempch;
        if (tempch=="yes"||tempch=="YES"){
            chanel="sport5live";

        }
    }
    string str3="",all=link+chanel;
    if (chanel == "kan11" || chanel == "keshet12" || chanel == "reshet13" || chanel == "now-14"){
        str3="news category";
       cout<<str3+"\n";
        cout<<"the link is\n" + all;
    }
    if (chanel == "sport1" || chanel == "sport2" || chanel == "sport3" || chanel == "sport4"||chanel == "sport5" || chanel == "sport5gold" || chanel == "sport5live" ||chanel=="sport5plus")
    {
        str3="sport category";
        cout<<str3+"\n";
        cout<<"the link is\n"+ all;
    }
    if (str3 == "news category" || str3 == "sport category")
    {

    }
    else
    {
        cout<<"Wrong link";

    }
}
