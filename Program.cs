using System.Numerics;

ListNode nodes = new ListNode(9);

ListNode nodes2 = new ListNode(1,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9))))))))));


Solution solution = new Solution();
ListNode nodeFinal = solution.AddTwoNumbers(nodes, nodes2);

while (nodeFinal != null)
{
    Console.WriteLine(nodeFinal.val);
    nodeFinal = nodeFinal.next;
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        string valores = "";
        string valores2 = "";

        while (l1 != null)
        {
            valores = valores + l1.val.ToString();
            l1 = l1.next;


        }
        while (l2 != null)
        {
            valores2 = valores2 + l2.val.ToString();
            l2 = l2.next;
        }

        valores = voltearCadena(valores);
        valores2 = voltearCadena(valores2);
        BigInteger numeros = BigInteger.Parse(valores);
        BigInteger numeros2 = BigInteger.Parse(valores2);
        BigInteger numerosSuma = numeros + numeros2;
        int[] digitos = numerosSuma.ToString().Select(c => c - '0').ToArray();
        List<int> lista = digitos.ToList();
        return enlazarNodo(lista);
    }


    ListNode enlazarNodo(List<int> lista)
    {
        int numero = lista[lista.Count - 1];
        lista.RemoveAt(lista.Count - 1);
        if (lista.Count != 0)
        {
            return new ListNode(numero, enlazarNodo(lista));

        }
        else
        {
            return new ListNode(numero);
        }
    }

    string voltearCadena(string cadena)
    {
        string nuevo = "";
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            nuevo += cadena[i];
        }
        return nuevo;
    }

}