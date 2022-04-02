// Написать программу масштабирования фигуры

void scaleFigure(float[] pointA, float[] pointB, float[] pointC, float[] pointD, float k)
{
    float[] scaleA = pointA;
    float[] scaleB = new float[2];
    float[] scaleC = new float[2];
    float[] scaleD = new float[2];
    scaleB[0] = (pointA[0] + (pointB[0] - pointA[0]) * k);
    scaleB[1] = (pointA[1] + (pointB[1] - pointA[1]) * k);
    scaleC[0] = (pointA[0] + (pointC[0] - pointA[0]) * k);
    scaleC[1] = (pointA[1] + (pointC[1] - pointA[1]) * k);
    scaleD[0] = (pointA[0] + (pointD[0] - pointA[0]) * k);
    scaleD[1] = (pointA[1] + (pointD[1] - pointA[1]) * k);
    Console.WriteLine($"({scaleA[0]}, {scaleA[1]}) ({scaleB[0]}, {scaleB[1]}) ({scaleC[0]}, {scaleC[1]}) ({scaleD[0]}, {scaleD[1]})");
}

float[] A = {0, 0};
float[] B = {2, 0};
float[] C = {2, 2};
float[] D = {0, 2};

float k1 = 2;
float k2 = 4;
float k3 = 0.5F;

scaleFigure(A, B, C, D, k1);
scaleFigure(A, B, C, D, k2);
scaleFigure(A, B, C, D, k3);

