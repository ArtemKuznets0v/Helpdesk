//switchBackground

const eyeOpenL =
  "M60 30C60 46.5685 46.5685 60 30 60C13.4315 60 0 46.5685 0 30C0 13.4315 13.4315 0 30 0C46.5685 0 60 13.4315 60 30Z";
const eyeOpenR =
  "M208 31C208 47.5685 194.569 61 178 61C161.431 61 148 47.5685 148 31C148 14.4315 161.431 1 178 1C194.569 1 208 14.4315 208 31Z";
const eyeClosedL =
  "M60 0.000190258C60 16.5687 46.5685 30.0002 30 30.0002C13.4315 30.0002 0 16.5687 0 0.000190258C0 0.000190258 13.4315 5.5 30 5.5C46.5685 5.5 60 0.000190258 60 0.000190258Z";
const eyeClosedR =
  "M208 0.999969C208 17.5685 194.569 31 178 31C161.431 31 148 17.5685 148 0.999969C148 0.999969 161.431 9.00001 178 9.00001C194.569 9.00001 208 0.999969 208 0.999969Z";
const mouthOpen =
  "M77 60H130V73.5C130 88.1355 118.136 100 103.5 100C88.8645 100 77 88.1355 77 73.5V60Z";
const mouthClosed =
  "M77 30H130V30.3375C130 30.7034 118.136 31 103.5 31C88.8645 31 77 30.7034 77 30.3375V30Z";
const closedEyeLeft = document.querySelector(".eye-left");
const closedEyeRight = document.querySelector(".eye-right");
const closedMouth = document.querySelector(".mouth");
const face = document.querySelector(".innerSwitch");
const switchBG = document.querySelector(".switch-background");
const background = document.querySelector("body");
let switched = false;

face.addEventListener("click", () => {
  var tl = anime.timeline({
    easing: "easeOutExpo",
    duration: 1050
  });
  tl.add(
    {
      targets: [face],
      translateX: switched ? -1 : 50,
      rotate: switched ? -360 : 360,
      backgroundColor: switched ? "rgb(110,240,225)" : "rgb(243,255,148)"
    },
    500
  )
    .add(
      {
        targets: [switchBG, background],
        backgroundColor: switched ? "rgb(255,255,255)" : "rgb(197 105 80)"
      },
      500
    )
    .add(
      {
        targets: ".eye-left",

        d: [
          {
            value: switched ? eyeClosedL : eyeOpenL
          }
        ]
      },
      "-=1200"
    )
    .add(
      {
        targets: ".eye-right",
        d: [
          {
            value: switched ? eyeClosedR : eyeOpenR
          }
        ]
      },
      "-=1210"
    )
    .add(
      {
        targets: ".mouth",
        d: [
          {
            value: switched ? mouthClosed : mouthOpen
          }
        ]
      },
      "-=1210"
    );

  if (switched == true) {
      
    if (switchBG.classList.contains("on-shadow")) {
      switchBG.classList.remove("on-shadow");
    }
    switchBG.classList.add("off-shadow");
    switched = false;
  } else {
    if (switchBG.classList.contains("off-shadow")) {
      switchBG.classList.remove("off-shadow");
    }
    switchBG.classList.add("on-shadow");
    switched = true;
  }
});



//clock

function showTime(){
    var date = new Date();
    var h = date.getHours(); 
    var m = date.getMinutes(); 
    var s = date.getSeconds(); 
    var session = "AM";
    
    if(h == 0){
        h = 12;
    }
    
    if(h > 12){
        h = h - 12;
        session = "PM";
    }
    
    h = (h < 10) ? "0" + h : h;
    m = (m < 10) ? "0" + m : m;
    s = (s < 10) ? "0" + s : s;
    
    var time = h + ":" + m + ":" + s + " " + session;
    document.getElementById("MyClockDisplay").innerText = time;
    document.getElementById("MyClockDisplay").textContent = time;
    
    setTimeout(showTime, 1000);
    
}

showTime();
