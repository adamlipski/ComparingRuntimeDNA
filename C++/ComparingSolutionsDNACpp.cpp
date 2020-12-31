#include <iostream>
#include <string>
#include <chrono>
using namespace std;

char convert(char c)
{
    if (c == 'A') return 'C';
    if (c == 'C') return 'G';
    if (c == 'G') return 'T';
    if (c == 'T') return 'A';
    return ' ';
}

int main()
{
    /*
    Based on code from https://towardsdatascience.com/how-fast-is-c-compared-to-python-978f18f474c7
    Articel by Naser Tamimi
    */
    cout << "Based on code from https://towardsdatascience.com/how-fast-is-c-compared-to-python-978f18f474c7" << endl;
    cout << "Articel by Naser Tamimi" << endl;
    std::chrono::seconds sec(1);
    std::chrono::milliseconds ms = std::chrono::duration_cast<std::chrono::milliseconds> (sec);
    auto start = chrono::high_resolution_clock::now();
    cout << "Start" << endl;

    string opt = "ACGT";
    string s = "";
    string s_last = "";
    int len_str = 13;
    bool change_next;

    for (int i = 0; i < len_str; i++)
    {
        s += opt[0];
    }

    for (int i = 0; i < len_str; i++)
    {
        s_last += opt.back();
    }

    //int pos = 0;
    int counter = 1;
    while (s != s_last)
    {
        counter++;
        // You can uncomment the next line to see all k-mers.
        // cout << s << endl;  
        change_next = true;
        for (int i = 0; i < len_str; i++)
        {
            if (change_next)
            {
                if (s[i] == opt.back())
                {
                    s[i] = convert(s[i]);
                    change_next = true;
                }
                else {
                    s[i] = convert(s[i]);
                    break;
                }
            }
        }
    }

    // You can uncomment the next line to see all k-mers.
    // cout << s << endl;
    auto stop = chrono::high_resolution_clock::now();
    auto duration = (stop - start);
    ms = std::chrono::duration_cast<std::chrono::milliseconds> (duration);
    cout << (ms).count() << endl;
    cout << "Number of generated k-mers: " << counter << endl;
    cout << "Finish!" << endl;
    string input;
   
    cin >> input;
    return 0;
}