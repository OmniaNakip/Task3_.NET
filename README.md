# Task3
## Search task:
Record vs Struct vs Class

Class = compare by reference "يعني object بيتخزن في الميموري ك refrence" 

struct = copy values  "ده بيخزن نسخة من الداتا نفسها"

Record = compare by values automatically "بيقارن بالمحتوى مش بالمكان"

### Example:
class Student { }

struct Point { }

record Person(string Name);
### when to use:
Class: object بيتغير وعنده behavior  (BankAccount, Library)

Struct: data صغيرة مفيش inheritance  (Point, Color)

Record: بس بتنقل data مش بتغير فيها (API Response, Config)
