# T-FLEX-CAD-Fast-Operations
Fast Operations for T-FLEX CAD

RUS
-------
Для собственного удобства я написал несколько простых макросов, позволяющих быстро производить булевы операции между двумя селектированными в 3D-окне телами. 

Использовать макросы просто: выбираете в 3D окне два тела, жмете на кнопку, запускающую макрос, и выполняется нужная вам булева операция. 
Кроме трех базовых операций я добавил также еще и четвертую, которую назвал "Отделение объема". Это комплексная булева операция, включающая в себя вычитание и пересечение (первоначально именно эту операцию я хотел реализовать).

В данный момент все операции, кроме булевой сложения, используют только первые два выбранные тела.
Булева операция сложиня работает со всеми выбранными телами. Первое выбранное тело выбирается в качестве первого операнда, остальные тела - в качестве второго.

-----Как установить макрос себе-----
GRB-файл с макросом нужно положить в папку:
C:\Program Files\T-FLEX CAD 14 x64\Program\Macros

-----Как использовать-----
Выбираете в окне два тела, кликаете на нужную кнопку для создания быстрой булевой.

ENG
------
For your own convenience, I wrote a simple macro that allows you to quickly perform Boolean operations between two (so far) bodies that were selected in 3D-window.

How to use: select the two bodies in the 3D window, pressing the button that launches the macro.

Besides the three basic operations, I also added a fourth, which he called "Volume Separation". This is a complex Boolean operations, including the subtraction and intersection (originally it was this operation, I would like to implement).

Currently, all operations (besides Boolean Addition) work with the first two selected bodies only.
Boolean Addition operation works with all selected bodies. The first body selected is the first operand, and the rest of the bodies - as a second.

----- How to install the macro -----
GDB-macro files should be put in a folder:
C: \ Program Files \ T-FLEX CAD 14 x64 \ Program \ Macros

-----How to use-----
Choose two of the body box, click on the appropriate button to create a quick Boolean.
