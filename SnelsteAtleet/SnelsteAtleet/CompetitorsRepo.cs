

using System.Collections;


namespace SnelsteAtleet;


public class CompetitorsRepo : IEnumerable
{
    private Atleet[] _arr = new Atleet[2];
    public int Length => _arr.Length;
    public Atleet this[int index]
    {
        get => _arr[index];
        set => _arr[index] = value;
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            yield return _arr[i];
        }
    }

    public void SortAscending()
    {
        for (int i = 0; i < _arr.Length - 1; i++)
        {
            for (int j = 0; j < _arr.Length - i - 1; j++)
            {

                if (_arr[j] is not null && _arr[j + 1] is not null && _arr[j].CompareTo(_arr[j + 1]) > 0)
                {


                    Atleet temp = _arr[j];
                    _arr[j] = _arr[j + 1];
                    _arr[j + 1] = temp;
                    //kan Array.Sort()
                }
            }

        }
    }

    public void Add(Atleet at)
    {
        if (_arr[_arr.Length - 1] != null)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
        }

        for (int i = 0; i < _arr.Length; i++)
        {
            if (_arr[i] == null)
            {
                _arr[i] = at;
                return;
            }

        }
        Resize(_arr);
    }

    private void Resize(Atleet[] at)
    {
        if (at[_arr.Length - 1] != null)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
        }
    }
}





