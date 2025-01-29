# UnityTest

Este es un proyecto de Unity sencillo donde un jugador puede moverse por el mapa, recolectar monedas, y enfrentarse a un enemigo con IA básica. El objetivo es recolectar todas las monedas para ganar la partida.

## Características

- Movimiento del jugador con teclado.
- Colección de monedas que actualiza la interfaz.
- Condición de victoria al recolectar todas las monedas.
- Enemigo con IA básica que se mueve por el mapa.

## Requisitos

- Unity (versión recomendada: 2021 o superior)
- C# para la programación de los scripts

## Instalación

1. Clonar o descargar el repositorio.
2. Abrir el proyecto en Unity.
3. Asegurarse de que las escenas y assets están correctamente configurados.
4. Ejecutar la escena principal desde el Editor de Unity.

## Controles

- **WASD** o **Flechas** para moverse.

## Estructura del Proyecto

```
Assets/
├── Scripts/        # Scripts en C#
├── Prefabs/        # Prefabs de monedas
├── Materials/      # Materiales y texturas usadas
```

## Scripts Principales

### `PlayerController.cs`

Controla el movimiento del jugador.

### `Coin.cs`

Gestiona la recolección de monedas y actualiza la interfaz.

### `GameManager.cs`

Controla el estado del juego y la condición de victoria.

### `EnemyAI.cs`

Define el comportamiento del enemigo que se mueve por el mapa.

## Objetivo del Juego

Recolectar todas las monedas mientras se evita al enemigo. Al recolectar todas, se muestra un mensaje de victoria.

## Mejoras Futuras

- Animaciones y efectos visuales.
- Más niveles y desafíos.
- IA mejorada para el enemigo.

## Autor

[Ancor García Guedes]
