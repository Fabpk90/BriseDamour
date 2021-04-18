using System;
using System.Collections.Generic;
using UnityEngine;

namespace Letter
{
    [RequireComponent(typeof(CSV_Reader))]
    public class LetterManager : MonoBehaviour
    {
        public CSV_Reader reader;
        public string[,] TextFromCSV;

        //je suppose que c'est le chemin que tu veux passer au CSV reader ? 
        private string pathData;
        public static LetterManager instance;

        public List<LetterData> m_LetterDataBase;

        private void Awake()
        {
            DontDestroyOnLoad(this);
            instance = this;
        }

        private void Start()
        {


            //load data 
          //  TextFromCSV = CSV_Reader.SplitCsvGrid(reader.csvFile.text);

           // m_LetterDataBase = new List<LetterData>(200);

            //parse data 
         /*   for (int i = 0; i < TextFromCSV.GetLength(0); i++)
            {
                int id;
                int loveLevel;
                if (!int.TryParse(TextFromCSV[i, 0], out id))
                {
                    Debug.Log("L'identifiant de la Lettre" + TextFromCSV[i, 1] + " dans le fichier excel n'est pas un nombre.");
                }

                if (!int.TryParse(TextFromCSV[i, 1], out loveLevel))
                {

                    Debug.Log("Le LoveLevel de la Lettre" + TextFromCSV[i, 1] + " dans le fichier excel n'est pas un nombre.");
                }

                if (TextFromCSV[i, 2] == "A" || TextFromCSV[i, 2] == "a")
                {
                    LetterData currentLetter = new LetterData((ELetterType)0, id, loveLevel, TextFromCSV[i, 4], TextFromCSV[i, 5], TextFromCSV[i, 6]);
                    m_LetterDataBase.Add(currentLetter);

                }
                else
                {
                    LetterData currentLetter = new LetterData((ELetterType)1, id, loveLevel, TextFromCSV[i, 4], TextFromCSV[i, 5], TextFromCSV[i, 6]);
                    m_LetterDataBase.Add(currentLetter);
                }
            }*/
        }
    }
}