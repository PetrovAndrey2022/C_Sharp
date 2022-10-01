



        // функция разворачивающая массив одномерный
        int [] Reversel (int[] mmm)
        {

            int [] revmas = new int (mmm.Length);
            for (int i=0; i<mmm.Length; i++)
            {

                revmas[i]=mmm[mmm.Length-1-i];

            }
            return revmas;


        }
