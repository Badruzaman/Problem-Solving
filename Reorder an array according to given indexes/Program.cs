

int[] arr = { 50, 40, 70, 60, 90 };
int[] index = { 3, 0, 4, 1, 2 };
solution(arr, index);

// O(N) time
// O(N) space
void solution(int[] arr, int[] index)
{
    int[] temp = new int[arr.Length];
	for (int i = 0; i < arr.Length; i++)
	{
        temp[index[i]] = arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = temp[i];
        index[i] = i;
    }
}