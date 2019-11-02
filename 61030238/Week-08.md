# การทดลองที่ 8 คลาสและออปเจกต์ 2

## (Class and Objects 2)

## Constructors
## Constructors in C#
* มีชื่อเดียวกับ คลาสที่เป็นเจ้าของ  
* โดยทั่วไป จะมีการทำ overloaded  (มี constructor หลายๆ ตัวในคลาส)
* อาจจะ มีรูปแบบเป็น delegate เพื่อสั่งการเริ่มต้นให้ constructor ตัวอื่น
* ในกรณีที่เราไม่ได้ระบุ constructors  จะมีการสร้าง constructor ให้ เรียกว่า  default constructor ซึ่งไม่มี constructor
–	ซึ่งทำหน้าที่เรียก   constructor ที่ไม่มี parameter ใน base class 
* ในกรณีที่มีการกำหนด constructor  จะไม่มีการสร้าง default constructor
Constructor syntax
* constructor  คือ method ที่มีชื่อ เหมือนกัน type
* method signature ประกอบด้วย method name และ parameter list เท่านั้น
* method signature ไม่มี return type
* มี modifier ตามความเหมาะสม
–	public
–	static

Default constructors
* ถ้าเราไม่ได้ระบุ constructor (สำหรับ class)
–	C# สร้างมาให้ 1 ตัวโดยอัตโนมัติ
–	จะกำหนดค่าตัวแปรต่างๆ ให้เป็นค่าเริ่มต้น ตามแต่ละชนิดของตัวแปร
–	ดูรายละเอียดจาก Default Values Table
* การระบุ constructor  โดยไม่ระบุ parameter ก็เป็น default constructor
Default values table (C# Reference)
ผลของโปรแกรมนี้คือ?
Parameterized Constructors
Expression body definition
Copy Constructors
Static constructors
* class หรือ structure ใดๆ สามารถประกอบด้วย static constructor จำนวน 1 ตัว
–	ทำหน้าที่กำหนดค่าเริ่มต้นให้กับตัวแปรที่เป็น static
* Static constructors ไม่รับ parameter 
* ถ้าไม่ระบุ static constructor เอาไว้  C# compiler จะสร้าง default static constructor ให้เรา 1 ตัว
–	ทำหน้าที่กำหนดค่าเริ่มต้นให้ตัวแปรที่เป็น static
–	ค่าเริ่มต้น ดูได้จาก Default Values Table. 
Static constructors
Private Constructor
* Private constructor เป็น constructor ชนิดพิเศษ ที่ใช้เพื่อระงับยับยั้งการใช้ constructor ในรูปแบบนั้น บนคลาสนั้น
–	เช่น ถ้า default constructor เป็น private จะไม่สามารถใช้ default constructor บนคลาสนั้น เพื่อเป็นการบังคับให้ต้องป้อน parameter ใน constructor เป็นต้น
* หากมีการใช้ private constructor โดยไม่มี public constructor มาทำการ overloaded อยู่ ก็จะไม่สามารถสร้าง object ใดๆ จากคลาสนั้นได้ 
ตัวอย่าง private constructor
Instance Constructors
* Instance constructors ใช้สำหรับการสร้างและกำหนดค่าเริ่มต้นให้ ตัวแปรภายใน class ที่สร้างด้วยคำสั่ง new
Constructor หลายตัว
* ในคลาสหนึ่ง สามารถมี constructor ได้หลายตัว
* จะเป็น overloaded constructor (ดูเนื้อหาเรื่อง function overloading)

ตัวอย่างการใช้งาน Constructor
ตัวอย่างการใช้งาน Constructor
สรุป Constructors
Constructor มี 5 ชนิด
* Default Constructor
* Parameterized Constructor
* Copy Constructor
* Static Constructor
* Private Constructor

Assignment
* ให้สร้างคลาสกล่อง  (BOX) 
–	มี properties 3 ตัวคือ กว้าง ยาว สูง
–	มี constructor ที่รับค่า กว้าง ยาว สูง
–	มีเมธอดคำนวณพื้นที่ผิว
–	มีเมธอดคำนวณความจุ (ปริมาตร)
