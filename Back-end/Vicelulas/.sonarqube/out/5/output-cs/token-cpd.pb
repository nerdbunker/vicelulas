�

kC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Teste\APITeste\TriboAPITeste.cs
	namespace 	
	Vicelulas
 
. 
Teste 
. 
APITeste "
{ 
public 

class 

{ 
[		 	
Fact			 
]		
public

 
void

 

WorkGetAll

 
(

 
)

  
{ 	
TriboController 
_triboController ,
=- .
new/ 2
TriboController3 B
(B C
)C D
;D E
int

=
$num
;
var 
actionResult 
= 
_triboController /
./ 0
Get0 3
(3 4
)4 5
;5 6
var 
okObjectResult 
=  
(! "
OkObjectResult" 0
)0 1
actionResult1 =
;= >
Assert 
. 
Equal 
( 

,& '
okObjectResult( 6
.6 7

StatusCode7 A
)A B
;B C
} 	
} 
} 