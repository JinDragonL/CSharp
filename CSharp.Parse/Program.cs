
//IEnumerable vs IEnumerator



using CSharp.IEnmumerable;

List<Tiger> tigers = new List<Tiger>()
{
    new Tiger { Color = "black", Weight = 0.5 },
    new Tiger { Color = "black-yellow", Weight = 0.8 },
    new Tiger { Color = "white-yellow", Weight = 0.77 },
};

IEnumerable<Tiger> arrTigers = new Tiger[]
{
    new Tiger { Color = "black", Weight = 0.5 },
    new Tiger { Color = "black-yellow", Weight = 0.8 },
    new Tiger { Color = "white-yellow", Weight = 0.77 },
};


//Covariance

IEnumerator<Tiger> enumerator = tigers.GetEnumerator();

while(enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current.Color);
}


foreach (var item in arrTigers)
{
    Console.WriteLine(item.Color);
}


//Defferd Excution

//for, foreach, while

