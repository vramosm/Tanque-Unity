# Tanque-Unity

Para este ejercicio crearemos un tanque al que manejaremos mientras el tiempo sea positivo. Podrá moverse, girar sobre él mismo y tendrá una cadencia de disparo.


Tanque

Controles del tanque:

- Con los botones A/D o las flechas izquierda/derecha: el tanque girara en su eje Y, a un lado y al otro.

- Con los botones W/S o las flechas arriba/abajo: el objeto avanzará o retrocederá.

- IMPORTANTE: el avance siempre debe ser respecto a como está girado el objeto (como un tanque).

- El tanque deberá ser capaz de disparar cuando se pulse la tecla ESPACIO.

- Los proyectiles deberán ir rectos respecto la orientación del vehículo.


Script en POSITIVO para controlar el tanque.


- El script debe cumplir las siguientes funcionalidades:

+ Debe tener una variable global numérica pública (tipo int o float).

+ Mediante el inspector, dar un valor a esta variable.

+ Cuando se ejecute la escena (botón play), en cada update se eberá restar una unidad a esta variable.

+ Una vez la cuenta atrás llegue a su fin, el jugador no podrá controlar el tanque (Ni moverse, ni rotar, ni disparar).

+ La cuenta atrás no deberá seguir restando.

+ Cuando acabe el tiempo, deberá salir un mensaje que diga "Te has quedado sin gasolina".

Script para cadencia de disparo.

- El tanque tendrá un tiempo entre disparo y disparo.

- Cuando el contador llegue al tiempo establecido, podremos disparar.

- Una vez se dispare, el contador se reiniciará a su valor inicial para poder disparar de nuevo.
