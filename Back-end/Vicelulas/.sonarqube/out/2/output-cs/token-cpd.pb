�
oC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Negocio\Abstração\INegocioBase.cs
	namespace 	
	Vicelulas
 
. 
Negocio 
. 
Abstração %
{ 
public 

	interface 
INegocioBase !
<! "
T" #
># $
where% *
T+ ,
:- .
class/ 4
{ 
IEnumerable		 
<		 
T		 
>		 

Selecionar		 !
(		! "
)		" #
;		# $
T

 	
SelecionarPorId


 
(

 
int

 
id

  
)

  !
;

! "
int 
Inserir 
( 
T 
entity 
) 
; 
T 	
Alterar
 
( 
int 
id 
, 
T 
entity "
)" #
;# $
void 
Deletar 
( 
int 
id 
) 
; 
} 
} 