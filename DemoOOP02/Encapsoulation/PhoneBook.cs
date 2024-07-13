using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Encapsoulation
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] Names;
        int[] Numbers;
        int size;

        #endregion
        #region peoperty
        public int Size
        {
            get { return size; }
        }

        // phoneBook["Mido"] =999
        //Indexer => is a special property
        // 1. Nmae with Keyword  "this"
        //2.Can Take paramete
        public int this[string name]
        {
            get 
            {
                if (Names is not null && Numbers is not null)
                  for (int i = 0; i <Names.Length; i++)
                         if (Names[i]==name)
                          {
                                return Numbers[i];
                          }
                    
                 return -1;

            }
            set 
            {
                //Note["Mona"]=999
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    
                        if (Names[i] == name)
                        {
                            Numbers[i] = value;
                            break;
                        }
                    
                }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"{index}::{Names[index]}::::{Numbers[index]}";
            }
        }
        #endregion
        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            Names = new string[size];
            Numbers = new int[size];
        }
        #endregion
        #region Method add to person into Note
        // object Member function [Non-static]
        public void AddPerson(int position,string name,int Number)
        {
            if (Numbers is not null && Names is not null)
                if (position < size)
                {
                    Names[position] = name;
                    Numbers[position] = Number;
                }
            
        }
        #endregion
        #region Getter Setter
        //Get
        public int GetPersonNumber(string name)
        {
            if(Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i]== name)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;
        }



        //Set
        public void setpersonNumber(string name ,int newnum)
        {
            if (Names is not null &&Numbers is not null)
            {
                for (int i = 0; i <Names.Length; i++)
                {
                    if (Names[i]== name)
                    {
                        // setNumber
                        Numbers[i]= newnum;
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
