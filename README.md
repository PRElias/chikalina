# chikalina
Chikalina Website

Esse site utiliza a API do [Facebook](https://developers.facebook.com/) e um arquivo key.cs para armazenar a chave e o segredo.

Crie um arquivo na raíz do projeto com o nome e formato abaixo. Ele é incluso no gitignore e portando não é salvo no repositório por segurança

Formato do arquivo keys.cs

```
namespace Chikalina
{
    public class keys
    {
        public static string appid = "x";
        public static string appsecret = "x";
    }
}
```