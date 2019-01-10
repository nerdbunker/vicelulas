—
LC:\vicelulas\Back-end\Vicelulas\Vicelulas.IoC\Negocio\NegocioBootStrapper.cs
	namespace 	
	Vicelulas
 
. 
IoC 
. 
Negocio 
{ 
internal 
class 
NegocioBootStrapper &
{ 
internal 
void  
ChildServiceRegister *
(* +
IServiceCollection+ =
service> E
)E F
{		 	
service

 
.

 
	AddScoped

 
<

 
IUnidadeNegocio

 -
,

- .
UnidadeNegocio

/ =
>

= >
(

> ?
)

? @
;

@ A
service 
. 
	AddScoped 
< 
ITriboNegocio +
,+ ,
TriboNegocio- 9
>9 :
(: ;
); <
;< =
service 
. 
	AddScoped 
< 
ISquadNegocio +
,+ ,
SquadNegocio- 9
>9 :
(: ;
); <
;< =
service 
. 
	AddScoped 
< 
IPessoaNegocio ,
,, -
PessoaNegocio. ;
>; <
(< =
)= >
;> ?
service 
. 
	AddScoped 
< 
IPapelNegocio +
,+ ,
PapelNegocio- 9
>9 :
(: ;
); <
;< =
service 
. 
	AddScoped 
<  
IAutenticacaoNegocio 2
,2 3
AutenticacaoNegocio4 G
>G H
(H I
)I J
;J K
service 
. 
	AddScoped 
< 
IMentorNegocio ,
,, -
MentorNegocio. ;
>; <
(< =
)= >
;> ?
} 	
} 
} ß
TC:\vicelulas\Back-end\Vicelulas\Vicelulas.IoC\Repositorio\RepositorioBootStrapper.cs
	namespace 	
	Vicelulas
 
. 
IoC 
. 
Repositorio #
{ 
internal 
class #
RepositorioBootStrapper *
{ 
internal 
void  
ChildServiceRegister *
(* +
IServiceCollection+ =
service> E
)E F
{		 	
service

 
.

 
	AddScoped

 
<

 
IUnidadeRepositorio

 1
,

1 2
UnidadeRepositorio

3 E
>

E F
(

F G
)

G H
;

H I
service 
. 
	AddScoped 
< 
ITriboRepositorio /
,/ 0
TriboRepositorio1 A
>A B
(B C
)C D
;D E
service 
. 
	AddScoped 
< 
ISquadRepositorio /
,/ 0
SquadRepositorio1 A
>A B
(B C
)C D
;D E
service 
. 
	AddScoped 
< 
IPessoaRepositorio 0
,0 1
PessoaRepositorio2 C
>C D
(D E
)E F
;F G
service 
. 
	AddScoped 
< 
IPapelRepositorio /
,/ 0
PapelRepositorio1 A
>A B
(B C
)C D
;D E
service 
. 
	AddScoped 
< $
IAutenticacaoRepositorio 6
,6 7#
AutenticacaoRepositorio8 O
>O P
(P Q
)Q R
;R S
service 
. 
	AddScoped 
< 
IMentorRepositorio 0
,0 1
MentorRepositorio2 C
>C D
(D E
)E F
;F G
} 	
} 
} Ý
HC:\vicelulas\Back-end\Vicelulas\Vicelulas.IoC\RootServiceBootStrapper.cs
	namespace 	
	Vicelulas
 
. 
IoC 
{ 
public 

class #
RootServiceBootStrapper (
{ 
public		 
void		  
ChildServiceRegister		 (
(		( )
IServiceCollection		) ;
service		< C
)		C D
{

 	
new 
NegocioBootStrapper #
(# $
)$ %
.% & 
ChildServiceRegister& :
(: ;
service; B
)B C
;C D
new #
RepositorioBootStrapper '
(' (
)( )
.) * 
ChildServiceRegister* >
(> ?
service? F
)F G
;G H
} 	
} 
} 