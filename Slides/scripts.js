var currentSlide = 0;

function handleBodyLoad() {
    setContentSize();
    updateSlidesDisplay();
}

function handleBodyResize() {
    setContentSize();
}

function handleBodyKeyDown(ev) {
    const nextSlideTriggers = "ArrowDown ArrowRight Space Enter";
    const prevSlideTriggers = "ArrowUp ArrowLeft Backspace";

    if(nextSlideTriggers.indexOf(ev.key) >= 0) updateSlidesDisplay(1);
    else if(prevSlideTriggers.indexOf(ev.key) >= 0) updateSlidesDisplay(-1);
}

function handleBodyMouseDown(ev) {
    if(ev.button === 0) updateSlidesDisplay(1);
}

function setContentSize(padding){
    let contentPadding = 10;
    
    if(!!padding) contentPadding = padding;
    
    const content = document.getElementById("content");
    content.style.padding = contentPadding + "px";
    content.style.height = document.documentElement.clientHeight - (contentPadding * 2);
    content.style.width = document.documentElement.clientWidth - (contentPadding * 2);

    document.documentElement.style.fontSize = (content.clientHeight * .03) + "px";
}

function updateSlidesDisplay(delta) {
    if(!delta) delta = 0;

    const slides = document.getElementsByClassName("slide");

    currentSlide += delta;
    if(currentSlide < 0) currentSlide = slides.length -1;
    else if(currentSlide >= slides.length) currentSlide = 0;

    for(var i = 0; i < slides.length; i++){
        slides[i].classList.remove("visible");
        if(i === currentSlide) slides[i].classList.add("visible");
    }
}