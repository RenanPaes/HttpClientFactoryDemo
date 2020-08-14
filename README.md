# HttpClientFactoryDemo

Aplicação que utiliza HttpClientFactory e politica de retry com a lib Polly.

O principal objetivo é usar o HttpClient de forma mais eficiente, evitando exceptions de exaustão de Sockets, problema que acontece geralmente quando há um número muito grande de requests.

Para testar o request externo da aplicação, foi utilizado uma fake REST API, localizada em: https://jsonplaceholder.typicode.com/

