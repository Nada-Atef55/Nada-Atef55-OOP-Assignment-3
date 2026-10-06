# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
  it violates OCP and DIP 

- What did you change?
  i applied strategy design pattern by creating a class for each carrier and each one inherits from interface so high level and low level class depend on abstraction using interface
  
---

## OrderProcessor

- What was the problem?
  OrderProcessor is reaponsible for creating its dependencies which causes tight coupling so it violates DIP

- What did you change?
  i created saver and sender interfaces so that each concrete class can depend on them
  and OrderProcessor depends on interface 
  each client should inject sender and saver objects into OrderProcessor so it can directly use them
---

## Notifications

- What was the problem?
  notification classes don't have shared data to inherit but they have shared capability 
  and each new notification service leads to increase number of subclasses

- What did you change?
  i implemented an interface INotifier and created an object inside Notification class
  so this object can hold any channel and use its send()


---

## Proof

- New carrier file(s): Bosta
- New notification channel file(s): WhatsApp
- Existing classes left unchanged? (yes/no): no
