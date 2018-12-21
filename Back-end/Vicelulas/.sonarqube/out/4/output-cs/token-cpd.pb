Ÿ

oC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Teste\APITeste\TriboNegocioTeste.cs
	namespace		 	
	Vicelulas		
 
.		 
Teste		 
.		 
APITeste		 "
{

 
public 

class 
TriboNegocioTeste "
{ 
[ 	
Fact	 
] 
public 
void 
Teste 
( 
) 
{ 	
TriboNegocio 
_triboNegocio &
=' (
new) ,
TriboNegocio- 9
(9 :
): ;
;; <
TriboDto 
	_triboDto 
=  
new! $
TriboDto% -
(- .
). /
;/ 0
TriboDto 
_triboDtoEsperado &
=' (
new) ,
TriboDto- 5
(5 6
)6 7
;7 8
	_triboDto 
= 
_triboNegocio %
.% &
SelecionarPorId& 5
(5 6
$num6 7
)7 8
;8 9
Assert 
. 
Equal 
( 
_triboDtoEsperado *
,* +
	_triboDto, 5
)5 6
;6 7
} 	
} 
} 