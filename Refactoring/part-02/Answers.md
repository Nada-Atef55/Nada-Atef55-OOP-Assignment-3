# Part 02 — answers

---

## Reports

- What was the problem?
  the three classes do the same steps to Export and have same methods except Format()


- What did you change?
  i created an abstract class ReportProcessor has all methods once and an abstract method Format,
  each reprot inherits it and implement Format his own way


- Why did you choose that approach?
  the steps to export a report are fixed in all report types so i need one place that cares about these steps which matches Template method desogn pattern


---

## Enrollment

- What was the problem?
  client is responsible for completing enrollment steps by calling methods in order , but this is not its responsiblity , it is responsible only for calling a method to complete enrollment


- What did you change?
  i created a class to be the entry point for the client to enrollment, so the client connects with it to complete enrollment without caring about details

- Why did you choose that approach?
  i want an entry point to be responsible for enrollment and the client can just call it once without knowing details , which matches Facade desogn pattern
