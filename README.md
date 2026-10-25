# ATM

Crear una aplicación de consola que simule algunas operaciones básicas de un cajero.

El programa comenzará con un saldo inicial, por ejemplo:

```csharp
decimal saldo = 1000;
```

Mostrar un menú:

```text
=== CAJERO ===

1. Consultar saldo
2. Ingresar dinero
3. Retirar dinero
0. Salir
```

Requisitos:

- El menú deberá repetirse hasta seleccionar `0`.
- Utilizar `switch`.
- Validar las cantidades mediante `decimal.TryParse()`.
- No permitir ingresos negativos.
- No permitir retiradas negativas.
- No permitir retirar una cantidad superior al saldo.
- Separar las operaciones en métodos.

No es necesario utilizar clases para este ejercicio.