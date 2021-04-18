using System;
using UnityEngine;

namespace Letter
{
    public class LetterManager : MonoBehaviour
    {
        public CSV_Reader m_CSV_Reader;
        public string[,] TextFromCSV;

        //je suppose que c'est le chemin que tu veux passer au CSV reader ? 
        public string pathData;
        public static LetterManager instance;

        private void Awake()
        {
            DontDestroyOnLoad(this);
            instance = this;
        }

        private void Start()
        {
            //load data 
            pathData = "Lettres"; //Le chemin part de Resources. (Si le fichier que vous voulez s'appelle "Poule.csv", et est range dans le dossier "Ferme" qui est range dans le dossier "Animaux", qui lui est dans Resources, le "path" est : "Animaux\Ferme\Poule".) 
            TextFromCSV = CSV_Reader.SplitCsvGrid("Lettres.csv");

            LetterData[] m_LetterDataBase = new LetterData[200];

            //parse data 
            for (int i = 0; i < TextFromCSV.GetLength(0); i++)
            {
                int id;
                int loveLevel;
                if (!int.TryParse(TextFromCSV[i, 1], out id))
                {
                    Debug.Log("L'identifiant de la Lettre" + TextFromCSV[i, 1] + " dans le fichier excel n'est pas un nombre.");
                }

                if (!int.TryParse(TextFromCSV[i, 2], out loveLevel))
                {

                    Debug.Log("Le LoveLevel de la Lettre" + TextFromCSV[i, 1] + " dans le fichier excel n'est pas un nombre.");
                }

                if (TextFromCSV[i, 4] == "A" || TextFromCSV[i, 4] == "a")
                {
                    LetterData currentLetter = new LetterData((ELetterType)0, id, loveLevel, TextFromCSV[i, 4], TextFromCSV[i, 5], TextFromCSV[i, 6]);
                    m_LetterDataBase[currentLetter.groupLetter] = currentLetter;

                }
                else
                {
                    LetterData currentLetter = new LetterData((ELetterType)1, id, loveLevel, TextFromCSV[i, 4], TextFromCSV[i, 5], TextFromCSV[i, 6]);
                    m_LetterDataBase[currentLetter.groupLetter] = currentLetter;
                }
            }
        }
    }
}