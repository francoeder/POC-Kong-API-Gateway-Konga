# POC Kong API Gateway + Konga

## Execução
Executar o seguinte script:
```bash
  ./startup.sh
```

O script sobe os seguintes containers:
- Kong API Gateway
- Konga
- 3 serviços que retornam um json: A, B1 e B2
    - Serviço A: Porta 8080
    - Serviço B1: Porta 8081
    - Serviço B2: Porta 8082