# Microservices Architecture with Azure Service Bus, RabbitMQ, and Ocelot

## Application Architecture

The application has two repository branches:

- **main**: uses Azure Service Bus to implement the service bus.
- **RabbitMQ**: uses RabbitMQ to implement the service bus.

At the time of the last update, the application architecture looked like this:
![image](https://github.com/GreeM364/MangoRestaurant/assets/99215600/2cf67178-14c4-495b-a378-da9389c35451)

## RabbitMQ

### Exchange Types

Exchange Types determine how an Exchange routes messages to a queue.

1. **Direct Exchange**: Direct exchange routes messages to a queue based on a routing key specified in the message. The message will be delivered to a queue with the exact same routing key that was specified when the message was published.

2. **Fanout Exchange**: Fanout exchange broadcasts every message to all queues that are subscribed to it. It ignores routing keys that may be specified in the messages.

3. **Topic Exchange**: Topic exchange routes messages to queues based on routing keys that match patterns specified during queue subscription.

4. **Headers Exchange**: Headers exchange uses message headers for routing. It allows using arbitrary headers, not just routing keys, to determine the route to a queue.

### Queue Parameters

| Parameter   | Description                              |
|-------------|------------------------------------------|
| Name        | Name of the queue                        |
| Durable     | Persist the queue to disk                |
| Exclusive   | Delete queue when not needed             |
| Auto Delete | Queue deleted when consumer unsubscribes |

### Standart Queue
![image](https://github.com/GreeM364/MangoRestaurant/assets/99215600/ce6ccd8b-ce5f-444f-ab8e-fd858c5f864d)

### Direct Exchange
![image](https://github.com/GreeM364/MangoRestaurant/assets/99215600/863ce9b2-e4a4-413b-aac5-438f1fc963d1)

### Fanout Exchange
![image](https://github.com/GreeM364/MangoRestaurant/assets/99215600/d6a73eff-6b1b-4197-a511-742612b6b809)

### Topic Exchange
![image](https://github.com/GreeM364/MangoRestaurant/assets/99215600/209cb402-85a2-489c-8e83-6a4704e79dbf)

### Headers Exchange
![image](https://github.com/GreeM364/MangoRestaurant/assets/99215600/247954d9-695e-4012-99b6-fba49ef867b2)
