﻿//[?] 2개의 정수 배열 합치기: 단, 2개의 배열은 오름차순으로 정렬되어 있다고 가정 
using System;

/// <summary>
/// 병합 알고리즘(Merge Algorithm): 오름차순으로 정렬되어 있는 정수 배열을 하나로 병합
/// </summary>
class MergeAlgorithmTest
{
    static void Main()
    {
        int count = 0; 
        //[1] Input
        int[] first = { 1, 3, 5 }; // 오름차순 정렬됨
        int[] second = { 2, 4 }; // 오름차순 정렬됨
        int M = first.Length; int N = second.Length; // M:N 관행
        int[] merge = new int[M + N]; // 병합된 배열을 담을 그릇
        int i = 0; int j = 0; int k = 0; // i, j, k 관행

        count = PrintStep(count, merge, i, j, k);

        //[2] Process: MERGE
        while (i < M && j < N) // 둘 중 하나라도 배열의 끝에 도달할 때까지
        {
            if (first[i] <= second[j]) // 더 작은 값을 merge 배열에 저장
            {
                merge[k++] = first[i++]; // 작은 값 대입 후 각각의 인덱스 증가
            }
            else
            {
                merge[k++] = second[j++]; // 작은 값 대입 후 각각의 인덱스 증가
            }

            count = PrintStep(count, merge, i, j, k);
        }
        while (i < M) // 첫 번째 배열이 끝까지 도달할 때까지
        {
            merge[k++] = first[i++];
            count = PrintStep(count, merge, i, j, k);
        }
        while (j < N) // 두 번째 배열이 끝까지 도달할 때까지
        {
            merge[k++] = second[j++];
            count = PrintStep(count, merge, i, j, k);
        }
    }

    private static int PrintStep(int count, int[] merge, int i, int j, int k)
    {
        Console.WriteLine($"{count++}회전");
        Console.WriteLine($"\ti: {i}, j: {j}, k: {k}, merge: {String.Join(",", merge)}");
        return count;
    }
}
