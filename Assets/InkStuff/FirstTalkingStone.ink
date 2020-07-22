what do you want? 

+[hello] -> Divert2

+[i'm lost] i'm lost! any help? 

-

-> Divert1

== Divert1 ==
 so you don't know where you are. that's unfortunate.  
 
 +[how did i die?] how did i die? #me
 {&i don't know. | i don't care} #rock
 -> Divert1
 
 +[how do i leave?] how do i leave this place? #me
 {you can't leave. you're dead. | you could try to leave again} #rock
  -> Divert1
 
 +[how can you talk?] how can you talk? 
 {~i'm one of those new talking graves. | i'm an easter island head | all graves can talk}
  -> Divert1
 
 +[are you serious?]
 -> Serious

 
 == Divert2 ==
hi - i'm new here. what is this place? 
this place is the end forever. 

+[but where am i?]
-> Divert1


== Serious ==
yes i am. stonefaced. 

+[what's with the weather here?] what's with the weather here?
it's usually temperate in the cemetery
++ [go back] ->Serious

+[Leave] sorry, i should go. 
 ++[Continue] -> EndPart




== EndPart == 
-> END



