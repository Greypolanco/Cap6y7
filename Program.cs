using System;
using System.Collections;
public class Cap6y7{

    public static void Main(String[] args)
    {
        System.Console.WriteLine( "El promedio del arreglo es:" + AverageArray());
        System.Console.WriteLine("El numero menor es: " + YougerArray());  
        System.Console.WriteLine("El numero mayor es: "+ OldestArray()); 

        int[][] jagged = new int[2][];
        jagged [0] = new int[3]{5,6,7};
        jagged [1] = new int[2]{20,30};

        System.Console.WriteLine("El arreglo Jagged--> ");
        Sum(jagged);

        //ArrayList
        ArrayList qualification = new ArrayList();
        qualification.Add(90);
        qualification.Add(60);
        qualification.Add(80); 

        

        System.Console.WriteLine("La calificacion maxima es: "+ QualificationMax(qualification));
        System.Console.WriteLine("La calificacion minima es: "+ QualificationMin(qualification));
    }

    public static double AverageArray()
    {
        int[][] jagged = new int[4][];

        jagged [0]= new int[4]{1,2,3,4};
        jagged [1]= new int[4]{6,7,9,8};
        jagged [2]= new int[4]{65,23,87,21};
        jagged [3]= new int[2]{32,21};

        int cont =0;
        double sum=0, promedio;

        for(int i=0; i<jagged.Length; i++)
        {
            for(int j=0; j<jagged[i].Length; j++)
            {
                sum += jagged[i][j];
                cont++;
            }
        }
        promedio = sum/cont;
        return promedio;
    }

    public static int YougerArray()
    {
        int[][] jagged = new int[4][];

        jagged [0]= new int[4]{1,2,3,4};
        jagged [1]= new int[4]{6,7,9,8};
        jagged [2]= new int[4]{65,23,87,21};
        jagged [3]= new int[2]{32,21};

        int youger=jagged[0][1];

        for(int i=0; i<jagged.Length; i++)
        {
            for(int j=0; j<jagged[i].Length; j++)
            {
                if(jagged[i][j]<youger)
                {
                    youger = jagged[i][j];
                }
            }
        }
        return youger;
    }

    public  static int OldestArray()
    {
        int[][] jagged = new int[4][];

        jagged [0]= new int[4]{1,2,3,4};
        jagged [1]= new int[4]{6,7,9,8};
        jagged [2]= new int[4]{65,23,87,21};
        jagged [3]= new int[2]{32,21};

        int older = jagged[0][1];
        for(int i=0; i<jagged.Length; i++)
        {
            for(int j=0; j<jagged[i].Length; j++)
            {
                if(jagged[i][j] > older)
                {
                    older = jagged[i][j];
                }
            }
            
        }
        return older;
    }

    public static void Sum(int[][] jagged)
    {
        for(int i=0; i<jagged.Length; i++)
        {
            for(int j=0; j<jagged[i].Length; j++)
            {
                System.Console.Write(jagged[i][j] + ",");
            }
        }    
    }

    public static int QualificationMax(ArrayList qualification)
    {
        int olderList = 0;
        for(int i=0; i< qualification.Count; i++)
        {
            int num = (int)qualification[i];
            if( num > olderList)
            {
                olderList = num;
            }
        }
        return olderList;
        
    }

    public static int QualificationMin(ArrayList qualification)
    {
        int yougerList = (int)qualification[0];
        for(int i=0; i< qualification.Count; i++)
        {
            int num = (int)qualification[i];
            if( num < yougerList)
            {
                yougerList = num;
            }
        }
        return yougerList;
        
    }

}
