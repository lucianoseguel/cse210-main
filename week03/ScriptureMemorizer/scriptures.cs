using System;
public class Verse
{


    private string _book;
    private string _verse;

    public void Setverse(string book, string verse)
    {
        _book = book;
        _verse = verse;

    }

    public string Getverse()
    {
        if (_book != null && _verse != null)
        {

            return $"{_book}: {_verse}";
        }
        else
        {
            return "No verse set";
        }

    }

    public string Getonlyverse()
    {
        if (_verse != null)
        {
            return _verse;
        }
        else
        {
            return "No verse set";
        }

    }

    public  string Getbook()
    {
        if (_book != null)
        {
            return _book;
        }
        else
        {
            return "No verse set";
        }

    }

}


