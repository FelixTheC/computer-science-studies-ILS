var clickTime; var createdTime; var reactionTime;
		
		function getRandomColor(){
			var letters = '0123456789ABCDEF'.split('');
			var color = '#';
			for (var i = 0; i <6; i++) {
				color += letters[Math.round(Math.random() *15)];
				}
			return color;
		}
		
		function game(){
			var time= Math.random();
				time= time*3000;
			setTimeout(function() {
				document.getElementById("box").style.backgroundColor = getRandomColor();
				
				if(Math.random()>0.7){
					document.getElementById("box").style.borderRadius = "100px";
				}
				else{
					document.getElementById("box").style.borderRadius = "0px";
				}
				
				var top = Math.random();
				top = top*400;
				
				var left = Math.random();
				left = left*400;
				
				document.getElementById("box").style.top = top +"px";
				document.getElementById("box").style.left = left +"px";
				document.getElementById("box").style.display = "block";
				createdTime = Date.now();
			}, time);			
		}
		
		document.getElementById("box").onclick=function(){
			
			clickTime = Date.now();
			reactionTime = (clickTime - createdTime)/1000;
				document.getElementById("time").innerHTML= reactionTime;
			//document.getElementById("box").style.display = "none";
			//bei gleicher Id kann auch mit this. gearbeitet werden
			this.style.display = "none";
			game();
		}
		
		game();