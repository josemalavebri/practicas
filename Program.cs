


int[] nums = [0,4,3,0];
int target = 0;
int[] resultados = TwoSum(nums, target);

for (int i = 0; i < resultados.Length; i++)
{
    Console.WriteLine(resultados[i]);
}

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {

        for (int j = i + 1; j < nums.Length; j++)
        {
            int suma = nums[i] + nums[j];

            if (suma == target)
            {
                int[] nuevoArray = { i, j };
                return nuevoArray;
            }
        }
    }
    return [];
}

