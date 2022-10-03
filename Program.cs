int a = Convert.ToInt32(null);//nesse caso, um dato vazio é representado através do null, pois o null converte o valor (vazio) para zero e não vai dar erro e nesse caso não pode usar o parse pq ele não vai aceitar que seja nulo.

Console.WriteLine(a);
