using System;

class Code{
    static void Main(string[]args){
        bool end = true;
        do{
            Console.Write("+ or - : ");
            string input = Console.ReadLine();
            switch (input){
                case "+" :
                    Console.Write("size i : ");
                    int i = int.Parse(Console.ReadLine());
                    Console.Write("size j : ");
                    int j = int.Parse(Console.ReadLine());
                    float [ , ] matrix1 = new float [i, j];
                    float [ , ] matrix2 = new float [i, j];
                    float [ , ] result1 = new float [i, j];

                    for (int a = 0; a < i; a++){
                        for (int b = 0; b < j; b++){
                            Console.Write("");
                            float num = float.Parse(Console.ReadLine());
                            matrix1[a, b] = num;
                        }
                    }

                    for (int a = 0; a < i; a++){
                        for (int b = 0; b < j; b++){
                            Console.Write("");
                            float num = float.Parse(Console.ReadLine());
                            matrix2[a, b] = num;
                        }
                    }

                    for (int a = 0; a < i; a++){
                        for (int b = 0; b < j; b++){
                            result1[a, b] = matrix1[a, b] + matrix2[a, b];
                        }
                    }

                    for (int a = 0; a < i; a++){
                        for (int b = 0; b < j; b++){
                            Console.Write("{0} ",result1[a, b]);
                        }
                        Console.WriteLine(" ");
                    }

                    break;

                case "-" :
                    Console.Write("size i : ");
                    int k = int.Parse(Console.ReadLine());
                    Console.Write("size j : ");
                    int l = int.Parse(Console.ReadLine());
                    float [ , ] matrix3 = new float [k, l];
                    float [ , ] matrix4 = new float [k, l];
                    float [ , ] result2 = new float [k, l];

                    for (int a = 0; a < k; a++){
                        for (int b = 0; b < l; b++){
                            Console.Write("");
                            float num = float.Parse(Console.ReadLine());
                            matrix3[a, b] = num;
                        }
                    }

                    for (int a = 0; a < k; a++){
                        for (int b = 0; b < l; b++){
                            Console.Write("");
                            float num = float.Parse(Console.ReadLine());
                            matrix4[a, b] = num;
                        }
                    }

                    for (int a = 0; a < k; a++){
                        for (int b = 0; b < l; b++){
                            result2[a, b] = matrix3[a, b] - matrix4[a, b];
                        }
                    }

                    for (int a = 0; a < k; a++){
                        for (int b = 0; b < l; b++){
                            Console.Write("{0} ",result2[a, b]);
                        }
                        Console.WriteLine(" ");
                    }

                    break;

                default :
                    end = false;
                    break;
            }

            

        }while(end);
    }
}
