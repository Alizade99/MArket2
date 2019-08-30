var pos=0;
var brandsLi=$(".brands li");
$(".brands li:nth-child(-n+3)").addClass("active")

var liLength=brandsLi.children().length;
var liheight=brandsLi.outerHeight()

$(".nextbtn").on("click",function(){
    // brandsLi.eq(pos).removeClass("active")
 pos++;
    // $(".brands li").eq(pos+2).addClass("active")
   
 if(pos==$(".brands").children().length-2){
   pos=0
    // var brandClone=$(".brands li").clone().appendTo(".brands");
    //     brandClone.addClass("clone")
}
 $(".brands li").css({
     top:-(liheight)*pos+'px'
     
 })
   
})
$(".prebtn").on("click",function(){
    pos--;
 

    if(pos==-1){
        pos=$(".brands li").children().length-3;
    
    }
    $(".brands li").css({
        top:-(liheight)*pos+'px'
    })
  
   })
//