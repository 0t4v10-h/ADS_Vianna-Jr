class ListaEncadeada<T>
{
    public void AdicionarInicio(T valor)
    {
        var novoNo = new No<T> {Valor = valor};

        if(primeiro == null)
        {
            primeiro = ultimo = novoNo;
        }
        else
        {
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }
    }

    public void AdicionarFinal(T valor)
    {
        var novoNo = new No<T> {Valor = valor};

        if(ultimo == null)
        {
            ultimo = primeiro = novoNo;
        }
        else
        {
            ultimo.Proximo = novoNo;
            ultimo = novoNo;
        }
    }

    public void RemoverInicio()
    {
        if(primeiro == null)
        {
            throw new Exception("Nao é possivel remover no inicio!");
        }

        primeiro = primeiro.Proximo;

        if(primeiro == null)
        {
            ultimo = null;
        }
    }

    public void RemoverFinal()
    {
        if(primeiro == null)
        {
            throw new Exception("Nao é possivel remover no fim!");
        }

        if(primeiro.Proximo == null)
        {
            primeiro = null;
        }
        else
        {
            var penultimo = primeiro;

            while(penultimo?.Proximo?.Proximo != null)
            {
                penultimo = penultimo.Proximo;
            }

            if(penultimo != null)
            {
                penultimo.Proximo = null;
                ultimo = penultimo;
            }
        }
    }

    public void ParaCada(Action<T> visitar)
    {
        var atual = primeiro;

        while(atual != null)
        {
            visitar(atual.Valor);
            atual = atual.Proximo;
        }
    }

    private No<T>? primeiro = null;
    private No<T> ultimo = null;
}